// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Autofac;
using EdFi.Ods.Common.Constants;
using EdFi.Ods.Common.Container;
using EdFi.Ods.Common.Dependencies;
using Microsoft.FeatureManagement;

namespace EdFi.Ods.Features.ResourceLinks.Modules;

public class ResourceLinksModule : ConditionalModule
{
    public ResourceLinksModule(IFeatureManager featureManager)
        : base(featureManager) { }

    protected override bool IsSelected() => IsFeatureEnabled(ApiFeature.ResourceLinks);

    protected override void ApplyConfigurationSpecificRegistrations(ContainerBuilder builder)
    {
        // Provide static code with access to enabled state of resource links feature
        GeneratedArtifactStaticDependencies.Resolvers.SetEnabledFeatures(resourceLinksEnabled: true);
    }
}
