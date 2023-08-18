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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="HostPoolResource" /> and their operations.
    /// Each <see cref="HostPoolResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="HostPoolCollection" /> instance call the GetHostPools method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class HostPoolCollection : ArmCollection, IEnumerable<HostPoolResource>, IAsyncEnumerable<HostPoolResource>
    {
        private readonly ClientDiagnostics _hostPoolClientDiagnostics;
        private readonly HostPoolsRestOperations _hostPoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostPoolCollection"/> class for mocking. </summary>
        protected HostPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostPoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", HostPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HostPoolResource.ResourceType, out string hostPoolApiVersion);
            _hostPoolRestClient = new HostPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostPoolApiVersion);
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
        /// Create or update a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="data"> Object containing HostPool definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HostPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string hostPoolName, HostPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostPoolRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<HostPoolResource>(Response.FromValue(new HostPoolResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="data"> Object containing HostPool definitions. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HostPoolResource> CreateOrUpdate(WaitUntil waitUntil, string hostPoolName, HostPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostPoolRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, data, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<HostPoolResource>(Response.FromValue(new HostPoolResource(Client, response), response.GetRawResponse()));
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
        /// Get a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual async Task<Response<HostPoolResource>> GetAsync(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a host pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual Response<HostPoolResource> Get(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _hostPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List hostPools.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostPoolResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostPoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostPoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HostPoolResource(Client, HostPoolData.DeserializeHostPoolData(e)), _hostPoolClientDiagnostics, Pipeline, "HostPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List hostPools.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostPoolResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostPoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostPoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, pageSizeHint, isDescending, initialSkip);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HostPoolResource(Client, HostPoolData.DeserializeHostPoolData(e)), _hostPoolClientDiagnostics, Pipeline, "HostPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hostPoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="hostPoolName"> The name of the host pool within the specified resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="hostPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="hostPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string hostPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(hostPoolName, nameof(hostPoolName));

            using var scope = _hostPoolClientDiagnostics.CreateScope("HostPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _hostPoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, hostPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HostPoolResource> IEnumerable<HostPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostPoolResource> IAsyncEnumerable<HostPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
