// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Threading;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Grafana
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _managedGrafanaGrafanaClientDiagnostics;
        private GrafanaRestOperations _managedGrafanaGrafanaRestClient;

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

        private ClientDiagnostics ManagedGrafanaGrafanaClientDiagnostics => _managedGrafanaGrafanaClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Grafana", ManagedGrafanaResource.ResourceType.Namespace, Diagnostics);
        private GrafanaRestOperations ManagedGrafanaGrafanaRestClient => _managedGrafanaGrafanaRestClient ??= new GrafanaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ManagedGrafanaResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Dashboard/grafana</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ManagedGrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ManagedGrafanaResource> GetManagedGrafanasAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedGrafanaGrafanaRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedGrafanaGrafanaRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return Core.PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ManagedGrafanaResource(Client, ManagedGrafanaData.DeserializeManagedGrafanaData(e)), ManagedGrafanaGrafanaClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetManagedGrafanas", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all resources of workspaces for Grafana under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Dashboard/grafana</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ManagedGrafanaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ManagedGrafanaResource> GetManagedGrafanas(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ManagedGrafanaGrafanaRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ManagedGrafanaGrafanaRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return Core.PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ManagedGrafanaResource(Client, ManagedGrafanaData.DeserializeManagedGrafanaData(e)), ManagedGrafanaGrafanaClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetManagedGrafanas", "value", "nextLink", cancellationToken);
        }
    }
}
