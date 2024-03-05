// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Advisor;

namespace Azure.ResourceManager.Advisor.Models
{
    /// <summary> The list of Advisor recommendations. </summary>
    internal partial class ResourceRecommendationBaseListResult
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

        /// <summary> Initializes a new instance of <see cref="ResourceRecommendationBaseListResult"/>. </summary>
        internal ResourceRecommendationBaseListResult()
        {
            Value = new ChangeTrackingList<ResourceRecommendationBaseData>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceRecommendationBaseListResult"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of recommendations. </param>
        /// <param name="value"> The list of recommendations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceRecommendationBaseListResult(string nextLink, IReadOnlyList<ResourceRecommendationBaseData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The link used to get the next page of recommendations. </summary>
        public string NextLink { get; }
        /// <summary> The list of recommendations. </summary>
        public IReadOnlyList<ResourceRecommendationBaseData> Value { get; }
    }
}
