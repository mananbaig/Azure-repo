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

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteVirtualNetworkConnectionGateway along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteVirtualNetworkConnectionGatewayResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteVirtualNetworkConnectionGatewayResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteVirtualNetworkConnectionResource" /> using the GetSiteVirtualNetworkConnectionGateway method.
    /// </summary>
    public partial class SiteVirtualNetworkConnectionGatewayResource : VnetGatewayResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteVirtualNetworkConnectionGatewayResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string vnetName, string gatewayName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteVirtualNetworkConnectionGatewayWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionGatewayResource"/> class for mocking. </summary>
        protected SiteVirtualNetworkConnectionGatewayResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteVirtualNetworkConnectionGatewayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteVirtualNetworkConnectionGatewayResource(ArmClient client, VnetGatewayData data) : base(client, data)
        {
            _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteVirtualNetworkConnectionGatewayWebAppsApiVersion);
            _siteVirtualNetworkConnectionGatewayWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteVirtualNetworkConnectionGatewayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteVirtualNetworkConnectionGatewayResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteVirtualNetworkConnectionGatewayResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteVirtualNetworkConnectionGatewayWebAppsApiVersion);
            _siteVirtualNetworkConnectionGatewayWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteVirtualNetworkConnectionGatewayWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/virtualNetworkConnections/gateways";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets an app&apos;s Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_GetVnetConnectionGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<VnetGatewayResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayResource.Get");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an app&apos;s Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_GetVnetConnectionGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SiteVirtualNetworkConnectionGatewayResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteVirtualNetworkConnectionGatewayResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets an app&apos;s Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_GetVnetConnectionGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<VnetGatewayResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayResource.Get");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionGatewayWebAppsRestClient.GetVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(GetResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets an app&apos;s Virtual Network gateway.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_GetVnetConnectionGateway
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SiteVirtualNetworkConnectionGatewayResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SiteVirtualNetworkConnectionGatewayResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_UpdateVnetConnectionGateway
        /// </summary>
        /// <param name="data"> The properties to update this gateway with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SiteVirtualNetworkConnectionGatewayResource>> UpdateAsync(VnetGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayResource.Update");
            scope.Start();
            try
            {
                var response = await _siteVirtualNetworkConnectionGatewayWebAppsRestClient.UpdateVnetConnectionGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Adds a gateway to a connected Virtual Network (PUT) or updates it (PATCH).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// Operation Id: WebApps_UpdateVnetConnectionGateway
        /// </summary>
        /// <param name="data"> The properties to update this gateway with. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SiteVirtualNetworkConnectionGatewayResource> Update(VnetGatewayData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteVirtualNetworkConnectionGatewayWebAppsClientDiagnostics.CreateScope("SiteVirtualNetworkConnectionGatewayResource.Update");
            scope.Start();
            try
            {
                var response = _siteVirtualNetworkConnectionGatewayWebAppsRestClient.UpdateVnetConnectionGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new SiteVirtualNetworkConnectionGatewayResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
