// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Multi subnet ip configuration for an availability group listener. </summary>
    public partial class MultiSubnetIPConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MultiSubnetIPConfiguration"/>. </summary>
        /// <param name="privateIPAddress"> Private IP address. </param>
        /// <param name="sqlVmInstance"> SQL virtual machine instance resource id that are enrolled into the availability group listener. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="privateIPAddress"/> or <paramref name="sqlVmInstance"/> is null. </exception>
        public MultiSubnetIPConfiguration(AvailabilityGroupListenerPrivateIPAddress privateIPAddress, string sqlVmInstance)
        {
            Argument.AssertNotNull(privateIPAddress, nameof(privateIPAddress));
            Argument.AssertNotNull(sqlVmInstance, nameof(sqlVmInstance));

            PrivateIPAddress = privateIPAddress;
            SqlVmInstance = sqlVmInstance;
        }

        /// <summary> Initializes a new instance of <see cref="MultiSubnetIPConfiguration"/>. </summary>
        /// <param name="privateIPAddress"> Private IP address. </param>
        /// <param name="sqlVmInstance"> SQL virtual machine instance resource id that are enrolled into the availability group listener. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MultiSubnetIPConfiguration(AvailabilityGroupListenerPrivateIPAddress privateIPAddress, string sqlVmInstance, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PrivateIPAddress = privateIPAddress;
            SqlVmInstance = sqlVmInstance;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MultiSubnetIPConfiguration"/> for deserialization. </summary>
        internal MultiSubnetIPConfiguration()
        {
        }

        /// <summary> Private IP address. </summary>
        public AvailabilityGroupListenerPrivateIPAddress PrivateIPAddress { get; set; }
        /// <summary> SQL virtual machine instance resource id that are enrolled into the availability group listener. </summary>
        public string SqlVmInstance { get; set; }
    }
}
