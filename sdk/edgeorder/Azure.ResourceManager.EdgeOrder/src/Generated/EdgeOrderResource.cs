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
    /// A Class representing an EdgeOrder along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EdgeOrderResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEdgeOrderResource method.
    /// Otherwise you can get one from its parent resource <see cref="ResourceGroupResource" /> using the GetEdgeOrder method.
    /// </summary>
    public partial class EdgeOrderResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EdgeOrderResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, AzureLocation location, string orderName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _edgeOrderClientDiagnostics;
        private readonly EdgeOrderManagementRestOperations _edgeOrderRestClient;
        private readonly EdgeOrderData _data;

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderResource"/> class for mocking. </summary>
        protected EdgeOrderResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EdgeOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EdgeOrderResource(ArmClient client, EdgeOrderData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EdgeOrderResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EdgeOrderResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _edgeOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EdgeOrder", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string edgeOrderApiVersion);
            _edgeOrderRestClient = new EdgeOrderManagementRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, edgeOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.EdgeOrder/locations/orders";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EdgeOrderData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets an order.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EdgeOrder/locations/{location}/orders/{orderName}
        /// Operation Id: GetOrderByName
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EdgeOrderResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderResource.Get");
            scope.Start();
            try
            {
                var response = await _edgeOrderRestClient.GetOrderByNameAsync(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EdgeOrderResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _edgeOrderClientDiagnostics.CreateScope("EdgeOrderResource.Get");
            scope.Start();
            try
            {
                var response = _edgeOrderRestClient.GetOrderByName(Id.SubscriptionId, Id.ResourceGroupName, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EdgeOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
