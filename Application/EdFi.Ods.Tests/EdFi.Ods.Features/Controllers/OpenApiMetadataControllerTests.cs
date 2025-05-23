﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Collections.Generic;
using EdFi.Ods.Api.Constants;
using EdFi.Ods.Api.Models;
using EdFi.Ods.Api.Providers;
using EdFi.Ods.Common.Configuration;
using EdFi.Ods.Features.Controllers;
using EdFi.Ods.Features.OpenApiMetadata.Models;
using EdFi.Ods.Tests.EdFi.Ods.Api.Services.Metadata.Helpers;
using EdFi.TestFixture;
using FakeItEasy;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using NUnit.Framework;
using Test.Common;
using Assert = NUnit.Framework.Legacy.ClassicAssert;

namespace EdFi.Ods.Tests.EdFi.Ods.Features.Controllers
{
    public class OpenApiMetadataControllerTests
    {
        [TestFixture]
        public class When_calling_the_metadata_controller : TestFixtureBase
        {
            private OpenApiMetadataController _controller;
            private IOpenApiMetadataCacheProvider _openApiMetadataCacheProvider;

            protected override void Arrange()
            {
                _openApiMetadataCacheProvider = Stub<IOpenApiMetadataCacheProvider>();

                A.CallTo(() => _openApiMetadataCacheProvider.GetOpenApiContentByFeedName(A<string>._))
                    .Returns(OpenApiMetadataHelper.GetIdentityContent());

                var fakeopenAPIcontent = A.Fake<List<OpenApiContent>>();

                A.CallTo(() => _openApiMetadataCacheProvider.GetAllSectionDocuments(A<bool>._)).Returns(fakeopenAPIcontent);

                var sectiondata = _openApiMetadataCacheProvider.GetOpenApiContentByFeedName("openApiMetadata");
                fakeopenAPIcontent.Add(sectiondata);

                _controller = new OpenApiMetadataController(_openApiMetadataCacheProvider, new FakeFeatureManager(), new ApiSettings());

                var request = A.Fake<HttpRequest>();
                request.Method = HttpMethods.Post;
                request.Scheme = "http";

                A.CallTo(() => request.Host).Returns(new HostString("localhost", 80));

                request.PathBase = "/";
                request.Path = "/metadata";
                request.RouteValues = new RouteValueDictionary { { "controller", "Token" } };

                var httpContext = A.Fake<HttpContext>();

                A.CallTo(() => httpContext.Request).Returns(request);

                var controllerContext = new ControllerContext()
                {
                    HttpContext = httpContext,
                };
                RouteValueDictionary dictionary = new RouteValueDictionary();
                dictionary.Add("controller", "Token");

                controllerContext.RouteData = new RouteData(dictionary);
                _controller.ControllerContext = controllerContext;
            }

