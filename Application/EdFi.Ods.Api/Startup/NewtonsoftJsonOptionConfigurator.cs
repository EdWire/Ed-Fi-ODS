// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using EdFi.Ods.Api.Serialization;
using EdFi.Ods.Common;
using EdFi.Ods.Common.Context;
using EdFi.Ods.Common.Models;
using EdFi.Ods.Common.Profiles;
using EdFi.Ods.Common.Security.Claims;
using EdFi.Ods.Common.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EdFi.Ods.Api.Startup;

/// <summary>
/// Initializes JSON.NET with the custom <see cref="ProfilesAwareContractResolver" /> that is Profiles-aware, rather than the
/// general-purpose <see cref="CamelCasePropertyNamesContractResolver" />.
/// </summary>
public class NewtonsoftJsonOptionConfigurator : IConfigureOptions<MvcNewtonsoftJsonOptions>
{
    private readonly IServiceProvider _serviceProvider;

    public NewtonsoftJsonOptionConfigurator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Configure(MvcNewtonsoftJsonOptions options)
    {
        options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
        options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
        options.SerializerSettings.DateParseHandling = DateParseHandling.None;
        options.SerializerSettings.Formatting = Formatting.Indented;
        options.SerializerSettings.Converters = new JsonConverter[] { new Int64Converter() };

        var contactResolver = _serviceProvider.GetService<ProfilesAwareContractResolver>();

        options.SerializerSettings.ContractResolver = contactResolver;
    }
}