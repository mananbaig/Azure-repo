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
using Azure.ResourceManager.ContainerInstance.Mocking;
using Azure.ResourceManager.ContainerInstance.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.ContainerInstance
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.ContainerInstance. </summary>
    public static partial class ContainerInstanceExtensions
    {
        private static MockableContainerInstanceArmClient GetMockableContainerInstanceArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableContainerInstanceArmClient(client0));
        }

        private static MockableContainerInstanceResourceGroupResource GetMockableContainerInstanceResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableContainerInstanceResourceGroupResource(client, resource.Id));
        }

        private static MockableContainerInstanceSubscriptionResource GetMockableContainerInstanceSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableContainerInstanceSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="ContainerGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ContainerGroupResource.CreateResourceIdentifier" /> to create a <see cref="ContainerGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceArmClient.GetContainerGroupResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="ContainerGroupResource" /> object. </returns>
        public static ContainerGroupResource GetContainerGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableContainerInstanceArmClient(client).GetContainerGroupResource(id);
        }

        /// <summary>
        /// Gets a collection of ContainerGroupResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceResourceGroupResource.GetContainerGroups()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of ContainerGroupResources and their operations over a ContainerGroupResource. </returns>
        public static ContainerGroupCollection GetContainerGroups(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableContainerInstanceResourceGroupResource(resourceGroupResource).GetContainerGroups();
        }

        /// <summary>
        /// Gets the properties of the specified container group in the specified subscription and resource group. The operation returns the properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceResourceGroupResource.GetContainerGroupAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="containerGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ContainerGroupResource>> GetContainerGroupAsync(this ResourceGroupResource resourceGroupResource, string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableContainerInstanceResourceGroupResource(resourceGroupResource).GetContainerGroupAsync(containerGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the properties of the specified container group in the specified subscription and resource group. The operation returns the properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerInstance/containerGroups/{containerGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceResourceGroupResource.GetContainerGroup(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="containerGroupName"> The name of the container group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="containerGroupName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="containerGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<ContainerGroupResource> GetContainerGroup(this ResourceGroupResource resourceGroupResource, string containerGroupName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableContainerInstanceResourceGroupResource(resourceGroupResource).GetContainerGroup(containerGroupName, cancellationToken);
        }

        /// <summary>
        /// Delete container group virtual network association links. The operation does not delete other resources provided by the user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}/providers/Microsoft.ContainerInstance/serviceAssociationLinks/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubnetServiceAssociationLink_Delete</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceResourceGroupResource.DeleteSubnetServiceAssociationLink(WaitUntil,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is null. </exception>
        public static async Task<ArmOperation> DeleteSubnetServiceAssociationLinkAsync(this ResourceGroupResource resourceGroupResource, WaitUntil waitUntil, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableContainerInstanceResourceGroupResource(resourceGroupResource).DeleteSubnetServiceAssociationLinkAsync(waitUntil, virtualNetworkName, subnetName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Delete container group virtual network association links. The operation does not delete other resources provided by the user.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}/providers/Microsoft.ContainerInstance/serviceAssociationLinks/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SubnetServiceAssociationLink_Delete</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceResourceGroupResource.DeleteSubnetServiceAssociationLink(WaitUntil,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="virtualNetworkName"> The name of the virtual network. </param>
        /// <param name="subnetName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/>, <paramref name="virtualNetworkName"/> or <paramref name="subnetName"/> is null. </exception>
        public static ArmOperation DeleteSubnetServiceAssociationLink(this ResourceGroupResource resourceGroupResource, WaitUntil waitUntil, string virtualNetworkName, string subnetName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableContainerInstanceResourceGroupResource(resourceGroupResource).DeleteSubnetServiceAssociationLink(waitUntil, virtualNetworkName, subnetName, cancellationToken);
        }

        /// <summary>
        /// Get a list of container groups in the specified subscription. This operation returns properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/containerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetContainerGroups(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ContainerGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ContainerGroupResource> GetContainerGroupsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetContainerGroupsAsync(cancellationToken);
        }

        /// <summary>
        /// Get a list of container groups in the specified subscription. This operation returns properties of each container group including containers, image registry credentials, restart policy, IP address type, OS type, state, and volumes.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/containerGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContainerGroups_List</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetContainerGroups(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ContainerGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ContainerGroupResource> GetContainerGroups(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetContainerGroups(cancellationToken);
        }

        /// <summary>
        /// Get the usage for a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListUsage</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetUsagesWithLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The identifier for the physical azure location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ContainerInstanceUsage" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ContainerInstanceUsage> GetUsagesWithLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetUsagesWithLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Get the usage for a subscription
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/usages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListUsage</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetUsagesWithLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The identifier for the physical azure location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ContainerInstanceUsage" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ContainerInstanceUsage> GetUsagesWithLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetUsagesWithLocation(location, cancellationToken);
        }

        /// <summary>
        /// Get the list of cached images on specific OS type for a subscription in a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/cachedImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCachedImages</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetCachedImagesWithLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The identifier for the physical azure location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="CachedImages" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<CachedImages> GetCachedImagesWithLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetCachedImagesWithLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Get the list of cached images on specific OS type for a subscription in a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/cachedImages</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCachedImages</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetCachedImagesWithLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The identifier for the physical azure location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="CachedImages" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<CachedImages> GetCachedImagesWithLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetCachedImagesWithLocation(location, cancellationToken);
        }

        /// <summary>
        /// Get the list of CPU/memory/GPU capabilities of a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCapabilities</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetCapabilitiesWithLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The identifier for the physical azure location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="ContainerCapabilities" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ContainerCapabilities> GetCapabilitiesWithLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetCapabilitiesWithLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Get the list of CPU/memory/GPU capabilities of a region.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerInstance/locations/{location}/capabilities</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Location_ListCapabilities</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableContainerInstanceSubscriptionResource.GetCapabilitiesWithLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The identifier for the physical azure location. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="ContainerCapabilities" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ContainerCapabilities> GetCapabilitiesWithLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableContainerInstanceSubscriptionResource(subscriptionResource).GetCapabilitiesWithLocation(location, cancellationToken);
        }
    }
}
