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
    /// A Class representing a SiteSlotNetworkConfig along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteSlotNetworkConfigResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteSlotNetworkConfigResource method.
    /// Otherwise you can get one from its parent resource <see cref="SiteSlotResource" /> using the GetSiteSlotNetworkConfig method.
    /// </summary>
    public partial class SiteSlotNetworkConfigResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteSlotNetworkConfigResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string slot)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteSlotNetworkConfigWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteSlotNetworkConfigWebAppsRestClient;
        private readonly SwiftVirtualNetworkData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotNetworkConfigResource"/> class for mocking. </summary>
        protected SiteSlotNetworkConfigResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteSlotNetworkConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteSlotNetworkConfigResource(ArmClient client, SwiftVirtualNetworkData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotNetworkConfigResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteSlotNetworkConfigResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteSlotNetworkConfigWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteSlotNetworkConfigWebAppsApiVersion);
            _siteSlotNetworkConfigWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteSlotNetworkConfigWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/slots/networkConfig";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SwiftVirtualNetworkData Data
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
        /// Description for Gets a Swift Virtual Network connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_GetSwiftVirtualNetworkConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteSlotNetworkConfigResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.Get");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.GetSwiftVirtualNetworkConnectionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotNetworkConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a Swift Virtual Network connection.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_GetSwiftVirtualNetworkConnectionSlot
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteSlotNetworkConfigResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.Get");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.GetSwiftVirtualNetworkConnectionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotNetworkConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Deletes a Swift Virtual Network connection from an app (or deployment slot).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_DeleteSwiftVirtualNetworkSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.Delete");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.DeleteSwiftVirtualNetworkSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Deletes a Swift Virtual Network connection from an app (or deployment slot).
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_DeleteSwiftVirtualNetworkSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.Delete");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.DeleteSwiftVirtualNetworkSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, cancellationToken);
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
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_UpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SiteSlotNetworkConfigResource>> UpdateAsync(SwiftVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.Update");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.UpdateSwiftVirtualNetworkConnectionWithCheckSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotNetworkConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_UpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SiteSlotNetworkConfigResource> Update(SwiftVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.Update");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.UpdateSwiftVirtualNetworkConnectionWithCheckSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                return Response.FromValue(new SiteSlotNetworkConfigResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteSlotNetworkConfigResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SwiftVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteSlotNetworkConfigWebAppsRestClient.CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteSlotNetworkConfigResource>(Response.FromValue(new SiteSlotNetworkConfigResource(Client, response), response.GetRawResponse()));
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
        /// Description for Integrates this Web App with a Virtual Network. This requires that 1) &quot;swiftSupported&quot; is true when doing a GET against this resource, and 2) that the target Subnet has already been delegated, and is not
        /// in use by another App Service Plan other than the one this App is in.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/networkConfig/virtualNetwork
        /// Operation Id: WebApps_CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlot
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Properties of the Virtual Network connection. See example. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SiteSlotNetworkConfigResource> CreateOrUpdate(WaitUntil waitUntil, SwiftVirtualNetworkData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _siteSlotNetworkConfigWebAppsClientDiagnostics.CreateScope("SiteSlotNetworkConfigResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteSlotNetworkConfigWebAppsRestClient.CreateOrUpdateSwiftVirtualNetworkConnectionWithCheckSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, data, cancellationToken);
                var operation = new AppServiceArmOperation<SiteSlotNetworkConfigResource>(Response.FromValue(new SiteSlotNetworkConfigResource(Client, response), response.GetRawResponse()));
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
    }
}
