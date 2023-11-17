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
using Azure.ResourceManager.DesktopVirtualization.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="HostPoolPrivateEndpointConnectionResource" /> and their operations.
    /// Each <see cref="HostPoolPrivateEndpointConnectionResource" /> in the collection will belong to the same instance of <see cref="HostPoolResource" />.
    /// To get a <see cref="HostPoolPrivateEndpointConnectionCollection" /> instance call the GetHostPoolPrivateEndpointConnections method from an instance of <see cref="HostPoolResource" />.
    /// </summary>
    public partial class HostPoolPrivateEndpointConnectionCollection : ArmCollection, IEnumerable<HostPoolPrivateEndpointConnectionResource>, IAsyncEnumerable<HostPoolPrivateEndpointConnectionResource>
    {
        private readonly ClientDiagnostics _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics;
        private readonly PrivateEndpointConnectionsRestOperations _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="HostPoolPrivateEndpointConnectionCollection"/> class for mocking. </summary>
        protected HostPoolPrivateEndpointConnectionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HostPoolPrivateEndpointConnectionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HostPoolPrivateEndpointConnectionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", HostPoolPrivateEndpointConnectionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HostPoolPrivateEndpointConnectionResource.ResourceType, out string hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
            _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient = new PrivateEndpointConnectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HostPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HostPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Approve or reject a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_UpdateByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="connection"> Object containing the updated connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="connection"/> is null. </exception>
        public virtual async Task<ArmOperation<HostPoolPrivateEndpointConnectionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string privateEndpointConnectionName, DesktopVirtualizationPrivateEndpointConnection connection, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(connection, nameof(connection));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateByHostPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, connection, cancellationToken).ConfigureAwait(false);
                var operation = new DesktopVirtualizationArmOperation<HostPoolPrivateEndpointConnectionResource>(Response.FromValue(new HostPoolPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Approve or reject a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_UpdateByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="connection"> Object containing the updated connection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> or <paramref name="connection"/> is null. </exception>
        public virtual ArmOperation<HostPoolPrivateEndpointConnectionResource> CreateOrUpdate(WaitUntil waitUntil, string privateEndpointConnectionName, DesktopVirtualizationPrivateEndpointConnection connection, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));
            Argument.AssertNotNull(connection, nameof(connection));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.UpdateByHostPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, connection, cancellationToken);
                var operation = new DesktopVirtualizationArmOperation<HostPoolPrivateEndpointConnectionResource>(Response.FromValue(new HostPoolPrivateEndpointConnectionResource(Client, response), response.GetRawResponse()));
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
        /// Get a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<HostPoolPrivateEndpointConnectionResource>> GetAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = await _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByHostPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostPoolPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a private endpoint connection.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<HostPoolPrivateEndpointConnectionResource> Get(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.Get");
            scope.Start();
            try
            {
                var response = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByHostPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HostPoolPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List private endpoint connections associated with hostpool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HostPoolPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HostPoolPrivateEndpointConnectionResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByHostPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByHostPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HostPoolPrivateEndpointConnectionResource(Client, DesktopVirtualizationPrivateEndpointConnectionDataData.DeserializeDesktopVirtualizationPrivateEndpointConnectionDataData(e)), _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "HostPoolPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List private endpoint connections associated with hostpool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_ListByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HostPoolPrivateEndpointConnectionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HostPoolPrivateEndpointConnectionResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByHostPoolRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.CreateListByHostPoolNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HostPoolPrivateEndpointConnectionResource(Client, DesktopVirtualizationPrivateEndpointConnectionDataData.DeserializeDesktopVirtualizationPrivateEndpointConnectionDataData(e)), _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics, Pipeline, "HostPoolPrivateEndpointConnectionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByHostPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual Response<bool> Exists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.Exists");
            scope.Start();
            try
            {
                var response = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByHostPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual async Task<NullableResponse<HostPoolPrivateEndpointConnectionResource>> GetIfExistsAsync(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByHostPoolAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<HostPoolPrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new HostPoolPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/privateEndpointConnections/{privateEndpointConnectionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PrivateEndpointConnections_GetByHostPool</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="privateEndpointConnectionName"> The name of the private endpoint connection associated with the Azure resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="privateEndpointConnectionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="privateEndpointConnectionName"/> is null. </exception>
        public virtual NullableResponse<HostPoolPrivateEndpointConnectionResource> GetIfExists(string privateEndpointConnectionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(privateEndpointConnectionName, nameof(privateEndpointConnectionName));

            using var scope = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsClientDiagnostics.CreateScope("HostPoolPrivateEndpointConnectionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _hostPoolPrivateEndpointConnectionPrivateEndpointConnectionsRestClient.GetByHostPool(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, privateEndpointConnectionName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<HostPoolPrivateEndpointConnectionResource>(response.GetRawResponse());
                return Response.FromValue(new HostPoolPrivateEndpointConnectionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HostPoolPrivateEndpointConnectionResource> IEnumerable<HostPoolPrivateEndpointConnectionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HostPoolPrivateEndpointConnectionResource> IAsyncEnumerable<HostPoolPrivateEndpointConnectionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
