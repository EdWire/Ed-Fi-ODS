﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Autofac;
using EdFi.Ods.Entities.Common.EdFi;
using EdFi.Ods.Api.Security.AuthorizationStrategies.Relationships;
using EdFi.Ods.Standard.Security.Authorization.Overrides;

namespace EdFi.Ods.Standard.Container.Modules
{
    public class V510_RelationshipsAuthorizationContextDataProviderOverridesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Establish authorization context for EvaluationRubricDimension using the ProgramEducationOrganizationId rather than
            // using the default behavior (EducationOrganizationId)
            builder.RegisterType<EvaluationRubricDimensionRelationshipsAuthorizationContextDataProvider>()
                .As<IRelationshipsAuthorizationContextDataProvider<IEvaluationRubricDimension>>()
                .SingleInstance();

            // Establish authorization context for StudentAssessment using the ProgramEducationOrganizationId rather than
            // using the default behavior (EducationOrganizationId)
            builder.RegisterType<ProgramEvaluationRelationshipsAuthorizationContextDataProvider>()
                .As<IRelationshipsAuthorizationContextDataProvider<IProgramEvaluation>>()
                .SingleInstance();

            // Establish authorization context for StudentAssessment using the ProgramEducationOrganizationId rather than
            // using the default behavior (EducationOrganizationId)
            builder.RegisterType<ProgramEvaluationElementRelationshipsAuthorizationContextDataProvider>()
                .As<IRelationshipsAuthorizationContextDataProvider<IProgramEvaluationElement>>()
                .SingleInstance();

            // Establish authorization context for StudentAssessment using the ProgramEducationOrganizationId rather than
            // using the default behavior (EducationOrganizationId)
            builder.RegisterType<ProgramEvaluationObjectiveRelationshipsAuthorizationContextDataProvider>()
                .As<IRelationshipsAuthorizationContextDataProvider<IProgramEvaluationObjective>>()
                .SingleInstance();
        }
    }
}