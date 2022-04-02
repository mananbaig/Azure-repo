// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="LocalNetworkGatewayResource" /> and their operations.
    /// Each <see cref="LocalNetworkGatewayResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="LocalNetworkGatewayCollection" /> instance call the GetLocalNetworkGateways method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class LocalNetworkGatewayCollection : ArmCollection, IEnumerable<LocalNetworkGatewayResource>, IAsyncEnumerable<LocalNetworkGatewayResource>
    {
        private readonly ClientDiagnostics _localNetworkGatewayClientDiagnostics;
        private readonly LocalNetworkGatewaysRestOperations _localNetworkGatewayRestClient;

        /// <summary> Initializes a new instance of the <see cref="LocalNetworkGatewayCollection"/> class for mocking. </summary>
        protected LocalNetworkGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="LocalNetworkGatewayCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal LocalNetworkGatewayCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _localNetworkGatewayClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", LocalNetworkGatewayResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(LocalNetworkGatewayResource.ResourceType, out string localNetworkGatewayApiVersion);
            _localNetworkGatewayRestClient = new LocalNetworkGatewaysRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, localNetworkGatewayApiVersion);
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
        /// Creates or updates a local network gateway in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways/{localNetworkGatewayName}
        /// Operation Id: LocalNetworkGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="data"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<LocalNetworkGatewayResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string localNetworkGatewayName, LocalNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localNetworkGatewayName, nameof(localNetworkGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _localNetworkGatewayRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<LocalNetworkGatewayResource>(new LocalNetworkGatewayOperationSource(Client), _localNetworkGatewayClientDiagnostics, Pipeline, _localNetworkGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a local network gateway in the specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways/{localNetworkGatewayName}
        /// Operation Id: LocalNetworkGateways_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="data"> Parameters supplied to the create or update local network gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<LocalNetworkGatewayResource> CreateOrUpdate(WaitUntil waitUntil, string localNetworkGatewayName, LocalNetworkGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localNetworkGatewayName, nameof(localNetworkGatewayName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _localNetworkGatewayRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, data, cancellationToken);
                var operation = new NetworkArmOperation<LocalNetworkGatewayResource>(new LocalNetworkGatewayOperationSource(Client), _localNetworkGatewayClientDiagnostics, Pipeline, _localNetworkGatewayRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified local network gateway in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways/{localNetworkGatewayName}
        /// Operation Id: LocalNetworkGateways_Get
        /// </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> is null. </exception>
        public virtual async Task<Response<LocalNetworkGatewayResource>> GetAsync(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localNetworkGatewayName, nameof(localNetworkGatewayName));

            using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _localNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified local network gateway in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways/{localNetworkGatewayName}
        /// Operation Id: LocalNetworkGateways_Get
        /// </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> is null. </exception>
        public virtual Response<LocalNetworkGatewayResource> Get(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localNetworkGatewayName, nameof(localNetworkGatewayName));

            using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _localNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new LocalNetworkGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all the local network gateways in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways
        /// Operation Id: LocalNetworkGateways_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LocalNetworkGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LocalNetworkGatewayResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<LocalNetworkGatewayResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _localNetworkGatewayRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<LocalNetworkGatewayResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _localNetworkGatewayRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all the local network gateways in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways
        /// Operation Id: LocalNetworkGateways_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LocalNetworkGatewayResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LocalNetworkGatewayResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<LocalNetworkGatewayResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _localNetworkGatewayRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<LocalNetworkGatewayResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _localNetworkGatewayRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new LocalNetworkGatewayResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways/{localNetworkGatewayName}
        /// Operation Id: LocalNetworkGateways_Get
        /// </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localNetworkGatewayName, nameof(localNetworkGatewayName));

            using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await _localNetworkGatewayRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/localNetworkGateways/{localNetworkGatewayName}
        /// Operation Id: LocalNetworkGateways_Get
        /// </summary>
        /// <param name="localNetworkGatewayName"> The name of the local network gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="localNetworkGatewayName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="localNetworkGatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string localNetworkGatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(localNetworkGatewayName, nameof(localNetworkGatewayName));

            using var scope = _localNetworkGatewayClientDiagnostics.CreateScope("LocalNetworkGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = _localNetworkGatewayRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, localNetworkGatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<LocalNetworkGatewayResource> IEnumerable<LocalNetworkGatewayResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<LocalNetworkGatewayResource> IAsyncEnumerable<LocalNetworkGatewayResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
