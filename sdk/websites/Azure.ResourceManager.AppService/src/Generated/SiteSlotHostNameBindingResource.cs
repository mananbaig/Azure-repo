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
    /// A Class representing a SiteSlotHostNameBinding along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotHostNameBindingResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotHostNameBindingResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteSlotResource" /> using the GetSiteSlotHostNameBinding method.
    /// </summary>
    public partial class SiteSlotHostNameBindingResource : HostNameBindingResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotHostNameBindingResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot, string hostName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotHostNameBindingWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotHostNameBindingWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHostNameBindingResource"/> class for mocking. </summary>
        protected SiteSlotHostNameBindingResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotHostNameBindingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotHostNameBindingResource(ArmClient client, HostNameBindingData data) : base(client, data)
        {
            _siteSlotHostNameBindingWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotHostNameBindingWebAppsApiVersion);
            _siteSlotHostNameBindingWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotHostNameBindingWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotHostNameBindingResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotHostNameBindingResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotHostNameBindingWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotHostNameBindingWebAppsApiVersion);
            _siteSlotHostNameBindingWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotHostNameBindingWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/hostNameBindings";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get the named hostname binding for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_GetHostNameBindingSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<HostNameBindingResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteSlotHostNameBindingResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotHostNameBindingWebAppsRestClient.GetHostNameBindingSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get the named hostname binding for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_GetHostNameBindingSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<SiteSlotHostNameBindingResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteSlotHostNameBindingResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get the named hostname binding for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_GetHostNameBindingSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<HostNameBindingResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteSlotHostNameBindingResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotHostNameBindingWebAppsRestClient.GetHostNameBindingSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get the named hostname binding for an app (or deployment slot, if specified).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_GetHostNameBindingSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<SiteSlotHostNameBindingResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((SiteSlotHostNameBindingResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Description for Deletes a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_DeleteHostNameBindingSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteSlotHostNameBindingResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotHostNameBindingWebAppsRestClient.DeleteHostNameBindingSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Description for Deletes a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_DeleteHostNameBindingSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteSlotHostNameBindingResource.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotHostNameBindingWebAppsRestClient.DeleteHostNameBindingSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppServiceArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_CreateOrUpdateHostNameBindingSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<HostNameBindingResource>> UpdateCoreAsync(WaitUntil waitUntil, HostNameBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteSlotHostNameBindingResource.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotHostNameBindingWebAppsRestClient.CreateOrUpdateHostNameBindingSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<HostNameBindingResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_CreateOrUpdateHostNameBindingSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<SiteSlotHostNameBindingResource>> UpdateAsync(WaitUntil waitUntil, HostNameBindingData data, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(waitUntil, data, cancellationToken).ConfigureAwait(false);
            return new AppServiceArmOperation<SiteSlotHostNameBindingResource>(Response.FromValue((SiteSlotHostNameBindingResource)result.Value, result.GetRawResponse()));
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_CreateOrUpdateHostNameBindingSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<HostNameBindingResource> UpdateCore(WaitUntil waitUntil, HostNameBindingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotHostNameBindingWebAppsClientDiagnostics.CreateScope("SiteSlotHostNameBindingResource.Update");
            scope.Start();
            try
            {
                var response = _siteSlotHostNameBindingWebAppsRestClient.CreateOrUpdateHostNameBindingSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<HostNameBindingResource>(Response.FromValue(GetResource(Client, response), response.GetRawResponse()));
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
        /// Description for Creates a hostname binding for an app.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/hostNameBindings/{hostName}
        /// Operation Id: WebApps_CreateOrUpdateHostNameBindingSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Binding details. This is the JSON representation of a HostNameBinding object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<SiteSlotHostNameBindingResource> Update(WaitUntil waitUntil, HostNameBindingData data, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(waitUntil, data, cancellationToken);
            return new AppServiceArmOperation<SiteSlotHostNameBindingResource>(Response.FromValue((SiteSlotHostNameBindingResource)result.Value, result.GetRawResponse()));
        }
    }
}
