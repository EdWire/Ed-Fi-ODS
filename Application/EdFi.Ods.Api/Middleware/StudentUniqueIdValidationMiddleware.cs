using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using EdFi.Ods.Api.Models;
using EdFi.Ods.Common.Exceptions;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using log4net;

namespace EdFi.Ods.Api.Middleware
{
    public class StudentUniqueIdValidationMiddleware
    {
        private readonly RequestDelegate _next;
        private ILog _logger;

        public StudentUniqueIdValidationMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = LogManager.GetLogger("StudentRequestLogger");
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //get the URL of the request
            var url = context.Request.Path.Value;
            var method = context.Request.Method;
            var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
            var username = appSettings["EScholar:Username"];
            var password = appSettings["EScholar:Password"];
            var shouldValidate = appSettings["EScholar:EnableStudentIdValidation"]?.Equals("True") ?? false;
            var studentSearchUrl = appSettings["EScholar:BaseUrl"] + "/StudentSearch";

            //check if the request is a POST request and the URL contains /ed-fi/students.  This will be the URL for creating a new student
            if (!IsStudentsEndpoint(url) || !method.Equals("POST") || !shouldValidate)
            {
                await _next(context);
                return;
            }

            // convert stream to string
            var reader = new StreamReader(context.Request.Body);
            var studentJson = await reader.ReadToEndAsync();
            var studentNode = JsonNode.Parse(studentJson)!;
            var studentUniqueId = (string)studentNode!["studentUniqueId"];       
            var soapEnvelope = GetSOAPEnvelopeAsString(studentNode, username, password, studentSearchUrl);

            using (var httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromMinutes(5);

                var httpContent = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");
                httpContent.Headers.Add("searchWithIDExactMatch", studentSearchUrl);
                httpContent.Headers.Add("SOAPAction", studentSearchUrl);

                _logger.Info("Adding headers to the request.  Sending request to eScholar.");

                try
                {
                    var message = await httpClient.PostAsync(studentSearchUrl, httpContent);

                    _logger.Info($"Received response from eScholar.");

                    //deserialize the response into a studentSearchResponse object
                    var response = await message.Content.ReadAsStringAsync();
                    context.Request.Body = new MemoryStream(Encoding.UTF8.GetBytes(studentJson));

                    _logger.Info($"Response: {response}");

                    if (response.Contains("SUCCESS_SINGLE_MATCH_RECORD"))
                    {
                        await _next(context);
                        return;
                    }

                    //create a RESTError object to return to the client if the student search fails
                    var restError = new RESTError();

                    if (response.Contains("SUCCESS_NO_MATCHING_RECORDS"))
                    {
                        restError.Code = 400;
                        restError.Message = "A search was completed but did not match an existing student record.  Please check the firstName, lastName, birthDate and studentUniqueId fields.  The values must match exactly, although firstName and lastName are not case sensitive.";
                    }
                    else if (response.Contains("ERROR</status>"))
                    {
                        restError.Code = 400;
                        restError.Message = "An error occurred while trying to validate the student record.  This error likely happened within eScholar.   Please check the firstName, lastName, birthDate and studentUniqueId values you provided or try again later.";
                    }
                    else if (response.Contains("FAILED_VALIDATION"))
                    {
                        restError.Code = 400;
                        restError.Message = "The student record failed eScholar validation. Please check the firstName, lastName, birthDate and studentUniqueId fields.  The values must match exactly, although firstName and lastName are not case sensitive.";
                    }

                    context.Response.StatusCode = restError.Code;
                    context.Response.ContentType = "application/json";

                    var responseBody = JsonConvert.SerializeObject(restError);
                    await context.Response.WriteAsync(responseBody);
                }
                catch(Exception ex)
                {
                    _logger.Error($"An error occurred while trying to validate the student record.  Error: {ex.Message}", ex);
                    _logger.Info(soapEnvelope, ex);

                    context.Response.StatusCode = 200;
                    context.Response.ContentType = "application/json";

                    var restError = new RESTError();
                    restError.Code = 500;
                    restError.Message = "An error occurred while trying to validate the student record.  Please try again later.";

                    var responseBody = JsonConvert.SerializeObject(restError);
                    await context.Response.WriteAsync(responseBody);
                }
               
            }     
        }

        private bool IsStudentsEndpoint(string url)
        {
            return url.EndsWith("/ed-fi/students", StringComparison.OrdinalIgnoreCase) || url.Contains("/ed-fi/students/");
        }

        private string GetSOAPEnvelopeAsString(JsonNode studentNode, string username, string password, string studentSearchUrl)
        {
            var envelope = @$"
                <soapenv:Envelope xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:wsv2=""http://wsv2.escholar.com"" xmlns:soapenc=""http://schemas.xmlsoap.org/soap/encoding/"">
                   <soapenv:Header/>
                   <soapenv:Body>
                      <wsv2:searchWithIDExactMatch soapenv:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
                            <student xsi:type=""esc:StudentV2"" xmlns:esc=""http://www.escholar.com"">
                                <birthDate xsi:type=""xsd:string"">{(string)studentNode!["birthDate"]}</birthDate>
                                <districtCode xsi:type=""xsd:string"">NONE</districtCode>         
                                <schoolCode xsi:type=""xsd:string"">NONE</schoolCode>
                                <stateStudentId xsi:type=""xsd:string"">{(string)studentNode!["studentUniqueId"]}</stateStudentId>
                                <studentFirstName xsi:type=""xsd:string"">{(string)studentNode!["firstName"]}</studentFirstName>
                                <studentLastName xsi:type=""xsd:string"">{(string)studentNode!["lastSurname"]}</studentLastName>
                             </student>
                         <userId xsi:type=""xsd:string"">{username}</userId>
                         <password xsi:type=""xsd:string"">{password}</password>
                      </wsv2:searchWithIDExactMatch>
                   </soapenv:Body>
                </soapenv:Envelope>";
            return envelope;
        }

        private string GetDescriptorCodeValue(string descriptor)
        {
            if(string.IsNullOrEmpty(descriptor) || !descriptor.Contains("#"))
            {
                return descriptor;
            }

            return descriptor.Split("#")[1];
        }

        private string GetGender(string genderDescriptor)
        {
            var codeValue = GetDescriptorCodeValue(genderDescriptor);

            switch (codeValue.ToUpper())
            {
                case "MALE": return "M";
                case "FEMALE": return "F";
                default: return codeValue;
            }
        }
    }

    public static class StudentUniqueIdValidationMiddlewareExtensions
    {
        public static IApplicationBuilder UseStudentUniqueIdValidationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<StudentUniqueIdValidationMiddleware>();
        }
    }
}
