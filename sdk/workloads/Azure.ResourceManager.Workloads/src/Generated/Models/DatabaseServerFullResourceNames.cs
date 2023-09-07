// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The full resource names object for database layer resources. The number of entries in this list should be equal to the number VMs to be created for database layer. </summary>
    public partial class DatabaseServerFullResourceNames
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseServerFullResourceNames"/>. </summary>
        public DatabaseServerFullResourceNames()
        {
            VirtualMachines = new ChangeTrackingList<VirtualMachineResourceNames>();
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseServerFullResourceNames"/>. </summary>
        /// <param name="virtualMachines"> The list of virtual machine naming details. </param>
        /// <param name="availabilitySetName"> The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet. </param>
        /// <param name="loadBalancer"> The resource names object for load balancer and related resources. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseServerFullResourceNames(IList<VirtualMachineResourceNames> virtualMachines, string availabilitySetName, LoadBalancerResourceNames loadBalancer, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualMachines = virtualMachines;
            AvailabilitySetName = availabilitySetName;
            LoadBalancer = loadBalancer;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of virtual machine naming details. </summary>
        public IList<VirtualMachineResourceNames> VirtualMachines { get; }
        /// <summary> The full name for availability set. In case name is not provided, it will be defaulted to {SID}-DB-AvSet. </summary>
        public string AvailabilitySetName { get; set; }
        /// <summary> The resource names object for load balancer and related resources. </summary>
        public LoadBalancerResourceNames LoadBalancer { get; set; }
    }
}
