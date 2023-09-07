// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> The common service resource properties. </summary>
    public partial class ManagedServiceBaseProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedServiceBaseProperties"/>. </summary>
        public ManagedServiceBaseProperties()
        {
            CorrelationScheme = new ChangeTrackingList<ManagedServiceCorrelation>();
            ServiceLoadMetrics = new ChangeTrackingList<ManagedServiceLoadMetric>();
            ServicePlacementPolicies = new ChangeTrackingList<ManagedServicePlacementPolicy>();
            ScalingPolicies = new ChangeTrackingList<ManagedServiceScalingPolicy>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedServiceBaseProperties"/>. </summary>
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
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedServiceBaseProperties(string placementConstraints, IList<ManagedServiceCorrelation> correlationScheme, IList<ManagedServiceLoadMetric> serviceLoadMetrics, IList<ManagedServicePlacementPolicy> servicePlacementPolicies, ServiceFabricManagedServiceMoveCost? defaultMoveCost, IList<ManagedServiceScalingPolicy> scalingPolicies, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PlacementConstraints = placementConstraints;
            CorrelationScheme = correlationScheme;
            ServiceLoadMetrics = serviceLoadMetrics;
            ServicePlacementPolicies = servicePlacementPolicies;
            DefaultMoveCost = defaultMoveCost;
            ScalingPolicies = scalingPolicies;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes where NodeType is blue specify the following: "NodeColor == blue)". </summary>
        public string PlacementConstraints { get; set; }
        /// <summary> A list that describes the correlation of the service with other services. </summary>
        public IList<ManagedServiceCorrelation> CorrelationScheme { get; }
        /// <summary> The service load metrics is given as an array of ServiceLoadMetric objects. </summary>
        public IList<ManagedServiceLoadMetric> ServiceLoadMetrics { get; }
        /// <summary>
        /// A list that describes the correlation of the service with other services.
        /// Please note <see cref="ManagedServicePlacementPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ServicePlacementInvalidDomainPolicy"/>, <see cref="ServicePlacementNonPartiallyPlaceServicePolicy"/>, <see cref="ServicePlacementPreferPrimaryDomainPolicy"/>, <see cref="ServicePlacementRequiredDomainPolicy"/> and <see cref="ServicePlacementRequireDomainDistributionPolicy"/>.
        /// </summary>
        public IList<ManagedServicePlacementPolicy> ServicePlacementPolicies { get; }
        /// <summary> Specifies the move cost for the service. </summary>
        public ServiceFabricManagedServiceMoveCost? DefaultMoveCost { get; set; }
        /// <summary> Scaling policies for this service. </summary>
        public IList<ManagedServiceScalingPolicy> ScalingPolicies { get; }
    }
}
