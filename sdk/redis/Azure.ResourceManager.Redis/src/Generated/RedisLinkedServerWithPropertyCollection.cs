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
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Redis.Models;

namespace Azure.ResourceManager.Redis
{
    /// <summary>
    /// A class representing a collection of <see cref="RedisLinkedServerWithPropertyResource" /> and their operations.
    /// Each <see cref="RedisLinkedServerWithPropertyResource" /> in the collection will belong to the same instance of <see cref="RedisResource" />.
    /// To get a <see cref="RedisLinkedServerWithPropertyCollection" /> instance call the GetRedisLinkedServerWithProperties method from an instance of <see cref="RedisResource" />.
    /// </summary>
    public partial class RedisLinkedServerWithPropertyCollection : ArmCollection, IEnumerable<RedisLinkedServerWithPropertyResource>, IAsyncEnumerable<RedisLinkedServerWithPropertyResource>
    {
        private readonly ClientDiagnostics _redisLinkedServerWithPropertyLinkedServerClientDiagnostics;
        private readonly LinkedServerRestOperations _redisLinkedServerWithPropertyLinkedServerRestClient;

        /// <summary> Initializes a new instance of the <see cref="RedisLinkedServerWithPropertyCollection"/> class for mocking. </summary>
        protected RedisLinkedServerWithPropertyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RedisLinkedServerWithPropertyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RedisLinkedServerWithPropertyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _redisLinkedServerWithPropertyLinkedServerClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Redis", RedisLinkedServerWithPropertyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RedisLinkedServerWithPropertyResource.ResourceType, out string redisLinkedServerWithPropertyLinkedServerApiVersion);
            _redisLinkedServerWithPropertyLinkedServerRestClient = new LinkedServerRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, redisLinkedServerWithPropertyLinkedServerApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != RedisResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, RedisResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Adds a linked server to the Redis cache (requires Premium SKU).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkedServerName"> The name of the linked server that is being added to the Redis cache. </param>
        /// <param name="content"> Parameters supplied to the Create Linked server operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> or <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<RedisLinkedServerWithPropertyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string linkedServerName, RedisLinkedServerWithPropertyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _redisLinkedServerWithPropertyLinkedServerRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, content, cancellationToken).ConfigureAwait(false);
                var operation = new RedisArmOperation<RedisLinkedServerWithPropertyResource>(new RedisLinkedServerWithPropertyOperationSource(Client), _redisLinkedServerWithPropertyLinkedServerClientDiagnostics, Pipeline, _redisLinkedServerWithPropertyLinkedServerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Adds a linked server to the Redis cache (requires Premium SKU).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="linkedServerName"> The name of the linked server that is being added to the Redis cache. </param>
        /// <param name="content"> Parameters supplied to the Create Linked server operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> or <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<RedisLinkedServerWithPropertyResource> CreateOrUpdate(WaitUntil waitUntil, string linkedServerName, RedisLinkedServerWithPropertyCreateOrUpdateContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _redisLinkedServerWithPropertyLinkedServerRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, content, cancellationToken);
                var operation = new RedisArmOperation<RedisLinkedServerWithPropertyResource>(new RedisLinkedServerWithPropertyOperationSource(Client), _redisLinkedServerWithPropertyLinkedServerClientDiagnostics, Pipeline, _redisLinkedServerWithPropertyLinkedServerRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, content).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the detailed information about a linked server of a redis cache (requires Premium SKU).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServerName"> The name of the linked server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> is null. </exception>
        public virtual async Task<Response<RedisLinkedServerWithPropertyResource>> GetAsync(string linkedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.Get");
            scope.Start();
            try
            {
                var response = await _redisLinkedServerWithPropertyLinkedServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisLinkedServerWithPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the detailed information about a linked server of a redis cache (requires Premium SKU).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServerName"> The name of the linked server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> is null. </exception>
        public virtual Response<RedisLinkedServerWithPropertyResource> Get(string linkedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.Get");
            scope.Start();
            try
            {
                var response = _redisLinkedServerWithPropertyLinkedServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RedisLinkedServerWithPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of linked servers associated with this redis cache (requires Premium SKU).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RedisLinkedServerWithPropertyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RedisLinkedServerWithPropertyResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisLinkedServerWithPropertyLinkedServerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisLinkedServerWithPropertyLinkedServerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RedisLinkedServerWithPropertyResource(Client, RedisLinkedServerWithPropertyData.DeserializeRedisLinkedServerWithPropertyData(e)), _redisLinkedServerWithPropertyLinkedServerClientDiagnostics, Pipeline, "RedisLinkedServerWithPropertyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of linked servers associated with this redis cache (requires Premium SKU).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RedisLinkedServerWithPropertyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RedisLinkedServerWithPropertyResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _redisLinkedServerWithPropertyLinkedServerRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _redisLinkedServerWithPropertyLinkedServerRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RedisLinkedServerWithPropertyResource(Client, RedisLinkedServerWithPropertyData.DeserializeRedisLinkedServerWithPropertyData(e)), _redisLinkedServerWithPropertyLinkedServerClientDiagnostics, Pipeline, "RedisLinkedServerWithPropertyCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServerName"> The name of the linked server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _redisLinkedServerWithPropertyLinkedServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServerName"> The name of the linked server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.Exists");
            scope.Start();
            try
            {
                var response = _redisLinkedServerWithPropertyLinkedServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServerName"> The name of the linked server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> is null. </exception>
        public virtual async Task<NullableResponse<RedisLinkedServerWithPropertyResource>> GetIfExistsAsync(string linkedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _redisLinkedServerWithPropertyLinkedServerRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<RedisLinkedServerWithPropertyResource>(response.GetRawResponse());
                return Response.FromValue(new RedisLinkedServerWithPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Cache/redis/{name}/linkedServers/{linkedServerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LinkedServer_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkedServerName"> The name of the linked server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkedServerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServerName"/> is null. </exception>
        public virtual NullableResponse<RedisLinkedServerWithPropertyResource> GetIfExists(string linkedServerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkedServerName, nameof(linkedServerName));

            using var scope = _redisLinkedServerWithPropertyLinkedServerClientDiagnostics.CreateScope("RedisLinkedServerWithPropertyCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _redisLinkedServerWithPropertyLinkedServerRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkedServerName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<RedisLinkedServerWithPropertyResource>(response.GetRawResponse());
                return Response.FromValue(new RedisLinkedServerWithPropertyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RedisLinkedServerWithPropertyResource> IEnumerable<RedisLinkedServerWithPropertyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RedisLinkedServerWithPropertyResource> IAsyncEnumerable<RedisLinkedServerWithPropertyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
