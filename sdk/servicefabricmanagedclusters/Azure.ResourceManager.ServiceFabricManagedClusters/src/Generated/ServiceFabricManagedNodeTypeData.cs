// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;

namespace Azure.ResourceManager.ServiceFabricManagedClusters
{
    /// <summary>
    /// A class representing the ServiceFabricManagedNodeType data model.
    /// Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
    /// </summary>
    public partial class ServiceFabricManagedNodeTypeData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedNodeTypeData"/>. </summary>
        public ServiceFabricManagedNodeTypeData()
        {
            PlacementProperties = new ChangeTrackingDictionary<string, string>();
            Capacities = new ChangeTrackingDictionary<string, string>();
            VmSecrets = new ChangeTrackingList<NodeTypeVaultSecretGroup>();
            VmExtensions = new ChangeTrackingList<NodeTypeVmssExtension>();
            FrontendConfigurations = new ChangeTrackingList<NodeTypeFrontendConfiguration>();
            NetworkSecurityRules = new ChangeTrackingList<ServiceFabricManagedNetworkSecurityRule>();
            AdditionalDataDisks = new ChangeTrackingList<NodeTypeVmssDataDisk>();
            Zones = new ChangeTrackingList<string>();
            VmSetupActions = new ChangeTrackingList<VmSetupAction>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricManagedNodeTypeData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sku"> The node type sku. </param>
        /// <param name="isPrimary"> Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created. </param>
        /// <param name="vmInstanceCount"> The number of nodes in the node type. &lt;br /&gt;&lt;br /&gt;**Values:** &lt;br /&gt;-1 - Use when auto scale rules are configured or sku.capacity is defined &lt;br /&gt; 0 - Not supported &lt;br /&gt; &gt;0 - Use for manual scale. </param>
        /// <param name="dataDiskSizeInGB"> Disk size for the managed disk attached to the vms on the node type in GBs. </param>
        /// <param name="dataDiskType"> Managed data disk type. Specifies the storage account type for the managed disk. </param>
        /// <param name="dataDiskLetter"> Managed data disk letter. It can not use the reserved letter C or D and it can not change after created. </param>
        /// <param name="placementProperties"> The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. </param>
        /// <param name="capacities"> The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. </param>
        /// <param name="applicationPorts"> The range of ports from which cluster assigned port to Service Fabric applications. </param>
        /// <param name="ephemeralPorts"> The range of ephemeral ports that nodes in this node type should be configured with. </param>
        /// <param name="vmSize"> The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3. </param>
        /// <param name="vmImagePublisher"> The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer. </param>
        /// <param name="vmImageOffer"> The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer. </param>
        /// <param name="vmImageSku"> The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter. </param>
        /// <param name="vmImageVersion"> The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'. </param>
        /// <param name="vmSecrets"> The secrets to install in the virtual machines. </param>
        /// <param name="vmExtensions"> Set of extensions that should be installed onto the virtual machines. </param>
        /// <param name="vmManagedIdentity"> Identities to assign to the virtual machine scale set under the node type. </param>
        /// <param name="isStateless"> Indicates if the node type can only host Stateless workloads. </param>
        /// <param name="hasMultiplePlacementGroups"> Indicates if scale set associated with the node type can be composed of multiple placement groups. </param>
        /// <param name="frontendConfigurations"> Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created. </param>
        /// <param name="networkSecurityRules"> The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations. </param>
        /// <param name="additionalDataDisks"> Additional managed data disks. </param>
        /// <param name="isEncryptionAtHostEnabled"> Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource. </param>
        /// <param name="provisioningState"> The provisioning state of the node type resource. </param>
        /// <param name="isAcceleratedNetworkingEnabled"> Specifies whether the network interface is accelerated networking-enabled. </param>
        /// <param name="useDefaultPublicLoadBalancer"> Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity. </param>
        /// <param name="useTempDataDisk"> Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types. </param>
        /// <param name="isOverProvisioningEnabled"> Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types. </param>
        /// <param name="zones"> Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability zones, initiates az migration for the cluster. </param>
        /// <param name="isSpotVm"> Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available and the VMs can be evicted at any time. </param>
        /// <param name="hostGroupId"> Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts. </param>
        /// <param name="useEphemeralOSDisk"> Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature. </param>
        /// <param name="spotRestoreTimeout"> Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO 8601. </param>
        /// <param name="evictionPolicy"> Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete. </param>
        /// <param name="vmImageResourceId"> Indicates the resource id of the vm image. This parameter is used for custom vm image. </param>
        /// <param name="subnetId"> Indicates the resource id of the subnet for the node type. </param>
        /// <param name="vmSetupActions"> Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime. </param>
        /// <param name="securityType"> Specifies the security type of the nodeType. Only TrustedLaunch is currently supported. </param>
        /// <param name="isSecureBootEnabled"> Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch SecurityType. </param>
        /// <param name="isNodePublicIPEnabled"> Specifies whether each node is allocated its own public IP address. This is only supported on secondary node types with custom Load Balancers. </param>
        /// <param name="vmSharedGalleryImageId"> Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image. </param>
        /// <param name="natGatewayId"> Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer. </param>
        /// <param name="vmImagePlan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save. </param>
        /// <param name="tags"> Azure resource tags. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricManagedNodeTypeData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NodeTypeSku sku, bool? isPrimary, int? vmInstanceCount, int? dataDiskSizeInGB, ServiceFabricManagedDataDiskType? dataDiskType, string dataDiskLetter, IDictionary<string, string> placementProperties, IDictionary<string, string> capacities, EndpointRangeDescription applicationPorts, EndpointRangeDescription ephemeralPorts, string vmSize, string vmImagePublisher, string vmImageOffer, string vmImageSku, string vmImageVersion, IList<NodeTypeVaultSecretGroup> vmSecrets, IList<NodeTypeVmssExtension> vmExtensions, VmManagedIdentity vmManagedIdentity, bool? isStateless, bool? hasMultiplePlacementGroups, IList<NodeTypeFrontendConfiguration> frontendConfigurations, IList<ServiceFabricManagedNetworkSecurityRule> networkSecurityRules, IList<NodeTypeVmssDataDisk> additionalDataDisks, bool? isEncryptionAtHostEnabled, ServiceFabricManagedResourceProvisioningState? provisioningState, bool? isAcceleratedNetworkingEnabled, bool? useDefaultPublicLoadBalancer, bool? useTempDataDisk, bool? isOverProvisioningEnabled, IList<string> zones, bool? isSpotVm, string hostGroupId, bool? useEphemeralOSDisk, string spotRestoreTimeout, SpotNodeVmEvictionPolicyType? evictionPolicy, ResourceIdentifier vmImageResourceId, ResourceIdentifier subnetId, IList<VmSetupAction> vmSetupActions, ServiceFabricManagedClusterSecurityType? securityType, bool? isSecureBootEnabled, bool? isNodePublicIPEnabled, ResourceIdentifier vmSharedGalleryImageId, ResourceIdentifier natGatewayId, VmImagePlan vmImagePlan, IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Sku = sku;
            IsPrimary = isPrimary;
            VmInstanceCount = vmInstanceCount;
            DataDiskSizeInGB = dataDiskSizeInGB;
            DataDiskType = dataDiskType;
            DataDiskLetter = dataDiskLetter;
            PlacementProperties = placementProperties;
            Capacities = capacities;
            ApplicationPorts = applicationPorts;
            EphemeralPorts = ephemeralPorts;
            VmSize = vmSize;
            VmImagePublisher = vmImagePublisher;
            VmImageOffer = vmImageOffer;
            VmImageSku = vmImageSku;
            VmImageVersion = vmImageVersion;
            VmSecrets = vmSecrets;
            VmExtensions = vmExtensions;
            VmManagedIdentity = vmManagedIdentity;
            IsStateless = isStateless;
            HasMultiplePlacementGroups = hasMultiplePlacementGroups;
            FrontendConfigurations = frontendConfigurations;
            NetworkSecurityRules = networkSecurityRules;
            AdditionalDataDisks = additionalDataDisks;
            IsEncryptionAtHostEnabled = isEncryptionAtHostEnabled;
            ProvisioningState = provisioningState;
            IsAcceleratedNetworkingEnabled = isAcceleratedNetworkingEnabled;
            UseDefaultPublicLoadBalancer = useDefaultPublicLoadBalancer;
            UseTempDataDisk = useTempDataDisk;
            IsOverProvisioningEnabled = isOverProvisioningEnabled;
            Zones = zones;
            IsSpotVm = isSpotVm;
            HostGroupId = hostGroupId;
            UseEphemeralOSDisk = useEphemeralOSDisk;
            SpotRestoreTimeout = spotRestoreTimeout;
            EvictionPolicy = evictionPolicy;
            VmImageResourceId = vmImageResourceId;
            SubnetId = subnetId;
            VmSetupActions = vmSetupActions;
            SecurityType = securityType;
            IsSecureBootEnabled = isSecureBootEnabled;
            IsNodePublicIPEnabled = isNodePublicIPEnabled;
            VmSharedGalleryImageId = vmSharedGalleryImageId;
            NatGatewayId = natGatewayId;
            VmImagePlan = vmImagePlan;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The node type sku. </summary>
        public NodeTypeSku Sku { get; set; }
        /// <summary> Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created. </summary>
        public bool? IsPrimary { get; set; }
        /// <summary> The number of nodes in the node type. &lt;br /&gt;&lt;br /&gt;**Values:** &lt;br /&gt;-1 - Use when auto scale rules are configured or sku.capacity is defined &lt;br /&gt; 0 - Not supported &lt;br /&gt; &gt;0 - Use for manual scale. </summary>
        public int? VmInstanceCount { get; set; }
        /// <summary> Disk size for the managed disk attached to the vms on the node type in GBs. </summary>
        public int? DataDiskSizeInGB { get; set; }
        /// <summary> Managed data disk type. Specifies the storage account type for the managed disk. </summary>
        public ServiceFabricManagedDataDiskType? DataDiskType { get; set; }
        /// <summary> Managed data disk letter. It can not use the reserved letter C or D and it can not change after created. </summary>
        public string DataDiskLetter { get; set; }
        /// <summary> The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run. </summary>
        public IDictionary<string, string> PlacementProperties { get; }
        /// <summary> The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has. </summary>
        public IDictionary<string, string> Capacities { get; }
        /// <summary> The range of ports from which cluster assigned port to Service Fabric applications. </summary>
        public EndpointRangeDescription ApplicationPorts { get; set; }
        /// <summary> The range of ephemeral ports that nodes in this node type should be configured with. </summary>
        public EndpointRangeDescription EphemeralPorts { get; set; }
        /// <summary> The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3. </summary>
        public string VmSize { get; set; }
        /// <summary> The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer. </summary>
        public string VmImagePublisher { get; set; }
        /// <summary> The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer. </summary>
        public string VmImageOffer { get; set; }
        /// <summary> The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter. </summary>
        public string VmImageSku { get; set; }
        /// <summary> The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'. </summary>
        public string VmImageVersion { get; set; }
        /// <summary> The secrets to install in the virtual machines. </summary>
        public IList<NodeTypeVaultSecretGroup> VmSecrets { get; }
        /// <summary> Set of extensions that should be installed onto the virtual machines. </summary>
        public IList<NodeTypeVmssExtension> VmExtensions { get; }
        /// <summary> Identities to assign to the virtual machine scale set under the node type. </summary>
        internal VmManagedIdentity VmManagedIdentity { get; set; }
        /// <summary> The list of user identities associated with the virtual machine scale set under the node type. Each entry will be an ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </summary>
        public IList<ResourceIdentifier> UserAssignedIdentities
        {
            get
            {
                if (VmManagedIdentity is null)
                    VmManagedIdentity = new VmManagedIdentity();
                return VmManagedIdentity.UserAssignedIdentities;
            }
        }

        /// <summary> Indicates if the node type can only host Stateless workloads. </summary>
        public bool? IsStateless { get; set; }
        /// <summary> Indicates if scale set associated with the node type can be composed of multiple placement groups. </summary>
        public bool? HasMultiplePlacementGroups { get; set; }
        /// <summary> Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created. </summary>
        public IList<NodeTypeFrontendConfiguration> FrontendConfigurations { get; }
        /// <summary> The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations. </summary>
        public IList<ServiceFabricManagedNetworkSecurityRule> NetworkSecurityRules { get; }
        /// <summary> Additional managed data disks. </summary>
        public IList<NodeTypeVmssDataDisk> AdditionalDataDisks { get; }
        /// <summary> Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource. </summary>
        public bool? IsEncryptionAtHostEnabled { get; set; }
        /// <summary> The provisioning state of the node type resource. </summary>
        public ServiceFabricManagedResourceProvisioningState? ProvisioningState { get; }
        /// <summary> Specifies whether the network interface is accelerated networking-enabled. </summary>
        public bool? IsAcceleratedNetworkingEnabled { get; set; }
        /// <summary> Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity. </summary>
        public bool? UseDefaultPublicLoadBalancer { get; set; }
        /// <summary> Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types. </summary>
        public bool? UseTempDataDisk { get; set; }
        /// <summary> Specifies whether the node type should be overprovisioned. It is only allowed for stateless node types. </summary>
        public bool? IsOverProvisioningEnabled { get; set; }
        /// <summary> Specifies the availability zones where the node type would span across. If the cluster is not spanning across availability zones, initiates az migration for the cluster. </summary>
        public IList<string> Zones { get; }
        /// <summary> Indicates whether the node type will be Spot Virtual Machines. Azure will allocate the VMs if there is capacity available and the VMs can be evicted at any time. </summary>
        public bool? IsSpotVm { get; set; }
        /// <summary> Specifies the full host group resource Id. This property is used for deploying on azure dedicated hosts. </summary>
        public string HostGroupId { get; set; }
        /// <summary> Indicates whether to use ephemeral os disk. The sku selected on the vmSize property needs to support this feature. </summary>
        public bool? UseEphemeralOSDisk { get; set; }
        /// <summary> Indicates the time duration after which the platform will not try to restore the VMSS SPOT instances specified as ISO 8601. </summary>
        public string SpotRestoreTimeout { get; set; }
        /// <summary> Specifies the eviction policy for virtual machines in a SPOT node type. Default is Delete. </summary>
        public SpotNodeVmEvictionPolicyType? EvictionPolicy { get; set; }
        /// <summary> Indicates the resource id of the vm image. This parameter is used for custom vm image. </summary>
        public ResourceIdentifier VmImageResourceId { get; set; }
        /// <summary> Indicates the resource id of the subnet for the node type. </summary>
        public ResourceIdentifier SubnetId { get; set; }
        /// <summary> Specifies the actions to be performed on the vms before bootstrapping the service fabric runtime. </summary>
        public IList<VmSetupAction> VmSetupActions { get; }
        /// <summary> Specifies the security type of the nodeType. Only TrustedLaunch is currently supported. </summary>
        public ServiceFabricManagedClusterSecurityType? SecurityType { get; set; }
        /// <summary> Specifies whether secure boot should be enabled on the nodeType. Can only be used with TrustedLaunch SecurityType. </summary>
        public bool? IsSecureBootEnabled { get; set; }
        /// <summary> Specifies whether each node is allocated its own public IP address. This is only supported on secondary node types with custom Load Balancers. </summary>
        public bool? IsNodePublicIPEnabled { get; set; }
        /// <summary> Indicates the resource id of the vm shared galleries image. This parameter is used for custom vm image. </summary>
        public ResourceIdentifier VmSharedGalleryImageId { get; set; }
        /// <summary> Specifies the resource id of a NAT Gateway to attach to the subnet of this node type. Node type must use custom load balancer. </summary>
        public ResourceIdentifier NatGatewayId { get; set; }
        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use. In the Azure portal, find the marketplace image that you want to use and then click Want to deploy programmatically, Get Started -&gt;. Enter any required information and then click Save. </summary>
        public VmImagePlan VmImagePlan { get; set; }
        /// <summary> Azure resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
