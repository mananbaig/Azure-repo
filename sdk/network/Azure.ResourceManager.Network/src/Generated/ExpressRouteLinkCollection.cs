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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRouteLinkResource" /> and their operations.
    /// Each <see cref="ExpressRouteLinkResource" /> in the collection will belong to the same instance of <see cref="ExpressRoutePortResource" />.
    /// To get an <see cref="ExpressRouteLinkCollection" /> instance call the GetExpressRouteLinks method from an instance of <see cref="ExpressRoutePortResource" />.
    /// </summary>
    public partial class ExpressRouteLinkCollection : ArmCollection, IEnumerable<ExpressRouteLinkResource>, IAsyncEnumerable<ExpressRouteLinkResource>
    {
        private readonly ClientDiagnostics _expressRouteLinkClientDiagnostics;
        private readonly ExpressRouteLinksRestOperations _expressRouteLinkRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteLinkCollection"/> class for mocking. </summary>
        protected ExpressRouteLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRouteLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRouteLinkClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRouteLinkResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRouteLinkResource.ResourceType, out string expressRouteLinkApiVersion);
            _expressRouteLinkRestClient = new ExpressRouteLinksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRouteLinkApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ExpressRoutePortResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ExpressRoutePortResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Retrieves the specified ExpressRouteLink resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the ExpressRouteLink resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<Response<ExpressRouteLinkResource>> GetAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _expressRouteLinkClientDiagnostics.CreateScope("ExpressRouteLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the specified ExpressRouteLink resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the ExpressRouteLink resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual Response<ExpressRouteLinkResource> Get(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _expressRouteLinkClientDiagnostics.CreateScope("ExpressRouteLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteLinkResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieve the ExpressRouteLink sub-resources of the specified ExpressRoutePort resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteLinks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteLinkResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteLinkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteLinkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new ExpressRouteLinkResource(Client, ExpressRouteLinkData.DeserializeExpressRouteLinkData(e)), _expressRouteLinkClientDiagnostics, Pipeline, "ExpressRouteLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieve the ExpressRouteLink sub-resources of the specified ExpressRoutePort resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}/links</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteLinks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteLinkResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteLinkResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRouteLinkRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRouteLinkRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new ExpressRouteLinkResource(Client, ExpressRouteLinkData.DeserializeExpressRouteLinkData(e)), _expressRouteLinkClientDiagnostics, Pipeline, "ExpressRouteLinkCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the ExpressRouteLink resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _expressRouteLinkClientDiagnostics.CreateScope("ExpressRouteLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRouteLinkRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}/links/{linkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRouteLinks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="linkName"> The name of the ExpressRouteLink resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="linkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="linkName"/> is null. </exception>
        public virtual Response<bool> Exists(string linkName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(linkName, nameof(linkName));

            using var scope = _expressRouteLinkClientDiagnostics.CreateScope("ExpressRouteLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRouteLinkRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, linkName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRouteLinkResource> IEnumerable<ExpressRouteLinkResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteLinkResource> IAsyncEnumerable<ExpressRouteLinkResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
