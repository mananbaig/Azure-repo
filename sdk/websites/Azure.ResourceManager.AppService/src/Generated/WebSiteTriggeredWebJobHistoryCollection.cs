// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="WebSiteTriggeredWebJobHistoryResource" /> and their operations.
    /// Each <see cref="WebSiteTriggeredWebJobHistoryResource" /> in the collection will belong to the same instance of <see cref="WebSiteTriggeredwebJobResource" />.
    /// To get a <see cref="WebSiteTriggeredWebJobHistoryCollection" /> instance call the GetWebSiteTriggeredWebJobHistories method from an instance of <see cref="WebSiteTriggeredwebJobResource" />.
    /// </summary>
    public partial class WebSiteTriggeredWebJobHistoryCollection : ArmCollection, IEnumerable<WebSiteTriggeredWebJobHistoryResource>, IAsyncEnumerable<WebSiteTriggeredWebJobHistoryResource>
    {
        private readonly ClientDiagnostics _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _webSiteTriggeredWebJobHistoryWebAppsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredWebJobHistoryCollection"/> class for mocking. </summary>
        protected WebSiteTriggeredWebJobHistoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WebSiteTriggeredWebJobHistoryCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WebSiteTriggeredWebJobHistoryCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", WebSiteTriggeredWebJobHistoryResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WebSiteTriggeredWebJobHistoryResource.ResourceType, out string webSiteTriggeredWebJobHistoryWebAppsApiVersion);
            _webSiteTriggeredWebJobHistoryWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, webSiteTriggeredWebJobHistoryWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WebSiteTriggeredwebJobResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WebSiteTriggeredwebJobResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<WebSiteTriggeredWebJobHistoryResource>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _webSiteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Gets a triggered web job's history by its ID for an app, , or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<WebSiteTriggeredWebJobHistoryResource> Get(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredWebJobHistoryCollection.Get");
            scope.Start();
            try
            {
                var response = _webSiteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WebSiteTriggeredWebJobHistoryResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for List a triggered web job's history for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WebSiteTriggeredWebJobHistoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WebSiteTriggeredWebJobHistoryResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteTriggeredWebJobHistoryResource(Client, TriggeredJobHistoryData.DeserializeTriggeredJobHistoryData(e)), _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics, Pipeline, "WebSiteTriggeredWebJobHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Description for List a triggered web job's history for an app, or a deployment slot.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_ListTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WebSiteTriggeredWebJobHistoryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WebSiteTriggeredWebJobHistoryResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _webSiteTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _webSiteTriggeredWebJobHistoryWebAppsRestClient.CreateListTriggeredWebJobHistoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new WebSiteTriggeredWebJobHistoryResource(Client, TriggeredJobHistoryData.DeserializeTriggeredJobHistoryData(e)), _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics, Pipeline, "WebSiteTriggeredWebJobHistoryCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await _webSiteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistoryAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/triggeredwebjobs/{webJobName}/history/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetTriggeredWebJobHistory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> History ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _webSiteTriggeredWebJobHistoryWebAppsClientDiagnostics.CreateScope("WebSiteTriggeredWebJobHistoryCollection.Exists");
            scope.Start();
            try
            {
                var response = _webSiteTriggeredWebJobHistoryWebAppsRestClient.GetTriggeredWebJobHistory(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, id, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WebSiteTriggeredWebJobHistoryResource> IEnumerable<WebSiteTriggeredWebJobHistoryResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WebSiteTriggeredWebJobHistoryResource> IAsyncEnumerable<WebSiteTriggeredWebJobHistoryResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
