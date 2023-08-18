// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DnsResolver.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver
{
    /// <summary>
    /// A class representing the DnsForwardingRulesetVirtualNetworkLink data model.
    /// Describes a virtual network link.
    /// </summary>
    public partial class DnsForwardingRulesetVirtualNetworkLinkData : ResourceData
    {
        /// <summary> Initializes a new instance of DnsForwardingRulesetVirtualNetworkLinkData. </summary>
        /// <param name="virtualNetwork"> The reference to the virtual network. This cannot be changed after creation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetwork"/> is null. </exception>
        public DnsForwardingRulesetVirtualNetworkLinkData(WritableSubResource virtualNetwork)
        {
            Argument.AssertNotNull(virtualNetwork, nameof(virtualNetwork));

            VirtualNetwork = virtualNetwork;
            Metadata = new Core.ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DnsForwardingRulesetVirtualNetworkLinkData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> ETag of the virtual network link. </param>
        /// <param name="virtualNetwork"> The reference to the virtual network. This cannot be changed after creation. </param>
        /// <param name="metadata"> Metadata attached to the virtual network link. </param>
        /// <param name="provisioningState"> The current provisioning state of the virtual network link. This is a read-only property and any attempt to set this value will be ignored. </param>
        internal DnsForwardingRulesetVirtualNetworkLinkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ETag? etag, WritableSubResource virtualNetwork, IDictionary<string, string> metadata, DnsResolverProvisioningState? provisioningState) : base(id, name, resourceType, systemData)
        {
            ETag = etag;
            VirtualNetwork = virtualNetwork;
            Metadata = metadata;
            ProvisioningState = provisioningState;
        }

        /// <summary> ETag of the virtual network link. </summary>
        public ETag? ETag { get; }
        /// <summary> The reference to the virtual network. This cannot be changed after creation. </summary>
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

        /// <summary> Metadata attached to the virtual network link. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> The current provisioning state of the virtual network link. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverProvisioningState? ProvisioningState { get; }
    }
}
