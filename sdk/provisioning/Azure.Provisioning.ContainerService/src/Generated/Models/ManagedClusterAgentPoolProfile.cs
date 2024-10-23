// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// Profile for the container service agent pool.
/// </summary>
public partial class ManagedClusterAgentPoolProfile : ProvisionableConstruct
{
    /// <summary>
    /// Windows agent pool names must be 6 characters or less.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Number of agents (VMs) to host docker containers. Allowed values must
    /// be in the range of 0 to 1000 (inclusive) for user pools and in the
    /// range of 1 to 1000 (inclusive) for system pools. The default value is
    /// 1.
    /// </summary>
    public BicepValue<int> Count { get => _count; set => _count.Assign(value); }
    private readonly BicepValue<int> _count;

    /// <summary>
    /// VM size availability varies by region. If a node contains insufficient
    /// compute resources (memory, cpu, etc) pods might fail to run correctly.
    /// For more details on restricted VM sizes, see:
    /// https://docs.microsoft.com/azure/aks/quotas-skus-regions.
    /// </summary>
    public BicepValue<string> VmSize { get => _vmSize; set => _vmSize.Assign(value); }
    private readonly BicepValue<string> _vmSize;

    /// <summary>
    /// OS Disk Size in GB to be used to specify the disk size for every
    /// machine in the master/agent pool. If you specify 0, it will apply the
    /// default osDisk size according to the vmSize specified.
    /// </summary>
    public BicepValue<int> OSDiskSizeInGB { get => _oSDiskSizeInGB; set => _oSDiskSizeInGB.Assign(value); }
    private readonly BicepValue<int> _oSDiskSizeInGB;

    /// <summary>
    /// The default is &apos;Ephemeral&apos; if the VM supports it and has a
    /// cache disk larger than the requested OSDiskSizeGB. Otherwise, defaults
    /// to &apos;Managed&apos;. May not be changed after creation. For more
    /// information see [Ephemeral
    /// OS](https://docs.microsoft.com/azure/aks/cluster-configuration#ephemeral-os).
    /// </summary>
    public BicepValue<ContainerServiceOSDiskType> OSDiskType { get => _oSDiskType; set => _oSDiskType.Assign(value); }
    private readonly BicepValue<ContainerServiceOSDiskType> _oSDiskType;

    /// <summary>
    /// Determines the placement of emptyDir volumes, container runtime data
    /// root, and Kubelet ephemeral storage.
    /// </summary>
    public BicepValue<KubeletDiskType> KubeletDiskType { get => _kubeletDiskType; set => _kubeletDiskType.Assign(value); }
    private readonly BicepValue<KubeletDiskType> _kubeletDiskType;

    /// <summary>
    /// Determines the type of workload a node can run.
    /// </summary>
    public BicepValue<WorkloadRuntime> WorkloadRuntime { get => _workloadRuntime; set => _workloadRuntime.Assign(value); }
    private readonly BicepValue<WorkloadRuntime> _workloadRuntime;

    /// <summary>
    /// If this is not specified, a VNET and subnet will be generated and used.
    /// If no podSubnetID is specified, this applies to nodes and pods,
    /// otherwise it applies to just nodes. This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> VnetSubnetId { get => _vnetSubnetId; set => _vnetSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _vnetSubnetId;

    /// <summary>
    /// If omitted, pod IPs are statically assigned on the node subnet (see
    /// vnetSubnetID for more details). This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualNetworks/{virtualNetworkName}/subnets/{subnetName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> PodSubnetId { get => _podSubnetId; set => _podSubnetId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _podSubnetId;

    /// <summary>
    /// The maximum number of pods that can run on a node.
    /// </summary>
    public BicepValue<int> MaxPods { get => _maxPods; set => _maxPods.Assign(value); }
    private readonly BicepValue<int> _maxPods;

    /// <summary>
    /// The operating system type. The default is Linux.
    /// </summary>
    public BicepValue<ContainerServiceOSType> OSType { get => _oSType; set => _oSType.Assign(value); }
    private readonly BicepValue<ContainerServiceOSType> _oSType;

    /// <summary>
    /// Specifies the OS SKU used by the agent pool. The default is Ubuntu if
    /// OSType is Linux. The default is Windows2019 when Kubernetes &lt;= 1.24
    /// or Windows2022 when Kubernetes &gt;= 1.25 if OSType is Windows.
    /// </summary>
    public BicepValue<ContainerServiceOSSku> OSSku { get => _oSSku; set => _oSSku.Assign(value); }
    private readonly BicepValue<ContainerServiceOSSku> _oSSku;

