using EdFi.Ods.Api.Models;
using EdFi.Ods.Common.Database;
using log4net;
using log4net.Appender;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EdFi.Ods.Api.Middleware
{
    public class SnackPackMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IOdsDatabaseConnectionStringProvider _connectionStringProvider;
        private ILog _snackPackLogger;

        public SnackPackMiddleware(RequestDelegate next, IOdsDatabaseConnectionStringProvider connectionStringProvider)
        {
            _connectionStringProvider = connectionStringProvider;
            _next = next;
        }

        protected ILog SnackPackRequestLogger
        {
            get => _snackPackLogger ??= LogManager.GetLogger("SnackPackRequestLogger");
        }

        public async Task InvokeAsync(HttpContext context)
        {
            //get the URL of the request
            var url = context.Request.Path.Value;
            var restError = new RESTError()
            {
                Code = 200
            };

            if (!string.IsNullOrWhiteSpace(url) && url.Contains("/ks/snackpacks", StringComparison.OrdinalIgnoreCase))
            {
                SetDatabaseAppenderConnectionString();
                
                //check if the request is a GET request
                if (context.Request.Method.Equals("GET"))
                {
                    var stateStudentId = context.Request.Query["stateStudentId"].ToString();
                    
                    //check if the request has a student unique id
                    if (!string.IsNullOrWhiteSpace(stateStudentId))
                    {
                        LogicalThreadContext.Properties["stateStudentId"] = stateStudentId;
                    }
                    else
                    {
                        restError.Code = 400;
                        restError.Message = "stateStudentId is a required field.";
                    }
                }
                else
                {
                    restError.Code = 405;               
                }

                if(restError.Code != 200)
                {
                    context.Response.StatusCode = restError.Code;
                }

                AddLoggerDetailProperties(context.Request.Method, context.Response.StatusCode, context);
                SnackPackRequestLogger.Info("SnackPack Request");
            }

            //we put this here and not above because we want to log 400 and 405 errors
            if(restError.Code == 400 || restError.Code == 405)
            {
                var responseBody = JsonConvert.SerializeObject(restError);
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(responseBody);
                return;
            }

            await _next(context);
        }

        void SetDatabaseAppenderConnectionString()
        {
            var requestResponseAppenders = ((log4net.Repository.Hierarchy.Logger)LogManager.GetAllRepositories().FirstOrDefault()?.GetLogger("SnackPackRequestLogger"))?.Appenders;

            if (requestResponseAppenders?.Count != 1 || requestResponseAppenders.OfType<AdoNetAppender>().Count() != 1)
                return;

            var adoNetAppender = (AdoNetAppender)requestResponseAppenders[0];
            adoNetAppender.ConnectionString = _connectionStringProvider.GetConnectionString();
            adoNetAppender.ActivateOptions();
        }

        private void AddLoggerDetailProperties(string requestMethod, int responseCode, HttpContext context)
        {
            LogicalThreadContext.Properties["RequestMethod"] = requestMethod;
            LogicalThreadContext.Properties["ResponseCode"] = context.Response.StatusCode.ToString();
            LogicalThreadContext.Properties["RequestUrl"] = $"{context.Request.Path.Value}{context.Request.QueryString}";
            LogicalThreadContext.Properties["IpAddress"] = context.Connection.RemoteIpAddress.ToString();
        }
    }

    public static class SnackPackMiddlewareExtensions
    {
        public static IApplicationBuilder UseSnackPackMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SnackPackMiddleware>();
        }
    }
}
