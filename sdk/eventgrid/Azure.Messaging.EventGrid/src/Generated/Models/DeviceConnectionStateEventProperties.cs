// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a device connection state event (DeviceConnected, DeviceDisconnected). </summary>
    public partial class DeviceConnectionStateEventProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DeviceConnectionStateEventProperties"/>. </summary>
        internal DeviceConnectionStateEventProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeviceConnectionStateEventProperties"/>. </summary>
        /// <param name="deviceId"> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </param>
        /// <param name="moduleId"> The unique identifier of the module. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </param>
        /// <param name="hubName"> Name of the IoT Hub where the device was created or deleted. </param>
        /// <param name="deviceConnectionStateEventInfo"> Information about the device connection state event. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeviceConnectionStateEventProperties(string deviceId, string moduleId, string hubName, DeviceConnectionStateEventInfo deviceConnectionStateEventInfo, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeviceId = deviceId;
            ModuleId = moduleId;
            HubName = hubName;
            DeviceConnectionStateEventInfo = deviceConnectionStateEventInfo;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The unique identifier of the device. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </summary>
        public string DeviceId { get; }
        /// <summary> The unique identifier of the module. This case-sensitive string can be up to 128 characters long, and supports ASCII 7-bit alphanumeric characters plus the following special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $ '. </summary>
        public string ModuleId { get; }
        /// <summary> Name of the IoT Hub where the device was created or deleted. </summary>
        public string HubName { get; }
        /// <summary> Information about the device connection state event. </summary>
        public DeviceConnectionStateEventInfo DeviceConnectionStateEventInfo { get; }
    }
}
