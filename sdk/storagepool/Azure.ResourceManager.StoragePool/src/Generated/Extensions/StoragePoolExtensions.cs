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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StoragePool.Mocking;
using Azure.ResourceManager.StoragePool.Models;

namespace Azure.ResourceManager.StoragePool
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StoragePool. </summary>
    public static partial class StoragePoolExtensions
    {
        private static MockableStoragePoolArmClient GetMockableStoragePoolArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableStoragePoolArmClient(client0));
        }

        private static MockableStoragePoolResourceGroupResource GetMockableStoragePoolResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableStoragePoolResourceGroupResource(client, resource.Id));
        }

        private static MockableStoragePoolSubscriptionResource GetMockableStoragePoolSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableStoragePoolSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskPoolResource.CreateResourceIdentifier" /> to create a <see cref="DiskPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolArmClient.GetDiskPoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DiskPoolResource"/> object. </returns>
        public static DiskPoolResource GetDiskPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStoragePoolArmClient(client).GetDiskPoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DiskPoolIscsiTargetResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DiskPoolIscsiTargetResource.CreateResourceIdentifier" /> to create a <see cref="DiskPoolIscsiTargetResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolArmClient.GetDiskPoolIscsiTargetResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="DiskPoolIscsiTargetResource"/> object. </returns>
        public static DiskPoolIscsiTargetResource GetDiskPoolIscsiTargetResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStoragePoolArmClient(client).GetDiskPoolIscsiTargetResource(id);
        }

        /// <summary>
        /// Gets a collection of DiskPoolResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolResourceGroupResource.GetDiskPools()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of DiskPoolResources and their operations over a DiskPoolResource. </returns>
        public static DiskPoolCollection GetDiskPools(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableStoragePoolResourceGroupResource(resourceGroupResource).GetDiskPools();
        }

        /// <summary>
        /// Get a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolResourceGroupResource.GetDiskPoolAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="diskPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DiskPoolResource>> GetDiskPoolAsync(this ResourceGroupResource resourceGroupResource, string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableStoragePoolResourceGroupResource(resourceGroupResource).GetDiskPoolAsync(diskPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a Disk pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StoragePool/diskPools/{diskPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolResourceGroupResource.GetDiskPool(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="diskPoolName"> The name of the Disk Pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="diskPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="diskPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<DiskPoolResource> GetDiskPool(this ResourceGroupResource resourceGroupResource, string diskPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableStoragePoolResourceGroupResource(resourceGroupResource).GetDiskPool(diskPoolName, cancellationToken);
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolSubscriptionResource.GetDiskPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DiskPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DiskPoolResource> GetDiskPoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStoragePoolSubscriptionResource(subscriptionResource).GetDiskPoolsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets a list of Disk Pools in a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/diskPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolSubscriptionResource.GetDiskPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DiskPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DiskPoolResource> GetDiskPools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStoragePoolSubscriptionResource(subscriptionResource).GetDiskPools(cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPoolZones_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolSubscriptionResource.GetDiskPoolZones(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="DiskPoolZoneInfo"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DiskPoolZoneInfo> GetDiskPoolZonesAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStoragePoolSubscriptionResource(subscriptionResource).GetDiskPoolZonesAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists available Disk Pool Skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/diskPoolZones</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>DiskPoolZones_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolSubscriptionResource.GetDiskPoolZones(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="DiskPoolZoneInfo"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DiskPoolZoneInfo> GetDiskPoolZones(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStoragePoolSubscriptionResource(subscriptionResource).GetDiskPoolZones(location, cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceSkus_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolSubscriptionResource.GetResourceSkus(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="StoragePoolSkuInfo"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StoragePoolSkuInfo> GetResourceSkusAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStoragePoolSubscriptionResource(subscriptionResource).GetResourceSkusAsync(location, cancellationToken);
        }

        /// <summary>
        /// Lists available StoragePool resources and skus in an Azure location.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StoragePool/locations/{location}/skus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourceSkus_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStoragePoolSubscriptionResource.GetResourceSkus(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="StoragePoolSkuInfo"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StoragePoolSkuInfo> GetResourceSkus(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStoragePoolSubscriptionResource(subscriptionResource).GetResourceSkus(location, cancellationToken);
        }
    }
}
