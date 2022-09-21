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
    /// A Class representing a WebSiteSlotWebJob along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="WebSiteSlotWebJobResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetWebSiteSlotWebJobResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource" /> using the GetWebSiteSlotWebJob method.
    /// </summary>
    public partial class WebSiteSlotWebJobResource : WebJobResource
    {
        /// <summary> Generate the resource identifier of a <see cref="WebSiteSlotWebJobResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string webJobName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _webSiteSlotWebJobWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteSlotWebJobWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotWebJobResource"/> class for mocking. </summary>
        protected WebSiteSlotWebJobResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "WebSiteSlotWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal WebSiteSlotWebJobResource(ArmClient client, WebJobData data) : base(client, data)
        {
            _webSiteSlotWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotWebJobWebAppsApiVersion);
            _webSiteSlotWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteSlotWebJobResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal WebSiteSlotWebJobResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteSlotWebJobWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string webSiteSlotWebJobWebAppsApiVersion);
            _webSiteSlotWebJobWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteSlotWebJobWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/webjobs";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get webjob information for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}
        /// Operation Id: WebApps_GetWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<WebJobResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobResource.GetCore");
            scope.Start();
            try
            {
                var response = await _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get webjob information for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}
        /// Operation Id: WebApps_GetWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<WebSiteSlotWebJobResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((WebSiteSlotWebJobResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get webjob information for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}
        /// Operation Id: WebApps_GetWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<WebJobResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _webSiteSlotWebJobWebAppsClientDiagnostics.CreateScope("WebSiteSlotWebJobResource.GetCore");
            scope.Start();
            try
            {
                var response = _webSiteSlotWebJobWebAppsRestClient.GetWebJobSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get webjob information for an app, or a deployment slot.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/webjobs/{webJobName}
        /// Operation Id: WebApps_GetWebJobSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<WebSiteSlotWebJobResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((WebSiteSlotWebJobResource)value.Value, value.GetRawResponse());
        }
    }
}