    /// <summary>
    /// The maximum number of nodes for auto-scaling.
    /// </summary>
    public BicepValue<int> MaxCount { get => _maxCount; set => _maxCount.Assign(value); }
    private readonly BicepValue<int> _maxCount;

    /// <summary>
    /// The minimum number of nodes for auto-scaling.
    /// </summary>
    public BicepValue<int> MinCount { get => _minCount; set => _minCount.Assign(value); }
    private readonly BicepValue<int> _minCount;

    /// <summary>
    /// Whether to enable auto-scaler.
    /// </summary>
    public BicepValue<bool> EnableAutoScaling { get => _enableAutoScaling; set => _enableAutoScaling.Assign(value); }
    private readonly BicepValue<bool> _enableAutoScaling;

    /// <summary>
    /// This also effects the cluster autoscaler behavior. If not specified, it
    /// defaults to Delete.
    /// </summary>
    public BicepValue<ScaleDownMode> ScaleDownMode { get => _scaleDownMode; set => _scaleDownMode.Assign(value); }
    private readonly BicepValue<ScaleDownMode> _scaleDownMode;

    /// <summary>
    /// The type of Agent Pool.
    /// </summary>
    public BicepValue<AgentPoolType> AgentPoolType { get => _agentPoolType; set => _agentPoolType.Assign(value); }
    private readonly BicepValue<AgentPoolType> _agentPoolType;

    /// <summary>
    /// A cluster must have at least one &apos;System&apos; Agent Pool at all
    /// times. For additional information on agent pool restrictions and best
    /// practices, see: https://docs.microsoft.com/azure/aks/use-system-pools.
    /// </summary>
    public BicepValue<AgentPoolMode> Mode { get => _mode; set => _mode.Assign(value); }
    private readonly BicepValue<AgentPoolMode> _mode;

    /// <summary>
    /// Both patch version &lt;major.minor.patch&gt; (e.g. 1.20.13) and
    /// &lt;major.minor&gt; (e.g. 1.20) are supported. When
    /// &lt;major.minor&gt; is specified, the latest supported GA patch
    /// version is chosen automatically. Updating the cluster with the same
    /// &lt;major.minor&gt; once it has been created (e.g. 1.14.x -&gt; 1.14)
    /// will not trigger an upgrade, even if a newer patch version is
    /// available. As a best practice, you should upgrade all node pools in an
    /// AKS cluster to the same Kubernetes version. The node pool version must
    /// have the same major version as the control plane. The node pool minor
    /// version must be within two minor versions of the control plane
    /// version. The node pool version cannot be greater than the control
    /// plane version. For more information see [upgrading a node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#upgrade-a-node-pool).
    /// </summary>
    public BicepValue<string> OrchestratorVersion { get => _orchestratorVersion; set => _orchestratorVersion.Assign(value); }
    private readonly BicepValue<string> _orchestratorVersion;

    /// <summary>
    /// If orchestratorVersion is a fully specified version
    /// &lt;major.minor.patch&gt;, this field will be exactly equal to it. If
    /// orchestratorVersion is &lt;major.minor&gt;, this field will contain
    /// the full &lt;major.minor.patch&gt; version being used.
    /// </summary>
    public BicepValue<string> CurrentOrchestratorVersion { get => _currentOrchestratorVersion; }
    private readonly BicepValue<string> _currentOrchestratorVersion;

    /// <summary>
    /// The version of node image.
    /// </summary>
    public BicepValue<string> NodeImageVersion { get => _nodeImageVersion; }
    private readonly BicepValue<string> _nodeImageVersion;

    /// <summary>
    /// Settings for upgrading the agentpool.
    /// </summary>
    public BicepValue<AgentPoolUpgradeSettings> UpgradeSettings { get => _upgradeSettings; set => _upgradeSettings.Assign(value); }
    private readonly BicepValue<AgentPoolUpgradeSettings> _upgradeSettings;

    /// <summary>
    /// The current deployment or provisioning state.
    /// </summary>
    public BicepValue<string> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<string> _provisioningState;

