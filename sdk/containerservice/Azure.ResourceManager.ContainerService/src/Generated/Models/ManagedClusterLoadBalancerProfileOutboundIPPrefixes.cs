// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Desired outbound IP Prefix resources for the cluster load balancer. </summary>
    internal partial class ManagedClusterLoadBalancerProfileOutboundIPPrefixes
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerProfileOutboundIPPrefixes"/>. </summary>
        public ManagedClusterLoadBalancerProfileOutboundIPPrefixes()
        {
            PublicIPPrefixes = new ChangeTrackingList<WritableSubResource>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterLoadBalancerProfileOutboundIPPrefixes"/>. </summary>
        /// <param name="publicIPPrefixes"> A list of public IP prefix resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterLoadBalancerProfileOutboundIPPrefixes(IList<WritableSubResource> publicIPPrefixes, Dictionary<string, BinaryData> rawData)
        {
            PublicIPPrefixes = publicIPPrefixes;
            _rawData = rawData;
        }

        /// <summary> A list of public IP prefix resources. </summary>
        public IList<WritableSubResource> PublicIPPrefixes { get; }
    }
}
