// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The Video Analyzer edge module can act as a transparent gateway for video, enabling IoT devices to send video to the cloud from behind a firewall. A remote device adapter should be created for each such IoT device. Communication between the cloud and IoT device would then flow via the Video Analyzer edge module. </summary>
    public partial class RemoteDeviceAdapter
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapter"/>. </summary>
        /// <param name="name"> The unique identifier for the remote device adapter. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public RemoteDeviceAdapter(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapter"/>. </summary>
        /// <param name="name"> The unique identifier for the remote device adapter. </param>
        /// <param name="systemData"> Read-only system metadata associated with this object. </param>
        /// <param name="properties"> Properties of the remote device adapter. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RemoteDeviceAdapter(string name, SystemData systemData, RemoteDeviceAdapterProperties properties, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemoteDeviceAdapter"/> for deserialization. </summary>
        internal RemoteDeviceAdapter()
        {
        }

        /// <summary> The unique identifier for the remote device adapter. </summary>
        public string Name { get; set; }
        /// <summary> Read-only system metadata associated with this object. </summary>
        public SystemData SystemData { get; set; }
        /// <summary> Properties of the remote device adapter. </summary>
        public RemoteDeviceAdapterProperties Properties { get; set; }
    }
}
