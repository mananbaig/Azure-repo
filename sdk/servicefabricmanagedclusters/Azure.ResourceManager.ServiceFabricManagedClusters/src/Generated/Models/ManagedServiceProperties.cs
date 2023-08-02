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
    /// The service resource properties.
    /// Please note <see cref="ManagedServiceProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="StatefulServiceProperties"/> and <see cref="StatelessServiceProperties"/>.
    /// </summary>
    public partial class ManagedServiceProperties : ManagedServiceBaseProperties
    {
        /// <summary> Initializes a new instance of ManagedServiceProperties. </summary>
        /// <param name="serviceTypeName"> The name of the service type. </param>
        /// <param name="partitionDescription">
        /// Describes how the service is partitioned.
        /// Please note <see cref="ManagedServicePartitionScheme"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionScheme"/>, <see cref="SingletonPartitionScheme"/> and <see cref="UniformInt64RangePartitionScheme"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="serviceTypeName"/> or <paramref name="partitionDescription"/> is null. </exception>
        public ManagedServiceProperties(string serviceTypeName, ManagedServicePartitionScheme partitionDescription)
        {
            Argument.AssertNotNull(serviceTypeName, nameof(serviceTypeName));
            Argument.AssertNotNull(partitionDescription, nameof(partitionDescription));

            ServiceTypeName = serviceTypeName;
            PartitionDescription = partitionDescription;
        }

        /// <summary> Initializes a new instance of ManagedServiceProperties. </summary>
        /// <param name="placementConstraints"> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: "NodeColor == blue)". </param>
        /// <param name="correlationScheme"> A list that describes the correlation of the service with other services. </param>
        /// <param name="serviceLoadMetrics"> The service load metrics is given as an array of ServiceLoadMetric objects. </param>
        /// <param name="servicePlacementPolicies">
        /// A list that describes the correlation of the service with other services.
        /// Please note <see cref="ManagedServicePlacementPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ServicePlacementInvalidDomainPolicy"/>, <see cref="ServicePlacementNonPartiallyPlaceServicePolicy"/>, <see cref="ServicePlacementPreferPrimaryDomainPolicy"/>, <see cref="ServicePlacementRequiredDomainPolicy"/> and <see cref="ServicePlacementRequireDomainDistributionPolicy"/>.
        /// </param>
        /// <param name="defaultMoveCost"> Specifies the move cost for the service. </param>
        /// <param name="scalingPolicies"> Scaling policies for this service. </param>
        /// <param name="provisioningState"> The current deployment or provisioning state, which only appears in the response. </param>
        /// <param name="serviceKind"> The kind of service (Stateless or Stateful). </param>
        /// <param name="serviceTypeName"> The name of the service type. </param>
        /// <param name="partitionDescription">
        /// Describes how the service is partitioned.
        /// Please note <see cref="ManagedServicePartitionScheme"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionScheme"/>, <see cref="SingletonPartitionScheme"/> and <see cref="UniformInt64RangePartitionScheme"/>.
        /// </param>
        /// <param name="servicePackageActivationMode"> The activation Mode of the service package. </param>
        /// <param name="serviceDnsName">
        /// Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service endpoints for application layer protocols (e.g., HTTP).
        /// When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        /// When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.
        ///
        /// </param>
        internal ManagedServiceProperties(string placementConstraints, IList<ManagedServiceCorrelation> correlationScheme, IList<ManagedServiceLoadMetric> serviceLoadMetrics, IList<ManagedServicePlacementPolicy> servicePlacementPolicies, ServiceFabricManagedServiceMoveCost? defaultMoveCost, IList<ManagedServiceScalingPolicy> scalingPolicies, string provisioningState, ServiceKind serviceKind, string serviceTypeName, ManagedServicePartitionScheme partitionDescription, ManagedServicePackageActivationMode? servicePackageActivationMode, string serviceDnsName) : base(placementConstraints, correlationScheme, serviceLoadMetrics, servicePlacementPolicies, defaultMoveCost, scalingPolicies)
        {
            ProvisioningState = provisioningState;
            ServiceKind = serviceKind;
            ServiceTypeName = serviceTypeName;
            PartitionDescription = partitionDescription;
            ServicePackageActivationMode = servicePackageActivationMode;
            ServiceDnsName = serviceDnsName;
        }

        /// <summary> The current deployment or provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The kind of service (Stateless or Stateful). </summary>
        internal ServiceKind ServiceKind { get; set; }
        /// <summary> The name of the service type. </summary>
        public string ServiceTypeName { get; set; }
        /// <summary>
        /// Describes how the service is partitioned.
        /// Please note <see cref="ManagedServicePartitionScheme"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="NamedPartitionScheme"/>, <see cref="SingletonPartitionScheme"/> and <see cref="UniformInt64RangePartitionScheme"/>.
        /// </summary>
        public ManagedServicePartitionScheme PartitionDescription { get; set; }
        /// <summary> The activation Mode of the service package. </summary>
        public ManagedServicePackageActivationMode? ServicePackageActivationMode { get; set; }
        /// <summary>
        /// Dns name used for the service. If this is specified, then the DNS name can be used to return the IP addresses of service endpoints for application layer protocols (e.g., HTTP).
        /// When updating serviceDnsName, old name may be temporarily resolvable. However, rely on new name.
        /// When removing serviceDnsName, removed name may temporarily be resolvable. Do not rely on the name being unresolvable.
        ///
        /// </summary>
        public string ServiceDnsName { get; set; }
    }
}
