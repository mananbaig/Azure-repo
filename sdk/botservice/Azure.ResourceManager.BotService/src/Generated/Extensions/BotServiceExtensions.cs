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
using Azure.ResourceManager.BotService.Mocking;
using Azure.ResourceManager.BotService.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.BotService
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.BotService. </summary>
    public static partial class BotServiceExtensions
    {
        private static BotServiceArmClientMockingExtension GetBotServiceArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new BotServiceArmClientMockingExtension(client);
            });
        }

        private static BotServiceResourceGroupMockingExtension GetBotServiceResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new BotServiceResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static BotServiceSubscriptionMockingExtension GetBotServiceSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new BotServiceSubscriptionMockingExtension(client, resource.Id);
            });
        }

        private static BotServiceTenantMockingExtension GetBotServiceTenantMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new BotServiceTenantMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="BotResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BotResource.CreateResourceIdentifier" /> to create a <see cref="BotResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BotResource" /> object. </returns>
        public static BotResource GetBotResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBotServiceArmClientMockingExtension(client).GetBotResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BotChannelResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BotChannelResource.CreateResourceIdentifier" /> to create a <see cref="BotChannelResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BotChannelResource" /> object. </returns>
        public static BotChannelResource GetBotChannelResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBotServiceArmClientMockingExtension(client).GetBotChannelResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BotConnectionSettingResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BotConnectionSettingResource.CreateResourceIdentifier" /> to create a <see cref="BotConnectionSettingResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BotConnectionSettingResource" /> object. </returns>
        public static BotConnectionSettingResource GetBotConnectionSettingResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBotServiceArmClientMockingExtension(client).GetBotConnectionSettingResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BotServicePrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BotServicePrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="BotServicePrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BotServicePrivateEndpointConnectionResource" /> object. </returns>
        public static BotServicePrivateEndpointConnectionResource GetBotServicePrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetBotServiceArmClientMockingExtension(client).GetBotServicePrivateEndpointConnectionResource(id);
        }

        /// <summary> Gets a collection of BotResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of BotResources and their operations over a BotResource. </returns>
        public static BotCollection GetBots(this ResourceGroupResource resourceGroupResource)
        {
            return GetBotServiceResourceGroupMockingExtension(resourceGroupResource).GetBots();
        }

        /// <summary>
        /// Returns a BotService specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BotResource>> GetBotAsync(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return await GetBotServiceResourceGroupMockingExtension(resourceGroupResource).GetBotAsync(resourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns a BotService specified by the parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.BotService/botServices/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="resourceName"> The name of the Bot resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<BotResource> GetBot(this ResourceGroupResource resourceGroupResource, string resourceName, CancellationToken cancellationToken = default)
        {
            return GetBotServiceResourceGroupMockingExtension(resourceGroupResource).GetBot(resourceName, cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/botServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BotResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<BotResource> GetBotsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotsAsync(cancellationToken);
        }

        /// <summary>
        /// Returns all the resources of a particular type belonging to a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/botServices</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BotResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<BotResource> GetBots(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBots(cancellationToken);
        }

        /// <summary>
        /// Lists the available Service Providers for creating Connection Settings
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listAuthServiceProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_ListServiceProviders</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BotServiceProvider" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<BotServiceProvider> GetBotConnectionServiceProvidersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotConnectionServiceProvidersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists the available Service Providers for creating Connection Settings
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listAuthServiceProviders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>BotConnection_ListServiceProviders</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BotServiceProvider" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<BotServiceProvider> GetBotConnectionServiceProviders(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotConnectionServiceProviders(cancellationToken);
        }

        /// <summary>
        /// Lists the QnA Maker endpoint keys
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listQnAMakerEndpointKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QnAMakerEndpointKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<GetBotServiceQnAMakerEndpointKeyResult>> GetBotServiceQnAMakerEndpointKeyAsync(this SubscriptionResource subscriptionResource, GetBotServiceQnAMakerEndpointKeyContent content, CancellationToken cancellationToken = default)
        {
            return await GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotServiceQnAMakerEndpointKeyAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Lists the QnA Maker endpoint keys
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/listQnAMakerEndpointKeys</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>QnAMakerEndpointKeys_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<GetBotServiceQnAMakerEndpointKeyResult> GetBotServiceQnAMakerEndpointKey(this SubscriptionResource subscriptionResource, GetBotServiceQnAMakerEndpointKeyContent content, CancellationToken cancellationToken = default)
        {
            return GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotServiceQnAMakerEndpointKey(content, cancellationToken);
        }

        /// <summary>
        /// Get per subscription settings needed to host bot in compute resource such as Azure App Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/hostSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static async Task<Response<BotServiceHostSettingsResult>> GetBotServiceHostSettingsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return await GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotServiceHostSettingsAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get per subscription settings needed to host bot in compute resource such as Azure App Service
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.BotService/hostSettings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HostSettings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public static Response<BotServiceHostSettingsResult> GetBotServiceHostSettings(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetBotServiceSubscriptionMockingExtension(subscriptionResource).GetBotServiceHostSettings(cancellationToken);
        }

        /// <summary>
        /// Check whether a bot name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BotService/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_GetCheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<BotServiceNameAvailabilityResult>> CheckBotServiceNameAvailabilityAsync(this TenantResource tenantResource, BotServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetBotServiceTenantMockingExtension(tenantResource).CheckBotServiceNameAvailabilityAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check whether a bot name is available.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.BotService/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Bots_GetCheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="content"> The request body parameters to provide for the check name availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<BotServiceNameAvailabilityResult> CheckBotServiceNameAvailability(this TenantResource tenantResource, BotServiceNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetBotServiceTenantMockingExtension(tenantResource).CheckBotServiceNameAvailability(content, cancellationToken);
        }
    }
}