    /// <summary>
    /// Tells whether the cluster is Running or Stopped.
    /// </summary>
    public BicepValue<ContainerServiceStateCode> PowerStateCode { get => _powerStateCode; set => _powerStateCode.Assign(value); }
    private readonly BicepValue<ContainerServiceStateCode> _powerStateCode;

    /// <summary>
    /// The list of Availability zones to use for nodes. This can only be
    /// specified if the AgentPoolType property is
    /// &apos;VirtualMachineScaleSets&apos;.
    /// </summary>
    public BicepList<string> AvailabilityZones { get => _availabilityZones; set => _availabilityZones.Assign(value); }
    private readonly BicepList<string> _availabilityZones;

    /// <summary>
    /// Some scenarios may require nodes in a node pool to receive their own
    /// dedicated public IP addresses. A common scenario is for gaming
    /// workloads, where a console needs to make a direct connection to a
    /// cloud virtual machine to minimize hops. For more information see
    /// [assigning a public IP per
    /// node](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#assign-a-public-ip-per-node-for-your-node-pools).
    /// The default is false.
    /// </summary>
    public BicepValue<bool> EnableNodePublicIP { get => _enableNodePublicIP; set => _enableNodePublicIP.Assign(value); }
    private readonly BicepValue<bool> _enableNodePublicIP;

