﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using EdFi.Ods.Api.Constants;
using EdFi.Ods.Api.Models;
using EdFi.Ods.Api.Providers;
using EdFi.Ods.Common.Utils.Extensions;
using EdFi.Ods.Features.OpenApiMetadata.Providers;

namespace EdFi.Ods.Features.ChangeQueries.Providers
{
    public class ChangeQueriesOpenApiContentProvider : IOpenApiContentProvider
    {
        private const string Name = "ChangeQueries";
        private readonly IOpenApiUpconversionProvider _openApiV3UpconversionProvider;
        
        public ChangeQueriesOpenApiContentProvider(IOpenApiUpconversionProvider openApiUpconversionProvider)
        {
            _openApiV3UpconversionProvider = openApiUpconversionProvider;
        }

        public string RouteName
        {
            get => ChangeQueriesConstants.ChangeQueriesMetadataRouteName;
        }

        public IEnumerable<OpenApiContent> GetOpenApiContent()
        {
            var assembly = GetType()
                .Assembly;

            return assembly
                .GetManifestResourceNames()
                .Where(x => x.EndsWith($"{Name}.json"))
                .Select(
                    x => new OpenApiContent(
                        OpenApiMetadataSections.Other, Name,
                        new Lazy<string>(() => assembly.ReadResource(x)),
                        new Lazy<string>(() => _openApiV3UpconversionProvider.GetUpconvertedOpenApiJson(assembly.ReadResource(x))),
                        $"{Name}/v{ChangeQueriesConstants.FeatureVersion}", string.Empty));
        }
    }
}
