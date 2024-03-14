// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Analysis;

namespace Azure.ResourceManager.Analysis.Models
{
    /// <summary> Represents the SKU name and Azure pricing tier for Analysis Services resource. </summary>
    public partial class AnalysisResourceSku
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

        /// <summary> Initializes a new instance of <see cref="AnalysisResourceSku"/>. </summary>
        /// <param name="name"> Name of the SKU level. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public AnalysisResourceSku(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisResourceSku"/>. </summary>
        /// <param name="name"> Name of the SKU level. </param>
        /// <param name="tier"> The name of the Azure pricing tier to which the SKU applies. </param>
        /// <param name="capacity"> The number of instances in the read only query pool. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalysisResourceSku(string name, AnalysisSkuTier? tier, int? capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalysisResourceSku"/> for deserialization. </summary>
        internal AnalysisResourceSku()
        {
        }

        /// <summary> Name of the SKU level. </summary>
        public string Name { get; set; }
        /// <summary> The name of the Azure pricing tier to which the SKU applies. </summary>
        public AnalysisSkuTier? Tier { get; set; }
        /// <summary> The number of instances in the read only query pool. </summary>
        public int? Capacity { get; set; }
    }
}
