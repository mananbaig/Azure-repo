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
using Azure.ResourceManager.HDInsight.Models;

namespace Azure.ResourceManager.HDInsight
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _hdInsightClusterClustersClientDiagnostics;
        private ClustersRestOperations _hdInsightClusterClustersRestClient;
        private ClientDiagnostics _locationsClientDiagnostics;
        private LocationsRestOperations _locationsRestClient;

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

        private ClientDiagnostics HDInsightClusterClustersClientDiagnostics => _hdInsightClusterClustersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight", HDInsightClusterResource.ResourceType.Namespace, Diagnostics);
        private ClustersRestOperations HDInsightClusterClustersRestClient => _hdInsightClusterClustersRestClient ??= new ClustersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(HDInsightClusterResource.ResourceType));
        private ClientDiagnostics LocationsClientDiagnostics => _locationsClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.HDInsight", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationsRestOperations LocationsRestClient => _locationsRestClient ??= new LocationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Lists all the HDInsight clusters under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HDInsightClusterResource> GetHDInsightClustersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HDInsightClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HDInsightClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, (e, o) => new HDInsightClusterResource(Client, HDInsightClusterData.DeserializeHDInsightClusterData(e)), HDInsightClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHDInsightClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the HDInsight clusters under the subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusters</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Clusters_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HDInsightClusterResource> GetHDInsightClusters(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => HDInsightClusterClustersRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => HDInsightClusterClustersRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, (e, o) => new HDInsightClusterResource(Client, HDInsightClusterData.DeserializeHDInsightClusterData(e)), HDInsightClusterClustersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHDInsightClusters", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the capabilities for the specified location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapabilities</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HDInsightCapabilitiesResult>> GetHDInsightCapabilitiesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHDInsightCapabilities");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.GetCapabilitiesAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the capabilities for the specified location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_GetCapabilities</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HDInsightCapabilitiesResult> GetHDInsightCapabilities(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHDInsightCapabilities");
            scope.Start();
            try
            {
                var response = LocationsRestClient.GetCapabilities(Id.SubscriptionId, location, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the usages for the specified location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_ListUsages</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HDInsightUsage> GetHDInsightUsagesAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationsRestClient.CreateListUsagesRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, HDInsightUsage.DeserializeHDInsightUsage, LocationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHDInsightUsages", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the usages for the specified location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_ListUsages</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightUsage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HDInsightUsage> GetHDInsightUsages(AzureLocation location, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationsRestClient.CreateListUsagesRequest(Id.SubscriptionId, location);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, HDInsightUsage.DeserializeHDInsightUsage, LocationsClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetHDInsightUsages", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists the billingSpecs for the specified subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/billingSpecs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_ListBillingSpecs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HDInsightBillingSpecsListResult>> GetHDInsightBillingSpecsAsync(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHDInsightBillingSpecs");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.ListBillingSpecsAsync(Id.SubscriptionId, location, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the billingSpecs for the specified subscription and location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/billingSpecs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_ListBillingSpecs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HDInsightBillingSpecsListResult> GetHDInsightBillingSpecs(AzureLocation location, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.GetHDInsightBillingSpecs");
            scope.Start();
            try
            {
                var response = LocationsRestClient.ListBillingSpecs(Id.SubscriptionId, location, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the cluster name is available or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="content"> The HDInsightNameAvailabilityContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HDInsightNameAvailabilityResult>> CheckHDInsightNameAvailabilityAsync(AzureLocation location, HDInsightNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckHDInsightNameAvailability");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the cluster name is available or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="content"> The HDInsightNameAvailabilityContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HDInsightNameAvailabilityResult> CheckHDInsightNameAvailability(AzureLocation location, HDInsightNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckHDInsightNameAvailability");
            scope.Start();
            try
            {
                var response = LocationsRestClient.CheckNameAvailability(Id.SubscriptionId, location, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate the cluster create request spec is valid or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/validateCreateRequest</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_ValidateClusterCreateRequest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="content"> The HDInsightClusterCreationValidateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<HDInsightClusterCreationValidateResult>> ValidateHDInsightClusterCreationAsync(AzureLocation location, HDInsightClusterCreationValidateContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateHDInsightClusterCreation");
            scope.Start();
            try
            {
                var response = await LocationsRestClient.ValidateClusterCreateRequestAsync(Id.SubscriptionId, location, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Validate the cluster create request spec is valid or not.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/validateCreateRequest</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_ValidateClusterCreateRequest</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> The Azure location (region) for which to make the request. </param>
        /// <param name="content"> The HDInsightClusterCreationValidateContent to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<HDInsightClusterCreationValidateResult> ValidateHDInsightClusterCreation(AzureLocation location, HDInsightClusterCreationValidateContent content, CancellationToken cancellationToken = default)
        {
            using var scope = LocationsClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.ValidateHDInsightClusterCreation");
            scope.Start();
            try
            {
                var response = LocationsRestClient.ValidateClusterCreateRequest(Id.SubscriptionId, location, content, cancellationToken);
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
