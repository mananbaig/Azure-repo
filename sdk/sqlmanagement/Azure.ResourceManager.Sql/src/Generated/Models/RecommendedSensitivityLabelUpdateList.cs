// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of recommended sensitivity label update operations. </summary>
    public partial class RecommendedSensitivityLabelUpdateList
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

        /// <summary> Initializes a new instance of <see cref="RecommendedSensitivityLabelUpdateList"/>. </summary>
        public RecommendedSensitivityLabelUpdateList()
        {
            Operations = new ChangeTrackingList<RecommendedSensitivityLabelUpdate>();
        }

        /// <summary> Initializes a new instance of <see cref="RecommendedSensitivityLabelUpdateList"/>. </summary>
        /// <param name="operations"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RecommendedSensitivityLabelUpdateList(IList<RecommendedSensitivityLabelUpdate> operations, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Operations = operations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the operations. </summary>
        public IList<RecommendedSensitivityLabelUpdate> Operations { get; }
    }
}
