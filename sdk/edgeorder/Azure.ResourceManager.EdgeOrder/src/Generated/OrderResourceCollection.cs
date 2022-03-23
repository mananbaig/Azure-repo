// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.EdgeOrder
{
    /// <summary>
    /// A class representing a collection of <see cref="OrderResource" /> and their operations.
    /// Each <see cref="OrderResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="OrderResourceCollection" /> instance call the GetOrderResources method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class OrderResourceCollection : ArmCollection
    {
        private readonly ClientDiagnostics _orderResourceClientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _orderResourceRestClient;

        /// <summary> Initializes a new instance of the <see cref="OrderResourceCollection"/> class for mocking. </summary>
        protected OrderResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="OrderResourceCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal OrderResourceCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _orderResourceClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", OrderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(OrderResource.ResourceType, out string orderResourceApiVersion);
            _orderResourceRestClient = new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, orderResourceApiVersion);
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
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual async Task<Response<OrderResource>> GetAsync(string location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _orderResourceClientDiagnostics.CreateScope("OrderResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _orderResourceRestClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual Response<OrderResource> Get(string location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _orderResourceClientDiagnostics.CreateScope("OrderResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _orderResourceRestClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new OrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _orderResourceClientDiagnostics.CreateScope("OrderResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(location, orderName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual Response<bool> Exists(string location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _orderResourceClientDiagnostics.CreateScope("OrderResourceCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(location, orderName, cancellationToken: cancellationToken);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual async Task<Response<OrderResource>> GetIfExistsAsync(string location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _orderResourceClientDiagnostics.CreateScope("OrderResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _orderResourceRestClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<OrderResource>(null, response.GetRawResponse());
                return Response.FromValue(new OrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="orderName"> The name of the order. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="location"/> or <paramref name="orderName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="location"/> or <paramref name="orderName"/> is null. </exception>
        public virtual Response<OrderResource> GetIfExists(string location, string orderName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(location, nameof(location));
            Argument.AssertNotNullOrEmpty(orderName, nameof(orderName));

            using var scope = _orderResourceClientDiagnostics.CreateScope("OrderResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _orderResourceRestClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, location, orderName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<OrderResource>(null, response.GetRawResponse());
                return Response.FromValue(new OrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
