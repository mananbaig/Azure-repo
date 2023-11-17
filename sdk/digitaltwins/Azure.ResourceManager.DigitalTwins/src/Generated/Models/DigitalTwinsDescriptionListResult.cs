// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> A list of DigitalTwins description objects with a next link. </summary>
    internal partial class DigitalTwinsDescriptionListResult
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

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsDescriptionListResult"/>. </summary>
        internal DigitalTwinsDescriptionListResult()
        {
            Value = new ChangeTrackingList<DigitalTwinsDescriptionData>();
        }

        /// <summary> Initializes a new instance of <see cref="DigitalTwinsDescriptionListResult"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of DigitalTwins description objects. </param>
        /// <param name="value"> A list of DigitalTwins description objects. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DigitalTwinsDescriptionListResult(string nextLink, IReadOnlyList<DigitalTwinsDescriptionData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link used to get the next page of DigitalTwins description objects. </summary>
        public string NextLink { get; }
        /// <summary> A list of DigitalTwins description objects. </summary>
        public IReadOnlyList<DigitalTwinsDescriptionData> Value { get; }
    }
}