            [Assert]
            public void Should_return_valid_http_response_message()
            {
                var request = new OpenApiMetadataSectionRequest
                {
                    Sdk = true
                };

                var response = (OkObjectResult)_controller.Get(request);
                var openapisectionlist = (List<OpenApiMetadataSectionDetails>)response.Value;

                Assert.AreEqual(200, response.StatusCode);
                Assert.IsNotNull(response);
                Assert.IsTrue(openapisectionlist.Count > 0);
                Assert.AreEqual("Identity", openapisectionlist[0].Name);
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("localhost"));
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("metadata"));
                Assert.AreEqual("Other", openapisectionlist[0].Prefix);
            }
        }

        [TestFixture]
        public class When_calling_the_metadata_controller_with_use_reverse_proxy_and_forwarded_headers : TestFixtureBase
        {
            private OpenApiMetadataController _controller;
            private IOpenApiMetadataCacheProvider _openApiMetadataCacheProvider;

            protected override void Arrange()
            {
                var apiSettings = new ApiSettings();
                apiSettings.UseReverseProxyHeaders = true;
                apiSettings.OverrideForForwardingHostPort = 80;
                apiSettings.OverrideForForwardingHostServer = "localhost";

                _openApiMetadataCacheProvider = Stub<IOpenApiMetadataCacheProvider>();

                _openApiMetadataCacheProvider = Stub<IOpenApiMetadataCacheProvider>();

                A.CallTo(() => _openApiMetadataCacheProvider.GetOpenApiContentByFeedName(A<string>._))
                    .Returns(OpenApiMetadataHelper.GetIdentityContent());

                var fakeopenAPIcontent = A.Fake<List<OpenApiContent>>();

                A.CallTo(() => _openApiMetadataCacheProvider.GetAllSectionDocuments(A<bool>._)).Returns(fakeopenAPIcontent);

                var sectiondata = _openApiMetadataCacheProvider.GetOpenApiContentByFeedName("openApiMetadata");
                fakeopenAPIcontent.Add(sectiondata);
                _controller = new OpenApiMetadataController(
                    _openApiMetadataCacheProvider, 
                    new FakeFeatureManager(), 
                    apiSettings);

                var request = A.Fake<HttpRequest>();
                request.Method = HttpMethods.Post;
                request.Scheme = "http";

                A.CallTo(() => request.Host).Returns(new HostString("localhost", 80));

                request.PathBase = "/";
                request.Path = "/metadata";
                request.RouteValues = new RouteValueDictionary { {
                            "controller", "Token"
                        } };

                HeaderDictionary headers = new HeaderDictionary();
                headers.Add(HeaderConstants.XForwardedProto, "https");
                headers.Add(HeaderConstants.XForwardedHost, "api.com");
                headers.Add(HeaderConstants.XForwardedPort, "443");

                A.CallTo(() => request.Headers).Returns(headers);

                var httpContext = A.Fake<HttpContext>();

                A.CallTo(() => httpContext.Request).Returns(request);

                var controllerContext = new ControllerContext()
                {
                    HttpContext = httpContext,
                };
                RouteValueDictionary dictionary = new RouteValueDictionary();
                dictionary.Add("controller", "Token");

                controllerContext.RouteData = new RouteData(dictionary);

                _controller.ControllerContext = controllerContext;
            }

            [Assert]
            public void Should_return_valid_http_response_message()
            {
                var request = new OpenApiMetadataSectionRequest
                {
                    Sdk = true
                };

                var response = (OkObjectResult)_controller.Get(request);

                var openapisectionlist = (List<OpenApiMetadataSectionDetails>)response.Value;
                Assert.AreEqual(200, response.StatusCode);
                Assert.IsNotNull(response);
                Assert.IsTrue(openapisectionlist.Count > 0);
                Assert.AreEqual("Identity", openapisectionlist[0].Name);
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("localhost"));
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("https"));
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("metadata"));
                Assert.AreEqual("Other", openapisectionlist[0].Prefix);
            }
        }

        [TestFixture]
        public class When_calling_the_metadata_controller_with_use_reverse_proxy_and_no_forwarded_headers : TestFixtureBase
        {
            private OpenApiMetadataController _controller;
            private IOpenApiMetadataCacheProvider _openApiMetadataCacheProvider;

            protected override void Arrange()
            {
                var configValueProvider = new ApiSettings
                {
                    UseReverseProxyHeaders = true,
                    OverrideForForwardingHostPort = 80,
                    OverrideForForwardingHostServer = "localhost"
                };

                _openApiMetadataCacheProvider = Stub<IOpenApiMetadataCacheProvider>();

                A.CallTo(() => _openApiMetadataCacheProvider.GetOpenApiContentByFeedName(A<string>._))
                    .Returns(OpenApiMetadataHelper.GetIdentityContent());

                var fakeopenAPIcontent = A.Fake<List<OpenApiContent>>();

                A.CallTo(() => _openApiMetadataCacheProvider.GetAllSectionDocuments(A<bool>._)).Returns(fakeopenAPIcontent);

                var sectiondata = _openApiMetadataCacheProvider.GetOpenApiContentByFeedName("openApiMetadata");
                fakeopenAPIcontent.Add(sectiondata);

                _controller = new OpenApiMetadataController(_openApiMetadataCacheProvider, new FakeFeatureManager(), new ApiSettings());

                var request = A.Fake<HttpRequest>();
                request.Method = HttpMethods.Post;
                request.Scheme = "http";

                A.CallTo(() => request.Host).Returns(new HostString("localhost", 80));

                request.PathBase = "/";
                request.Path = "/metadata";
                request.RouteValues = new RouteValueDictionary { {
                            "controller", "Token"
                        } };

                var httpContext = A.Fake<HttpContext>();

                A.CallTo(() => httpContext.Request).Returns(request);

                var controllerContext = new ControllerContext()
                {
                    HttpContext = httpContext,
                };
                RouteValueDictionary dictionary = new RouteValueDictionary();
                dictionary.Add("controller", "Token");

                controllerContext.RouteData = new RouteData(dictionary);

                _controller.ControllerContext = controllerContext;
            }

            [Assert]
            public void Should_return_valid_http_response_message()
            {
                var request = new OpenApiMetadataSectionRequest
                {
                    Sdk = true,
                };

                var response = (OkObjectResult)_controller.Get(request);
                var openapisectionlist = (List<OpenApiMetadataSectionDetails>)response.Value;

                Assert.AreEqual(200, response.StatusCode);
                Assert.IsNotNull(response);
                Assert.IsTrue(openapisectionlist.Count > 0);
                Assert.AreEqual("Identity", openapisectionlist[0].Name);
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("localhost"));
                Assert.IsTrue(openapisectionlist[0].EndpointUri.Contains("metadata"));
            }
        }
    }
}
