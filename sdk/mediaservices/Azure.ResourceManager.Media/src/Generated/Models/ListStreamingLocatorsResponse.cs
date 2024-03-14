// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The Streaming Locators associated with this Asset. </summary>
    internal partial class ListStreamingLocatorsResponse
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

        /// <summary> Initializes a new instance of <see cref="ListStreamingLocatorsResponse"/>. </summary>
        internal ListStreamingLocatorsResponse()
        {
            StreamingLocators = new ChangeTrackingList<MediaAssetStreamingLocator>();
        }

        /// <summary> Initializes a new instance of <see cref="ListStreamingLocatorsResponse"/>. </summary>
        /// <param name="streamingLocators"> The list of Streaming Locators. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ListStreamingLocatorsResponse(IReadOnlyList<MediaAssetStreamingLocator> streamingLocators, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StreamingLocators = streamingLocators;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of Streaming Locators. </summary>
        public IReadOnlyList<MediaAssetStreamingLocator> StreamingLocators { get; }
    }
}
