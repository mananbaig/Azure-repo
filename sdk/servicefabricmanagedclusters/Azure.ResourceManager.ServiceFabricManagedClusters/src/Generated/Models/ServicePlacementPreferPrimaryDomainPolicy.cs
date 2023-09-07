// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary>
    /// Describes the policy to be used for placement of a Service Fabric service where the service's
    /// Primary replicas should optimally be placed in a particular domain.
    ///
    /// This placement policy is usually used with fault domains in scenarios where the Service Fabric
    /// cluster is geographically distributed in order to indicate that a service's primary replica should
    /// be located in a particular fault domain, which in geo-distributed scenarios usually aligns with regional
    /// or datacenter boundaries. Note that since this is an optimization it is possible that the Primary replica
    /// may not end up located in this domain due to failures, capacity limits, or other constraints.
    ///
    /// </summary>
    public partial class ServicePlacementPreferPrimaryDomainPolicy : ManagedServicePlacementPolicy
    {
        /// <summary> Initializes a new instance of <see cref="ServicePlacementPreferPrimaryDomainPolicy"/>. </summary>
        /// <param name="domainName"> The name of the domain that should used for placement as per this policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public ServicePlacementPreferPrimaryDomainPolicy(string domainName)
        {
            Argument.AssertNotNull(domainName, nameof(domainName));

            DomainName = domainName;
            ServicePlacementPolicyType = ServicePlacementPolicyType.PreferredPrimaryDomain;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePlacementPreferPrimaryDomainPolicy"/>. </summary>
        /// <param name="servicePlacementPolicyType"> The type of placement policy for a service fabric service. Following are the possible values. </param>
        /// <param name="domainName"> The name of the domain that should used for placement as per this policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePlacementPreferPrimaryDomainPolicy(ServicePlacementPolicyType servicePlacementPolicyType, string domainName, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(servicePlacementPolicyType, serializedAdditionalRawData)
        {
            DomainName = domainName;
            ServicePlacementPolicyType = servicePlacementPolicyType;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePlacementPreferPrimaryDomainPolicy"/> for deserialization. </summary>
        internal ServicePlacementPreferPrimaryDomainPolicy()
        {
        }

        /// <summary> The name of the domain that should used for placement as per this policy. </summary>
        public string DomainName { get; set; }
    }
}
