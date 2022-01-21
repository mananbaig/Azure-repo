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
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SiteExtensionInfo and their operations over its parent. </summary>
    public partial class SiteSlotSiteextensionCollection : ArmCollection, IEnumerable<SiteSlotSiteextension>, IAsyncEnumerable<SiteSlotSiteextension>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebAppsRestOperations _webAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotSiteextensionCollection"/> class for mocking. </summary>
        protected SiteSlotSiteextensionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SiteSlotSiteextensionCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotSiteextensionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(SiteSlotSiteextension.ResourceType, out string apiVersion);
            _webAppsRestClient = new WebAppsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SiteSlot.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SiteSlot.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_InstallSiteExtensionSlot
        /// <summary> Description for Install site extension on a web site, or a deployment slot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual SiteSlotSiteextensionCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.InstallSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken);
                var operation = new SiteSlotSiteextensionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webAppsRestClient.CreateInstallSiteExtensionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_InstallSiteExtensionSlot
        /// <summary> Description for Install site extension on a web site, or a deployment slot. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public async virtual Task<SiteSlotSiteextensionCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.InstallSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken).ConfigureAwait(false);
                var operation = new SiteSlotSiteextensionCreateOrUpdateOperation(this, _clientDiagnostics, Pipeline, _webAppsRestClient.CreateInstallSiteExtensionSlotRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetSiteExtensionSlot
        /// <summary> Description for Get site extension information by its ID for a web site, or a deployment slot. </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<SiteSlotSiteextension> Get(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.Get");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotSiteextension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions/{siteExtensionId}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_GetSiteExtensionSlot
        /// <summary> Description for Get site extension information by its ID for a web site, or a deployment slot. </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotSiteextension>> GetAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.Get");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotSiteextension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<SiteSlotSiteextension> GetIfExists(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _webAppsRestClient.GetSiteExtensionSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotSiteextension>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotSiteextension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public async virtual Task<Response<SiteSlotSiteextension>> GetIfExistsAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _webAppsRestClient.GetSiteExtensionSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, siteExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SiteSlotSiteextension>(null, response.GetRawResponse());
                return Response.FromValue(new SiteSlotSiteextension(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public virtual Response<bool> Exists(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(siteExtensionId, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="siteExtensionId"> Site extension name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="siteExtensionId"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="siteExtensionId"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string siteExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(siteExtensionId, nameof(siteExtensionId));

            using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(siteExtensionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListSiteExtensionsSlot
        /// <summary> Description for Get list of siteextensions for a web site, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotSiteextension" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotSiteextension> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotSiteextension> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListSiteExtensionsSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotSiteextension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotSiteextension> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _webAppsRestClient.ListSiteExtensionsSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotSiteextension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}/siteextensions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: WebApps_ListSiteExtensionsSlot
        /// <summary> Description for Get list of siteextensions for a web site, or a deployment slot. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotSiteextension" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotSiteextension> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotSiteextension>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListSiteExtensionsSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotSiteextension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotSiteextension>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotSiteextensionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _webAppsRestClient.ListSiteExtensionsSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotSiteextension(this, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotSiteextension> IEnumerable<SiteSlotSiteextension>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotSiteextension> IAsyncEnumerable<SiteSlotSiteextension>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SiteSlotSiteextension, SiteExtensionInfoData> Construct() { }
    }
}
