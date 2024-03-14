// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HDInsight;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Result of the request to list cluster Applications. It contains a list of operations and a URL link to get the next set of results. </summary>
    internal partial class ApplicationListResult
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

        /// <summary> Initializes a new instance of <see cref="ApplicationListResult"/>. </summary>
        internal ApplicationListResult()
        {
            Value = new ChangeTrackingList<HDInsightApplicationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ApplicationListResult"/>. </summary>
        /// <param name="value"> The list of HDInsight applications installed on HDInsight cluster. </param>
        /// <param name="nextLink"> The URL to get the next set of operation list results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplicationListResult(IReadOnlyList<HDInsightApplicationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of HDInsight applications installed on HDInsight cluster. </summary>
        public IReadOnlyList<HDInsightApplicationData> Value { get; }
        /// <summary> The URL to get the next set of operation list results if there are any. </summary>
        public string NextLink { get; }
    }
}
