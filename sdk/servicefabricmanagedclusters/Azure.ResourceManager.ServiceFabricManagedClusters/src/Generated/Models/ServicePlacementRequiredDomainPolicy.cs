// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes the policy to be used for placement of a Service Fabric service where the instances or replicas of that service must be placed in a particular domain. </summary>
    public partial class ServicePlacementRequiredDomainPolicy : ManagedClusterServicePlacementPolicy
    {
        /// <summary> Initializes a new instance of ServicePlacementRequiredDomainPolicy. </summary>
        /// <param name="domainName"> The name of the domain that should used for placement as per this policy. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="domainName"/> is null. </exception>
        public ServicePlacementRequiredDomainPolicy(string domainName)
        {
            if (domainName == null)
            {
                throw new ArgumentNullException(nameof(domainName));
            }

            DomainName = domainName;
            ServicePlacementPolicyType = ServicePlacementPolicyType.RequiredDomain;
        }

        /// <summary> Initializes a new instance of ServicePlacementRequiredDomainPolicy. </summary>
        /// <param name="servicePlacementPolicyType"> The type of placement policy for a service fabric service. Following are the possible values. </param>
        /// <param name="domainName"> The name of the domain that should used for placement as per this policy. </param>
        internal ServicePlacementRequiredDomainPolicy(ServicePlacementPolicyType servicePlacementPolicyType, string domainName) : base(servicePlacementPolicyType)
        {
            DomainName = domainName;
            ServicePlacementPolicyType = servicePlacementPolicyType;
        }

        /// <summary> The name of the domain that should used for placement as per this policy. </summary>
        public string DomainName { get; set; }
    }
}
