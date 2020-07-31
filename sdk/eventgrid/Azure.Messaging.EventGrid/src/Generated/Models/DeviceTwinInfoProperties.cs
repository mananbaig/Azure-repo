// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    /// <summary> Properties JSON element. </summary>
    public partial class DeviceTwinInfoProperties
    {
        /// <summary> Initializes a new instance of DeviceTwinInfoProperties. </summary>
        internal DeviceTwinInfoProperties()
        {
        }

        /// <summary> Initializes a new instance of DeviceTwinInfoProperties. </summary>
        /// <param name="desired"> A portion of the properties that can be written only by the application back-end, and read by the device. </param>
        /// <param name="reported"> A portion of the properties that can be written only by the device, and read by the application back-end. </param>
        internal DeviceTwinInfoProperties(DeviceTwinProperties desired, DeviceTwinProperties reported)
        {
            Desired = desired;
            Reported = reported;
        }

        /// <summary> A portion of the properties that can be written only by the application back-end, and read by the device. </summary>
        public DeviceTwinProperties Desired { get; }
        /// <summary> A portion of the properties that can be written only by the device, and read by the application back-end. </summary>
        public DeviceTwinProperties Reported { get; }
    }
}
