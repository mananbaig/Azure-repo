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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="VirtualNetworkGatewayResource" /> and their operations.
    /// Each <see cref="VirtualNetworkGatewayResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="VirtualNetworkGatewayCollection" /> instance call the GetVirtualNetworkGateways method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class VirtualNetworkGatewayCollection : ArmCollection, IEnumerable<VirtualNetworkGatewayResource>, IAsyncEnumerable<VirtualNetworkGatewayResource>
    {
        private readonly ClientDiagnostics _virtualNetworkGatewayClientDiagnostics;
        private readonly VirtualNetworkGatewaysRestOperations _virtualNetworkGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayCollection"/> class for mocking. </summary>
        protected VirtualNetworkGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualNetworkGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal VirtualNetworkGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _virtualNetworkGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", VirtualNetworkGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(VirtualNetworkGatewayResource.ResourceType, out string virtualNetworkGatewayApiVersion);
            _virtualNetworkGatewayRestClient = new VirtualNetworkGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, virtualNetworkGatewayApiVersion);
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
        /// Creates or updates a virtual network gateway in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="data"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<VirtualNetworkGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string virtualNetworkGatewayName, VirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<VirtualNetworkGatewayResource>(new VirtualNetworkGatewayOperationSource(Client), _virtualNetworkGatewayClientDiagnostics, Pipeline, _virtualNetworkGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a virtual network gateway in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="data"> Parameters supplied to create or update virtual network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<VirtualNetworkGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string virtualNetworkGatewayName, VirtualNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, data, cancellationToken);
                var operation = new NetworkArmOperation<VirtualNetworkGatewayResource>(new VirtualNetworkGatewayOperationSource(Client), _virtualNetworkGatewayClientDiagnostics, Pipeline, _virtualNetworkGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified virtual network gateway by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual async Task<Response<VirtualNetworkGatewayResource>> GetAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified virtual network gateway by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual Response<VirtualNetworkGatewayResource> Get(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all virtual network gateways by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualNetworkGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VirtualNetworkGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkGatewayRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkGatewayRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualNetworkGatewayResource(Client, VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(e)), _virtualNetworkGatewayClientDiagnostics, Pipeline, "VirtualNetworkGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all virtual network gateways by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualNetworkGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VirtualNetworkGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _virtualNetworkGatewayRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _virtualNetworkGatewayRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new VirtualNetworkGatewayResource(Client, VirtualNetworkGatewayData.DeserializeVirtualNetworkGatewayData(e)), _virtualNetworkGatewayClientDiagnostics, Pipeline, "VirtualNetworkGatewayCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual async Task<NullableResponse<VirtualNetworkGatewayResource>> GetIfExistsAsync(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _virtualNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkGatewayResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworkGateways/{virtualNetworkGatewayName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkGateways_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="virtualNetworkGatewayName"> The name of the virtual network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetworkGatewayName"/> is null. </exception>
        public virtual NullableResponse<VirtualNetworkGatewayResource> GetIfExists(string virtualNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(virtualNetworkGatewayName, nameof(virtualNetworkGatewayName));

            using var scope = _virtualNetworkGatewayClientDiagnostics.CreateScope("VirtualNetworkGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _virtualNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, virtualNetworkGatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<VirtualNetworkGatewayResource>(response.GetRawResponse());
                return Response.FromValue(new VirtualNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<VirtualNetworkGatewayResource> IEnumerable<VirtualNetworkGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<VirtualNetworkGatewayResource> IAsyncEnumerable<VirtualNetworkGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
