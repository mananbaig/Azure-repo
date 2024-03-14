// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceFabricManagedClusters;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Describes a Subnet. </summary>
    public partial class ManagedClusterSubnet
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ManagedClusterSubnet"/>. </summary>
        /// <param name="name"> Subnet name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ManagedClusterSubnet(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterSubnet"/>. </summary>
        /// <param name="name"> Subnet name. </param>
        /// <param name="isIPv6Enabled"> Indicates wether to enable Ipv6 or not. If not provided, it will take the same configuration as the cluster. </param>
        /// <param name="privateEndpointNetworkPolicies"> Enable or Disable apply network policies on private end point in the subnet. </param>
        /// <param name="privateLinkServiceNetworkPolicies"> Enable or Disable apply network policies on private link service in the subnet. </param>
        /// <param name="networkSecurityGroupId"> Full resource id for the network security group. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedClusterSubnet(string name, bool? isIPv6Enabled, ManagedClusterSubnetPrivateEndpointNetworkPoliciesState? privateEndpointNetworkPolicies, ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState? privateLinkServiceNetworkPolicies, ResourceIdentifier networkSecurityGroupId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            IsIPv6Enabled = isIPv6Enabled;
            PrivateEndpointNetworkPolicies = privateEndpointNetworkPolicies;
            PrivateLinkServiceNetworkPolicies = privateLinkServiceNetworkPolicies;
            NetworkSecurityGroupId = networkSecurityGroupId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedClusterSubnet"/> for deserialization. </summary>
        internal ManagedClusterSubnet()
        {
        }

        /// <summary> Subnet name. </summary>
        public string Name { get; set; }
        /// <summary> Indicates wether to enable Ipv6 or not. If not provided, it will take the same configuration as the cluster. </summary>
        public bool? IsIPv6Enabled { get; set; }
        /// <summary> Enable or Disable apply network policies on private end point in the subnet. </summary>
        public ManagedClusterSubnetPrivateEndpointNetworkPoliciesState? PrivateEndpointNetworkPolicies { get; set; }
        /// <summary> Enable or Disable apply network policies on private link service in the subnet. </summary>
        public ManagedClusterSubnetPrivateLinkServiceNetworkPoliciesState? PrivateLinkServiceNetworkPolicies { get; set; }
        /// <summary> Full resource id for the network security group. </summary>
        public ResourceIdentifier NetworkSecurityGroupId { get; set; }
    }
}
