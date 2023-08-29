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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing a collection of <see cref="SubscriptionPacketCoreControlPlaneVersionResource" /> and their operations.
    /// Each <see cref="SubscriptionPacketCoreControlPlaneVersionResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SubscriptionPacketCoreControlPlaneVersionCollection" /> instance call the GetSubscriptionPacketCoreControlPlaneVersions method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SubscriptionPacketCoreControlPlaneVersionCollection : ArmCollection, IEnumerable<SubscriptionPacketCoreControlPlaneVersionResource>, IAsyncEnumerable<SubscriptionPacketCoreControlPlaneVersionResource>
    {
        private readonly ClientDiagnostics _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics;
        private readonly PacketCoreControlPlaneVersionsRestOperations _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPacketCoreControlPlaneVersionCollection"/> class for mocking. </summary>
        protected SubscriptionPacketCoreControlPlaneVersionCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionPacketCoreControlPlaneVersionCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubscriptionPacketCoreControlPlaneVersionCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MobileNetwork", SubscriptionPacketCoreControlPlaneVersionResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubscriptionPacketCoreControlPlaneVersionResource.ResourceType, out string subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
            _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient = new PacketCoreControlPlaneVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_GetBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<SubscriptionPacketCoreControlPlaneVersionResource>> GetAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("SubscriptionPacketCoreControlPlaneVersionCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetBySubscriptionAsync(Id.SubscriptionId, versionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_GetBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<SubscriptionPacketCoreControlPlaneVersionResource> Get(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("SubscriptionPacketCoreControlPlaneVersionCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetBySubscription(Id.SubscriptionId, versionName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubscriptionPacketCoreControlPlaneVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all supported packet core control planes versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubscriptionPacketCoreControlPlaneVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubscriptionPacketCoreControlPlaneVersionResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new SubscriptionPacketCoreControlPlaneVersionResource(Client, PacketCoreControlPlaneVersionData.DeserializePacketCoreControlPlaneVersionData(e)), _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics, Pipeline, "SubscriptionPacketCoreControlPlaneVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all supported packet core control planes versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubscriptionPacketCoreControlPlaneVersionResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubscriptionPacketCoreControlPlaneVersionResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new SubscriptionPacketCoreControlPlaneVersionResource(Client, PacketCoreControlPlaneVersionData.DeserializePacketCoreControlPlaneVersionData(e)), _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics, Pipeline, "SubscriptionPacketCoreControlPlaneVersionCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_GetBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("SubscriptionPacketCoreControlPlaneVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetBySubscriptionAsync(Id.SubscriptionId, versionName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_GetBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        public virtual Response<bool> Exists(string versionName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(versionName, nameof(versionName));

            using var scope = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsClientDiagnostics.CreateScope("SubscriptionPacketCoreControlPlaneVersionCollection.Exists");
            scope.Start();
            try
            {
                var response = _subscriptionPacketCoreControlPlaneVersionPacketCoreControlPlaneVersionsRestClient.GetBySubscription(Id.SubscriptionId, versionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubscriptionPacketCoreControlPlaneVersionResource> IEnumerable<SubscriptionPacketCoreControlPlaneVersionResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubscriptionPacketCoreControlPlaneVersionResource> IAsyncEnumerable<SubscriptionPacketCoreControlPlaneVersionResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
