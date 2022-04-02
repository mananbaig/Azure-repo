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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusNamespaceResource" /> and their operations.
    /// Each <see cref="ServiceBusNamespaceResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ServiceBusNamespaceCollection" /> instance call the GetServiceBusNamespaces method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ServiceBusNamespaceCollection : ArmCollection, IEnumerable<ServiceBusNamespaceResource>, IAsyncEnumerable<ServiceBusNamespaceResource>
    {
        private readonly ClientDiagnostics _serviceBusNamespaceNamespacesClientDiagnostics;
        private readonly NamespacesRestOperations _serviceBusNamespaceNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespaceCollection"/> class for mocking. </summary>
        protected ServiceBusNamespaceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusNamespaceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusNamespaceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusNamespaceNamespacesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusNamespaceResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusNamespaceResource.ResourceType, out string serviceBusNamespaceNamespacesApiVersion);
            _serviceBusNamespaceNamespacesRestClient = new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusNamespaceNamespacesApiVersion);
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
        /// Creates or updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="data"> Parameters supplied to create a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusNamespaceResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string namespaceName, ServiceBusNamespaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusNamespaceResource>(new ServiceBusNamespaceOperationSource(Client), _serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, _serviceBusNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a service namespace. Once created, this namespace&apos;s resource manifest is immutable. This operation is idempotent.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> "F:Azure.WaitUntil.Completed" if the method should wait to return until the long-running operation has completed on the service; "F:Azure.WaitUntil.Started" if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="data"> Parameters supplied to create a namespace resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusNamespaceResource> CreateOrUpdate(WaitUntil waitUntil, string namespaceName, ServiceBusNamespaceData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusNamespaceResource>(new ServiceBusNamespaceOperationSource(Client), _serviceBusNamespaceNamespacesClientDiagnostics, Pipeline, _serviceBusNamespaceNamespacesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusNamespaceResource>> GetAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a description for the specified namespace.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<ServiceBusNamespaceResource> Get(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusNamespaceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the available namespaces within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces
        /// Operation Id: Namespaces_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusNamespaceResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceBusNamespaceResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusNamespaceNamespacesRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceBusNamespaceResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusNamespaceNamespacesRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets the available namespaces within a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces
        /// Operation Id: Namespaces_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusNamespaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusNamespaceResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceBusNamespaceResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusNamespaceNamespacesRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceBusNamespaceResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusNamespaceNamespacesRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusNamespaceResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceBusNamespaceNamespacesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}
        /// Operation Id: Namespaces_Get
        /// </summary>
        /// <param name="namespaceName"> The namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="namespaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="namespaceName"/> is null. </exception>
        public virtual Response<bool> Exists(string namespaceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(namespaceName, nameof(namespaceName));

            using var scope = _serviceBusNamespaceNamespacesClientDiagnostics.CreateScope("ServiceBusNamespaceCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceBusNamespaceNamespacesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, namespaceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusNamespaceResource> IEnumerable<ServiceBusNamespaceResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusNamespaceResource> IAsyncEnumerable<ServiceBusNamespaceResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
