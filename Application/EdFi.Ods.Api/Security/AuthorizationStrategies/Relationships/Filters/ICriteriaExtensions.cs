// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using EdFi.Ods.Api.Security.AuthorizationStrategies.CustomViewBased;
using EdFi.Ods.Common;
using EdFi.Ods.Common.Conventions;
using EdFi.Ods.Common.Infrastructure.Activities;
using EdFi.Ods.Common.Models.Domain;
using EdFi.Ods.Common.Security.Authorization;
using EdFi.Ods.Common.Security.CustomViewBased;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EdFi.Ods.Api.Security.AuthorizationStrategies.Relationships.Filters
{
    public static class ICriteriaExtensions
    {
        /// <summary>
        /// Applies a join-based filter to the criteria for the specified authorization view.
        /// </summary>
        /// <param name="criteria">The criteria to which filters should be applied.</param>
        /// <param name="whereJunction">The <see cref="ICriterion" /> container for adding WHERE clause criterion.</param>
        /// <param name="parameters">The named parameters to be used to satisfy additional filtering requirements.</param>
        /// <param name="viewName">The name of the view to be filtered.</param>
        /// <param name="subjectEndpointName">The name of the property to be joined for the entity being queried.</param>
        /// <param name="viewSourceEndpointName">The name of the property to be filtered using the claim values.</param> 
        /// <param name="viewTargetEndpointName">The name of the property to be joined for the other property as authorization view.</param> 
        /// <param name="joinType">The <see cref="JoinType" /> to be used.</param>
        /// <param name="authViewAlias">The name of the property to be used for auth View Alias name.</param>
        public static void ApplySingleColumnJoinFilter(
            this ICriteria criteria,
            IMultiValueRestrictions multiValueRestrictions,
            Junction whereJunction,
            IDictionary<string, object> parameters,
            string viewName,
            string subjectEndpointName,
            string viewSourceEndpointName,
            string viewTargetEndpointName,
            JoinType joinType,
            string authViewAlias = null)
        {
            authViewAlias = string.IsNullOrWhiteSpace(authViewAlias) ? $"authView{viewName}" : $"authView{authViewAlias}";

            // Apply authorization join using ICriteria
            criteria.CreateEntityAlias(
                authViewAlias,
                Restrictions.EqProperty($"aggregateRoot.{subjectEndpointName}",
                $"{authViewAlias}.{viewTargetEndpointName}"),
                joinType, 
                $"{viewName.GetAuthorizationViewClassName()}".GetFullNameForView());

            // Defensive check to ensure required parameter is present
            if (!parameters.TryGetValue(RelationshipAuthorizationConventions.ClaimsParameterName, out object value))
            {
                throw new Exception($"Unable to find parameter for filtering '{RelationshipAuthorizationConventions.ClaimsParameterName}' on view '{viewName}'. Available parameters: '{string.Join("', '", parameters.Keys)}'");
            }

            if (value is object[] arrayOfValues)
            {
                if (joinType == JoinType.InnerJoin)
                {
                    whereJunction.Add(multiValueRestrictions.In($"{{{authViewAlias}}}.{viewSourceEndpointName}", arrayOfValues));
                }
                else
                {
                    var and = new AndExpression(
                        multiValueRestrictions.In($"{{{authViewAlias}}}.{viewSourceEndpointName}", arrayOfValues),
                        Restrictions.IsNotNull($"{authViewAlias}.{viewTargetEndpointName}"));

                    whereJunction.Add(and);
                }
            }
            else
            {
                if (joinType == JoinType.InnerJoin)
                {
                    whereJunction.Add(Restrictions.Eq($"{authViewAlias}.{viewSourceEndpointName}", value));
                }
                else
                {
                    var and = new AndExpression(
                        Restrictions.Eq($"{authViewAlias}.{viewSourceEndpointName}", value),
                        Restrictions.IsNotNull($"{authViewAlias}.{viewTargetEndpointName}"));

                    whereJunction.Add(and);
                }
            }
        }

        private static string GetFullNameForView(this string viewName)
        {
            return Namespaces.Entities.NHibernate.QueryModels.GetViewNamespace(viewName);
        }

        /// <summary>
        /// Applies a join-based filter to the criteria for the specified custom authorization view.
        /// </summary>
        /// <param name="criteria">The criteria to which filters should be applied.</param>
        /// <param name="viewName">The name of the view to be filtered.</param>
        /// <param name="subjectEndpointNames">The name of the property to be joined for the entity being queried.</param>
        /// <param name="viewTargetEndpointNames">The name of the property to be joined for the other property as authorization view.</param> 
        /// <param name="joinType">The <see cref="JoinType" /> to be used.</param>
        /// <param name="authViewAlias">The name of the property to be used for auth View Alias name.</param>
        /// <param name="authorizationStrategy">The authorization strategy instance (which may be an instance providing additional context for authorization).</param>
        public static void ApplyCustomViewJoinFilter(
            this ICriteria criteria,
            string viewName,
            string[] subjectEndpointNames,
            string[] viewTargetEndpointNames,
            JoinType joinType,
            string authViewAlias,
            IAuthorizationStrategy authorizationStrategy)
        {
            if (authorizationStrategy is not CustomViewBasedAuthorizationStrategy customViewBasedAuthorizationStrategy)
            {
                throw new Exception(
                    $"The authorization strategy supplied to the '{nameof(ApplyCustomViewJoinFilter)}' was not of the expected type '{nameof(CustomViewBasedAuthorizationStrategy)}'.");
            }
            
            string authViewFullAlias = $"{CustomViewHelpers.GetAliasPrefix(viewName)}{authViewAlias}";

            if (subjectEndpointNames.Length == 1)
            {
                // Apply authorization join using ICriteria
                criteria.CreateEntityAlias(
                    authViewFullAlias,
                    Restrictions.EqProperty(
                        $"aggregateRoot.{subjectEndpointNames[0]}",
                        $"{authViewFullAlias}.{viewTargetEndpointNames[0]}"),
                    joinType,
                    customViewBasedAuthorizationStrategy.BasisEntity.EntityTypeFullName());
            }
            else
            {
                // Apply authorization join using ICriteria
                criteria.CreateEntityAlias(
                    authViewFullAlias,
                    BuildJoinCriterion(0),
                    joinType,
                    customViewBasedAuthorizationStrategy.BasisEntity.EntityTypeFullName());
                
                ICriterion BuildJoinCriterion(int endPointIndex)
                {
                    // If this is the last 2 names, build an And expression and terminate recursion
                    if (endPointIndex == subjectEndpointNames.Length - 2)
                    {
                        return new AndExpression(
                            Restrictions.EqProperty(
                                $"aggregateRoot.{subjectEndpointNames[endPointIndex]}",
                                $"{authViewFullAlias}.{viewTargetEndpointNames[endPointIndex]}"),
                            Restrictions.EqProperty(
                                $"aggregateRoot.{subjectEndpointNames[endPointIndex + 1]}",
                                $"{authViewFullAlias}.{viewTargetEndpointNames[endPointIndex + 1]}"));
                    }

                    // Recursively build the and expression
                    return new AndExpression(
                        Restrictions.EqProperty(
                            $"aggregateRoot.{subjectEndpointNames[endPointIndex]}",
                            $"{authViewFullAlias}.{viewTargetEndpointNames[endPointIndex]}"),
                        BuildJoinCriterion(endPointIndex + 1));
                }
            }
        }
    }
}
