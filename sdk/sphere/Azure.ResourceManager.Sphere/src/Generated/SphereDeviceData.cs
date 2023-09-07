// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sphere.Models;

namespace Azure.ResourceManager.Sphere
{
    /// <summary>
    /// A class representing the SphereDevice data model.
    /// An device resource belonging to a device group resource.
    /// Serialized Name: Device
    /// </summary>
    public partial class SphereDeviceData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SphereDeviceData"/>. </summary>
        public SphereDeviceData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SphereDeviceData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deviceId">
        /// Device ID
        /// Serialized Name: Device.properties.deviceId
        /// </param>
        /// <param name="chipSku">
        /// SKU of the chip
        /// Serialized Name: Device.properties.chipSku
        /// </param>
        /// <param name="lastAvailableOSVersion">
        /// OS version available for installation when update requested
        /// Serialized Name: Device.properties.lastAvailableOsVersion
        /// </param>
        /// <param name="lastInstalledOSVersion">
        /// OS version running on device when update requested
        /// Serialized Name: Device.properties.lastInstalledOsVersion
        /// </param>
        /// <param name="lastOSUpdateUtc">
        /// Time when update requested and new OS version available
        /// Serialized Name: Device.properties.lastOsUpdateUtc
        /// </param>
        /// <param name="lastUpdateRequestUtc">
        /// Time when update was last requested
        /// Serialized Name: Device.properties.lastUpdateRequestUtc
        /// </param>
        /// <param name="provisioningState">
        /// The status of the last operation.
        /// Serialized Name: Device.properties.provisioningState
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SphereDeviceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string deviceId, string chipSku, string lastAvailableOSVersion, string lastInstalledOSVersion, DateTimeOffset? lastOSUpdateUtc, DateTimeOffset? lastUpdateRequestUtc, SphereProvisioningState? provisioningState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DeviceId = deviceId;
            ChipSku = chipSku;
            LastAvailableOSVersion = lastAvailableOSVersion;
            LastInstalledOSVersion = lastInstalledOSVersion;
            LastOSUpdateUtc = lastOSUpdateUtc;
            LastUpdateRequestUtc = lastUpdateRequestUtc;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Device ID
        /// Serialized Name: Device.properties.deviceId
        /// </summary>
        public string DeviceId { get; set; }
        /// <summary>
        /// SKU of the chip
        /// Serialized Name: Device.properties.chipSku
        /// </summary>
        public string ChipSku { get; }
        /// <summary>
        /// OS version available for installation when update requested
        /// Serialized Name: Device.properties.lastAvailableOsVersion
        /// </summary>
        public string LastAvailableOSVersion { get; }
        /// <summary>
        /// OS version running on device when update requested
        /// Serialized Name: Device.properties.lastInstalledOsVersion
        /// </summary>
        public string LastInstalledOSVersion { get; }
        /// <summary>
        /// Time when update requested and new OS version available
        /// Serialized Name: Device.properties.lastOsUpdateUtc
        /// </summary>
        public DateTimeOffset? LastOSUpdateUtc { get; }
        /// <summary>
        /// Time when update was last requested
        /// Serialized Name: Device.properties.lastUpdateRequestUtc
        /// </summary>
        public DateTimeOffset? LastUpdateRequestUtc { get; }
        /// <summary>
        /// The status of the last operation.
        /// Serialized Name: Device.properties.provisioningState
        /// </summary>
        public SphereProvisioningState? ProvisioningState { get; }
    }
}
