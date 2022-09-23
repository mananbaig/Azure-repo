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
    /// A Class representing a StaticSiteUserProvidedFunctionApp along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="StaticSiteUserProvidedFunctionAppResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetStaticSiteUserProvidedFunctionAppResource method.
    /// Otherwise you can get one from its parent resource <see cref="StaticSiteResource" /> using the GetStaticSiteUserProvidedFunctionApp method.
    /// </summary>
    public partial class StaticSiteUserProvidedFunctionAppResource : BaseStaticSiteUserProvidedFunctionAppResource
    {
        /// <summary> Generate the resource identifier of a <see cref="StaticSiteUserProvidedFunctionAppResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name, string functionAppName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteUserProvidedFunctionAppStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppResource"/> class for mocking. </summary>
        protected StaticSiteUserProvidedFunctionAppResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "StaticSiteUserProvidedFunctionAppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal StaticSiteUserProvidedFunctionAppResource(ArmClient client, StaticSiteUserProvidedFunctionAppData data) : base(client, data)
        {
            _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal StaticSiteUserProvidedFunctionAppResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/staticSites/userProvidedFunctionApps";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<Response<BaseStaticSiteUserProvidedFunctionAppResource>> GetCoreAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new async Task<Response<StaticSiteUserProvidedFunctionAppResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            var result = await GetCoreAsync(cancellationToken).ConfigureAwait(false);
            return Response.FromValue((StaticSiteUserProvidedFunctionAppResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Get
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override Response<BaseStaticSiteUserProvidedFunctionAppResource> GetCore(CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Get");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        [ForwardsClientCalls]
        public new Response<StaticSiteUserProvidedFunctionAppResource> Get(CancellationToken cancellationToken = default)
        {
            var result = GetCore(cancellationToken);
            return Response.FromValue((StaticSiteUserProvidedFunctionAppResource)result.Value, result.GetRawResponse());
        }

        /// <summary>
        /// The core implementation for operation Delete
        /// Description for Detach the user provided function app from the static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_DetachUserProvidedFunctionAppFromStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override async Task<ArmOperation> DeleteCoreAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Delete");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
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
        /// Description for Detach the user provided function app from the static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_DetachUserProvidedFunctionAppFromStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        protected override ArmOperation DeleteCore(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Delete");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.DetachUserProvidedFunctionAppFromStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
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
        /// Description for Register a user provided function app with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override async Task<ArmOperation<BaseStaticSiteUserProvidedFunctionAppResource>> UpdateCoreAsync(WaitUntil waitUntil, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Update");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, isForced, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<BaseStaticSiteUserProvidedFunctionAppResource>(new BaseStaticSiteUserProvidedFunctionAppOperationSource(Client), _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Register a user provided function app with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new async Task<ArmOperation<StaticSiteUserProvidedFunctionAppResource>> UpdateAsync(WaitUntil waitUntil, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            var result = await UpdateCoreAsync(waitUntil, data, isForced, cancellationToken).ConfigureAwait(false);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<StaticSiteUserProvidedFunctionAppResource>(Response.FromValue((StaticSiteUserProvidedFunctionAppResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<StaticSiteUserProvidedFunctionAppResource>(new StaticSiteUserProvidedFunctionAppOperationSource(Client), _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, isForced).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }

        /// <summary>
        /// The core implementation for operation Update
        /// Description for Register a user provided function app with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        protected override ArmOperation<BaseStaticSiteUserProvidedFunctionAppResource> UpdateCore(WaitUntil waitUntil, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppResource.Update");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, isForced, cancellationToken);
                var operation = new AppServiceArmOperation<BaseStaticSiteUserProvidedFunctionAppResource>(new BaseStaticSiteUserProvidedFunctionAppOperationSource(Client), _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Register a user provided function app with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        [ForwardsClientCalls]
        public new ArmOperation<StaticSiteUserProvidedFunctionAppResource> Update(WaitUntil waitUntil, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            var result = UpdateCore(waitUntil, data, isForced, cancellationToken);
            if (waitUntil == WaitUntil.Completed)
            {
                return new AppServiceArmOperation<StaticSiteUserProvidedFunctionAppResource>(Response.FromValue((StaticSiteUserProvidedFunctionAppResource)result.Value, result.GetRawResponse()));
            }
            var operation = new AppServiceArmOperation<StaticSiteUserProvidedFunctionAppResource>(new StaticSiteUserProvidedFunctionAppOperationSource(Client), _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, isForced).Request, result.GetRawResponse(), OperationFinalStateVia.Location);
            return operation;
        }
    }
}
