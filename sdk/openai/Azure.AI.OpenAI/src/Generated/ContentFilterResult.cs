// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    /// <summary> Information about filtered content severity level and if it has been filtered or not. </summary>
    public partial class ContentFilterResult
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

        /// <summary> Initializes a new instance of <see cref="ContentFilterResult"/>. </summary>
        /// <param name="severity"> Ratings for the intensity and risk level of filtered content. </param>
        /// <param name="filtered"> A value indicating whether or not the content has been filtered. </param>
        internal ContentFilterResult(ContentFilterSeverity severity, bool filtered)
        {
            Severity = severity;
            Filtered = filtered;
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterResult"/>. </summary>
        /// <param name="severity"> Ratings for the intensity and risk level of filtered content. </param>
        /// <param name="filtered"> A value indicating whether or not the content has been filtered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContentFilterResult(ContentFilterSeverity severity, bool filtered, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Severity = severity;
            Filtered = filtered;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContentFilterResult"/> for deserialization. </summary>
        internal ContentFilterResult()
        {
        }

        /// <summary> Ratings for the intensity and risk level of filtered content. </summary>
        public ContentFilterSeverity Severity { get; }
        /// <summary> A value indicating whether or not the content has been filtered. </summary>
        public bool Filtered { get; }
    }
}
