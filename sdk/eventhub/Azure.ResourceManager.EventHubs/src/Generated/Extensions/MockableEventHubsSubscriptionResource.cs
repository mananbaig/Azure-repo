// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.EventHubs;
using Azure.ResourceManager.EventHubs.Models;

namespace Azure.ResourceManager.EventHubs.Mocking
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    public partial class MockableEventHubsSubscriptionResource : ArmResource
    {
        private ClientDiagnostics _eventHubsClusterClustersClientDiagnostics;
        private ClustersRestOperations _eventHubsClusterClustersRestClient;
        private ClientDiagnostics _eventHubsNamespaceNamespacesClientDiagnostics;
        private NamespacesRestOperations _eventHubsNamespaceNamespacesRestClient;

        /// <summary> Initializes a new instance of the <see cref="MockableEventHubsSubscriptionResource"/> class for mocking. </summary>
        protected MockableEventHubsSubscriptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableEventHubsSubscriptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableEventHubsSubscriptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics EventHubsClusterClustersClientDiagnostics => _eventHubsClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations EventHubsClusterClustersRestClient => _eventHubsClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(EventHubsClusterResource.ResourceType));
        private ClientDiagnostics EventHubsNamespaceNamespacesClientDiagnostics => _eventHubsNamespaceNamespacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.EventHubs", EventHubsNamespaceResource.ResourceType.Namespace, Diagnostics);
        private NamespacesRestOperations EventHubsNamespaceNamespacesRestClient => _eventHubsNamespaceNamespacesRestClient ??= new NamespacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(EventHubsNamespaceResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListAvailableClusterRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AvailableCluster"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AvailableCluster> GetAvailableClusterRegionClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EventHubsClusterClustersRestClient.CreateListAvailableClusterRegionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, AvailableCluster.DeserializeAvailableCluster, EventHubsClusterClustersClientDiagnostics, Pipeline, "MockableEventHubsSubscriptionResource.GetAvailableClusterRegionClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// List the quantity of available pre-provisioned Event Hubs Clusters, indexed by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/availableClusterRegions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListAvailableClusterRegion</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AvailableCluster"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AvailableCluster> GetAvailableClusterRegionClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EventHubsClusterClustersRestClient.CreateListAvailableClusterRegionRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, AvailableCluster.DeserializeAvailableCluster, EventHubsClusterClustersClientDiagnostics, Pipeline, "MockableEventHubsSubscriptionResource.GetAvailableClusterRegionClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsClusterResource> GetEventHubsClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EventHubsClusterClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EventHubsClusterClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsClusterResource(Client, EventHubsClusterData.DeserializeEventHubsClusterData(e)), EventHubsClusterClustersClientDiagnostics, Pipeline, "MockableEventHubsSubscriptionResource.GetEventHubsClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the available Event Hubs Clusters within an ARM resource group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsClusterResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsClusterResource> GetEventHubsClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EventHubsClusterClustersRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EventHubsClusterClustersRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsClusterResource(Client, EventHubsClusterData.DeserializeEventHubsClusterData(e)), EventHubsClusterClustersClientDiagnostics, Pipeline, "MockableEventHubsSubscriptionResource.GetEventHubsClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventHubsNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventHubsNamespaceResource> GetEventHubsNamespacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EventHubsNamespaceNamespacesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EventHubsNamespaceNamespacesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventHubsNamespaceResource(Client, EventHubsNamespaceData.DeserializeEventHubsNamespaceData(e)), EventHubsNamespaceNamespacesClientDiagnostics, Pipeline, "MockableEventHubsSubscriptionResource.GetEventHubsNamespaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the available Namespaces within a subscription, irrespective of the resource groups.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/namespaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventHubsNamespaceResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventHubsNamespaceResource> GetEventHubsNamespaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => EventHubsNamespaceNamespacesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => EventHubsNamespaceNamespacesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventHubsNamespaceResource(Client, EventHubsNamespaceData.DeserializeEventHubsNamespaceData(e)), EventHubsNamespaceNamespacesClientDiagnostics, Pipeline, "MockableEventHubsSubscriptionResource.GetEventHubsNamespaces", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<EventHubsNameAvailabilityResult>> CheckEventHubsNamespaceNameAvailabilityAsync(EventHubsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = EventHubsNamespaceNamespacesClientDiagnostics.CreateScope("MockableEventHubsSubscriptionResource.CheckEventHubsNamespaceNameAvailability");
            scope.Start();
            try
            {
                var response = await EventHubsNamespaceNamespacesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the give Namespace name availability.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.EventHub/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Namespaces_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters to check availability of the given Namespace name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<EventHubsNameAvailabilityResult> CheckEventHubsNamespaceNameAvailability(EventHubsNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = EventHubsNamespaceNamespacesClientDiagnostics.CreateScope("MockableEventHubsSubscriptionResource.CheckEventHubsNamespaceNameAvailability");
            scope.Start();
            try
            {
                var response = EventHubsNamespaceNamespacesRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
