// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EdFi.Ods.Api.Middleware;
using EdFi.Ods.Common.Configuration;
using EdFi.Ods.Common.Configuration.Sections;
using Microsoft.Extensions.Options;

namespace EdFi.Ods.Features.MultiTenancy;

/// <summary>
/// Provides access to the map of <see cref="TenantConfiguration" /> data derived from the application's configuration data.
/// </summary>
public class TenantConfigurationMapProvider : ITenantConfigurationMapProvider
{
    private readonly IOptionsMonitor<TenantsSection> _tenantsConfigurationOptions;

    private IDictionary<string, TenantConfiguration> _tenantConfigurationByIdentifier;

    public TenantConfigurationMapProvider(IOptionsMonitor<TenantsSection> tenantsConfigurationOptions)
    {
        _tenantsConfigurationOptions = tenantsConfigurationOptions;
        _tenantConfigurationByIdentifier = InitializeTenantsConfiguration(_tenantsConfigurationOptions.CurrentValue);

        _tenantsConfigurationOptions.OnChange(config =>
        {
            var newMap = InitializeTenantsConfiguration(config);
            Interlocked.Exchange(ref _tenantConfigurationByIdentifier, newMap);
        });
    }

    private static Dictionary<string, TenantConfiguration> InitializeTenantsConfiguration(TenantsSection config)
    {
        return config.Tenants.ToDictionary(
            t => t.Key,
            t => new TenantConfiguration
            {
                TenantIdentifier = t.Key,
                AdminConnectionString = t.Value.ConnectionStrings.GetValueOrDefault("EdFi_Admin"),
                SecurityConnectionString = t.Value.ConnectionStrings.GetValueOrDefault("EdFi_Security"),
            },
            StringComparer.OrdinalIgnoreCase);
    }

    /// <inheritdoc cref="ITenantConfigurationMapProvider.GetMap" />
    public IDictionary<string, TenantConfiguration> GetMap() => _tenantConfigurationByIdentifier;
}
