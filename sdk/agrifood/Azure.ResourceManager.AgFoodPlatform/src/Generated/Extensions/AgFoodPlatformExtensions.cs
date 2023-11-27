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
using Azure.ResourceManager.AgFoodPlatform.Mocking;
using Azure.ResourceManager.AgFoodPlatform.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AgFoodPlatform
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.AgFoodPlatform. </summary>
    public static partial class AgFoodPlatformExtensions
    {
        private static MockableAgFoodPlatformArmClient GetMockableAgFoodPlatformArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableAgFoodPlatformArmClient(client0));
        }

        private static MockableAgFoodPlatformResourceGroupResource GetMockableAgFoodPlatformResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAgFoodPlatformResourceGroupResource(client, resource.Id));
        }

        private static MockableAgFoodPlatformSubscriptionResource GetMockableAgFoodPlatformSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAgFoodPlatformSubscriptionResource(client, resource.Id));
        }

        private static MockableAgFoodPlatformTenantResource GetMockableAgFoodPlatformTenantResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableAgFoodPlatformTenantResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing an <see cref="ExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ExtensionResource.CreateResourceIdentifier" /> to create an <see cref="ExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformArmClient.GetExtensionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ExtensionResource"/> object. </returns>
        public static ExtensionResource GetExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAgFoodPlatformArmClient(client).GetExtensionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FarmBeatsExtensionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FarmBeatsExtensionResource.CreateResourceIdentifier" /> to create a <see cref="FarmBeatsExtensionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformArmClient.GetFarmBeatsExtensionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FarmBeatsExtensionResource"/> object. </returns>
        public static FarmBeatsExtensionResource GetFarmBeatsExtensionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAgFoodPlatformArmClient(client).GetFarmBeatsExtensionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FarmBeatResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FarmBeatResource.CreateResourceIdentifier" /> to create a <see cref="FarmBeatResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformArmClient.GetFarmBeatResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="FarmBeatResource"/> object. </returns>
        public static FarmBeatResource GetFarmBeatResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAgFoodPlatformArmClient(client).GetFarmBeatResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AgFoodPlatformPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgFoodPlatformPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AgFoodPlatformPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformArmClient.GetAgFoodPlatformPrivateEndpointConnectionResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AgFoodPlatformPrivateEndpointConnectionResource"/> object. </returns>
        public static AgFoodPlatformPrivateEndpointConnectionResource GetAgFoodPlatformPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAgFoodPlatformArmClient(client).GetAgFoodPlatformPrivateEndpointConnectionResource(id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AgFoodPlatformPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AgFoodPlatformPrivateLinkResource.CreateResourceIdentifier" /> to create an <see cref="AgFoodPlatformPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformArmClient.GetAgFoodPlatformPrivateLinkResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="AgFoodPlatformPrivateLinkResource"/> object. </returns>
        public static AgFoodPlatformPrivateLinkResource GetAgFoodPlatformPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableAgFoodPlatformArmClient(client).GetAgFoodPlatformPrivateLinkResource(id);
        }

        /// <summary>
        /// Gets a collection of FarmBeatResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformResourceGroupResource.GetFarmBeats()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of FarmBeatResources and their operations over a FarmBeatResource. </returns>
        public static FarmBeatCollection GetFarmBeats(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableAgFoodPlatformResourceGroupResource(resourceGroupResource).GetFarmBeats();
        }

        /// <summary>
        /// Get FarmBeats resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformResourceGroupResource.GetFarmBeatAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="farmBeatsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FarmBeatResource>> GetFarmBeatAsync(this ResourceGroupResource resourceGroupResource, string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableAgFoodPlatformResourceGroupResource(resourceGroupResource).GetFarmBeatAsync(farmBeatsResourceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get FarmBeats resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.AgFoodPlatform/farmBeats/{farmBeatsResourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformResourceGroupResource.GetFarmBeat(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="farmBeatsResourceName"> FarmBeats resource name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="farmBeatsResourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsResourceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<FarmBeatResource> GetFarmBeat(this ResourceGroupResource resourceGroupResource, string farmBeatsResourceName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableAgFoodPlatformResourceGroupResource(resourceGroupResource).GetFarmBeat(farmBeatsResourceName, cancellationToken);
        }

        /// <summary>
        /// Lists the FarmBeats instances for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/farmBeats</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformSubscriptionResource.GetFarmBeats(int?,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="FarmBeatResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<FarmBeatResource> GetFarmBeatsAsync(this SubscriptionResource subscriptionResource, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAgFoodPlatformSubscriptionResource(subscriptionResource).GetFarmBeatsAsync(maxPageSize, skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists the FarmBeats instances for a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/farmBeats</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsModels_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformSubscriptionResource.GetFarmBeats(int?,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="maxPageSize">
        /// Maximum number of items needed (inclusive).
        /// Minimum = 10, Maximum = 1000, Default value = 50.
        /// </param>
        /// <param name="skipToken"> Skip token for getting next set of results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="FarmBeatResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<FarmBeatResource> GetFarmBeats(this SubscriptionResource subscriptionResource, int? maxPageSize = null, string skipToken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAgFoodPlatformSubscriptionResource(subscriptionResource).GetFarmBeats(maxPageSize, skipToken, cancellationToken);
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformSubscriptionResource.CheckNameAvailabilityLocation(CheckNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckNameAvailabilityResponse>> CheckNameAvailabilityLocationAsync(this SubscriptionResource subscriptionResource, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableAgFoodPlatformSubscriptionResource(subscriptionResource).CheckNameAvailabilityLocationAsync(content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks the name availability of the resource with requested resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AgFoodPlatform/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformSubscriptionResource.CheckNameAvailabilityLocation(CheckNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="content"> NameAvailabilityRequest object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="content"/> is null. </exception>
        public static Response<CheckNameAvailabilityResponse> CheckNameAvailabilityLocation(this SubscriptionResource subscriptionResource, CheckNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableAgFoodPlatformSubscriptionResource(subscriptionResource).CheckNameAvailabilityLocation(content, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of FarmBeatsExtensionResources in the TenantResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformTenantResource.GetFarmBeatsExtensions()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> is null. </exception>
        /// <returns> An object representing collection of FarmBeatsExtensionResources and their operations over a FarmBeatsExtensionResource. </returns>
        public static FarmBeatsExtensionCollection GetFarmBeatsExtensions(this TenantResource tenantResource)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableAgFoodPlatformTenantResource(tenantResource).GetFarmBeatsExtensions();
        }

        /// <summary>
        /// Get farmBeats extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsExtensions_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformTenantResource.GetFarmBeatsExtensionAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="farmBeatsExtensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<FarmBeatsExtensionResource>> GetFarmBeatsExtensionAsync(this TenantResource tenantResource, string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return await GetMockableAgFoodPlatformTenantResource(tenantResource).GetFarmBeatsExtensionAsync(farmBeatsExtensionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get farmBeats extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsExtensions_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableAgFoodPlatformTenantResource.GetFarmBeatsExtension(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tenantResource"/> or <paramref name="farmBeatsExtensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<FarmBeatsExtensionResource> GetFarmBeatsExtension(this TenantResource tenantResource, string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(tenantResource, nameof(tenantResource));

            return GetMockableAgFoodPlatformTenantResource(tenantResource).GetFarmBeatsExtension(farmBeatsExtensionId, cancellationToken);
        }
    }
}
