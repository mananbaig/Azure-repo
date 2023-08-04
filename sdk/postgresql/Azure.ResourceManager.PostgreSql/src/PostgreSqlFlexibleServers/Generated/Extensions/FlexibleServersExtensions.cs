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
using Azure.ResourceManager.PostgreSql.FlexibleServers.Mocking;
using Azure.ResourceManager.PostgreSql.FlexibleServers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.PostgreSql.FlexibleServers. </summary>
    public static partial class FlexibleServersExtensions
    {
        private static FlexibleServersArmClientMockingExtension GetFlexibleServersArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new FlexibleServersArmClientMockingExtension(client);
            });
        }

        private static FlexibleServersResourceGroupMockingExtension GetFlexibleServersResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new FlexibleServersResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static FlexibleServersSubscriptionMockingExtension GetFlexibleServersSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new FlexibleServersSubscriptionMockingExtension(client, resource.Id);
            });
        }

        private static FlexibleServersTenantMockingExtension GetFlexibleServersTenantMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new FlexibleServersTenantMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFlexibleServerActiveDirectoryAdministratorResource" /> object. </returns>
        public static PostgreSqlFlexibleServerActiveDirectoryAdministratorResource GetPostgreSqlFlexibleServerActiveDirectoryAdministratorResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlFlexibleServerActiveDirectoryAdministratorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFlexibleServerBackupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFlexibleServerBackupResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFlexibleServerBackupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFlexibleServerBackupResource" /> object. </returns>
        public static PostgreSqlFlexibleServerBackupResource GetPostgreSqlFlexibleServerBackupResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlFlexibleServerBackupResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFlexibleServerConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFlexibleServerConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFlexibleServerConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFlexibleServerConfigurationResource" /> object. </returns>
        public static PostgreSqlFlexibleServerConfigurationResource GetPostgreSqlFlexibleServerConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlFlexibleServerConfigurationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFlexibleServerDatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFlexibleServerDatabaseResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFlexibleServerDatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFlexibleServerDatabaseResource" /> object. </returns>
        public static PostgreSqlFlexibleServerDatabaseResource GetPostgreSqlFlexibleServerDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlFlexibleServerDatabaseResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFlexibleServerFirewallRuleResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFlexibleServerFirewallRuleResource" /> object. </returns>
        public static PostgreSqlFlexibleServerFirewallRuleResource GetPostgreSqlFlexibleServerFirewallRuleResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlFlexibleServerFirewallRuleResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlFlexibleServerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlFlexibleServerResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlFlexibleServerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlFlexibleServerResource" /> object. </returns>
        public static PostgreSqlFlexibleServerResource GetPostgreSqlFlexibleServerResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlFlexibleServerResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlMigrationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlMigrationResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlMigrationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlMigrationResource" /> object. </returns>
        public static PostgreSqlMigrationResource GetPostgreSqlMigrationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlMigrationResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PostgreSqlLtrServerBackupOperationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PostgreSqlLtrServerBackupOperationResource.CreateResourceIdentifier" /> to create a <see cref="PostgreSqlLtrServerBackupOperationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PostgreSqlLtrServerBackupOperationResource" /> object. </returns>
        public static PostgreSqlLtrServerBackupOperationResource GetPostgreSqlLtrServerBackupOperationResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetFlexibleServersArmClientMockingExtension(client).GetPostgreSqlLtrServerBackupOperationResource(id);
        }

        /// <summary> Gets a collection of PostgreSqlFlexibleServerResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PostgreSqlFlexibleServerResources and their operations over a PostgreSqlFlexibleServerResource. </returns>
        public static PostgreSqlFlexibleServerCollection GetPostgreSqlFlexibleServers(this ResourceGroupResource resourceGroupResource)
        {
            return GetFlexibleServersResourceGroupMockingExtension(resourceGroupResource).GetPostgreSqlFlexibleServers();
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PostgreSqlFlexibleServerResource>> GetPostgreSqlFlexibleServerAsync(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return await GetFlexibleServersResourceGroupMockingExtension(resourceGroupResource).GetPostgreSqlFlexibleServerAsync(serverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about a server.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/flexibleServers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PostgreSqlFlexibleServerResource> GetPostgreSqlFlexibleServer(this ResourceGroupResource resourceGroupResource, string serverName, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersResourceGroupMockingExtension(resourceGroupResource).GetPostgreSqlFlexibleServer(serverName, cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilities_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PostgreSqlFlexibleServerCapabilityProperties> ExecuteLocationBasedCapabilitiesAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).ExecuteLocationBasedCapabilitiesAsync(locationName, cancellationToken);
        }

        /// <summary>
        /// Get capabilities at specified location in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LocationBasedCapabilities_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerCapabilityProperties" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PostgreSqlFlexibleServerCapabilityProperties> ExecuteLocationBasedCapabilities(this SubscriptionResource subscriptionResource, AzureLocation locationName, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).ExecuteLocationBasedCapabilities(locationName, cancellationToken);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<PostgreSqlFlexibleServerNameAvailabilityResult>> CheckPostgreSqlFlexibleServerNameAvailabilityAsync(this SubscriptionResource subscriptionResource, PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).CheckPostgreSqlFlexibleServerNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
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
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<PostgreSqlFlexibleServerNameAvailabilityResult> CheckPostgreSqlFlexibleServerNameAvailability(this SubscriptionResource subscriptionResource, PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).CheckPostgreSqlFlexibleServerNameAvailability(content, cancellationToken);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityWithLocation_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<PostgreSqlFlexibleServerNameAvailabilityResult>> CheckPostgreSqlFlexibleServerNameAvailabilityWithLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).CheckPostgreSqlFlexibleServerNameAvailabilityWithLocationAsync(locationName, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of name for resource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CheckNameAvailabilityWithLocation_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="content"> The required parameters for checking if resource name is available. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<PostgreSqlFlexibleServerNameAvailabilityResult> CheckPostgreSqlFlexibleServerNameAvailabilityWithLocation(this SubscriptionResource subscriptionResource, AzureLocation locationName, PostgreSqlFlexibleServerNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).CheckPostgreSqlFlexibleServerNameAvailabilityWithLocation(locationName, content, cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PostgreSqlFlexibleServerResource> GetPostgreSqlFlexibleServersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).GetPostgreSqlFlexibleServersAsync(cancellationToken);
        }

        /// <summary>
        /// List all the servers in a given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/flexibleServers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PostgreSqlFlexibleServerResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PostgreSqlFlexibleServerResource> GetPostgreSqlFlexibleServers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).GetPostgreSqlFlexibleServers(cancellationToken);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkVirtualNetworkSubnetUsage</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkSubnetUsage_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"/> is null. </exception>
        public static async Task<Response<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult>> ExecuteVirtualNetworkSubnetUsageAsync(this SubscriptionResource subscriptionResource, AzureLocation locationName, PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            return await GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).ExecuteVirtualNetworkSubnetUsageAsync(locationName, postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get virtual network subnet usage for a given vNet resource id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.DBforPostgreSQL/locations/{locationName}/checkVirtualNetworkSubnetUsage</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>VirtualNetworkSubnetUsage_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="locationName"> The name of the location. </param>
        /// <param name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"> The required parameters for creating or updating a server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter"/> is null. </exception>
        public static Response<PostgreSqlFlexibleServerVirtualNetworkSubnetUsageResult> ExecuteVirtualNetworkSubnetUsage(this SubscriptionResource subscriptionResource, AzureLocation locationName, PostgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersSubscriptionMockingExtension(subscriptionResource).ExecuteVirtualNetworkSubnetUsage(locationName, postgreSqlFlexibleServerVirtualNetworkSubnetUsageParameter, cancellationToken);
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DBforPostgreSQL/getPrivateDnsZoneSuffix</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetPrivateDnsZoneSuffix_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<string>> ExecuteGetPrivateDnsZoneSuffixAsync(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return await GetFlexibleServersTenantMockingExtension(tenantResource).ExecuteGetPrivateDnsZoneSuffixAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get private DNS zone suffix in the cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DBforPostgreSQL/getPrivateDnsZoneSuffix</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>GetPrivateDnsZoneSuffix_Execute</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<string> ExecuteGetPrivateDnsZoneSuffix(this TenantResource tenantResource, CancellationToken cancellationToken = default)
        {
            return GetFlexibleServersTenantMockingExtension(tenantResource).ExecuteGetPrivateDnsZoneSuffix(cancellationToken);
        }
    }
}
