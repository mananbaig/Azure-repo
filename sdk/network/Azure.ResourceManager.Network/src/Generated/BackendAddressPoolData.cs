// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the BackendAddressPool data model.
    /// Pool of backend IP addresses.
    /// </summary>
    public partial class BackendAddressPoolData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of <see cref="BackendAddressPoolData"/>. </summary>
        public BackendAddressPoolData()
        {
            TunnelInterfaces = new ChangeTrackingList<GatewayLoadBalancerTunnelInterface>();
            LoadBalancerBackendAddresses = new ChangeTrackingList<LoadBalancerBackendAddress>();
            BackendIPConfigurations = new ChangeTrackingList<NetworkInterfaceIPConfigurationData>();
            LoadBalancingRules = new ChangeTrackingList<WritableSubResource>();
            OutboundRules = new ChangeTrackingList<WritableSubResource>();
            InboundNatRules = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="BackendAddressPoolData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="location"> The location of the backend address pool. </param>
        /// <param name="tunnelInterfaces"> An array of gateway load balancer tunnel interfaces. </param>
        /// <param name="loadBalancerBackendAddresses"> An array of backend addresses. </param>
        /// <param name="backendIPConfigurations"> An array of references to IP addresses defined in network interfaces. </param>
        /// <param name="loadBalancingRules"> An array of references to load balancing rules that use this backend address pool. </param>
        /// <param name="outboundRule"> A reference to an outbound rule that uses this backend address pool. </param>
        /// <param name="outboundRules"> An array of references to outbound rules that use this backend address pool. </param>
        /// <param name="inboundNatRules"> An array of references to inbound NAT rules that use this backend address pool. </param>
        /// <param name="provisioningState"> The provisioning state of the backend address pool resource. </param>
        /// <param name="drainPeriodInSeconds"> Amount of seconds Load Balancer waits for before sending RESET to client and backend address. </param>
        /// <param name="virtualNetwork"> A reference to a virtual network. </param>
        /// <param name="syncMode"> Backend address synchronous mode for the backend pool. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackendAddressPoolData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, AzureLocation? location, IList<GatewayLoadBalancerTunnelInterface> tunnelInterfaces, IList<LoadBalancerBackendAddress> loadBalancerBackendAddresses, IReadOnlyList<NetworkInterfaceIPConfigurationData> backendIPConfigurations, IReadOnlyList<WritableSubResource> loadBalancingRules, WritableSubResource outboundRule, IReadOnlyList<WritableSubResource> outboundRules, IReadOnlyList<WritableSubResource> inboundNatRules, NetworkProvisioningState? provisioningState, int? drainPeriodInSeconds, WritableSubResource virtualNetwork, BackendAddressSyncMode? syncMode, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, rawData)
        {
            ETag = etag;
            Location = location;
            TunnelInterfaces = tunnelInterfaces;
            LoadBalancerBackendAddresses = loadBalancerBackendAddresses;
            BackendIPConfigurations = backendIPConfigurations;
            LoadBalancingRules = loadBalancingRules;
            OutboundRule = outboundRule;
            OutboundRules = outboundRules;
            InboundNatRules = inboundNatRules;
            ProvisioningState = provisioningState;
            DrainPeriodInSeconds = drainPeriodInSeconds;
            VirtualNetwork = virtualNetwork;
            SyncMode = syncMode;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The location of the backend address pool. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> An array of gateway load balancer tunnel interfaces. </summary>
        public IList<GatewayLoadBalancerTunnelInterface> TunnelInterfaces { get; }
        /// <summary> An array of backend addresses. </summary>
        public IList<LoadBalancerBackendAddress> LoadBalancerBackendAddresses { get; }
        /// <summary> An array of references to IP addresses defined in network interfaces. </summary>
        public IReadOnlyList<NetworkInterfaceIPConfigurationData> BackendIPConfigurations { get; }
        /// <summary> An array of references to load balancing rules that use this backend address pool. </summary>
        public IReadOnlyList<WritableSubResource> LoadBalancingRules { get; }
        /// <summary> A reference to an outbound rule that uses this backend address pool. </summary>
        internal WritableSubResource OutboundRule { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier OutboundRuleId
        {
            get => OutboundRule?.Id;
        }

        /// <summary> An array of references to outbound rules that use this backend address pool. </summary>
        public IReadOnlyList<WritableSubResource> OutboundRules { get; }
        /// <summary> An array of references to inbound NAT rules that use this backend address pool. </summary>
        public IReadOnlyList<WritableSubResource> InboundNatRules { get; }
        /// <summary> The provisioning state of the backend address pool resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Amount of seconds Load Balancer waits for before sending RESET to client and backend address. </summary>
        public int? DrainPeriodInSeconds { get; set; }
        /// <summary> A reference to a virtual network. </summary>
        internal WritableSubResource VirtualNetwork { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualNetworkId
        {
            get => VirtualNetwork is null ? default : VirtualNetwork.Id;
            set
            {
                if (VirtualNetwork is null)
                    VirtualNetwork = new WritableSubResource();
                VirtualNetwork.Id = value;
            }
        }

        /// <summary> Backend address synchronous mode for the backend pool. </summary>
        public BackendAddressSyncMode? SyncMode { get; set; }
    }
}
