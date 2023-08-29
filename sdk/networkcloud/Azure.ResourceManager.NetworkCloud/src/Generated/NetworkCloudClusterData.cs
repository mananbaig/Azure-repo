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
    /// A class representing the NetworkCloudCluster data model.
    /// Cluster represents the on-premises Network Cloud cluster.
    /// </summary>
    public partial class NetworkCloudClusterData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster manager associated with the cluster. </param>
        /// <param name="aggregatorOrSingleRackDefinition"> The rack definition that is intended to reflect only a single rack in a single rack cluster, or an aggregator rack in a multi-rack cluster. </param>
        /// <param name="clusterType"> The type of rack configuration for the cluster. </param>
        /// <param name="clusterVersion"> The current runtime version of the cluster. </param>
        /// <param name="networkFabricId"> The resource ID of the Network Fabric associated with the cluster. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="extendedLocation"/>, <paramref name="aggregatorOrSingleRackDefinition"/>, <paramref name="clusterVersion"/> or <paramref name="networkFabricId"/> is null. </exception>
        public NetworkCloudClusterData(AzureLocation location, ExtendedLocation extendedLocation, NetworkCloudRackDefinition aggregatorOrSingleRackDefinition, ClusterType clusterType, string clusterVersion, ResourceIdentifier networkFabricId) : base(location)
        {
            Argument.AssertNotNull(extendedLocation, nameof(extendedLocation));
            Argument.AssertNotNull(aggregatorOrSingleRackDefinition, nameof(aggregatorOrSingleRackDefinition));
            Argument.AssertNotNull(clusterVersion, nameof(clusterVersion));
            Argument.AssertNotNull(networkFabricId, nameof(networkFabricId));

            ExtendedLocation = extendedLocation;
            AggregatorOrSingleRackDefinition = aggregatorOrSingleRackDefinition;
            AvailableUpgradeVersions = new ChangeTrackingList<ClusterAvailableUpgradeVersion>();
            ClusterType = clusterType;
            ClusterVersion = clusterVersion;
            ComputeRackDefinitions = new ChangeTrackingList<NetworkCloudRackDefinition>();
            NetworkFabricId = networkFabricId;
            WorkloadResourceIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location of the cluster manager associated with the cluster. </param>
        /// <param name="aggregatorOrSingleRackDefinition"> The rack definition that is intended to reflect only a single rack in a single rack cluster, or an aggregator rack in a multi-rack cluster. </param>
        /// <param name="analyticsWorkspaceId"> The resource ID of the Log Analytics Workspace that will be used for storing relevant logs. </param>
        /// <param name="availableUpgradeVersions"> The list of cluster runtime version upgrades available for this cluster. </param>
        /// <param name="clusterCapacity"> The capacity supported by this cluster. </param>
        /// <param name="clusterConnectionStatus"> The latest heartbeat status between the cluster manager and the cluster. </param>
        /// <param name="clusterExtendedLocation"> The extended location (custom location) that represents the cluster's control plane location. This extended location is used to route the requests of child objects of the cluster that are handled by the platform operator. </param>
        /// <param name="clusterLocation"> The customer-provided location information to identify where the cluster resides. </param>
        /// <param name="clusterManagerConnectionStatus"> The latest connectivity status between cluster manager and the cluster. </param>
        /// <param name="clusterManagerId"> The resource ID of the cluster manager that manages this cluster. This is set by the Cluster Manager when the cluster is created. </param>
        /// <param name="clusterServicePrincipal"> The service principal to be used by the cluster during Arc Appliance installation. </param>
        /// <param name="clusterType"> The type of rack configuration for the cluster. </param>
        /// <param name="clusterVersion"> The current runtime version of the cluster. </param>
        /// <param name="computeDeploymentThreshold"> The validation threshold indicating the allowable failures of compute machines during environment validation and deployment. </param>
        /// <param name="computeRackDefinitions">
        /// The list of rack definitions for the compute racks in a multi-rack
        /// cluster, or an empty list in a single-rack cluster.
        /// </param>
        /// <param name="detailedStatus"> The current detailed status of the cluster. </param>
        /// <param name="detailedStatusMessage"> The descriptive message about the detailed status. </param>
        /// <param name="hybridAksExtendedLocation"> Field Deprecated. This field will not be populated in an upcoming version. The extended location (custom location) that represents the Hybrid AKS control plane location. This extended location is used when creating provisioned clusters (Hybrid AKS clusters). </param>
        /// <param name="managedResourceGroupConfiguration"> The configuration of the managed resource group associated with the resource. </param>
        /// <param name="manualActionCount"> The count of Manual Action Taken (MAT) events that have not been validated. </param>
        /// <param name="networkFabricId"> The resource ID of the Network Fabric associated with the cluster. </param>
        /// <param name="provisioningState"> The provisioning state of the cluster. </param>
        /// <param name="supportExpireOn"> The support end date of the runtime version of the cluster. </param>
        /// <param name="workloadResourceIds"> The list of workload resource IDs that are hosted within this cluster. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, NetworkCloudRackDefinition aggregatorOrSingleRackDefinition, ResourceIdentifier analyticsWorkspaceId, IReadOnlyList<ClusterAvailableUpgradeVersion> availableUpgradeVersions, ClusterCapacity clusterCapacity, ClusterConnectionStatus? clusterConnectionStatus, ExtendedLocation clusterExtendedLocation, string clusterLocation, ClusterManagerConnectionStatus? clusterManagerConnectionStatus, ResourceIdentifier clusterManagerId, ServicePrincipalInformation clusterServicePrincipal, ClusterType clusterType, string clusterVersion, ValidationThreshold computeDeploymentThreshold, IList<NetworkCloudRackDefinition> computeRackDefinitions, ClusterDetailedStatus? detailedStatus, string detailedStatusMessage, ExtendedLocation hybridAksExtendedLocation, ManagedResourceGroupConfiguration managedResourceGroupConfiguration, long? manualActionCount, ResourceIdentifier networkFabricId, ClusterProvisioningState? provisioningState, DateTimeOffset? supportExpireOn, IReadOnlyList<ResourceIdentifier> workloadResourceIds, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            AggregatorOrSingleRackDefinition = aggregatorOrSingleRackDefinition;
            AnalyticsWorkspaceId = analyticsWorkspaceId;
            AvailableUpgradeVersions = availableUpgradeVersions;
            ClusterCapacity = clusterCapacity;
            ClusterConnectionStatus = clusterConnectionStatus;
            ClusterExtendedLocation = clusterExtendedLocation;
            ClusterLocation = clusterLocation;
            ClusterManagerConnectionStatus = clusterManagerConnectionStatus;
            ClusterManagerId = clusterManagerId;
            ClusterServicePrincipal = clusterServicePrincipal;
            ClusterType = clusterType;
            ClusterVersion = clusterVersion;
            ComputeDeploymentThreshold = computeDeploymentThreshold;
            ComputeRackDefinitions = computeRackDefinitions;
            DetailedStatus = detailedStatus;
            DetailedStatusMessage = detailedStatusMessage;
            HybridAksExtendedLocation = hybridAksExtendedLocation;
            ManagedResourceGroupConfiguration = managedResourceGroupConfiguration;
            ManualActionCount = manualActionCount;
            NetworkFabricId = networkFabricId;
            ProvisioningState = provisioningState;
            SupportExpireOn = supportExpireOn;
            WorkloadResourceIds = workloadResourceIds;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterData"/> for deserialization. </summary>
        internal NetworkCloudClusterData()
        {
        }

        /// <summary> The extended location of the cluster manager associated with the cluster. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> The rack definition that is intended to reflect only a single rack in a single rack cluster, or an aggregator rack in a multi-rack cluster. </summary>
        public NetworkCloudRackDefinition AggregatorOrSingleRackDefinition { get; set; }
        /// <summary> The resource ID of the Log Analytics Workspace that will be used for storing relevant logs. </summary>
        public ResourceIdentifier AnalyticsWorkspaceId { get; set; }
        /// <summary> The list of cluster runtime version upgrades available for this cluster. </summary>
        public IReadOnlyList<ClusterAvailableUpgradeVersion> AvailableUpgradeVersions { get; }
        /// <summary> The capacity supported by this cluster. </summary>
        public ClusterCapacity ClusterCapacity { get; }
        /// <summary> The latest heartbeat status between the cluster manager and the cluster. </summary>
        public ClusterConnectionStatus? ClusterConnectionStatus { get; }
        /// <summary> The extended location (custom location) that represents the cluster's control plane location. This extended location is used to route the requests of child objects of the cluster that are handled by the platform operator. </summary>
        public ExtendedLocation ClusterExtendedLocation { get; }
        /// <summary> The customer-provided location information to identify where the cluster resides. </summary>
        public string ClusterLocation { get; set; }
        /// <summary> The latest connectivity status between cluster manager and the cluster. </summary>
        public ClusterManagerConnectionStatus? ClusterManagerConnectionStatus { get; }
        /// <summary> The resource ID of the cluster manager that manages this cluster. This is set by the Cluster Manager when the cluster is created. </summary>
        public ResourceIdentifier ClusterManagerId { get; }
        /// <summary> The service principal to be used by the cluster during Arc Appliance installation. </summary>
        public ServicePrincipalInformation ClusterServicePrincipal { get; set; }
        /// <summary> The type of rack configuration for the cluster. </summary>
        public ClusterType ClusterType { get; set; }
        /// <summary> The current runtime version of the cluster. </summary>
        public string ClusterVersion { get; set; }
        /// <summary> The validation threshold indicating the allowable failures of compute machines during environment validation and deployment. </summary>
        public ValidationThreshold ComputeDeploymentThreshold { get; set; }
        /// <summary>
        /// The list of rack definitions for the compute racks in a multi-rack
        /// cluster, or an empty list in a single-rack cluster.
        /// </summary>
        public IList<NetworkCloudRackDefinition> ComputeRackDefinitions { get; }
        /// <summary> The current detailed status of the cluster. </summary>
        public ClusterDetailedStatus? DetailedStatus { get; }
        /// <summary> The descriptive message about the detailed status. </summary>
        public string DetailedStatusMessage { get; }
        /// <summary> Field Deprecated. This field will not be populated in an upcoming version. The extended location (custom location) that represents the Hybrid AKS control plane location. This extended location is used when creating provisioned clusters (Hybrid AKS clusters). </summary>
        public ExtendedLocation HybridAksExtendedLocation { get; }
        /// <summary> The configuration of the managed resource group associated with the resource. </summary>
        public ManagedResourceGroupConfiguration ManagedResourceGroupConfiguration { get; set; }
        /// <summary> The count of Manual Action Taken (MAT) events that have not been validated. </summary>
        public long? ManualActionCount { get; }
        /// <summary> The resource ID of the Network Fabric associated with the cluster. </summary>
        public ResourceIdentifier NetworkFabricId { get; set; }
        /// <summary> The provisioning state of the cluster. </summary>
        public ClusterProvisioningState? ProvisioningState { get; }
        /// <summary> The support end date of the runtime version of the cluster. </summary>
        public DateTimeOffset? SupportExpireOn { get; }
        /// <summary> The list of workload resource IDs that are hosted within this cluster. </summary>
        public IReadOnlyList<ResourceIdentifier> WorkloadResourceIds { get; }
    }
}
