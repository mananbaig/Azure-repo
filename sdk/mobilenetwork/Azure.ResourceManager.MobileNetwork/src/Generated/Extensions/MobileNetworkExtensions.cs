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
using Azure.ResourceManager.MobileNetwork.Mocking;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.MobileNetwork. </summary>
    public static partial class MobileNetworkExtensions
    {
        private static MobileNetworkArmClientMockingExtension GetMobileNetworkArmClientMockingExtension(ArmClient client)
        {
            return client.GetCachedClient(client =>
            {
                return new MobileNetworkArmClientMockingExtension(client);
            });
        }

        private static MobileNetworkResourceGroupMockingExtension GetMobileNetworkResourceGroupMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new MobileNetworkResourceGroupMockingExtension(client, resource.Id);
            });
        }

        private static MobileNetworkSubscriptionMockingExtension GetMobileNetworkSubscriptionMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new MobileNetworkSubscriptionMockingExtension(client, resource.Id);
            });
        }

        private static MobileNetworkTenantMockingExtension GetMobileNetworkTenantMockingExtension(ArmResource resource)
        {
            return resource.GetCachedClient(client =>
            {
                return new MobileNetworkTenantMockingExtension(client, resource.Id);
            });
        }

        /// <summary>
        /// Gets an object representing an <see cref="AttachedDataNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AttachedDataNetworkResource.CreateResourceIdentifier" /> to create an <see cref="AttachedDataNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AttachedDataNetworkResource" /> object. </returns>
        public static AttachedDataNetworkResource GetAttachedDataNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetAttachedDataNetworkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DataNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataNetworkResource.CreateResourceIdentifier" /> to create a <see cref="DataNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataNetworkResource" /> object. </returns>
        public static DataNetworkResource GetDataNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetDataNetworkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="MobileNetworkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="MobileNetworkResource.CreateResourceIdentifier" /> to create a <see cref="MobileNetworkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="MobileNetworkResource" /> object. </returns>
        public static MobileNetworkResource GetMobileNetworkResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetMobileNetworkResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PacketCoreControlPlaneResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PacketCoreControlPlaneResource.CreateResourceIdentifier" /> to create a <see cref="PacketCoreControlPlaneResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PacketCoreControlPlaneResource" /> object. </returns>
        public static PacketCoreControlPlaneResource GetPacketCoreControlPlaneResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetPacketCoreControlPlaneResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PacketCoreControlPlaneVersionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PacketCoreControlPlaneVersionResource.CreateResourceIdentifier" /> to create a <see cref="PacketCoreControlPlaneVersionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PacketCoreControlPlaneVersionResource" /> object. </returns>
        public static PacketCoreControlPlaneVersionResource GetPacketCoreControlPlaneVersionResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetPacketCoreControlPlaneVersionResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="PacketCoreDataPlaneResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PacketCoreDataPlaneResource.CreateResourceIdentifier" /> to create a <see cref="PacketCoreDataPlaneResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PacketCoreDataPlaneResource" /> object. </returns>
        public static PacketCoreDataPlaneResource GetPacketCoreDataPlaneResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetPacketCoreDataPlaneResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ServiceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ServiceResource.CreateResourceIdentifier" /> to create a <see cref="ServiceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ServiceResource" /> object. </returns>
        public static ServiceResource GetServiceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetServiceResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SimResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SimResource.CreateResourceIdentifier" /> to create a <see cref="SimResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SimResource" /> object. </returns>
        public static SimResource GetSimResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetSimResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SimGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SimGroupResource.CreateResourceIdentifier" /> to create a <see cref="SimGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SimGroupResource" /> object. </returns>
        public static SimGroupResource GetSimGroupResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetSimGroupResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SimPolicyResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SimPolicyResource.CreateResourceIdentifier" /> to create a <see cref="SimPolicyResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SimPolicyResource" /> object. </returns>
        public static SimPolicyResource GetSimPolicyResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetSimPolicyResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SiteResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SiteResource.CreateResourceIdentifier" /> to create a <see cref="SiteResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SiteResource" /> object. </returns>
        public static SiteResource GetSiteResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetSiteResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SliceResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SliceResource.CreateResourceIdentifier" /> to create a <see cref="SliceResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SliceResource" /> object. </returns>
        public static SliceResource GetSliceResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMobileNetworkArmClientMockingExtension(client).GetSliceResource(id);
        }

        /// <summary> Gets a collection of MobileNetworkResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of MobileNetworkResources and their operations over a MobileNetworkResource. </returns>
        public static MobileNetworkCollection GetMobileNetworks(this ResourceGroupResource resourceGroupResource)
        {
            return GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetMobileNetworks();
        }

        /// <summary>
        /// Gets information about the specified mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<MobileNetworkResource>> GetMobileNetworkAsync(this ResourceGroupResource resourceGroupResource, string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            return await GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetMobileNetworkAsync(mobileNetworkName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified mobile network.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/mobileNetworks/{mobileNetworkName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="mobileNetworkName"> The name of the mobile network. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="mobileNetworkName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="mobileNetworkName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<MobileNetworkResource> GetMobileNetwork(this ResourceGroupResource resourceGroupResource, string mobileNetworkName, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetMobileNetwork(mobileNetworkName, cancellationToken);
        }

        /// <summary> Gets a collection of PacketCoreControlPlaneResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PacketCoreControlPlaneResources and their operations over a PacketCoreControlPlaneResource. </returns>
        public static PacketCoreControlPlaneCollection GetPacketCoreControlPlanes(this ResourceGroupResource resourceGroupResource)
        {
            return GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetPacketCoreControlPlanes();
        }

        /// <summary>
        /// Gets information about the specified packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PacketCoreControlPlaneResource>> GetPacketCoreControlPlaneAsync(this ResourceGroupResource resourceGroupResource, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            return await GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetPacketCoreControlPlaneAsync(packetCoreControlPlaneName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified packet core control plane.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes/{packetCoreControlPlaneName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="packetCoreControlPlaneName"> The name of the packet core control plane. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="packetCoreControlPlaneName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="packetCoreControlPlaneName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PacketCoreControlPlaneResource> GetPacketCoreControlPlane(this ResourceGroupResource resourceGroupResource, string packetCoreControlPlaneName, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetPacketCoreControlPlane(packetCoreControlPlaneName, cancellationToken);
        }

        /// <summary> Gets a collection of SimGroupResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of SimGroupResources and their operations over a SimGroupResource. </returns>
        public static SimGroupCollection GetSimGroups(this ResourceGroupResource resourceGroupResource)
        {
            return GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetSimGroups();
        }

        /// <summary>
        /// Gets information about the specified SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<SimGroupResource>> GetSimGroupAsync(this ResourceGroupResource resourceGroupResource, string simGroupName, CancellationToken cancellationToken = default)
        {
            return await GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetSimGroupAsync(simGroupName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified SIM group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MobileNetwork/simGroups/{simGroupName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="simGroupName"> The name of the SIM Group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="simGroupName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="simGroupName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<SimGroupResource> GetSimGroup(this ResourceGroupResource resourceGroupResource, string simGroupName, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkResourceGroupMockingExtension(resourceGroupResource).GetSimGroup(simGroupName, cancellationToken);
        }

        /// <summary>
        /// Lists all the mobile networks in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/mobileNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MobileNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<MobileNetworkResource> GetMobileNetworksAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkSubscriptionMockingExtension(subscriptionResource).GetMobileNetworksAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the mobile networks in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/mobileNetworks</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>MobileNetworks_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MobileNetworkResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<MobileNetworkResource> GetMobileNetworks(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkSubscriptionMockingExtension(subscriptionResource).GetMobileNetworks(cancellationToken);
        }

        /// <summary>
        /// Lists all the packet core control planes in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="PacketCoreControlPlaneResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<PacketCoreControlPlaneResource> GetPacketCoreControlPlanesAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkSubscriptionMockingExtension(subscriptionResource).GetPacketCoreControlPlanesAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all the packet core control planes in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/packetCoreControlPlanes</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlanes_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="PacketCoreControlPlaneResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<PacketCoreControlPlaneResource> GetPacketCoreControlPlanes(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkSubscriptionMockingExtension(subscriptionResource).GetPacketCoreControlPlanes(cancellationToken);
        }

        /// <summary>
        /// Gets all the SIM groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/simGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SimGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SimGroupResource> GetSimGroupsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkSubscriptionMockingExtension(subscriptionResource).GetSimGroupsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets all the SIM groups in a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.MobileNetwork/simGroups</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SimGroups_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SimGroupResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SimGroupResource> GetSimGroups(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkSubscriptionMockingExtension(subscriptionResource).GetSimGroups(cancellationToken);
        }

        /// <summary> Gets a collection of PacketCoreControlPlaneVersionResources in the TenantResource. </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of PacketCoreControlPlaneVersionResources and their operations over a PacketCoreControlPlaneVersionResource. </returns>
        public static PacketCoreControlPlaneVersionCollection GetPacketCoreControlPlaneVersions(this TenantResource tenantResource)
        {
            return GetMobileNetworkTenantMockingExtension(tenantResource).GetPacketCoreControlPlaneVersions();
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<PacketCoreControlPlaneVersionResource>> GetPacketCoreControlPlaneVersionAsync(this TenantResource tenantResource, string versionName, CancellationToken cancellationToken = default)
        {
            return await GetMobileNetworkTenantMockingExtension(tenantResource).GetPacketCoreControlPlaneVersionAsync(versionName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified packet core control plane version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.MobileNetwork/packetCoreControlPlaneVersions/{versionName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PacketCoreControlPlaneVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tenantResource"> The <see cref="TenantResource" /> instance the method will execute against. </param>
        /// <param name="versionName"> The name of the packet core control plane version. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="versionName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="versionName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<PacketCoreControlPlaneVersionResource> GetPacketCoreControlPlaneVersion(this TenantResource tenantResource, string versionName, CancellationToken cancellationToken = default)
        {
            return GetMobileNetworkTenantMockingExtension(tenantResource).GetPacketCoreControlPlaneVersion(versionName, cancellationToken);
        }
    }
}
