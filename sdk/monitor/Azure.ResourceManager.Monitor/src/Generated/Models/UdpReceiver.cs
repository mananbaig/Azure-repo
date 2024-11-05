// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Receiver using UDP as transport protocol. </summary>
    public partial class UdpReceiver
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

        /// <summary> Initializes a new instance of <see cref="UdpReceiver"/>. </summary>
        /// <param name="endpoint"> TCP endpoint definition. Example: 0.0.0.0:&lt;port&gt;. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> is null. </exception>
        public UdpReceiver(string endpoint)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));

            Endpoint = endpoint;
        }

        /// <summary> Initializes a new instance of <see cref="UdpReceiver"/>. </summary>
        /// <param name="endpoint"> TCP endpoint definition. Example: 0.0.0.0:&lt;port&gt;. </param>
        /// <param name="encoding"> The encoding of the stream being received. </param>
        /// <param name="readQueueLength"> Max read queue length. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UdpReceiver(string endpoint, StreamEncodingType? encoding, int? readQueueLength, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Endpoint = endpoint;
            Encoding = encoding;
            ReadQueueLength = readQueueLength;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UdpReceiver"/> for deserialization. </summary>
        internal UdpReceiver()
        {
        }

        /// <summary> TCP endpoint definition. Example: 0.0.0.0:&lt;port&gt;. </summary>
        public string Endpoint { get; set; }
        /// <summary> The encoding of the stream being received. </summary>
        public StreamEncodingType? Encoding { get; set; }
        /// <summary> Max read queue length. </summary>
        public int? ReadQueueLength { get; set; }
    }
}
