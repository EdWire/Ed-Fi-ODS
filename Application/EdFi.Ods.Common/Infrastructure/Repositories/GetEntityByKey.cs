﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using EdFi.Common.Configuration;
using EdFi.Ods.Common.Configuration;
using EdFi.Ods.Common.Context;
using EdFi.Ods.Common.Database.Querying.Dialects;
using EdFi.Ods.Common.Extensions;
using EdFi.Ods.Common.Infrastructure.Listeners;
using EdFi.Ods.Common.Models;
using EdFi.Ods.Common.Models.Domain;
using EdFi.Ods.Common.Repositories;
using EdFi.Ods.Common.Security.Claims;
using log4net;
using Microsoft.FeatureManagement;
using NHibernate;

namespace EdFi.Ods.Common.Infrastructure.Repositories
{
    public class GetEntityByKey<TEntity> : GetEntitiesBase<TEntity>, IGetEntityByKey<TEntity>
        where TEntity : DomainObjectBase, IDateVersionedEntity, IHasIdentifier
    {
        private readonly IContextProvider<DataManagementResourceContext> _dataManagementResourceContextProvider;
        private readonly IEntityDeserializer _entityDeserializer;

        private readonly Lazy<ILog> _logger;

        public GetEntityByKey(
            ISessionFactory sessionFactory,
            IDomainModelProvider domainModelProvider,
            IContextProvider<DataManagementResourceContext> dataManagementResourceContextProvider,
            IFeatureManager featureManager,
            Dialect dialect,
            DatabaseEngine databaseEngine,
            IEntityDeserializer entityDeserializer)
            : base(sessionFactory, domainModelProvider, dataManagementResourceContextProvider, featureManager, dialect, databaseEngine)
        {
            _dataManagementResourceContextProvider = dataManagementResourceContextProvider;
            _entityDeserializer = entityDeserializer;

            _logger = new Lazy<ILog>(() => LogManager.GetLogger(GetType()));
        }

        /// <summary>
        /// Gets a single entity by its composite primary key values.
        /// </summary>
        /// <param name="specification">An entity instance that has all the primary key properties assigned with values.</param>
        /// <returns>The specified entity if found; otherwise null.</returns>
        public async Task<TEntity> GetByKeyAsync(TEntity specification, CancellationToken cancellationToken)
        {
            using (var scope = new SessionScope(SessionFactory))
            {
                TEntity persistedEntity = null;

                // Look up by composite key
                var entityWithKeyValues = specification as IHasPrimaryKeyValues;

                if (entityWithKeyValues == null)
                {
                    // Every root entity should have a primary key implementation. This is definitely a system error if it were to ever occur.
                    throw new Exception(
                        $"The '{typeof(TEntity).Name}' entity does not support accessing primary key values.");
                }

                // Go try to get the existing entity
                var compositeKeyValues = entityWithKeyValues.GetPrimaryKeyValues();

                var resource = _dataManagementResourceContextProvider.Get()?.Resource;

                if (ShouldTryLoadByCompositePrimaryKey())
                {
                    // Only look up by composite key if "Id" is not considered part of the "DomainSignature"
                    if (!compositeKeyValues.Contains("Id"))
                    {
                        // Use optimized load only if serialization feature enabled
                        if (SerializationEnabled)
                        {
                            var itemRawData = await GetItemRawDataByCompositeKey(compositeKeyValues, scope);

                            // Could not find the item
                            if (itemRawData == null)
                            {
                                return null;
                            }

                            // Can we deserialize it?
                            if (itemRawData.IsDeserializable)
                            {
                                // Deserialize the entity
                                var deserializedEntity = await _entityDeserializer.DeserializeAsync<TEntity>(itemRawData);

                                if (deserializedEntity != null)
                                {
                                    return deserializedEntity;
                                }
                            }
                        }

                        // Load the item from the ODS
                        persistedEntity = (await GetAggregateResultsAsync(
                                GetWhereClause(compositeKeyValues), q => q.SetParameters(compositeKeyValues), cancellationToken))
                            .SingleOrDefault();
                    }

                    if (persistedEntity != null)
                    {
                        return persistedEntity;
                    }
                }

                var entityWithAlternateKeyValues = specification as IHasAlternateKeyValues;

                // If entity doesn't have an alternate key, we're done.
                if (entityWithAlternateKeyValues == null)
                {
                    return null;
                }

                var (alternateKeyValues, isDefinedOnBaseType) = entityWithAlternateKeyValues.GetAlternateKeyValues();

                // Look up by alternate key
                if (alternateKeyValues.Count > 0)
                {
                    if (SerializationEnabled)
                    {
                        var itemRawData = await GetItemRawDataByCompositeKey(alternateKeyValues, scope, isDefinedOnBaseType);

                        // Could not find the item
                        if (itemRawData == null)
                        {
                            return null;
                        }

                        // Can we deserialize it?
                        if (itemRawData.IsDeserializable)
                        {
                            // Deserialize the entity
                            var deserializedEntity = await _entityDeserializer.DeserializeAsync<TEntity>(itemRawData);

                            if (deserializedEntity != null)
                            {
                                return deserializedEntity;
                            }
                        }
                    }

                    // Load the item from the ODS using NHibernate
                    persistedEntity = (await GetAggregateResultsAsync(
                            GetWhereClause(alternateKeyValues), q => q.SetParameters(alternateKeyValues), cancellationToken))
                        .SingleOrDefault();
                }

                return persistedEntity;

                bool ShouldTryLoadByCompositePrimaryKey()
                {
                    if (compositeKeyValues.Count > 1)
                    {
                        return true;
                    }

                    var identifier = resource?.Entity?.Identifier;

                    // If the entity doesn't have a surrogate key, proceed with load by primary key
                    if (identifier?.IsSurrogateIdentifier() != true)
                    {
                        return true;
                    }

                    // If the surrogate primary key values are non-zero, proceed with load by primary key (i.e. USIs for existing people will be resolved already)
                    if ((int) compositeKeyValues[identifier.Properties[0].PropertyName]! != 0)
                    {
                        return true;
                    }
                    
                    return false;
                }
            }

            string GetWhereClause(OrderedDictionary keyValues)
            {
                string criteria = string.Join(
                    " and ",
                    keyValues
                        .AsEnumerable()
                        .Select(e => $"a.{e.Key} = :{e.Key}"));

                return $" where {criteria}";
            }

            async Task<ItemRawData<TEntity>> GetItemRawDataByCompositeKey(
                OrderedDictionary compositeKeyValues,
                SessionScope scope,
                bool keyColumnsAreOnBaseType = false)
            {
                // Get the item from serialized form
                var singleItemQueryBuilder = GetSingleItemQueryBuilder();

                string rootTableAlias = keyColumnsAreOnBaseType ? "b" : "r";

                // Apply primary key values to the root (derived, if applicable) table, as that's how the composite key values are provided
                foreach (DictionaryEntry keyValue in compositeKeyValues)
                {
                    singleItemQueryBuilder.Where($"{rootTableAlias}.{(string) keyValue.Key}", keyValue.Value);
                }

                var singleItemTemplate = singleItemQueryBuilder.BuildTemplate();

                var itemRawData = await scope.Session.Connection.QuerySingleOrDefaultAsync<ItemRawData<TEntity>>(
                    singleItemTemplate.RawSql,
                    singleItemTemplate.Parameters);

                return itemRawData;
            }
        }
    }
}
