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

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A Class representing an ExpressRoutePortsLocation along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct an <see cref="ExpressRoutePortsLocationResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetExpressRoutePortsLocationResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionResource"/> using the GetExpressRoutePortsLocation method.
    /// </summary>
    public partial class ExpressRoutePortsLocationResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ExpressRoutePortsLocationResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="locationName"> The locationName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string locationName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _expressRoutePortsLocationClientDiagnostics;
        private readonly ExpressRoutePortsLocationsRestOperations _expressRoutePortsLocationRestClient;
        private readonly ExpressRoutePortsLocationData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/ExpressRoutePortsLocations";

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationResource"/> class for mocking. </summary>
        protected ExpressRoutePortsLocationResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ExpressRoutePortsLocationResource(ArmClient client, ExpressRoutePortsLocationData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortsLocationResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ExpressRoutePortsLocationResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRoutePortsLocationClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string expressRoutePortsLocationApiVersion);
            _expressRoutePortsLocationRestClient = new ExpressRoutePortsLocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRoutePortsLocationApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ExpressRoutePortsLocationData Data
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
        /// Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ExpressRoutePortsLocationResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationResource.Get");
            scope.Start();
            try
            {
                var response = await _expressRoutePortsLocationRestClient.GetAsync(Id.SubscriptionId, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves a single ExpressRoutePort peering location, including the list of available bandwidths available at said peering location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Network/ExpressRoutePortsLocations/{locationName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePortsLocations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ExpressRoutePortsLocationResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _expressRoutePortsLocationClientDiagnostics.CreateScope("ExpressRoutePortsLocationResource.Get");
            scope.Start();
            try
            {
                var response = _expressRoutePortsLocationRestClient.Get(Id.SubscriptionId, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortsLocationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
