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
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of IPGroup and their operations over its parent. </summary>
    public partial class IPGroupCollection : ArmCollection, IEnumerable<IPGroup>, IAsyncEnumerable<IPGroup>
    {
        private readonly ClientDiagnostics _ipGroupIpGroupsClientDiagnostics;
        private readonly IpGroupsRestOperations _ipGroupIpGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="IPGroupCollection"/> class for mocking. </summary>
        protected IPGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IPGroupCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IPGroupCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _ipGroupIpGroupsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", IPGroup.ResourceType.Namespace, DiagnosticOptions);
            TryGetApiVersion(IPGroup.ResourceType, out string ipGroupIpGroupsApiVersion);
            _ipGroupIpGroupsRestClient = new IpGroupsRestOperations(_ipGroupIpGroupsClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, ipGroupIpGroupsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates an ipGroups in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="parameters"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ArmOperation<IPGroup>> CreateOrUpdateAsync(bool waitForCompletion, string ipGroupsName, IPGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _ipGroupIpGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<IPGroup>(new IPGroupOperationSource(Client), _ipGroupIpGroupsClientDiagnostics, Pipeline, _ipGroupIpGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
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
        /// Creates or updates an ipGroups in a specified resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_CreateOrUpdate
        /// </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="parameters"> Parameters supplied to the create or update IpGroups operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ArmOperation<IPGroup> CreateOrUpdate(bool waitForCompletion, string ipGroupsName, IPGroupData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));
            Argument.AssertNotNull(parameters, nameof(parameters));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _ipGroupIpGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters, cancellationToken);
                var operation = new NetworkArmOperation<IPGroup>(new IPGroupOperationSource(Client), _ipGroupIpGroupsClientDiagnostics, Pipeline, _ipGroupIpGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, parameters).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitForCompletion)
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
        /// Gets the specified ipGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public async virtual Task<Response<IPGroup>> GetAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _ipGroupIpGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _ipGroupIpGroupsClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new IPGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified ipGroups.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<IPGroup> Get(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _ipGroupIpGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken);
                if (response.Value == null)
                    throw _ipGroupIpGroupsClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IPGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all IpGroups in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups
        /// Operation Id: IpGroups_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IPGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IPGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<IPGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipGroupIpGroupsRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<IPGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _ipGroupIpGroupsRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Gets all IpGroups in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups
        /// Operation Id: IpGroups_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IPGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IPGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<IPGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipGroupIpGroupsRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<IPGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _ipGroupIpGroupsRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new IPGroup(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(ipGroupsName, expand: expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<bool> Exists(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(ipGroupsName, expand: expand, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public async virtual Task<Response<IPGroup>> GetIfExistsAsync(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _ipGroupIpGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<IPGroup>(null, response.GetRawResponse());
                return Response.FromValue(new IPGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ipGroups/{ipGroupsName}
        /// Operation Id: IpGroups_Get
        /// </summary>
        /// <param name="ipGroupsName"> The name of the ipGroups. </param>
        /// <param name="expand"> Expands resourceIds (of Firewalls/Network Security Groups etc.) back referenced by the IpGroups resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="ipGroupsName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="ipGroupsName"/> is null. </exception>
        public virtual Response<IPGroup> GetIfExists(string ipGroupsName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(ipGroupsName, nameof(ipGroupsName));

            using var scope = _ipGroupIpGroupsClientDiagnostics.CreateScope("IPGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _ipGroupIpGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, ipGroupsName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<IPGroup>(null, response.GetRawResponse());
                return Response.FromValue(new IPGroup(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IPGroup> IEnumerable<IPGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IPGroup> IAsyncEnumerable<IPGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
