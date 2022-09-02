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

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary>
    /// A class representing a collection of <see cref="ConnectedRegistryResource" /> and their operations.
    /// Each <see cref="ConnectedRegistryResource" /> in the collection will belong to the same instance of <see cref="ContainerRegistryResource" />.
    /// To get a <see cref="ConnectedRegistryCollection" /> instance call the GetConnectedRegistries method from an instance of <see cref="ContainerRegistryResource" />.
    /// </summary>
    public partial class ConnectedRegistryCollection : ArmCollection, IEnumerable<ConnectedRegistryResource>, IAsyncEnumerable<ConnectedRegistryResource>
    {
        private readonly ClientDiagnostics _connectedRegistryClientDiagnostics;
        private readonly ConnectedRegistriesRestOperations _connectedRegistryRestClient;

        /// <summary> Initializes a new instance of the <see cref="ConnectedRegistryCollection"/> class for mocking. </summary>
        protected ConnectedRegistryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ConnectedRegistryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ConnectedRegistryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _connectedRegistryClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ConnectedRegistryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ConnectedRegistryResource.ResourceType, out string connectedRegistryApiVersion);
            _connectedRegistryRestClient = new ConnectedRegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, connectedRegistryApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerRegistryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerRegistryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a connected registry for a container registry with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries/{connectedRegistryName}
        /// Operation Id: ConnectedRegistries_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectedRegistryName"> The name of the connected registry. </param>
        /// <param name="data"> The parameters for creating a connectedRegistry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedRegistryName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ConnectedRegistryResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string connectedRegistryName, ConnectedRegistryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedRegistryName, nameof(connectedRegistryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _connectedRegistryRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ContainerRegistryArmOperation<ConnectedRegistryResource>(new ConnectedRegistryOperationSource(Client), _connectedRegistryClientDiagnostics, Pipeline, _connectedRegistryRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates a connected registry for a container registry with the specified parameters.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries/{connectedRegistryName}
        /// Operation Id: ConnectedRegistries_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="connectedRegistryName"> The name of the connected registry. </param>
        /// <param name="data"> The parameters for creating a connectedRegistry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedRegistryName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ConnectedRegistryResource> CreateOrUpdate(WaitUntil waitUntil, string connectedRegistryName, ConnectedRegistryData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedRegistryName, nameof(connectedRegistryName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _connectedRegistryRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, data, cancellationToken);
                var operation = new ContainerRegistryArmOperation<ConnectedRegistryResource>(new ConnectedRegistryOperationSource(Client), _connectedRegistryClientDiagnostics, Pipeline, _connectedRegistryRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets the properties of the connected registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries/{connectedRegistryName}
        /// Operation Id: ConnectedRegistries_Get
        /// </summary>
        /// <param name="connectedRegistryName"> The name of the connected registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedRegistryName"/> is null. </exception>
        public virtual async Task<Response<ConnectedRegistryResource>> GetAsync(string connectedRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedRegistryName, nameof(connectedRegistryName));

            using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.Get");
            scope.Start();
            try
            {
                var response = await _connectedRegistryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectedRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the properties of the connected registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries/{connectedRegistryName}
        /// Operation Id: ConnectedRegistries_Get
        /// </summary>
        /// <param name="connectedRegistryName"> The name of the connected registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedRegistryName"/> is null. </exception>
        public virtual Response<ConnectedRegistryResource> Get(string connectedRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedRegistryName, nameof(connectedRegistryName));

            using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.Get");
            scope.Start();
            try
            {
                var response = _connectedRegistryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ConnectedRegistryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all connected registries for the specified container registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries
        /// Operation Id: ConnectedRegistries_List
        /// </summary>
        /// <param name="filter"> An OData filter expression that describes a subset of connectedRegistries to return. The parameters that can be filtered are parent.id (the resource id of the connectedRegistry parent), mode, and connectionState. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ConnectedRegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ConnectedRegistryResource> GetAllAsync(string filter = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<ConnectedRegistryResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _connectedRegistryRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConnectedRegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ConnectedRegistryResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _connectedRegistryRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ConnectedRegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Lists all connected registries for the specified container registry.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries
        /// Operation Id: ConnectedRegistries_List
        /// </summary>
        /// <param name="filter"> An OData filter expression that describes a subset of connectedRegistries to return. The parameters that can be filtered are parent.id (the resource id of the connectedRegistry parent), mode, and connectionState. The supported operator is eq. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ConnectedRegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ConnectedRegistryResource> GetAll(string filter = null, CancellationToken cancellationToken = default)
        {
            Page<ConnectedRegistryResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _connectedRegistryRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConnectedRegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ConnectedRegistryResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _connectedRegistryRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ConnectedRegistryResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries/{connectedRegistryName}
        /// Operation Id: ConnectedRegistries_Get
        /// </summary>
        /// <param name="connectedRegistryName"> The name of the connected registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedRegistryName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string connectedRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedRegistryName, nameof(connectedRegistryName));

            using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _connectedRegistryRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerRegistry/registries/{registryName}/connectedRegistries/{connectedRegistryName}
        /// Operation Id: ConnectedRegistries_Get
        /// </summary>
        /// <param name="connectedRegistryName"> The name of the connected registry. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="connectedRegistryName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="connectedRegistryName"/> is null. </exception>
        public virtual Response<bool> Exists(string connectedRegistryName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(connectedRegistryName, nameof(connectedRegistryName));

            using var scope = _connectedRegistryClientDiagnostics.CreateScope("ConnectedRegistryCollection.Exists");
            scope.Start();
            try
            {
                var response = _connectedRegistryRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, connectedRegistryName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ConnectedRegistryResource> IEnumerable<ConnectedRegistryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ConnectedRegistryResource> IAsyncEnumerable<ConnectedRegistryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
