// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using EdFi.Ods.Api.Attributes;
using EdFi.Ods.Api.Constants;
using EdFi.Ods.Api.Helpers;
using EdFi.Ods.Common.Configuration;
using EdFi.Ods.Common.Constants;
using EdFi.Ods.Common.Exceptions;
using EdFi.Ods.Common.Extensions;
using EdFi.Ods.Common.Logging;
using EdFi.Ods.Common.Models;
using EdFi.Ods.Common.Models.Queries;
using EdFi.Ods.Common.Models.Validation;
using EdFi.Ods.Common.Serialization;
using EdFi.Ods.Features.ChangeQueries.Repositories.KeyChanges;
using log4net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.FeatureManagement;
using Newtonsoft.Json;

namespace EdFi.Ods.Features.ChangeQueries.Controllers
{
    [Authorize]
    [ApiController]
    [Produces("application/json")]
    [ApplyOdsRouteRootTemplate]
    [Route($"{RouteConstants.DataManagementRoutePrefix}/{{schema}}/{{resource}}/keyChanges")]
    public class KeyChangesController : ControllerBase
    {
        private readonly int _defaultPageLimitSize;
        private readonly IDomainModelProvider _domainModelProvider;
        private readonly bool _isEnabled;
        private readonly IKeyChangesResourceDataProvider _keyChangesResourceDataProvider;

        private readonly ILog _logger = LogManager.GetLogger(typeof(KeyChangesController));
        private readonly ILogContextAccessor _logContextAccessor;

        public KeyChangesController(
            IDomainModelProvider domainModelProvider,
            IKeyChangesResourceDataProvider keyChangesResourceDataProvider,
            IDefaultPageSizeLimitProvider defaultPageSizeLimitProvider,
            ILogContextAccessor logContextAccessor,
            IFeatureManager featureManager)
        {
            _domainModelProvider = domainModelProvider;
            _keyChangesResourceDataProvider = keyChangesResourceDataProvider;
            _logContextAccessor = logContextAccessor;

            _defaultPageLimitSize = defaultPageSizeLimitProvider.GetDefaultPageSizeLimit();

            _isEnabled = featureManager.IsFeatureEnabled(ApiFeature.ChangeQueries);
        }

        [HttpGet]
        public async Task<IActionResult> Get(
            string schema,
            string resource,
            [FromQuery] UrlQueryParametersRequest urlQueryParametersRequest)
        {
            if (!_isEnabled)
            {
                _logger.Debug("ChangeQueries is not enabled.");

                return ControllerHelpers.FeatureDisabled(
                    ChangeQueriesConstants.FeatureName,
                    _logContextAccessor.GetCorrelationId());
            }

            if (!_domainModelProvider.GetDomainModel()
                    .ResourceModel.TryGetResourceByApiCollectionName(schema, resource, out var resourceClass))
            {
                return ControllerHelpers.NotFound(_logContextAccessor.GetCorrelationId());
            }

            var parameterMessages = urlQueryParametersRequest.Validate(_defaultPageLimitSize).ToArray();

            if (parameterMessages.Any())
            {
                return BadRequest(
                    new BadRequestParameterException("Parameters supplied to the request were invalid.", parameterMessages)
                    {
                        CorrelationId = _logContextAccessor.GetCorrelationId()
                    }.AsSerializableModel());
            }

            var queryParameters = new QueryParameters(urlQueryParametersRequest);

            // TODO: ODS-6510 - Set authorization context (should this be moved/removed?)
            // _authorizationContextProvider.SetResourceUris(_resourceClaimUriProvider.GetResourceClaimUris(resourceClass));
            // _authorizationContextProvider.SetAction(_securityRepository.GetActionByName("ReadChanges").ActionUri);

            var keyChangesResponse = await _keyChangesResourceDataProvider.GetResourceDataAsync(resourceClass, queryParameters);

            // Add the total count, if requested
            if (urlQueryParametersRequest.TotalCount)
            {
                Response.Headers.Append("Total-Count", keyChangesResponse.Count.ToString());
            }

            // Explicitly serialize the response to remain backwards compatible with .NET Framework implementation responses
            return new ContentResult
            {
                Content = JsonConvert.SerializeObject(keyChangesResponse.Items, new Iso8601UtcDateOnlyConverter()),
                ContentType = MediaTypeNames.Application.Json,
                StatusCode = StatusCodes.Status200OK
            };
        }
    }
}
