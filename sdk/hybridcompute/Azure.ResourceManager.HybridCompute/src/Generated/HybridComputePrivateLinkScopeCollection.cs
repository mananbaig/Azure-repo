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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HybridCompute
{
    /// <summary>
    /// A class representing a collection of <see cref="HybridComputePrivateLinkScopeResource" /> and their operations.
    /// Each <see cref="HybridComputePrivateLinkScopeResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HybridComputePrivateLinkScopeCollection" /> instance call the GetHybridComputePrivateLinkScopes method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HybridComputePrivateLinkScopeCollection : ArmCollection, IEnumerable<HybridComputePrivateLinkScopeResource>, IAsyncEnumerable<HybridComputePrivateLinkScopeResource>
    {
        private readonly ClientDiagnostics _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics;
        private readonly PrivateLinkScopesRestOperations _hybridComputePrivateLinkScopePrivateLinkScopesRestClient;

        /// <summary> Initializes a new instance of the <see cref="HybridComputePrivateLinkScopeCollection"/> class for mocking. </summary>
        protected HybridComputePrivateLinkScopeCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HybridComputePrivateLinkScopeCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HybridComputePrivateLinkScopeCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HybridCompute", HybridComputePrivateLinkScopeResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HybridComputePrivateLinkScopeResource.ResourceType, out string hybridComputePrivateLinkScopePrivateLinkScopesApiVersion);
            _hybridComputePrivateLinkScopePrivateLinkScopesRestClient = new PrivateLinkScopesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hybridComputePrivateLinkScopePrivateLinkScopesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates (or updates) a Azure Arc PrivateLinkScope. Note: You cannot specify a different value for InstrumentationKey nor AppId in the Put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="data"> Properties that need to be specified to create or update a Azure Arc for Servers and Clusters PrivateLinkScope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HybridComputePrivateLinkScopeResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string scopeName, HybridComputePrivateLinkScopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("HybridComputePrivateLinkScopeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, scopeName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HybridComputeArmOperation<HybridComputePrivateLinkScopeResource>(Response.FromValue(new HybridComputePrivateLinkScopeResource(Client, response), response.GetRawResponse()));
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
        /// Creates (or updates) a Azure Arc PrivateLinkScope. Note: You cannot specify a different value for InstrumentationKey nor AppId in the Put operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="data"> Properties that need to be specified to create or update a Azure Arc for Servers and Clusters PrivateLinkScope. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HybridComputePrivateLinkScopeResource> CreateOrUpdate(WaitUntil waitUntil, string scopeName, HybridComputePrivateLinkScopeData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("HybridComputePrivateLinkScopeCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, scopeName, data, cancellationToken);
                var operation = new HybridComputeArmOperation<HybridComputePrivateLinkScopeResource>(Response.FromValue(new HybridComputePrivateLinkScopeResource(Client, response), response.GetRawResponse()));
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
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        public virtual async Task<Response<HybridComputePrivateLinkScopeResource>> GetAsync(string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));

            using var scope = _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("HybridComputePrivateLinkScopeCollection.Get");
            scope.Start();
            try
            {
                var response = await _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scopeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputePrivateLinkScopeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a Azure Arc PrivateLinkScope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        public virtual Response<HybridComputePrivateLinkScopeResource> Get(string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));

            using var scope = _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("HybridComputePrivateLinkScopeCollection.Get");
            scope.Start();
            try
            {
                var response = _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scopeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HybridComputePrivateLinkScopeResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of Azure Arc PrivateLinkScopes within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HybridComputePrivateLinkScopeResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HybridComputePrivateLinkScopeResource(Client, HybridComputePrivateLinkScopeData.DeserializeHybridComputePrivateLinkScopeData(e)), _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics, Pipeline, "HybridComputePrivateLinkScopeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of Azure Arc PrivateLinkScopes within a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HybridComputePrivateLinkScopeResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HybridComputePrivateLinkScopeResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HybridComputePrivateLinkScopeResource(Client, HybridComputePrivateLinkScopeData.DeserializeHybridComputePrivateLinkScopeData(e)), _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics, Pipeline, "HybridComputePrivateLinkScopeCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));

            using var scope = _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("HybridComputePrivateLinkScopeCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, scopeName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HybridCompute/privateLinkScopes/{scopeName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateLinkScopes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="scopeName"> The name of the Azure Arc PrivateLinkScope resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="scopeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="scopeName"/> is null. </exception>
        public virtual Response<bool> Exists(string scopeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(scopeName, nameof(scopeName));

            using var scope = _hybridComputePrivateLinkScopePrivateLinkScopesClientDiagnostics.CreateScope("HybridComputePrivateLinkScopeCollection.Exists");
            scope.Start();
            try
            {
                var response = _hybridComputePrivateLinkScopePrivateLinkScopesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, scopeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HybridComputePrivateLinkScopeResource> IEnumerable<HybridComputePrivateLinkScopeResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HybridComputePrivateLinkScopeResource> IAsyncEnumerable<HybridComputePrivateLinkScopeResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
