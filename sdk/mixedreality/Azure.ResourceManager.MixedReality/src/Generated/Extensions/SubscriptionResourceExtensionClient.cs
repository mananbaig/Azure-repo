// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
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
        private ClientDiagnostics _objectAnchorsAccountClientDiagnostics;
        private ObjectAnchorsAccountsRestOperations _objectAnchorsAccountRestClient;

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
        private ClientDiagnostics ObjectAnchorsAccountClientDiagnostics => _objectAnchorsAccountClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.MixedReality", ObjectAnchorsAccountResource.ResourceType.Namespace, Diagnostics);
        private ObjectAnchorsAccountsRestOperations ObjectAnchorsAccountRestClient => _objectAnchorsAccountRestClient ??= new ObjectAnchorsAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ObjectAnchorsAccountResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Check Name Availability for local uniqueness
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/locations/{location}/checkNameAvailability
        /// Operation Id: CheckNameAvailabilityLocal
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CheckNameAvailabilityResponse>> CheckNameAvailabilityLocalAsync(AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocal");
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/locations/{location}/checkNameAvailability
        /// Operation Id: CheckNameAvailabilityLocal
        /// </summary>
        /// <param name="location"> The location in which uniqueness will be verified. </param>
        /// <param name="content"> Check Name Availability Request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CheckNameAvailabilityResponse> CheckNameAvailabilityLocal(AzureLocation location, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = DefaultClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckNameAvailabilityLocal");
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
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/spatialAnchorsAccounts
        /// Operation Id: SpatialAnchorsAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SpatialAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SpatialAnchorsAccountResource> GetSpatialAnchorsAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SpatialAnchorsAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SpatialAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSpatialAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = await SpatialAnchorsAccountRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SpatialAnchorsAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SpatialAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSpatialAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = await SpatialAnchorsAccountRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List Spatial Anchors Accounts by Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/spatialAnchorsAccounts
        /// Operation Id: SpatialAnchorsAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SpatialAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SpatialAnchorsAccountResource> GetSpatialAnchorsAccounts(CancellationToken cancellationToken = default)
        {
            Page<SpatialAnchorsAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = SpatialAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSpatialAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = SpatialAnchorsAccountRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SpatialAnchorsAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = SpatialAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetSpatialAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = SpatialAnchorsAccountRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SpatialAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List Remote Rendering Accounts by Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/remoteRenderingAccounts
        /// Operation Id: RemoteRenderingAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RemoteRenderingAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RemoteRenderingAccountResource> GetRemoteRenderingAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RemoteRenderingAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = RemoteRenderingAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRemoteRenderingAccounts");
                scope.Start();
                try
                {
                    var response = await RemoteRenderingAccountRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RemoteRenderingAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<RemoteRenderingAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = RemoteRenderingAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRemoteRenderingAccounts");
                scope.Start();
                try
                {
                    var response = await RemoteRenderingAccountRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new RemoteRenderingAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List Remote Rendering Accounts by Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/remoteRenderingAccounts
        /// Operation Id: RemoteRenderingAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RemoteRenderingAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RemoteRenderingAccountResource> GetRemoteRenderingAccounts(CancellationToken cancellationToken = default)
        {
            Page<RemoteRenderingAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = RemoteRenderingAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRemoteRenderingAccounts");
                scope.Start();
                try
                {
                    var response = RemoteRenderingAccountRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RemoteRenderingAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<RemoteRenderingAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = RemoteRenderingAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetRemoteRenderingAccounts");
                scope.Start();
                try
                {
                    var response = RemoteRenderingAccountRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new RemoteRenderingAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List Object Anchors Accounts by Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/objectAnchorsAccounts
        /// Operation Id: ObjectAnchorsAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ObjectAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ObjectAnchorsAccountResource> GetObjectAnchorsAccountsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ObjectAnchorsAccountResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ObjectAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetObjectAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = await ObjectAnchorsAccountRestClient.ListBySubscriptionAsync(Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ObjectAnchorsAccountResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ObjectAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetObjectAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = await ObjectAnchorsAccountRestClient.ListBySubscriptionNextPageAsync(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// List Object Anchors Accounts by Subscription
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.MixedReality/objectAnchorsAccounts
        /// Operation Id: ObjectAnchorsAccounts_ListBySubscription
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ObjectAnchorsAccountResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ObjectAnchorsAccountResource> GetObjectAnchorsAccounts(CancellationToken cancellationToken = default)
        {
            Page<ObjectAnchorsAccountResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = ObjectAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetObjectAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = ObjectAnchorsAccountRestClient.ListBySubscription(Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ObjectAnchorsAccountResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = ObjectAnchorsAccountClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetObjectAnchorsAccounts");
                scope.Start();
                try
                {
                    var response = ObjectAnchorsAccountRestClient.ListBySubscriptionNextPage(nextLink, Id.SubscriptionId, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ObjectAnchorsAccountResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
