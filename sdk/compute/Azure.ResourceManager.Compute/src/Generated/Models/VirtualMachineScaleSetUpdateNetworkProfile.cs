// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Compute;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set network profile. </summary>
    public partial class VirtualMachineScaleSetUpdateNetworkProfile
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

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateNetworkProfile"/>. </summary>
        public VirtualMachineScaleSetUpdateNetworkProfile()
        {
            NetworkInterfaceConfigurations = new ChangeTrackingList<VirtualMachineScaleSetUpdateNetworkConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="VirtualMachineScaleSetUpdateNetworkProfile"/>. </summary>
        /// <param name="healthProbe"> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'. </param>
        /// <param name="networkInterfaceConfigurations"> The list of network configurations. </param>
        /// <param name="networkApiVersion"> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set with orchestration mode 'Flexible'. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal VirtualMachineScaleSetUpdateNetworkProfile(WritableSubResource healthProbe, IList<VirtualMachineScaleSetUpdateNetworkConfiguration> networkInterfaceConfigurations, NetworkApiVersion? networkApiVersion, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HealthProbe = healthProbe;
            NetworkInterfaceConfigurations = networkInterfaceConfigurations;
            NetworkApiVersion = networkApiVersion;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A reference to a load balancer probe used to determine the health of an instance in the virtual machine scale set. The reference will be in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/loadBalancers/{loadBalancerName}/probes/{probeName}'. </summary>
        internal WritableSubResource HealthProbe { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier HealthProbeId
        {
            get => HealthProbe is null ? default : HealthProbe.Id;
            set
            {
                if (HealthProbe is null)
                    HealthProbe = new WritableSubResource();
                HealthProbe.Id = value;
            }
        }

        /// <summary> The list of network configurations. </summary>
        public IList<VirtualMachineScaleSetUpdateNetworkConfiguration> NetworkInterfaceConfigurations { get; }
        /// <summary> specifies the Microsoft.Network API version used when creating networking resources in the Network Interface Configurations for Virtual Machine Scale Set with orchestration mode 'Flexible'. </summary>
        public NetworkApiVersion? NetworkApiVersion { get; set; }
    }
}
