// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Status of packet capture session. </summary>
    public partial class PacketCaptureQueryStatusResult
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="PacketCaptureQueryStatusResult"/>. </summary>
        internal PacketCaptureQueryStatusResult()
        {
            PacketCaptureError = new ChangeTrackingList<PcError>();
        }

        /// <summary> Initializes a new instance of <see cref="PacketCaptureQueryStatusResult"/>. </summary>
        /// <param name="name"> The name of the packet capture resource. </param>
        /// <param name="id"> The ID of the packet capture resource. </param>
        /// <param name="captureStartOn"> The start time of the packet capture session. </param>
        /// <param name="packetCaptureStatus"> The status of the packet capture session. </param>
        /// <param name="stopReason"> The reason the current packet capture session was stopped. </param>
        /// <param name="packetCaptureError"> List of errors of packet capture session. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PacketCaptureQueryStatusResult(string name, string id, DateTimeOffset? captureStartOn, PcStatus? packetCaptureStatus, string stopReason, IReadOnlyList<PcError> packetCaptureError, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Id = id;
            CaptureStartOn = captureStartOn;
            PacketCaptureStatus = packetCaptureStatus;
            StopReason = stopReason;
            PacketCaptureError = packetCaptureError;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the packet capture resource. </summary>
        public string Name { get; }
        /// <summary> The ID of the packet capture resource. </summary>
        public string Id { get; }
        /// <summary> The start time of the packet capture session. </summary>
        public DateTimeOffset? CaptureStartOn { get; }
        /// <summary> The status of the packet capture session. </summary>
        public PcStatus? PacketCaptureStatus { get; }
        /// <summary> The reason the current packet capture session was stopped. </summary>
        public string StopReason { get; }
        /// <summary> List of errors of packet capture session. </summary>
        public IReadOnlyList<PcError> PacketCaptureError { get; }
    }
}
