// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NetworkCloud.Models;

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing the NetworkCloudClusterMetricsConfiguration data model.
    /// ClusterMetricsConfiguration represents the metrics configuration of an on-premises Network Cloud cluster.
    /// </summary>
    public partial class NetworkCloudClusterMetricsConfigurationData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterMetricsConfigurationData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="collectionInterval"> The interval in minutes by which metrics will be collected. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/> is null. </exception>
        public NetworkCloudClusterMetricsConfigurationData(AzureLocation location, ExtendedLocation extendedLocation, long collectionInterval) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));

            ExtendedLocation = extendedLocation;
            CollectionInterval = collectionInterval;
            DisabledMetrics = new ChangeTrackingList<string>();
            EnabledMetrics = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterMetricsConfigurationData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster associated with the resource. </param>
        /// <param name="collectionInterval"> The interval in minutes by which metrics will be collected. </param>
        /// <param name="detailedStatus"> The more detailed status of the metrics configuration. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the current detailed status. </param>
        /// <param name="disabledMetrics"> The list of metrics that are available for the cluster but disabled at the moment. </param>
        /// <param name="enabledMetrics"> The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics. </param>
        /// <param name="provisioningState"> The provisioning state of the metrics configuration. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudClusterMetricsConfigurationData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, long collectionInterval, ClusterMetricsConfigurationDetailedStatus? detailedStatus, string detailedStatusMessage, IReadOnlyList<string> disabledMetrics, IList<string> enabledMetrics, ClusterMetricsConfigurationProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            CollectionInterval = collectionInterval;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            DisabledMetrics = disabledMetrics;
            EnabledMetrics = enabledMetrics;
            ProvisioningState = provisioningState;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterMetricsConfigurationData"/> for deserialization. </summary>
        internal NetworkCloudClusterMetricsConfigurationData()
        {
        }

        /// <summary> The extended location of the cluster associated with the resource. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The interval in minutes by which metrics will be collected. </summary>
        public long CollectionInterval { get; set; }
        /// <summary> The more detailed status of the metrics configuration. </summary>
        public ClusterMetricsConfigurationDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the current detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> The list of metrics that are available for the cluster but disabled at the moment. </summary>
        public IReadOnlyList<string> DisabledMetrics { get; }
        /// <summary> The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics. </summary>
        public IList<string> EnabledMetrics { get; }
        /// <summary> The provisioning state of the metrics configuration. </summary>
        public ClusterMetricsConfigurationProvisioningState? ProvisioningState { get; }
    }
}
