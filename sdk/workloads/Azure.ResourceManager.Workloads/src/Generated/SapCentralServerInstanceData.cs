// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;
using Azure.ResourceManager.Workloads.Models;

namespace Azure.ResourceManager.Workloads
{
    /// <summary>
    /// A class representing the SapCentralServerInstance data model.
    /// Define the SAP Central Services Instance resource.
    /// </summary>
    public partial class SapCentralServerInstanceData : TrackedResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SapCentralServerInstanceData"/>. </summary>
        /// <param name="location"> The location. </param>
        public SapCentralServerInstanceData(AzureLocation location) : base(location)
        {
            VmDetails = new ChangeTrackingList<CentralServerVmDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="SapCentralServerInstanceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="instanceNo"> The central services instance number. </param>
        /// <param name="subnetId"> The central services instance subnet. </param>
        /// <param name="messageServerProperties"> Defines the SAP Message Server properties. </param>
        /// <param name="enqueueServerProperties"> Defines the SAP Enqueue Server properties. </param>
        /// <param name="gatewayServerProperties"> Defines the SAP Gateway Server properties. </param>
        /// <param name="enqueueReplicationServerProperties"> Defines the SAP Enqueue Replication Server (ERS) properties. </param>
        /// <param name="kernelVersion"> The central services instance Kernel Version. </param>
        /// <param name="kernelPatch"> The central services instance Kernel Patch level. </param>
        /// <param name="loadBalancerDetails"> The Load Balancer details such as LoadBalancer ID attached to ASCS Virtual Machines. </param>
        /// <param name="vmDetails"> The list of virtual machines corresponding to the Central Services instance. </param>
        /// <param name="status"> Defines the SAP Instance status. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="provisioningState"> Defines the provisioning states. </param>
        /// <param name="errors"> Defines the errors related to SAP Central Services Instance resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SapCentralServerInstanceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string instanceNo, ResourceIdentifier subnetId, MessageServerProperties messageServerProperties, EnqueueServerProperties enqueueServerProperties, GatewayServerProperties gatewayServerProperties, EnqueueReplicationServerProperties enqueueReplicationServerProperties, string kernelVersion, string kernelPatch, SubResource loadBalancerDetails, IReadOnlyList<CentralServerVmDetails> vmDetails, SapVirtualInstanceStatus? status, SapHealthState? health, SapVirtualInstanceProvisioningState? provisioningState, SapVirtualInstanceError errors, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            InstanceNo = instanceNo;
            SubnetId = subnetId;
            MessageServerProperties = messageServerProperties;
            EnqueueServerProperties = enqueueServerProperties;
            GatewayServerProperties = gatewayServerProperties;
            EnqueueReplicationServerProperties = enqueueReplicationServerProperties;
            KernelVersion = kernelVersion;
            KernelPatch = kernelPatch;
            LoadBalancerDetails = loadBalancerDetails;
            VmDetails = vmDetails;
            Status = status;
            Health = health;
            ProvisioningState = provisioningState;
            Errors = errors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SapCentralServerInstanceData"/> for deserialization. </summary>
        internal SapCentralServerInstanceData()
        {
        }

        /// <summary> The central services instance number. </summary>
        public string InstanceNo { get; }
        /// <summary> The central services instance subnet. </summary>
        public ResourceIdentifier SubnetId { get; }
        /// <summary> Defines the SAP Message Server properties. </summary>
        public MessageServerProperties MessageServerProperties { get; set; }
        /// <summary> Defines the SAP Enqueue Server properties. </summary>
        public EnqueueServerProperties EnqueueServerProperties { get; set; }
        /// <summary> Defines the SAP Gateway Server properties. </summary>
        public GatewayServerProperties GatewayServerProperties { get; set; }
        /// <summary> Defines the SAP Enqueue Replication Server (ERS) properties. </summary>
        public EnqueueReplicationServerProperties EnqueueReplicationServerProperties { get; set; }
        /// <summary> The central services instance Kernel Version. </summary>
        public string KernelVersion { get; }
        /// <summary> The central services instance Kernel Patch level. </summary>
        public string KernelPatch { get; }
        /// <summary> The Load Balancer details such as LoadBalancer ID attached to ASCS Virtual Machines. </summary>
        internal SubResource LoadBalancerDetails { get; }
        /// <summary> Gets Id. </summary>
        public ResourceIdentifier LoadBalancerDetailsId
        {
            get => LoadBalancerDetails?.Id;
        }

        /// <summary> The list of virtual machines corresponding to the Central Services instance. </summary>
        public IReadOnlyList<CentralServerVmDetails> VmDetails { get; }
        /// <summary> Defines the SAP Instance status. </summary>
        public SapVirtualInstanceStatus? Status { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
        /// <summary> Defines the provisioning states. </summary>
        public SapVirtualInstanceProvisioningState? ProvisioningState { get; }
        /// <summary> Defines the errors related to SAP Central Services Instance resource. </summary>
        internal SapVirtualInstanceError Errors { get; }
        /// <summary> The Virtual Instance for SAP error body. </summary>
        public SapVirtualInstanceErrorDetail ErrorsProperties
        {
            get => Errors?.Properties;
        }
    }
}
