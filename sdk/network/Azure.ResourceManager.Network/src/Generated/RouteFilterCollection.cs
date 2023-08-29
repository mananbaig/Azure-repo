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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="RouteFilterResource" /> and their operations.
    /// Each <see cref="RouteFilterResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="RouteFilterCollection" /> instance call the GetRouteFilters method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class RouteFilterCollection : ArmCollection, IEnumerable<RouteFilterResource>, IAsyncEnumerable<RouteFilterResource>
    {
        private readonly ClientDiagnostics _routeFilterClientDiagnostics;
        private readonly RouteFiltersRestOperations _routeFilterRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteFilterCollection"/> class for mocking. </summary>
        protected RouteFilterCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RouteFilterCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RouteFilterCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _routeFilterClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", RouteFilterResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RouteFilterResource.ResourceType, out string routeFilterApiVersion);
            _routeFilterRestClient = new RouteFiltersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, routeFilterApiVersion);
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
        /// Creates or updates a route filter in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters/{routeFilterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="data"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<RouteFilterResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string routeFilterName, RouteFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routeFilterRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<RouteFilterResource>(new RouteFilterOperationSource(Client), _routeFilterClientDiagnostics, Pipeline, _routeFilterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates a route filter in a specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters/{routeFilterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="data"> Parameters supplied to the create or update route filter operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<RouteFilterResource> CreateOrUpdate(WaitUntil waitUntil, string routeFilterName, RouteFilterData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routeFilterRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, data, cancellationToken);
                var operation = new NetworkArmOperation<RouteFilterResource>(new RouteFilterOperationSource(Client), _routeFilterClientDiagnostics, Pipeline, _routeFilterRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Gets the specified route filter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters/{routeFilterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual async Task<Response<RouteFilterResource>> GetAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Get");
            scope.Start();
            try
            {
                var response = await _routeFilterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the specified route filter.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters/{routeFilterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<RouteFilterResource> Get(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Get");
            scope.Start();
            try
            {
                var response = _routeFilterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RouteFilterResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all route filters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RouteFilterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RouteFilterResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routeFilterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routeFilterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RouteFilterResource(Client, RouteFilterData.DeserializeRouteFilterData(e)), _routeFilterClientDiagnostics, Pipeline, "RouteFilterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets all route filters in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RouteFilterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RouteFilterResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _routeFilterRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _routeFilterRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RouteFilterResource(Client, RouteFilterData.DeserializeRouteFilterData(e)), _routeFilterClientDiagnostics, Pipeline, "RouteFilterCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters/{routeFilterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = await _routeFilterRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/routeFilters/{routeFilterName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RouteFilters_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeFilterName"> The name of the route filter. </param>
        /// <param name="expand"> Expands referenced express route bgp peering resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeFilterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeFilterName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeFilterName, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeFilterName, nameof(routeFilterName));

            using var scope = _routeFilterClientDiagnostics.CreateScope("RouteFilterCollection.Exists");
            scope.Start();
            try
            {
                var response = _routeFilterRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, routeFilterName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RouteFilterResource> IEnumerable<RouteFilterResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RouteFilterResource> IAsyncEnumerable<RouteFilterResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
