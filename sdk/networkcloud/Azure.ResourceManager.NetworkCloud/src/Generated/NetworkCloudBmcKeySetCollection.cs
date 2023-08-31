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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkCloudBmcKeySetResource" /> and their operations.
    /// Each <see cref="NetworkCloudBmcKeySetResource" /> in the collection will belong to the same instance of <see cref="NetworkCloudClusterResource" />.
    /// To get a <see cref="NetworkCloudBmcKeySetCollection" /> instance call the GetNetworkCloudBmcKeySets method from an instance of <see cref="NetworkCloudClusterResource" />.
    /// </summary>
    public partial class NetworkCloudBmcKeySetCollection : ArmCollection, IEnumerable<NetworkCloudBmcKeySetResource>, IAsyncEnumerable<NetworkCloudBmcKeySetResource>
    {
        private readonly ClientDiagnostics _networkCloudBmcKeySetBmcKeySetsClientDiagnostics;
        private readonly BmcKeySetsRestOperations _networkCloudBmcKeySetBmcKeySetsRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudBmcKeySetCollection"/> class for mocking. </summary>
        protected NetworkCloudBmcKeySetCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkCloudBmcKeySetCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkCloudBmcKeySetCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkCloudBmcKeySetBmcKeySetsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", NetworkCloudBmcKeySetResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkCloudBmcKeySetResource.ResourceType, out string networkCloudBmcKeySetBmcKeySetsApiVersion);
            _networkCloudBmcKeySetBmcKeySetsRestClient = new BmcKeySetsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkCloudBmcKeySetBmcKeySetsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != NetworkCloudClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, NetworkCloudClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a new baseboard management controller key set or update the existing one for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets/{bmcKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bmcKeySetName"> The name of the baseboard management controller key set. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bmcKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bmcKeySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<NetworkCloudBmcKeySetResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string bmcKeySetName, NetworkCloudBmcKeySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bmcKeySetName, nameof(bmcKeySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudBmcKeySetBmcKeySetsClientDiagnostics.CreateScope("NetworkCloudBmcKeySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _networkCloudBmcKeySetBmcKeySetsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkCloudArmOperation<NetworkCloudBmcKeySetResource>(new NetworkCloudBmcKeySetOperationSource(Client), _networkCloudBmcKeySetBmcKeySetsClientDiagnostics, Pipeline, _networkCloudBmcKeySetBmcKeySetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create a new baseboard management controller key set or update the existing one for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets/{bmcKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="bmcKeySetName"> The name of the baseboard management controller key set. </param>
        /// <param name="data"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bmcKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bmcKeySetName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<NetworkCloudBmcKeySetResource> CreateOrUpdate(WaitUntil waitUntil, string bmcKeySetName, NetworkCloudBmcKeySetData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bmcKeySetName, nameof(bmcKeySetName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _networkCloudBmcKeySetBmcKeySetsClientDiagnostics.CreateScope("NetworkCloudBmcKeySetCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _networkCloudBmcKeySetBmcKeySetsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, data, cancellationToken);
                var operation = new NetworkCloudArmOperation<NetworkCloudBmcKeySetResource>(new NetworkCloudBmcKeySetOperationSource(Client), _networkCloudBmcKeySetBmcKeySetsClientDiagnostics, Pipeline, _networkCloudBmcKeySetBmcKeySetsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Get baseboard management controller key set of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets/{bmcKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bmcKeySetName"> The name of the baseboard management controller key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bmcKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bmcKeySetName"/> is null. </exception>
        public virtual async Task<Response<NetworkCloudBmcKeySetResource>> GetAsync(string bmcKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bmcKeySetName, nameof(bmcKeySetName));

            using var scope = _networkCloudBmcKeySetBmcKeySetsClientDiagnostics.CreateScope("NetworkCloudBmcKeySetCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkCloudBmcKeySetBmcKeySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBmcKeySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get baseboard management controller key set of the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets/{bmcKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bmcKeySetName"> The name of the baseboard management controller key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bmcKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bmcKeySetName"/> is null. </exception>
        public virtual Response<NetworkCloudBmcKeySetResource> Get(string bmcKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bmcKeySetName, nameof(bmcKeySetName));

            using var scope = _networkCloudBmcKeySetBmcKeySetsClientDiagnostics.CreateScope("NetworkCloudBmcKeySetCollection.Get");
            scope.Start();
            try
            {
                var response = _networkCloudBmcKeySetBmcKeySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkCloudBmcKeySetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of baseboard management controller key sets for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkCloudBmcKeySetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkCloudBmcKeySetResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudBmcKeySetBmcKeySetsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudBmcKeySetBmcKeySetsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkCloudBmcKeySetResource(Client, NetworkCloudBmcKeySetData.DeserializeNetworkCloudBmcKeySetData(e)), _networkCloudBmcKeySetBmcKeySetsClientDiagnostics, Pipeline, "NetworkCloudBmcKeySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of baseboard management controller key sets for the provided cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkCloudBmcKeySetResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkCloudBmcKeySetResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkCloudBmcKeySetBmcKeySetsRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkCloudBmcKeySetBmcKeySetsRestClient.CreateListByClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new NetworkCloudBmcKeySetResource(Client, NetworkCloudBmcKeySetData.DeserializeNetworkCloudBmcKeySetData(e)), _networkCloudBmcKeySetBmcKeySetsClientDiagnostics, Pipeline, "NetworkCloudBmcKeySetCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets/{bmcKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bmcKeySetName"> The name of the baseboard management controller key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bmcKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bmcKeySetName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string bmcKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bmcKeySetName, nameof(bmcKeySetName));

            using var scope = _networkCloudBmcKeySetBmcKeySetsClientDiagnostics.CreateScope("NetworkCloudBmcKeySetCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkCloudBmcKeySetBmcKeySetsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetworkCloud/clusters/{clusterName}/bmcKeySets/{bmcKeySetName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BmcKeySets_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="bmcKeySetName"> The name of the baseboard management controller key set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="bmcKeySetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="bmcKeySetName"/> is null. </exception>
        public virtual Response<bool> Exists(string bmcKeySetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(bmcKeySetName, nameof(bmcKeySetName));

            using var scope = _networkCloudBmcKeySetBmcKeySetsClientDiagnostics.CreateScope("NetworkCloudBmcKeySetCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkCloudBmcKeySetBmcKeySetsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, bmcKeySetName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkCloudBmcKeySetResource> IEnumerable<NetworkCloudBmcKeySetResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkCloudBmcKeySetResource> IAsyncEnumerable<NetworkCloudBmcKeySetResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
