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

namespace Azure.ResourceManager.DesktopVirtualization
{
    /// <summary>
    /// A class representing a collection of <see cref="SessionHostResource" /> and their operations.
    /// Each <see cref="SessionHostResource" /> in the collection will belong to the same instance of <see cref="HostPoolResource" />.
    /// To get a <see cref="SessionHostCollection" /> instance call the GetSessionHosts method from an instance of <see cref="HostPoolResource" />.
    /// </summary>
    public partial class SessionHostCollection : ArmCollection, IEnumerable<SessionHostResource>, IAsyncEnumerable<SessionHostResource>
    {
        private readonly ClientDiagnostics _sessionHostClientDiagnostics;
        private readonly SessionHostsRestOperations _sessionHostRestClient;

        /// <summary> Initializes a new instance of the <see cref="SessionHostCollection"/> class for mocking. </summary>
        protected SessionHostCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SessionHostCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SessionHostCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sessionHostClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DesktopVirtualization", SessionHostResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SessionHostResource.ResourceType, out string sessionHostApiVersion);
            _sessionHostRestClient = new SessionHostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sessionHostApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != HostPoolResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, HostPoolResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a session host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual async Task<Response<SessionHostResource>> GetAsync(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Get");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SessionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a session host.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual Response<SessionHostResource> Get(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Get");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SessionHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List sessionHosts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SessionHostResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SessionHostResource> GetAllAsync(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sessionHostRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sessionHostRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SessionHostResource(Client, SessionHostData.DeserializeSessionHostData(e)), _sessionHostClientDiagnostics, Pipeline, "SessionHostCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List sessionHosts.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="pageSize"> Number of items per page. </param>
        /// <param name="isDescending"> Indicates whether the collection is descending. </param>
        /// <param name="initialSkip"> Initial number of items to skip. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SessionHostResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SessionHostResource> GetAll(int? pageSize = null, bool? isDescending = null, int? initialSkip = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _sessionHostRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _sessionHostRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, pageSizeHint, isDescending, initialSkip);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SessionHostResource(Client, SessionHostData.DeserializeSessionHostData(e)), _sessionHostClientDiagnostics, Pipeline, "SessionHostCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = await _sessionHostRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DesktopVirtualization/hostPools/{hostPoolName}/sessionHosts/{sessionHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SessionHosts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sessionHostName"> The name of the session host within the specified host pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sessionHostName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sessionHostName"/> is null. </exception>
        public virtual Response<bool> Exists(string sessionHostName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sessionHostName, nameof(sessionHostName));

            using var scope = _sessionHostClientDiagnostics.CreateScope("SessionHostCollection.Exists");
            scope.Start();
            try
            {
                var response = _sessionHostRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sessionHostName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SessionHostResource> IEnumerable<SessionHostResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SessionHostResource> IAsyncEnumerable<SessionHostResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
