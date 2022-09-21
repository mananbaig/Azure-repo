// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteProcess along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteProcessResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteProcessResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetSiteProcess method.
    /// </summary>
    public partial class SiteProcessResource : ProcessInfoResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteProcessResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string processId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteProcessWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteProcessWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteProcessResource"/> class for mocking. </summary>
        protected SiteProcessResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteProcessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteProcessResource(ArmClient client, ProcessInfoData data) : base(client, data)
        {
            _siteProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteProcessWebAppsApiVersion);
            _siteProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="SiteProcessResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteProcessResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteProcessWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteProcessWebAppsApiVersion);
            _siteProcessWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteProcessWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/processes";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SiteProcessModuleResources in the SiteProcess. </summary>
        /// <returns> An object representing collection of SiteProcessModuleResources and their operations over a SiteProcessModuleResource. </returns>
        public virtual SiteProcessModuleCollection GetSiteProcessModules()
        {
            return GetCachedClient(Client => new SiteProcessModuleCollection(Client, Id));
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModule
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SiteProcessModuleResource>> GetSiteProcessModuleAsync(string baseAddress, CancellationToken cancellationToken = default)
        {
            return await GetSiteProcessModules().GetAsync(baseAddress, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/modules/{baseAddress}
        /// Operation Id: WebApps_GetProcessModule
        /// </summary>
        /// <param name="baseAddress"> Module base address. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="baseAddress"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="baseAddress"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<SiteProcessModuleResource> GetSiteProcessModule(string baseAddress, CancellationToken cancellationToken = default)
        {
            return GetSiteProcessModules().Get(baseAddress, cancellationToken);
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<ProcessInfoResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetCore");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.GetProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual async Task<Response<SiteProcessResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var value = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((SiteProcessResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<ProcessInfoResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetCore");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.GetProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get process information by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_GetProcess
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new virtual Response<SiteProcessResource> Get(CancellationToken cancellationToken = default)
        {
            var value = GetCore(cancellationToken);
            return Response.FromValue((SiteProcessResource)value.Value, value.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Description for Terminate a process by its ID for a web site, or a deployment slot, or specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_DeleteProcess
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.DeleteCore");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.DeleteProcessAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Terminate a process by its ID for a web site, or a deployment slot, or specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}
        /// Operation Id: WebApps_DeleteProcess
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.DeleteCore");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.DeleteProcess(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Get a memory dump of a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/dump
        /// Operation Id: WebApps_GetProcessDump
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> GetProcessDumpAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetProcessDump");
            scope.Start();
            try
            {
                var response = await _siteProcessWebAppsRestClient.GetProcessDumpAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get a memory dump of a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/dump
        /// Operation Id: WebApps_GetProcessDump
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> GetProcessDump(CancellationToken cancellationToken = default)
        {
            using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetProcessDump");
            scope.Start();
            try
            {
                var response = _siteProcessWebAppsRestClient.GetProcessDump(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List the threads in a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/threads
        /// Operation Id: WebApps_ListProcessThreads
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ProcessThreadInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ProcessThreadInfo> GetProcessThreadsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ProcessThreadInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetProcessThreads");
                scope.Start();
                try
                {
                    var response = await _siteProcessWebAppsRestClient.ListProcessThreadsAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ProcessThreadInfo>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetProcessThreads");
                scope.Start();
                try
                {
                    var response = await _siteProcessWebAppsRestClient.ListProcessThreadsNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
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
        /// Description for List the threads in a process by its ID for a specific scaled-out instance in a web site.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/processes/{processId}/threads
        /// Operation Id: WebApps_ListProcessThreads
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ProcessThreadInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ProcessThreadInfo> GetProcessThreads(CancellationToken cancellationToken = default)
        {
            Page<ProcessThreadInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetProcessThreads");
                scope.Start();
                try
                {
                    var response = _siteProcessWebAppsRestClient.ListProcessThreads(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ProcessThreadInfo> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _siteProcessWebAppsClientDiagnostics.CreateScope("SiteProcessResource.GetProcessThreads");
                scope.Start();
                try
                {
                    var response = _siteProcessWebAppsRestClient.ListProcessThreadsNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }
    }
}
