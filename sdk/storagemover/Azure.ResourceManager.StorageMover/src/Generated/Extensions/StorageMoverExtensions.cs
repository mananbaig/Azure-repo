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
using Azure.ResourceManager.StorageMover.Mocking;

namespace Azure.ResourceManager.StorageMover
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.StorageMover. </summary>
    public static partial class StorageMoverExtensions
    {
        private static StorageMoverArmClientMockingExtension GetStorageMoverArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new StorageMoverArmClientMockingExtension(client);
            });
        }

        private static StorageMoverResourceGroupMockingExtension GetStorageMoverResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageMoverResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static StorageMoverSubscriptionMockingExtension GetStorageMoverSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new StorageMoverSubscriptionMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverResource" /> object. </returns>
        public static StorageMoverResource GetStorageMoverResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageMoverArmClientMockingExtension(client).GetStorageMoverResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverAgentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverAgentResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverAgentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverAgentResource" /> object. </returns>
        public static StorageMoverAgentResource GetStorageMoverAgentResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageMoverArmClientMockingExtension(client).GetStorageMoverAgentResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverEndpointResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverEndpointResource" /> object. </returns>
        public static StorageMoverEndpointResource GetStorageMoverEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageMoverArmClientMockingExtension(client).GetStorageMoverEndpointResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="StorageMoverProjectResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="StorageMoverProjectResource.CreateResourceIdentifier" /> to create a <see cref="StorageMoverProjectResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="StorageMoverProjectResource" /> object. </returns>
        public static StorageMoverProjectResource GetStorageMoverProjectResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageMoverArmClientMockingExtension(client).GetStorageMoverProjectResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="JobDefinitionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JobDefinitionResource.CreateResourceIdentifier" /> to create a <see cref="JobDefinitionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobDefinitionResource" /> object. </returns>
        public static JobDefinitionResource GetJobDefinitionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageMoverArmClientMockingExtension(client).GetJobDefinitionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="JobRunResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="JobRunResource.CreateResourceIdentifier" /> to create a <see cref="JobRunResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="JobRunResource" /> object. </returns>
        public static JobRunResource GetJobRunResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetStorageMoverArmClientMockingExtension(client).GetJobRunResource(id);
        }

        /// <summary> Gets a collection of StorageMoverResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of StorageMoverResources and their operations over a StorageMoverResource. </returns>
        public static StorageMoverCollection GetStorageMovers(this ResourceGroupResource resourceGroupResource)
        {
            return GetStorageMoverResourceGroupMockingExtension(resourceGroupResource).GetStorageMovers();
        }

        /// <summary>
        /// Gets a Storage Mover resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<StorageMoverResource>> GetStorageMoverAsync(this ResourceGroupResource resourceGroupResource, string storageMoverName, CancellationToken cancellationToken = default)
        {
            return await GetStorageMoverResourceGroupMockingExtension(resourceGroupResource).GetStorageMoverAsync(storageMoverName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Storage Mover resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.StorageMover/storageMovers/{storageMoverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="storageMoverName"> The name of the Storage Mover resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="storageMoverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="storageMoverName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<StorageMoverResource> GetStorageMover(this ResourceGroupResource resourceGroupResource, string storageMoverName, CancellationToken cancellationToken = default)
        {
            return GetStorageMoverResourceGroupMockingExtension(resourceGroupResource).GetStorageMover(storageMoverName, cancellationToken);
        }

        /// <summary>
        /// Lists all Storage Movers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageMover/storageMovers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="StorageMoverResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<StorageMoverResource> GetStorageMoversAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageMoverSubscriptionMockingExtension(subscriptionResource).GetStorageMoversAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all Storage Movers in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.StorageMover/storageMovers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>StorageMovers_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="StorageMoverResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<StorageMoverResource> GetStorageMovers(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetStorageMoverSubscriptionMockingExtension(subscriptionResource).GetStorageMovers(cancellationToken);
        }
    }
}
