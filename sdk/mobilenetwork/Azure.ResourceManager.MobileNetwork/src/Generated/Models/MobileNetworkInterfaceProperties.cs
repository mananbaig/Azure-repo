// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Interface properties. </summary>
    public partial class MobileNetworkInterfaceProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkInterfaceProperties"/>. </summary>
        public MobileNetworkInterfaceProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkInterfaceProperties"/>. </summary>
        /// <param name="name"> The logical name for this interface. This should match one of the interfaces configured on your Azure Stack Edge device. </param>
        /// <param name="ipv4Address"> The IPv4 address. </param>
        /// <param name="ipv4Subnet"> The IPv4 subnet. </param>
        /// <param name="ipv4Gateway"> The default IPv4 gateway (router). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkInterfaceProperties(string name, string ipv4Address, string ipv4Subnet, string ipv4Gateway, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            IPv4Address = ipv4Address;
            IPv4Subnet = ipv4Subnet;
            IPv4Gateway = ipv4Gateway;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The logical name for this interface. This should match one of the interfaces configured on your Azure Stack Edge device. </summary>
        public string Name { get; set; }
        /// <summary> The IPv4 address. </summary>
        public string IPv4Address { get; set; }
        /// <summary> The IPv4 subnet. </summary>
        public string IPv4Subnet { get; set; }
        /// <summary> The default IPv4 gateway (router). </summary>
        public string IPv4Gateway { get; set; }
    }
}
