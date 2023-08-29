// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.OperationalInsights
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _logAnalyticsQueryPackQueryPacksClientDiagnostics;
        private QueryPacksRestOperations _logAnalyticsQueryPackQueryPacksRestClient;
        private ClientDiagnostics _operationalInsightsClusterClustersClientDiagnostics;
        private ClustersRestOperations _operationalInsightsClusterClustersRestClient;
        private ClientDiagnostics _operationalInsightsWorkspaceWorkspacesClientDiagnostics;
        private WorkspacesRestOperations _operationalInsightsWorkspaceWorkspacesRestClient;
        private ClientDiagnostics _deletedWorkspacesClientDiagnostics;
        private DeletedWorkspacesRestOperations _deletedWorkspacesRestClient;

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

        private ClientDiagnostics LogAnalyticsQueryPackQueryPacksClientDiagnostics => _logAnalyticsQueryPackQueryPacksClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", LogAnalyticsQueryPackResource.ResourceType.Namespace, Diagnostics);
        private QueryPacksRestOperations LogAnalyticsQueryPackQueryPacksRestClient => _logAnalyticsQueryPackQueryPacksRestClient ??= new QueryPacksRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(LogAnalyticsQueryPackResource.ResourceType));
        private ClientDiagnostics OperationalInsightsClusterClustersClientDiagnostics => _operationalInsightsClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations OperationalInsightsClusterClustersRestClient => _operationalInsightsClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(OperationalInsightsClusterResource.ResourceType));
        private ClientDiagnostics OperationalInsightsWorkspaceWorkspacesClientDiagnostics => _operationalInsightsWorkspaceWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", OperationalInsightsWorkspaceResource.ResourceType.Namespace, Diagnostics);
        private WorkspacesRestOperations OperationalInsightsWorkspaceWorkspacesRestClient => _operationalInsightsWorkspaceWorkspacesRestClient ??= new WorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(OperationalInsightsWorkspaceResource.ResourceType));
        private ClientDiagnostics DeletedWorkspacesClientDiagnostics => _deletedWorkspacesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.OperationalInsights", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private DeletedWorkspacesRestOperations DeletedWorkspacesRestClient => _deletedWorkspacesRestClient ??= new DeletedWorkspacesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets a list of all Log Analytics QueryPacks within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/queryPacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QueryPacks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="LogAnalyticsQueryPackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<LogAnalyticsQueryPackResource> GetLogAnalyticsQueryPacksAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LogAnalyticsQueryPackQueryPacksRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LogAnalyticsQueryPackQueryPacksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new LogAnalyticsQueryPackResource(Client, LogAnalyticsQueryPackData.DeserializeLogAnalyticsQueryPackData(e)), LogAnalyticsQueryPackQueryPacksClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLogAnalyticsQueryPacks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of all Log Analytics QueryPacks within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/queryPacks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QueryPacks_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="LogAnalyticsQueryPackResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<LogAnalyticsQueryPackResource> GetLogAnalyticsQueryPacks(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LogAnalyticsQueryPackQueryPacksRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => LogAnalyticsQueryPackQueryPacksRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new LogAnalyticsQueryPackResource(Client, LogAnalyticsQueryPackData.DeserializeLogAnalyticsQueryPackData(e)), LogAnalyticsQueryPackQueryPacksClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLogAnalyticsQueryPacks", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the Log Analytics clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsClusterResource> GetOperationalInsightsClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationalInsightsClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationalInsightsClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new OperationalInsightsClusterResource(Client, OperationalInsightsClusterData.DeserializeOperationalInsightsClusterData(e)), OperationalInsightsClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOperationalInsightsClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the Log Analytics clusters in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsClusterResource> GetOperationalInsightsClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationalInsightsClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => OperationalInsightsClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new OperationalInsightsClusterResource(Client, OperationalInsightsClusterData.DeserializeOperationalInsightsClusterData(e)), OperationalInsightsClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOperationalInsightsClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the workspaces in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsWorkspaceResource> GetOperationalInsightsWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationalInsightsWorkspaceWorkspacesRestClient.CreateListRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), OperationalInsightsWorkspaceWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOperationalInsightsWorkspaces", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets the workspaces in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/workspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsWorkspaceResource> GetOperationalInsightsWorkspaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => OperationalInsightsWorkspaceWorkspacesRestClient.CreateListRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), OperationalInsightsWorkspaceWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetOperationalInsightsWorkspaces", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets recently deleted workspaces in a subscription, available for recovery.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/deletedWorkspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedWorkspaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<OperationalInsightsWorkspaceResource> GetDeletedWorkspacesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeletedWorkspacesRestClient.CreateListRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), DeletedWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedWorkspaces", "value", null, cancellationToken);
        }

        /// <summary>
        /// Gets recently deleted workspaces in a subscription, available for recovery.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.OperationalInsights/deletedWorkspaces</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DeletedWorkspaces_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="OperationalInsightsWorkspaceResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<OperationalInsightsWorkspaceResource> GetDeletedWorkspaces(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => DeletedWorkspacesRestClient.CreateListRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new OperationalInsightsWorkspaceResource(Client, OperationalInsightsWorkspaceData.DeserializeOperationalInsightsWorkspaceData(e)), DeletedWorkspacesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetDeletedWorkspaces", "value", null, cancellationToken);
        }
    }
}
