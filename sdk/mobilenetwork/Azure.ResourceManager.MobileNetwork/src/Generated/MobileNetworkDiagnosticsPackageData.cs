// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the MobileNetworkDiagnosticsPackage data model.
    /// Diagnostics package resource.
    /// </summary>
    public partial class MobileNetworkDiagnosticsPackageData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MobileNetworkDiagnosticsPackageData"/>. </summary>
        public MobileNetworkDiagnosticsPackageData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MobileNetworkDiagnosticsPackageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> The provisioning state of the diagnostics package resource. </param>
        /// <param name="status"> The status of the diagnostics package collection. </param>
        /// <param name="reason"> The reason for the current state of the diagnostics package collection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MobileNetworkDiagnosticsPackageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MobileNetworkProvisioningState? provisioningState, MobileNetworkDiagnosticsPackageStatus? status, string reason, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            Status = status;
            Reason = reason;
            _rawData = rawData;
        }

        /// <summary> The provisioning state of the diagnostics package resource. </summary>
        public MobileNetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The status of the diagnostics package collection. </summary>
        public MobileNetworkDiagnosticsPackageStatus? Status { get; }
        /// <summary> The reason for the current state of the diagnostics package collection. </summary>
        public string Reason { get; }
    }
}
