// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="StaticSiteUserProvidedFunctionAppResource" /> and their operations.
    /// Each <see cref="StaticSiteUserProvidedFunctionAppResource" /> in the collection will belong to the same instance of <see cref="StaticSiteResource" />.
    /// To get a <see cref="StaticSiteUserProvidedFunctionAppCollection" /> instance call the GetStaticSiteUserProvidedFunctionApps method from an instance of <see cref="StaticSiteResource" />.
    /// </summary>
    public partial class StaticSiteUserProvidedFunctionAppCollection : ArmCollection, IEnumerable<StaticSiteUserProvidedFunctionAppResource>, IAsyncEnumerable<StaticSiteUserProvidedFunctionAppResource>
    {
        private readonly ClientDiagnostics _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics;
        private readonly StaticSitesRestOperations _staticSiteUserProvidedFunctionAppStaticSitesRestClient;

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppCollection"/> class for mocking. </summary>
        protected StaticSiteUserProvidedFunctionAppCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="StaticSiteUserProvidedFunctionAppCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal StaticSiteUserProvidedFunctionAppCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", StaticSiteUserProvidedFunctionAppResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(StaticSiteUserProvidedFunctionAppResource.ResourceType, out string staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
            _staticSiteUserProvidedFunctionAppStaticSitesRestClient = new StaticSitesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, staticSiteUserProvidedFunctionAppStaticSitesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != StaticSiteResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, StaticSiteResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Register a user provided function app with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_RegisterUserProvidedFunctionAppWithStaticSite
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="functionAppName"> Name of the function app to register with the static site. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<StaticSiteUserProvidedFunctionAppResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string functionAppName, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, data, isForced, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<StaticSiteUserProvidedFunctionAppResource>(new StaticSiteUserProvidedFunctionAppOperationSource(Client), _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// <param name="functionAppName"> Name of the function app to register with the static site. </param>
        /// <param name="data"> A JSON representation of the user provided function app properties. See example. </param>
        /// <param name="isForced"> Specify &lt;code&gt;true&lt;/code&gt; to force the update of the auth configuration on the function app even if an AzureStaticWebApps provider is already configured on the function app. The default is &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<StaticSiteUserProvidedFunctionAppResource> CreateOrUpdate(WaitUntil waitUntil, string functionAppName, StaticSiteUserProvidedFunctionAppData data, bool? isForced = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.RegisterUserProvidedFunctionAppWithStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, data, isForced, cancellationToken);
                var operation = new AppServiceArmOperation<StaticSiteUserProvidedFunctionAppResource>(new StaticSiteUserProvidedFunctionAppOperationSource(Client), _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics, Pipeline, _staticSiteUserProvidedFunctionAppStaticSitesRestClient.CreateRegisterUserProvidedFunctionAppWithStaticSiteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, data, isForced).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Gets the details of the user provided function app registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<StaticSiteUserProvidedFunctionAppResource>> GetAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
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
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<StaticSiteUserProvidedFunctionAppResource> Get(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Get");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new StaticSiteUserProvidedFunctionAppResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets the details of the user provided function apps registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppsForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StaticSiteUserProvidedFunctionAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<StaticSiteUserProvidedFunctionAppResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<StaticSiteUserProvidedFunctionAppResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<StaticSiteUserProvidedFunctionAppResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Gets the details of the user provided function apps registered with a static site
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppsForStaticSite
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StaticSiteUserProvidedFunctionAppResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<StaticSiteUserProvidedFunctionAppResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<StaticSiteUserProvidedFunctionAppResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<StaticSiteUserProvidedFunctionAppResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppsForStaticSiteNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new StaticSiteUserProvidedFunctionAppResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Exists");
            scope.Start();
            try
            {
                var response = await _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSiteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/staticSites/{name}/userProvidedFunctionApps/{functionAppName}
        /// Operation Id: StaticSites_GetUserProvidedFunctionAppForStaticSite
        /// </summary>
        /// <param name="functionAppName"> Name of the function app registered with the static site. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="functionAppName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="functionAppName"/> is null. </exception>
        public virtual Response<bool> Exists(string functionAppName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(functionAppName, nameof(functionAppName));

            using var scope = _staticSiteUserProvidedFunctionAppStaticSitesClientDiagnostics.CreateScope("StaticSiteUserProvidedFunctionAppCollection.Exists");
            scope.Start();
            try
            {
                var response = _staticSiteUserProvidedFunctionAppStaticSitesRestClient.GetUserProvidedFunctionAppForStaticSite(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, functionAppName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<StaticSiteUserProvidedFunctionAppResource> IEnumerable<StaticSiteUserProvidedFunctionAppResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<StaticSiteUserProvidedFunctionAppResource> IAsyncEnumerable<StaticSiteUserProvidedFunctionAppResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
