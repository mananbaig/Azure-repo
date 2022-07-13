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
    /// <summary> A class representing the DnsResolver data model. </summary>
    public partial class DnsResolverData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DnsResolverData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="virtualNetwork"> The reference to the virtual network. This cannot be changed after creation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualNetwork"/> is null. </exception>
        public DnsResolverData(AzureLocation location, WritableSubResource virtualNetwork) : base(location)
        {
            if (virtualNetwork == null)
            {
                throw new ArgumentNullException(nameof(virtualNetwork));
            }

            VirtualNetwork = virtualNetwork;
        }

        /// <summary> Initializes a new instance of DnsResolverData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="etag"> ETag of the DNS resolver. </param>
        /// <param name="virtualNetwork"> The reference to the virtual network. This cannot be changed after creation. </param>
        /// <param name="dnsResolverState"> The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="provisioningState"> The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </param>
        /// <param name="resourceGuid"> The resourceGuid property of the DNS resolver resource. </param>
        internal DnsResolverData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ETag? etag, WritableSubResource virtualNetwork, DnsResolverState? dnsResolverState, DnsResolverProvisioningState? provisioningState, string resourceGuid) : base(id, name, resourceType, systemData, tags, location)
        {
            ETag = etag;
            VirtualNetwork = virtualNetwork;
            DnsResolverState = dnsResolverState;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
        }

        /// <summary> ETag of the DNS resolver. </summary>
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

        /// <summary> The current status of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverState? DnsResolverState { get; }
        /// <summary> The current provisioning state of the DNS resolver. This is a read-only property and any attempt to set this value will be ignored. </summary>
        public DnsResolverProvisioningState? ProvisioningState { get; }
        /// <summary> The resourceGuid property of the DNS resolver resource. </summary>
        public string ResourceGuid { get; }
    }
}
