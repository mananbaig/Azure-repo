// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.MySql.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MySql
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.MySql. </summary>
    public static partial class MySqlExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MySqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MySqlServerResource> GetMySqlServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMySqlServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/servers
        /// Operation Id: Servers_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MySqlServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MySqlServerResource> GetMySqlServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetMySqlServers(cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/performanceTiers
        /// Operation Id: LocationBasedPerformanceTier_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> An async collection of <see cref="MySqlPerformanceTier" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MySqlPerformanceTier> GetLocationBasedPerformanceTiersAsync(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(subscriptionResource).GetLocationBasedPerformanceTiersAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// List all the performance tiers at specified location in a given subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/performanceTiers
        /// Operation Id: LocationBasedPerformanceTier_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> is null. </exception>
        /// <returns> A collection of <see cref="MySqlPerformanceTier" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MySqlPerformanceTier> GetLocationBasedPerformanceTiers(this SubscriptionResource subscriptionResource, string locationName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));

            return GetExtensionClient(subscriptionResource).GetLocationBasedPerformanceTiers(locationName, cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<MySqlNameAvailabilityResult>> CheckMySqlNameAvailabilityAsync(this SubscriptionResource subscriptionResource, MySqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckMySqlNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/checkNameAvailability
        /// Operation Id: CheckNameAvailability_Execute
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<MySqlNameAvailabilityResult> CheckMySqlNameAvailability(this SubscriptionResource subscriptionResource, MySqlNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckMySqlNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Recommendation action session operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsAzureAsyncOperation/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsOperationStatus_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<MySqlRecommendedActionSessionsOperationStatus>> GetRecommendedActionSessionsOperationStatusAsync(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetRecommendedActionSessionsOperationStatusAsync(locationName, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Recommendation action session operation status.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsAzureAsyncOperation/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsOperationStatus_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        public static Response<MySqlRecommendedActionSessionsOperationStatus> GetRecommendedActionSessionsOperationStatus(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetRecommendedActionSessionsOperationStatus(locationName, operationId, cancellationToken);
        }

        /// <summary>
        /// Recommendation action session operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsOperationResults/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsResult_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        /// <returns> An async collection of <see cref="MySqlRecommendationActionResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MySqlRecommendationActionResource> GetRecommendedActionSessionsOperationResultsAsync(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetRecommendedActionSessionsOperationResultsAsync(locationName, operationId, cancellationToken);
        }

        /// <summary>
        /// Recommendation action session operation result.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DBforMySQL/locations/{locationName}/recommendedActionSessionsOperationResults/{operationId}
        /// Operation Id: LocationBasedRecommendedActionSessionsResult_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="operationId"> The operation identifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="locationName"/> or <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="locationName"/> or <paramref name="operationId"/> is null. </exception>
        /// <returns> A collection of <see cref="MySqlRecommendationActionResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MySqlRecommendationActionResource> GetRecommendedActionSessionsOperationResults(this SubscriptionResource subscriptionResource, string locationName, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(locationName, nameof(locationName));
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetRecommendedActionSessionsOperationResults(locationName, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of MySqlServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MySqlServerResources and their operations over a MySqlServerResource. </returns>
        public static MySqlServerCollection GetMySqlServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetMySqlServers();
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MySqlServerResource>> GetMySqlServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetMySqlServers().GetAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforMySQL/servers/{serverName}
        /// Operation Id: Servers_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MySqlServerResource> GetMySqlServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetMySqlServers().Get(serverName, cancellationToken);
        }

        #region MySqlServerResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerResource" /> object. </returns>
        public static MySqlServerResource GetMySqlServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlServerResource.ValidateResourceId(id);
                return new MySqlServerResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlFirewallRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="MySqlFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlFirewallRuleResource" /> object. </returns>
        public static MySqlFirewallRuleResource GetMySqlFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlFirewallRuleResource.ValidateResourceId(id);
                return new MySqlFirewallRuleResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlVirtualNetworkRuleResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlVirtualNetworkRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlVirtualNetworkRuleResource.CreateResourceIdentifier" /> to create a <see cref="MySqlVirtualNetworkRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlVirtualNetworkRuleResource" /> object. </returns>
        public static MySqlVirtualNetworkRuleResource GetMySqlVirtualNetworkRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlVirtualNetworkRuleResource.ValidateResourceId(id);
                return new MySqlVirtualNetworkRuleResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlDatabaseResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="MySqlDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlDatabaseResource" /> object. </returns>
        public static MySqlDatabaseResource GetMySqlDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlDatabaseResource.ValidateResourceId(id);
                return new MySqlDatabaseResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlConfigurationResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="MySqlConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlConfigurationResource" /> object. </returns>
        public static MySqlConfigurationResource GetMySqlConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlConfigurationResource.ValidateResourceId(id);
                return new MySqlConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlServerAdministratorResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerAdministratorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerAdministratorResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerAdministratorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerAdministratorResource" /> object. </returns>
        public static MySqlServerAdministratorResource GetMySqlServerAdministratorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlServerAdministratorResource.ValidateResourceId(id);
                return new MySqlServerAdministratorResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlServerSecurityAlertPolicyResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerSecurityAlertPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerSecurityAlertPolicyResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerSecurityAlertPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerSecurityAlertPolicyResource" /> object. </returns>
        public static MySqlServerSecurityAlertPolicyResource GetMySqlServerSecurityAlertPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlServerSecurityAlertPolicyResource.ValidateResourceId(id);
                return new MySqlServerSecurityAlertPolicyResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlQueryTextResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlQueryTextResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlQueryTextResource.CreateResourceIdentifier" /> to create a <see cref="MySqlQueryTextResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlQueryTextResource" /> object. </returns>
        public static MySqlQueryTextResource GetMySqlQueryTextResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlQueryTextResource.ValidateResourceId(id);
                return new MySqlQueryTextResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlQueryStatisticResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlQueryStatisticResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlQueryStatisticResource.CreateResourceIdentifier" /> to create a <see cref="MySqlQueryStatisticResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlQueryStatisticResource" /> object. </returns>
        public static MySqlQueryStatisticResource GetMySqlQueryStatisticResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlQueryStatisticResource.ValidateResourceId(id);
                return new MySqlQueryStatisticResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlWaitStatisticResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlWaitStatisticResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlWaitStatisticResource.CreateResourceIdentifier" /> to create a <see cref="MySqlWaitStatisticResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlWaitStatisticResource" /> object. </returns>
        public static MySqlWaitStatisticResource GetMySqlWaitStatisticResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlWaitStatisticResource.ValidateResourceId(id);
                return new MySqlWaitStatisticResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlAdvisorResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlAdvisorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlAdvisorResource.CreateResourceIdentifier" /> to create a <see cref="MySqlAdvisorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlAdvisorResource" /> object. </returns>
        public static MySqlAdvisorResource GetMySqlAdvisorResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlAdvisorResource.ValidateResourceId(id);
                return new MySqlAdvisorResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlRecommendationActionResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlRecommendationActionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlRecommendationActionResource.CreateResourceIdentifier" /> to create a <see cref="MySqlRecommendationActionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlRecommendationActionResource" /> object. </returns>
        public static MySqlRecommendationActionResource GetMySqlRecommendationActionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlRecommendationActionResource.ValidateResourceId(id);
                return new MySqlRecommendationActionResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="MySqlPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlPrivateEndpointConnectionResource" /> object. </returns>
        public static MySqlPrivateEndpointConnectionResource GetMySqlPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new MySqlPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="MySqlPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlPrivateLinkResource" /> object. </returns>
        public static MySqlPrivateLinkResource GetMySqlPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlPrivateLinkResource.ValidateResourceId(id);
                return new MySqlPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region MySqlServerKeyResource
        /// <summary>
        /// Gets an object representing a <see cref="MySqlServerKeyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MySqlServerKeyResource.CreateResourceIdentifier" /> to create a <see cref="MySqlServerKeyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MySqlServerKeyResource" /> object. </returns>
        public static MySqlServerKeyResource GetMySqlServerKeyResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                MySqlServerKeyResource.ValidateResourceId(id);
                return new MySqlServerKeyResource(client, id);
            }
            );
        }
        #endregion
    }
}
