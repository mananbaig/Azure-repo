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

namespace Azure.ResourceManager.HardwareSecurityModules
{
    /// <summary>
    /// A class representing a collection of <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="CloudHsmClusterResource" />.
    /// To get a <see cref="HardwareSecurityModulesPrivateEndpointConnectionCollection" /> instance call the GetHardwareSecurityModulesPrivateEndpointConnections method from an instance of <see cref="CloudHsmClusterResource" />.
    /// </summary>
    public partial class HardwareSecurityModulesPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<HardwareSecurityModulesPrivateEndpointConnectionResource>, IAsyncEnumerable<HardwareSecurityModulesPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics;
        private readonly CloudHsmClusterPrivateEndpointConnectionsRestOperations _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient;
        private readonly ClientDiagnostics _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HardwareSecurityModulesPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected HardwareSecurityModulesPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HardwareSecurityModulesPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HardwareSecurityModulesPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HardwareSecurityModules", HardwareSecurityModulesPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HardwareSecurityModulesPrivateEndpointConnectionResource.ResourceType, out string hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsApiVersion);
            _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient = new CloudHsmClusterPrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsApiVersion);
            _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.HardwareSecurityModules", HardwareSecurityModulesPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HardwareSecurityModulesPrivateEndpointConnectionResource.ResourceType, out string hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CloudHsmClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CloudHsmClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="data"> Parameters of the PrivateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string peConnectionName, HardwareSecurityModulesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, data, cancellationToken).ConfigureAwait(false);
                var operation = new HardwareSecurityModulesArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource>(Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="data"> Parameters of the PrivateEndpointConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string peConnectionName, HardwareSecurityModulesPrivateEndpointConnectionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, data, cancellationToken);
                var operation = new HardwareSecurityModulesArmOperation<HardwareSecurityModulesPrivateEndpointConnectionResource>(Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Gets the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<Response<HardwareSecurityModulesPrivateEndpointConnectionResource>> GetAsync(string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the private endpoint connection for the Cloud Hsm Cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual Response<HardwareSecurityModulesPrivateEndpointConnectionResource> Get(string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the Cloud HSM Cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByCloudHsmCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HardwareSecurityModulesPrivateEndpointConnectionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByCloudHsmClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByCloudHsmClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, HardwareSecurityModulesPrivateEndpointConnectionData.DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(e)), _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "HardwareSecurityModulesPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// The List operation gets information about the private endpoint connections associated with the Cloud HSM Cluster
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByCloudHsmCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HardwareSecurityModulesPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HardwareSecurityModulesPrivateEndpointConnectionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByCloudHsmClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByCloudHsmClusterNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HardwareSecurityModulesPrivateEndpointConnectionResource(Client, HardwareSecurityModulesPrivateEndpointConnectionData.DeserializeHardwareSecurityModulesPrivateEndpointConnectionData(e)), _hardwareSecurityModulesPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "HardwareSecurityModulesPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HardwareSecurityModules/cloudHsmClusters/{cloudHsmClusterName}/privateEndpointConnections/{peConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CloudHsmClusterPrivateEndpointConnections_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="peConnectionName"> Name of the private endpoint connection associated with the Cloud HSM Cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="peConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="peConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string peConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(peConnectionName, nameof(peConnectionName));

            using var scope = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsClientDiagnostics.CreateScope("HardwareSecurityModulesPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _hardwareSecurityModulesPrivateEndpointConnectionCloudHsmClusterPrivateEndpointConnectionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peConnectionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HardwareSecurityModulesPrivateEndpointConnectionResource> IEnumerable<HardwareSecurityModulesPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HardwareSecurityModulesPrivateEndpointConnectionResource> IAsyncEnumerable<HardwareSecurityModulesPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
