// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.StandbyPool.Mocking;

namespace Azure.ResourceManager.StandbyPool
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StandbyPool. </summary>
    public static partial class StandbyPoolExtensions
    {
        private static MockableStandbyPoolArmClient GetMockableStandbyPoolArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableStandbyPoolArmClient(client0));
        }

        private static MockableStandbyPoolResourceGroupResource GetMockableStandbyPoolResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableStandbyPoolResourceGroupResource(client, resource.Id));
        }

        private static MockableStandbyPoolSubscriptionResource GetMockableStandbyPoolSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableStandbyPoolSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyVirtualMachinePoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyVirtualMachinePoolResource.CreateResourceIdentifier" /> to create a <see cref="StandbyVirtualMachinePoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolArmClient.GetStandbyVirtualMachinePoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="StandbyVirtualMachinePoolResource"/> object. </returns>
        public static StandbyVirtualMachinePoolResource GetStandbyVirtualMachinePoolResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStandbyPoolArmClient(client).GetStandbyVirtualMachinePoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyVirtualMachineResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyVirtualMachineResource.CreateResourceIdentifier" /> to create a <see cref="StandbyVirtualMachineResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolArmClient.GetStandbyVirtualMachineResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="StandbyVirtualMachineResource"/> object. </returns>
        public static StandbyVirtualMachineResource GetStandbyVirtualMachineResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStandbyPoolArmClient(client).GetStandbyVirtualMachineResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyVirtualMachinePoolRuntimeViewResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyVirtualMachinePoolRuntimeViewResource.CreateResourceIdentifier" /> to create a <see cref="StandbyVirtualMachinePoolRuntimeViewResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolArmClient.GetStandbyVirtualMachinePoolRuntimeViewResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="StandbyVirtualMachinePoolRuntimeViewResource"/> object. </returns>
        public static StandbyVirtualMachinePoolRuntimeViewResource GetStandbyVirtualMachinePoolRuntimeViewResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStandbyPoolArmClient(client).GetStandbyVirtualMachinePoolRuntimeViewResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyContainerGroupPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyContainerGroupPoolResource.CreateResourceIdentifier" /> to create a <see cref="StandbyContainerGroupPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolArmClient.GetStandbyContainerGroupPoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="StandbyContainerGroupPoolResource"/> object. </returns>
        public static StandbyContainerGroupPoolResource GetStandbyContainerGroupPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStandbyPoolArmClient(client).GetStandbyContainerGroupPoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StandbyContainerGroupPoolRuntimeViewResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StandbyContainerGroupPoolRuntimeViewResource.CreateResourceIdentifier" /> to create a <see cref="StandbyContainerGroupPoolRuntimeViewResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolArmClient.GetStandbyContainerGroupPoolRuntimeViewResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="client"/> is null. </exception>
        /// <returns> Returns a <see cref="StandbyContainerGroupPoolRuntimeViewResource"/> object. </returns>
        public static StandbyContainerGroupPoolRuntimeViewResource GetStandbyContainerGroupPoolRuntimeViewResource(this ArmClient client, ResourceIdentifier id)
        {
            Argument.AssertNotNull(client, nameof(client));

            return GetMockableStandbyPoolArmClient(client).GetStandbyContainerGroupPoolRuntimeViewResource(id);
        }

        /// <summary>
        /// Gets a collection of StandbyVirtualMachinePoolResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolResourceGroupResource.GetStandbyVirtualMachinePools()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of StandbyVirtualMachinePoolResources and their operations over a StandbyVirtualMachinePoolResource. </returns>
        public static StandbyVirtualMachinePoolCollection GetStandbyVirtualMachinePools(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableStandbyPoolResourceGroupResource(resourceGroupResource).GetStandbyVirtualMachinePools();
        }

        /// <summary>
        /// Get a StandbyVirtualMachinePoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolResourceGroupResource.GetStandbyVirtualMachinePoolAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StandbyVirtualMachinePoolResource>> GetStandbyVirtualMachinePoolAsync(this ResourceGroupResource resourceGroupResource, string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableStandbyPoolResourceGroupResource(resourceGroupResource).GetStandbyVirtualMachinePoolAsync(standbyVirtualMachinePoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a StandbyVirtualMachinePoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools/{standbyVirtualMachinePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolResourceGroupResource.GetStandbyVirtualMachinePool(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="standbyVirtualMachinePoolName"> Name of the standby virtual machine pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="standbyVirtualMachinePoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyVirtualMachinePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<StandbyVirtualMachinePoolResource> GetStandbyVirtualMachinePool(this ResourceGroupResource resourceGroupResource, string standbyVirtualMachinePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableStandbyPoolResourceGroupResource(resourceGroupResource).GetStandbyVirtualMachinePool(standbyVirtualMachinePoolName, cancellationToken);
        }

        /// <summary>
        /// Gets a collection of StandbyContainerGroupPoolResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolResourceGroupResource.GetStandbyContainerGroupPools()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> is null. </exception>
        /// <returns> An object representing collection of StandbyContainerGroupPoolResources and their operations over a StandbyContainerGroupPoolResource. </returns>
        public static StandbyContainerGroupPoolCollection GetStandbyContainerGroupPools(this ResourceGroupResource resourceGroupResource)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableStandbyPoolResourceGroupResource(resourceGroupResource).GetStandbyContainerGroupPools();
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolResourceGroupResource.GetStandbyContainerGroupPoolAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StandbyContainerGroupPoolResource>> GetStandbyContainerGroupPoolAsync(this ResourceGroupResource resourceGroupResource, string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return await GetMockableStandbyPoolResourceGroupResource(resourceGroupResource).GetStandbyContainerGroupPoolAsync(standbyContainerGroupPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a StandbyContainerGroupPoolResource
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StandbyPool/standbyContainerGroupPools/{standbyContainerGroupPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPools_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolResourceGroupResource.GetStandbyContainerGroupPool(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="standbyContainerGroupPoolName"> Name of the standby container group pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceGroupResource"/> or <paramref name="standbyContainerGroupPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="standbyContainerGroupPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<StandbyContainerGroupPoolResource> GetStandbyContainerGroupPool(this ResourceGroupResource resourceGroupResource, string standbyContainerGroupPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(resourceGroupResource, nameof(resourceGroupResource));

            return GetMockableStandbyPoolResourceGroupResource(resourceGroupResource).GetStandbyContainerGroupPool(standbyContainerGroupPoolName, cancellationToken);
        }

        /// <summary>
        /// List StandbyVirtualMachinePoolResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolSubscriptionResource.GetStandbyVirtualMachinePools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="StandbyVirtualMachinePoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StandbyVirtualMachinePoolResource> GetStandbyVirtualMachinePoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStandbyPoolSubscriptionResource(subscriptionResource).GetStandbyVirtualMachinePoolsAsync(cancellationToken);
        }

        /// <summary>
        /// List StandbyVirtualMachinePoolResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StandbyPool/standbyVirtualMachinePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyVirtualMachinePoolResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyVirtualMachinePoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolSubscriptionResource.GetStandbyVirtualMachinePools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="StandbyVirtualMachinePoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StandbyVirtualMachinePoolResource> GetStandbyVirtualMachinePools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStandbyPoolSubscriptionResource(subscriptionResource).GetStandbyVirtualMachinePools(cancellationToken);
        }

        /// <summary>
        /// List StandbyContainerGroupPoolResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StandbyPool/standbyContainerGroupPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolSubscriptionResource.GetStandbyContainerGroupPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> An async collection of <see cref="StandbyContainerGroupPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StandbyContainerGroupPoolResource> GetStandbyContainerGroupPoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStandbyPoolSubscriptionResource(subscriptionResource).GetStandbyContainerGroupPoolsAsync(cancellationToken);
        }

        /// <summary>
        /// List StandbyContainerGroupPoolResource resources by subscription ID
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StandbyPool/standbyContainerGroupPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StandbyContainerGroupPoolResource_ListBySubscription</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-03-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="StandbyContainerGroupPoolResource"/></description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableStandbyPoolSubscriptionResource.GetStandbyContainerGroupPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> is null. </exception>
        /// <returns> A collection of <see cref="StandbyContainerGroupPoolResource"/> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StandbyContainerGroupPoolResource> GetStandbyContainerGroupPools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableStandbyPoolSubscriptionResource(subscriptionResource).GetStandbyContainerGroupPools(cancellationToken);
        }
    }
}
