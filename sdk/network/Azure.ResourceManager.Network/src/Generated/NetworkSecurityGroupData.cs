// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkSecurityGroup data model.
    /// NetworkSecurityGroup resource.
    /// </summary>
    public partial class NetworkSecurityGroupData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupData"/>. </summary>
        public NetworkSecurityGroupData()
        {
            SecurityRules = new ChangeTrackingList<SecurityRuleData>();
            DefaultSecurityRules = new ChangeTrackingList<SecurityRuleData>();
            NetworkInterfaces = new ChangeTrackingList<NetworkInterfaceData>();
            Subnets = new ChangeTrackingList<SubnetData>();
            FlowLogs = new ChangeTrackingList<FlowLogData>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkSecurityGroupData"/>. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="flushConnection"> When enabled, flows created from Network Security Group connections will be re-evaluated when rules are updates. Initial enablement will trigger re-evaluation. </param>
        /// <param name="securityRules"> A collection of security rules of the network security group. </param>
        /// <param name="defaultSecurityRules"> The default security rules of network security group. </param>
        /// <param name="networkInterfaces"> A collection of references to network interfaces. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="flowLogs"> A collection of references to flow log resources. </param>
        /// <param name="resourceGuid"> The resource GUID property of the network security group resource. </param>
        /// <param name="provisioningState"> The provisioning state of the network security group resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkSecurityGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, ETag? etag, bool? flushConnection, IList<SecurityRuleData> securityRules, IReadOnlyList<SecurityRuleData> defaultSecurityRules, IReadOnlyList<NetworkInterfaceData> networkInterfaces, IReadOnlyList<SubnetData> subnets, IReadOnlyList<FlowLogData> flowLogs, Guid? resourceGuid, NetworkProvisioningState? provisioningState, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, location, tags, rawData)
        {
            ETag = etag;
            FlushConnection = flushConnection;
            SecurityRules = securityRules;
            DefaultSecurityRules = defaultSecurityRules;
            NetworkInterfaces = networkInterfaces;
            Subnets = subnets;
            FlowLogs = flowLogs;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> When enabled, flows created from Network Security Group connections will be re-evaluated when rules are updates. Initial enablement will trigger re-evaluation. </summary>
        public bool? FlushConnection { get; set; }
        /// <summary> A collection of security rules of the network security group. </summary>
        public IList<SecurityRuleData> SecurityRules { get; }
        /// <summary> The default security rules of network security group. </summary>
        public IReadOnlyList<SecurityRuleData> DefaultSecurityRules { get; }
        /// <summary> A collection of references to network interfaces. </summary>
        public IReadOnlyList<NetworkInterfaceData> NetworkInterfaces { get; }
        /// <summary> A collection of references to subnets. </summary>
        public IReadOnlyList<SubnetData> Subnets { get; }
        /// <summary> A collection of references to flow log resources. </summary>
        public IReadOnlyList<FlowLogData> FlowLogs { get; }
        /// <summary> The resource GUID property of the network security group resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> The provisioning state of the network security group resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
