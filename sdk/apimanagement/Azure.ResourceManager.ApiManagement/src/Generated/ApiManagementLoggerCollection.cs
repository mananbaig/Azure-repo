// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A class representing a collection of <see cref="ApiManagementLoggerResource" /> and their operations.
    /// Each <see cref="ApiManagementLoggerResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementLoggerCollection" /> instance call the GetApiManagementLoggers method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementLoggerCollection : ArmCollection, IEnumerable<ApiManagementLoggerResource>, IAsyncEnumerable<ApiManagementLoggerResource>
    {
        private readonly ClientDiagnostics _apiManagementLoggerLoggerClientDiagnostics;
        private readonly LoggerRestOperations _apiManagementLoggerLoggerRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementLoggerCollection"/> class for mocking. </summary>
        protected ApiManagementLoggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementLoggerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementLoggerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementLoggerLoggerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementLoggerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementLoggerResource.ResourceType, out string apiManagementLoggerLoggerApiVersion);
            _apiManagementLoggerLoggerRestClient = new LoggerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementLoggerLoggerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ApiManagementServiceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ApiManagementServiceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or Updates a logger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers/{loggerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="loggerId"> Logger identifier. Must be unique in the API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loggerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loggerId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementLoggerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string loggerId, ApiManagementLoggerData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loggerId, nameof(loggerId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementLoggerLoggerClientDiagnostics.CreateScope("ApiManagementLoggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementLoggerLoggerRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loggerId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementLoggerResource>(Response.FromValue(new ApiManagementLoggerResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or Updates a logger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers/{loggerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="loggerId"> Logger identifier. Must be unique in the API Management service instance. </param>
        /// <param name="data"> Create parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loggerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loggerId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementLoggerResource> CreateOrUpdate(WaitUntil waitUntil, string loggerId, ApiManagementLoggerData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loggerId, nameof(loggerId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementLoggerLoggerClientDiagnostics.CreateScope("ApiManagementLoggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementLoggerLoggerRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loggerId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementLoggerResource>(Response.FromValue(new ApiManagementLoggerResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the logger specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers/{loggerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loggerId"> Logger identifier. Must be unique in the API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loggerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loggerId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementLoggerResource>> GetAsync(string loggerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loggerId, nameof(loggerId));

            using var scope = _apiManagementLoggerLoggerClientDiagnostics.CreateScope("ApiManagementLoggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementLoggerLoggerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loggerId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementLoggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the logger specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers/{loggerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loggerId"> Logger identifier. Must be unique in the API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loggerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loggerId"/> is null. </exception>
        public virtual Response<ApiManagementLoggerResource> Get(string loggerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loggerId, nameof(loggerId));

            using var scope = _apiManagementLoggerLoggerClientDiagnostics.CreateScope("ApiManagementLoggerCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementLoggerLoggerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loggerId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementLoggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of loggers in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| loggerType | filter | eq |     |&lt;/br&gt;| resourceId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementLoggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementLoggerResource> GetAllAsync(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementLoggerLoggerRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementLoggerLoggerRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementLoggerResource(Client, ApiManagementLoggerData.DeserializeApiManagementLoggerData(e)), _apiManagementLoggerLoggerClientDiagnostics, Pipeline, "ApiManagementLoggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of loggers in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> |     Field     |     Usage     |     Supported operators     |     Supported functions     |&lt;/br&gt;|-------------|-------------|-------------|-------------|&lt;/br&gt;| name | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| description | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;| loggerType | filter | eq |     |&lt;/br&gt;| resourceId | filter | ge, le, eq, ne, gt, lt | substringof, contains, startswith, endswith |&lt;/br&gt;. </param>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementLoggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementLoggerResource> GetAll(string filter = null, int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementLoggerLoggerRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementLoggerLoggerRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementLoggerResource(Client, ApiManagementLoggerData.DeserializeApiManagementLoggerData(e)), _apiManagementLoggerLoggerClientDiagnostics, Pipeline, "ApiManagementLoggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers/{loggerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loggerId"> Logger identifier. Must be unique in the API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loggerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loggerId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string loggerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loggerId, nameof(loggerId));

            using var scope = _apiManagementLoggerLoggerClientDiagnostics.CreateScope("ApiManagementLoggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementLoggerLoggerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loggerId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/loggers/{loggerId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Logger_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="loggerId"> Logger identifier. Must be unique in the API Management service instance. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="loggerId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="loggerId"/> is null. </exception>
        public virtual Response<bool> Exists(string loggerId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(loggerId, nameof(loggerId));

            using var scope = _apiManagementLoggerLoggerClientDiagnostics.CreateScope("ApiManagementLoggerCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementLoggerLoggerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, loggerId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementLoggerResource> IEnumerable<ApiManagementLoggerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementLoggerResource> IAsyncEnumerable<ApiManagementLoggerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
