// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The available private link resources for a provisioning service. </summary>
    internal partial class PrivateLinkResources
    {
        /// <summary> Initializes a new instance of PrivateLinkResources. </summary>
        internal PrivateLinkResources()
        {
            Value = new Core.ChangeTrackingList<DeviceProvisioningServicesPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of PrivateLinkResources. </summary>
        /// <param name="value"> The list of available private link resources for a provisioning service. </param>
        internal PrivateLinkResources(IReadOnlyList<DeviceProvisioningServicesPrivateLinkResourceData> value)
        {
            Value = value;
        }

        /// <summary> The list of available private link resources for a provisioning service. </summary>
        public IReadOnlyList<DeviceProvisioningServicesPrivateLinkResourceData> Value { get; }
    }
}