    /// <summary>
    /// This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/publicIPPrefixes/{publicIPPrefixName}.
    /// </summary>
    public BicepValue<ResourceIdentifier> NodePublicIPPrefixId { get => _nodePublicIPPrefixId; set => _nodePublicIPPrefixId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _nodePublicIPPrefixId;

    /// <summary>
    /// The Virtual Machine Scale Set priority. If not specified, the default
    /// is &apos;Regular&apos;.
    /// </summary>
    public BicepValue<ScaleSetPriority> ScaleSetPriority { get => _scaleSetPriority; set => _scaleSetPriority.Assign(value); }
    private readonly BicepValue<ScaleSetPriority> _scaleSetPriority;

    /// <summary>
    /// This cannot be specified unless the scaleSetPriority is
    /// &apos;Spot&apos;. If not specified, the default is &apos;Delete&apos;.
    /// </summary>
    public BicepValue<ScaleSetEvictionPolicy> ScaleSetEvictionPolicy { get => _scaleSetEvictionPolicy; set => _scaleSetEvictionPolicy.Assign(value); }
    private readonly BicepValue<ScaleSetEvictionPolicy> _scaleSetEvictionPolicy;

    /// <summary>
    /// Possible values are any decimal value greater than zero or -1 which
    /// indicates the willingness to pay any on-demand price. For more details
    /// on spot pricing, see [spot VMs
    /// pricing](https://docs.microsoft.com/azure/virtual-machines/spot-vms#pricing).
    /// </summary>
    public BicepValue<float> SpotMaxPrice { get => _spotMaxPrice; set => _spotMaxPrice.Assign(value); }
    private readonly BicepValue<float> _spotMaxPrice;

    /// <summary>
    /// The tags to be persisted on the agent pool virtual machine scale set.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The node labels to be persisted across all nodes in agent pool.
    /// </summary>
    public BicepDictionary<string> NodeLabels { get => _nodeLabels; set => _nodeLabels.Assign(value); }
    private readonly BicepDictionary<string> _nodeLabels;

    /// <summary>
    /// The taints added to new nodes during node pool create and scale. For
    /// example, key=value:NoSchedule.
    /// </summary>
    public BicepList<string> NodeTaints { get => _nodeTaints; set => _nodeTaints.Assign(value); }
    private readonly BicepList<string> _nodeTaints;

    /// <summary>
    /// The ID for Proximity Placement Group.
    /// </summary>
    public BicepValue<ResourceIdentifier> ProximityPlacementGroupId { get => _proximityPlacementGroupId; set => _proximityPlacementGroupId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _proximityPlacementGroupId;

    /// <summary>
    /// The Kubelet configuration on the agent pool nodes.
    /// </summary>
    public BicepValue<KubeletConfig> KubeletConfig { get => _kubeletConfig; set => _kubeletConfig.Assign(value); }
    private readonly BicepValue<KubeletConfig> _kubeletConfig;

    /// <summary>
    /// The OS configuration of Linux agent nodes.
    /// </summary>
    public BicepValue<LinuxOSConfig> LinuxOSConfig { get => _linuxOSConfig; set => _linuxOSConfig.Assign(value); }
    private readonly BicepValue<LinuxOSConfig> _linuxOSConfig;

    /// <summary>
    /// This is only supported on certain VM sizes and in certain Azure
    /// regions. For more information, see:
    /// https://docs.microsoft.com/azure/aks/enable-host-encryption.
    /// </summary>
    public BicepValue<bool> EnableEncryptionAtHost { get => _enableEncryptionAtHost; set => _enableEncryptionAtHost.Assign(value); }
    private readonly BicepValue<bool> _enableEncryptionAtHost;

    /// <summary>
    /// Whether to enable UltraSSD.
    /// </summary>
    public BicepValue<bool> EnableUltraSsd { get => _enableUltraSsd; set => _enableUltraSsd.Assign(value); }
    private readonly BicepValue<bool> _enableUltraSsd;

    /// <summary>
    /// See [Add a FIPS-enabled node
    /// pool](https://docs.microsoft.com/azure/aks/use-multiple-node-pools#add-a-fips-enabled-node-pool-preview)
    /// for more details.
    /// </summary>
    public BicepValue<bool> EnableFips { get => _enableFips; set => _enableFips.Assign(value); }
    private readonly BicepValue<bool> _enableFips;

    /// <summary>
    /// GPUInstanceProfile to be used to specify GPU MIG instance profile for
    /// supported GPU VM SKU.
    /// </summary>
    public BicepValue<GpuInstanceProfile> GpuInstanceProfile { get => _gpuInstanceProfile; set => _gpuInstanceProfile.Assign(value); }
    private readonly BicepValue<GpuInstanceProfile> _gpuInstanceProfile;

    /// <summary>
    /// This is the ARM ID of the source object to be used to create the target
    /// object.
    /// </summary>
    public BicepValue<ResourceIdentifier> CreationDataSourceResourceId { get => _creationDataSourceResourceId; set => _creationDataSourceResourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _creationDataSourceResourceId;

    /// <summary>
    /// AKS will associate the specified agent pool with the Capacity
    /// Reservation Group.
    /// </summary>
    public BicepValue<ResourceIdentifier> CapacityReservationGroupId { get => _capacityReservationGroupId; set => _capacityReservationGroupId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _capacityReservationGroupId;

    /// <summary>
    /// This is of the form:
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/hostGroups/{hostGroupName}.
    /// For more information see [Azure dedicated
    /// hosts](https://docs.microsoft.com/azure/virtual-machines/dedicated-hosts).
    /// </summary>
    public BicepValue<ResourceIdentifier> HostGroupId { get => _hostGroupId; set => _hostGroupId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _hostGroupId;

    /// <summary>
    /// Network-related settings of an agent pool.
    /// </summary>
    public BicepValue<AgentPoolNetworkProfile> NetworkProfile { get => _networkProfile; set => _networkProfile.Assign(value); }
    private readonly BicepValue<AgentPoolNetworkProfile> _networkProfile;

    /// <summary>
    /// Creates a new ManagedClusterAgentPoolProfile.
    /// </summary>
    public ManagedClusterAgentPoolProfile()
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"]);
        _count = BicepValue<int>.DefineProperty(this, "Count", ["count"]);
        _vmSize = BicepValue<string>.DefineProperty(this, "VmSize", ["vmSize"]);
        _oSDiskSizeInGB = BicepValue<int>.DefineProperty(this, "OSDiskSizeInGB", ["osDiskSizeGB"]);
        _oSDiskType = BicepValue<ContainerServiceOSDiskType>.DefineProperty(this, "OSDiskType", ["osDiskType"]);
        _kubeletDiskType = BicepValue<KubeletDiskType>.DefineProperty(this, "KubeletDiskType", ["kubeletDiskType"]);
        _workloadRuntime = BicepValue<WorkloadRuntime>.DefineProperty(this, "WorkloadRuntime", ["workloadRuntime"]);
        _vnetSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "VnetSubnetId", ["vnetSubnetID"]);
        _podSubnetId = BicepValue<ResourceIdentifier>.DefineProperty(this, "PodSubnetId", ["podSubnetID"]);
        _maxPods = BicepValue<int>.DefineProperty(this, "MaxPods", ["maxPods"]);
        _oSType = BicepValue<ContainerServiceOSType>.DefineProperty(this, "OSType", ["osType"]);
        _oSSku = BicepValue<ContainerServiceOSSku>.DefineProperty(this, "OSSku", ["osSKU"]);
        _maxCount = BicepValue<int>.DefineProperty(this, "MaxCount", ["maxCount"]);
        _minCount = BicepValue<int>.DefineProperty(this, "MinCount", ["minCount"]);
        _enableAutoScaling = BicepValue<bool>.DefineProperty(this, "EnableAutoScaling", ["enableAutoScaling"]);
        _scaleDownMode = BicepValue<ScaleDownMode>.DefineProperty(this, "ScaleDownMode", ["scaleDownMode"]);
        _agentPoolType = BicepValue<AgentPoolType>.DefineProperty(this, "AgentPoolType", ["type"]);
        _mode = BicepValue<AgentPoolMode>.DefineProperty(this, "Mode", ["mode"]);
        _orchestratorVersion = BicepValue<string>.DefineProperty(this, "OrchestratorVersion", ["orchestratorVersion"]);
        _currentOrchestratorVersion = BicepValue<string>.DefineProperty(this, "CurrentOrchestratorVersion", ["currentOrchestratorVersion"], isOutput: true);
        _nodeImageVersion = BicepValue<string>.DefineProperty(this, "NodeImageVersion", ["nodeImageVersion"], isOutput: true);
        _upgradeSettings = BicepValue<AgentPoolUpgradeSettings>.DefineProperty(this, "UpgradeSettings", ["upgradeSettings"]);
        _provisioningState = BicepValue<string>.DefineProperty(this, "ProvisioningState", ["provisioningState"], isOutput: true);
        _powerStateCode = BicepValue<ContainerServiceStateCode>.DefineProperty(this, "PowerStateCode", ["powerState", "code"]);
        _availabilityZones = BicepList<string>.DefineProperty(this, "AvailabilityZones", ["availabilityZones"]);
        _enableNodePublicIP = BicepValue<bool>.DefineProperty(this, "EnableNodePublicIP", ["enableNodePublicIP"]);
        _nodePublicIPPrefixId = BicepValue<ResourceIdentifier>.DefineProperty(this, "NodePublicIPPrefixId", ["nodePublicIPPrefixID"]);
        _scaleSetPriority = BicepValue<ScaleSetPriority>.DefineProperty(this, "ScaleSetPriority", ["scaleSetPriority"]);
        _scaleSetEvictionPolicy = BicepValue<ScaleSetEvictionPolicy>.DefineProperty(this, "ScaleSetEvictionPolicy", ["scaleSetEvictionPolicy"]);
        _spotMaxPrice = BicepValue<float>.DefineProperty(this, "SpotMaxPrice", ["spotMaxPrice"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
        _nodeLabels = BicepDictionary<string>.DefineProperty(this, "NodeLabels", ["nodeLabels"]);
        _nodeTaints = BicepList<string>.DefineProperty(this, "NodeTaints", ["nodeTaints"]);
        _proximityPlacementGroupId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ProximityPlacementGroupId", ["proximityPlacementGroupID"]);
        _kubeletConfig = BicepValue<KubeletConfig>.DefineProperty(this, "KubeletConfig", ["kubeletConfig"]);
        _linuxOSConfig = BicepValue<LinuxOSConfig>.DefineProperty(this, "LinuxOSConfig", ["linuxOSConfig"]);
        _enableEncryptionAtHost = BicepValue<bool>.DefineProperty(this, "EnableEncryptionAtHost", ["enableEncryptionAtHost"]);
        _enableUltraSsd = BicepValue<bool>.DefineProperty(this, "EnableUltraSsd", ["enableUltraSSD"]);
        _enableFips = BicepValue<bool>.DefineProperty(this, "EnableFips", ["enableFIPS"]);
        _gpuInstanceProfile = BicepValue<GpuInstanceProfile>.DefineProperty(this, "GpuInstanceProfile", ["gpuInstanceProfile"]);
        _creationDataSourceResourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "CreationDataSourceResourceId", ["creationData", "sourceResourceId"]);
        _capacityReservationGroupId = BicepValue<ResourceIdentifier>.DefineProperty(this, "CapacityReservationGroupId", ["capacityReservationGroupID"]);
        _hostGroupId = BicepValue<ResourceIdentifier>.DefineProperty(this, "HostGroupId", ["hostGroupID"]);
        _networkProfile = BicepValue<AgentPoolNetworkProfile>.DefineProperty(this, "NetworkProfile", ["networkProfile"]);
    }
}
