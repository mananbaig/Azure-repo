// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan protected item. </summary>
    public partial class RecoveryPlanProtectedItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanProtectedItem"/>. </summary>
        public RecoveryPlanProtectedItem()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanProtectedItem"/>. </summary>
        /// <param name="id"> The ARM Id of the recovery plan protected item. </param>
        /// <param name="virtualMachineId"> The virtual machine Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecoveryPlanProtectedItem(ResourceIdentifier id, string virtualMachineId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            VirtualMachineId = virtualMachineId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ARM Id of the recovery plan protected item. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The virtual machine Id. </summary>
        public string VirtualMachineId { get; set; }
    }
}
