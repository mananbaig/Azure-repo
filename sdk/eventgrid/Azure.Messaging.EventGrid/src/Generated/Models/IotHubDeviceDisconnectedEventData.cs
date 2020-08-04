// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Event data for Microsoft.Devices.DeviceDisconnected event. </summary>
    public partial class IotHubDeviceDisconnectedEventData : DeviceConnectionStateEventProperties
    {
        /// <summary> Initializes a new instance of IotHubDeviceDisconnectedEventData. </summary>
        internal IotHubDeviceDisconnectedEventData()
        {
        }

        /// <summary> Initializes a new instance of IotHubDeviceDisconnectedEventData. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ &apos;. </param>
        /// <param name="moduleId"> The unique identifier of the module. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ &apos;. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="deviceConnectionStateEventInfo"> Information about the device connection state event. </param>
        internal IotHubDeviceDisconnectedEventData(string deviceId, string moduleId, string hubName, DeviceConnectionStateEventInfo deviceConnectionStateEventInfo) : base(deviceId, moduleId, hubName, deviceConnectionStateEventInfo)
        {
        }
    }
}
