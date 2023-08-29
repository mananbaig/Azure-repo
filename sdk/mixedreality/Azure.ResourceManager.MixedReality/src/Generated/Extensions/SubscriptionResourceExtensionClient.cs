// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MixedReality.Models;

namespace Azure.ResourceManager.MixedReality
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _defaultClientDiagnostics;
        private MixedRealityRestOperations _defaultRestClient;
        private ClientDiagnostics _spatialAnchorsAccountClientDiagnostics;
        private SpatialAnchorsAccountsRestOperations _spatialAnchorsAccountRestClient;
        private ClientDiagnostics _remoteRenderingAccountClientDiagnostics;
        private RemoteRenderingAccountsRestOperations _remoteRenderingAccountRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics DefaultClientDiagnostics => _defaultClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MixedReality", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private MixedRealityRestOperations DefaultRestClient => _defaultRestClient ??= new MixedRealityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics SpatialAnchorsAccountClientDiagnostics => _spatialAnchorsAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MixedReality", SpatialAnchorsAccountResource.ResourceType.Namespace, Diagnostics);
        private SpatialAnchorsAccountsRestOperations SpatialAnchorsAccountRestClient => _spatialAnchorsAccountRestClient ??= new SpatialAnchorsAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(SpatialAnchorsAccountResource.ResourceType));
        private ClientDiagnostics RemoteRenderingAccountClientDiagnostics => _remoteRenderingAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MixedReality", RemoteRenderingAccountResource.ResourceType.Namespace, Diagnostics);
        private RemoteRenderingAccountsRestOperations RemoteRenderingAccountRestClient => _remoteRenderingAccountRestClient ??= new RemoteRenderingAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(RemoteRenderingAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check Name Availability for local uniqueness
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityLocal</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MixedRealityNameAvailabilityResult>> CheckMixedRealityNameAvailabilityAsync(AzureLocation location, MixedRealityNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMixedRealityNameAvailability");
            scope.Start();
            try
            {
                var response = await DefaultRestClient.CheckNameAvailabilityLocalAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check Name Availability for local uniqueness
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityLocal</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MixedRealityNameAvailabilityResult> CheckMixedRealityNameAvailability(AzureLocation location, MixedRealityNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckMixedRealityNameAvailability");
            scope.Start();
            try
            {
                var response = DefaultRestClient.CheckNameAvailabilityLocal(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List Spatial Anchors Accounts by Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/spatialAnchorsAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SpatialAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SpatialAnchorsAccountResource> GetSpatialAnchorsAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SpatialAnchorsAccountRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SpatialAnchorsAccountRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SpatialAnchorsAccountResource(Client, SpatialAnchorsAccountData.DeserializeSpatialAnchorsAccountData(e)), SpatialAnchorsAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSpatialAnchorsAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Spatial Anchors Accounts by Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/spatialAnchorsAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SpatialAnchorsAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SpatialAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SpatialAnchorsAccountResource> GetSpatialAnchorsAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SpatialAnchorsAccountRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => SpatialAnchorsAccountRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SpatialAnchorsAccountResource(Client, SpatialAnchorsAccountData.DeserializeSpatialAnchorsAccountData(e)), SpatialAnchorsAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSpatialAnchorsAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Remote Rendering Accounts by Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/remoteRenderingAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RemoteRenderingAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RemoteRenderingAccountResource> GetRemoteRenderingAccountsAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RemoteRenderingAccountRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RemoteRenderingAccountRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new RemoteRenderingAccountResource(Client, RemoteRenderingAccountData.DeserializeRemoteRenderingAccountData(e)), RemoteRenderingAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetRemoteRenderingAccounts", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List Remote Rendering Accounts by Subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/remoteRenderingAccounts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RemoteRenderingAccounts_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RemoteRenderingAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RemoteRenderingAccountResource> GetRemoteRenderingAccounts(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RemoteRenderingAccountRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RemoteRenderingAccountRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new RemoteRenderingAccountResource(Client, RemoteRenderingAccountData.DeserializeRemoteRenderingAccountData(e)), RemoteRenderingAccountClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetRemoteRenderingAccounts", "value", "nextLink", cancellationToken);
        }
    }
}
