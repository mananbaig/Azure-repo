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
using Azure.ResourceManager.Kusto.Models;

namespace Azure.ResourceManager.Kusto
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _kustoClusterClustersClientDiagnostics;
        private ClustersRestOperations _kustoClusterClustersRestClient;
        private ClientDiagnostics _skusClientDiagnostics;
        private SkusRestOperations _skusRestClient;

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

        private ClientDiagnostics KustoClusterClustersClientDiagnostics => _kustoClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Kusto", KustoClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations KustoClusterClustersRestClient => _kustoClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(KustoClusterResource.ResourceType));
        private ClientDiagnostics SkusClientDiagnostics => _skusClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.Kusto", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private SkusRestOperations SkusRestClient => _skusRestClient ??= new SkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all Kusto clusters within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoClusterResource> GetKustoClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => KustoClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new KustoClusterResource(Client, KustoClusterData.DeserializeKustoClusterData(e)), KustoClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetKustoClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto clusters within a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoClusterResource> GetKustoClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => KustoClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new KustoClusterResource(Client, KustoClusterData.DeserializeKustoClusterData(e)), KustoClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetKustoClusters", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Kusto resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoSkuDescription> GetKustoEligibleSkusAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => KustoClusterClustersRestClient.CreateListSkusRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, KustoSkuDescription.DeserializeKustoSkuDescription, KustoClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetKustoEligibleSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Kusto resource provider.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_ListSkus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoSkuDescription> GetKustoEligibleSkus(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => KustoClusterClustersRestClient.CreateListSkusRequest(Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, KustoSkuDescription.DeserializeKustoSkuDescription, KustoClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetKustoEligibleSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks that the cluster name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<KustoNameAvailabilityResult>> CheckKustoClusterNameAvailabilityAsync(AzureLocation location, KustoClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = KustoClusterClustersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckKustoClusterNameAvailability");
            scope.Start();
            try
            {
                var response = await KustoClusterClustersRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks that the cluster name is valid and is not already in use.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="content"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<KustoNameAvailabilityResult> CheckKustoClusterNameAvailability(AzureLocation location, KustoClusterNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = KustoClusterClustersClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckKustoClusterNameAvailability");
            scope.Start();
            try
            {
                var response = KustoClusterClustersRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists eligible region SKUs for Kusto resource provider by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KustoSkuDescription> GetSkusAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, KustoSkuDescription.DeserializeKustoSkuDescription, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSkus", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists eligible region SKUs for Kusto resource provider by Azure region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Skus_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The name of Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KustoSkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KustoSkuDescription> GetSkus(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => SkusRestClient.CreateListRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, KustoSkuDescription.DeserializeKustoSkuDescription, SkusClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetSkus", "value", null, cancellationToken);
        }
    }
}
