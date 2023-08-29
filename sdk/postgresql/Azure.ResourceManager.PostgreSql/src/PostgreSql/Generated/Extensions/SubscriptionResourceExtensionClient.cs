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
using Azure.ResourceManager.PostgreSql.Models;

namespace Azure.ResourceManager.PostgreSql
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _postgreSqlServerServersClientDiagnostics;
        private ServersRestOperations _postgreSqlServerServersRestClient;
        private ClientDiagnostics _locationBasedPerformanceTierClientDiagnostics;
        private LocationBasedPerformanceTierRestOperations _locationBasedPerformanceTierRestClient;
        private ClientDiagnostics _checkNameAvailabilityClientDiagnostics;
        private CheckNameAvailabilityRestOperations _checkNameAvailabilityRestClient;

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

        private ClientDiagnostics PostgreSqlServerServersClientDiagnostics => _postgreSqlServerServersClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql", PostgreSqlServerResource.ResourceType.Namespace, Diagnostics);
        private ServersRestOperations PostgreSqlServerServersRestClient => _postgreSqlServerServersRestClient ??= new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(PostgreSqlServerResource.ResourceType));
        private ClientDiagnostics LocationBasedPerformanceTierClientDiagnostics => _locationBasedPerformanceTierClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private LocationBasedPerformanceTierRestOperations LocationBasedPerformanceTierRestClient => _locationBasedPerformanceTierRestClient ??= new LocationBasedPerformanceTierRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
        private ClientDiagnostics CheckNameAvailabilityClientDiagnostics => _checkNameAvailabilityClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.PostgreSql", ProviderConstants.DefaultProviderNamespace, Diagnostics);
        private CheckNameAvailabilityRestOperations CheckNameAvailabilityRestClient => _checkNameAvailabilityRestClient ??= new CheckNameAvailabilityRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlServerResource> GetPostgreSqlServersAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PostgreSqlServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, (e, o) => new PostgreSqlServerResource(Client, PostgreSqlServerData.DeserializePostgreSqlServerData(e)), PostgreSqlServerServersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetPostgreSqlServers", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlServerResource> GetPostgreSqlServers(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => PostgreSqlServerServersRestClient.CreateListRequest(Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, (e, o) => new PostgreSqlServerResource(Client, PostgreSqlServerData.DeserializePostgreSqlServerData(e)), PostgreSqlServerServersClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetPostgreSqlServers", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/performanceTiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedPerformanceTier_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlPerformanceTierProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<PostgreSqlPerformanceTierProperties> GetLocationBasedPerformanceTiersAsync(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationBasedPerformanceTierRestClient.CreateListRequest(Id.SubscriptionId, locationName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, null, PostgreSqlPerformanceTierProperties.DeserializePostgreSqlPerformanceTierProperties, LocationBasedPerformanceTierClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLocationBasedPerformanceTiers", "value", null, cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/performanceTiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedPerformanceTier_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlPerformanceTierProperties" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<PostgreSqlPerformanceTierProperties> GetLocationBasedPerformanceTiers(AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => LocationBasedPerformanceTierRestClient.CreateListRequest(Id.SubscriptionId, locationName);
            return PageableHelpers.CreatePageable(FirstPageRequest, null, PostgreSqlPerformanceTierProperties.DeserializePostgreSqlPerformanceTierProperties, LocationBasedPerformanceTierClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetLocationBasedPerformanceTiers", "value", null, cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PostgreSqlNameAvailabilityResult>> CheckPostgreSqlNameAvailabilityAsync(PostgreSqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckPostgreSqlNameAvailability");
            scope.Start();
            try
            {
                var response = await CheckNameAvailabilityRestClient.ExecuteAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailability_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PostgreSqlNameAvailabilityResult> CheckPostgreSqlNameAvailability(PostgreSqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = CheckNameAvailabilityClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckPostgreSqlNameAvailability");
            scope.Start();
            try
            {
                var response = CheckNameAvailabilityRestClient.Execute(Id.SubscriptionId, content, cancellationToken);
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
