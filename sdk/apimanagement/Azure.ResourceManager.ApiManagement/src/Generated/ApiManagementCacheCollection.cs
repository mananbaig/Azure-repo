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
    /// A class representing a collection of <see cref="ApiManagementCacheResource" /> and their operations.
    /// Each <see cref="ApiManagementCacheResource" /> in the collection will belong to the same instance of <see cref="ApiManagementServiceResource" />.
    /// To get an <see cref="ApiManagementCacheCollection" /> instance call the GetApiManagementCaches method from an instance of <see cref="ApiManagementServiceResource" />.
    /// </summary>
    public partial class ApiManagementCacheCollection : ArmCollection, IEnumerable<ApiManagementCacheResource>, IAsyncEnumerable<ApiManagementCacheResource>
    {
        private readonly ClientDiagnostics _apiManagementCacheCacheClientDiagnostics;
        private readonly CacheRestOperations _apiManagementCacheCacheRestClient;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementCacheCollection"/> class for mocking. </summary>
        protected ApiManagementCacheCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementCacheCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ApiManagementCacheCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementCacheCacheClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ApiManagementCacheResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ApiManagementCacheResource.ResourceType, out string apiManagementCacheCacheApiVersion);
            _apiManagementCacheCacheRestClient = new CacheRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementCacheCacheApiVersion);
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
        /// Creates or updates an External Cache to be used in Api Management instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches/{cacheId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheId"> Identifier of the Cache entity. Cache identifier (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="data"> Create or Update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheId"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementCacheResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string cacheId, ApiManagementCacheData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheId, nameof(cacheId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementCacheCacheClientDiagnostics.CreateScope("ApiManagementCacheCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _apiManagementCacheCacheRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cacheId, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementCacheResource>(Response.FromValue(new ApiManagementCacheResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates an External Cache to be used in Api Management instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches/{cacheId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cacheId"> Identifier of the Cache entity. Cache identifier (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="data"> Create or Update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheId"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ApiManagementCacheResource> CreateOrUpdate(WaitUntil waitUntil, string cacheId, ApiManagementCacheData data, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheId, nameof(cacheId));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _apiManagementCacheCacheClientDiagnostics.CreateScope("ApiManagementCacheCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _apiManagementCacheCacheRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cacheId, data, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementCacheResource>(Response.FromValue(new ApiManagementCacheResource(Client, response), response.GetRawResponse()));
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
        /// Gets the details of the Cache specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches/{cacheId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheId"> Identifier of the Cache entity. Cache identifier (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheId"/> is null. </exception>
        public virtual async Task<Response<ApiManagementCacheResource>> GetAsync(string cacheId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheId, nameof(cacheId));

            using var scope = _apiManagementCacheCacheClientDiagnostics.CreateScope("ApiManagementCacheCollection.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementCacheCacheRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cacheId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementCacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the Cache specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches/{cacheId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheId"> Identifier of the Cache entity. Cache identifier (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheId"/> is null. </exception>
        public virtual Response<ApiManagementCacheResource> Get(string cacheId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheId, nameof(cacheId));

            using var scope = _apiManagementCacheCacheClientDiagnostics.CreateScope("ApiManagementCacheCollection.Get");
            scope.Start();
            try
            {
                var response = _apiManagementCacheCacheRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cacheId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementCacheResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists a collection of all external Caches in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ApiManagementCacheResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ApiManagementCacheResource> GetAllAsync(int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementCacheCacheRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementCacheCacheRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementCacheResource(Client, ApiManagementCacheData.DeserializeApiManagementCacheData(e)), _apiManagementCacheCacheClientDiagnostics, Pipeline, "ApiManagementCacheCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists a collection of all external Caches in the specified service instance.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_ListByService</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> Number of records to return. </param>
        /// <param name="skip"> Number of records to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ApiManagementCacheResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ApiManagementCacheResource> GetAll(int? top = null, int? skip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _apiManagementCacheCacheRestClient.CreateListByServiceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _apiManagementCacheCacheRestClient.CreateListByServiceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, top, skip);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ApiManagementCacheResource(Client, ApiManagementCacheData.DeserializeApiManagementCacheData(e)), _apiManagementCacheCacheClientDiagnostics, Pipeline, "ApiManagementCacheCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches/{cacheId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheId"> Identifier of the Cache entity. Cache identifier (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheId"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string cacheId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheId, nameof(cacheId));

            using var scope = _apiManagementCacheCacheClientDiagnostics.CreateScope("ApiManagementCacheCollection.Exists");
            scope.Start();
            try
            {
                var response = await _apiManagementCacheCacheRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cacheId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/caches/{cacheId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Cache_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cacheId"> Identifier of the Cache entity. Cache identifier (should be either 'default' or valid Azure region identifier). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="cacheId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="cacheId"/> is null. </exception>
        public virtual Response<bool> Exists(string cacheId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(cacheId, nameof(cacheId));

            using var scope = _apiManagementCacheCacheClientDiagnostics.CreateScope("ApiManagementCacheCollection.Exists");
            scope.Start();
            try
            {
                var response = _apiManagementCacheCacheRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cacheId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ApiManagementCacheResource> IEnumerable<ApiManagementCacheResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ApiManagementCacheResource> IAsyncEnumerable<ApiManagementCacheResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
