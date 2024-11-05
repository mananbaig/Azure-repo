// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary> Document author. </summary>
    public partial class ClinicalDocumentAuthor
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

        /// <summary> Initializes a new instance of <see cref="ClinicalDocumentAuthor"/>. </summary>
        public ClinicalDocumentAuthor()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClinicalDocumentAuthor"/>. </summary>
        /// <param name="id"> author id. </param>
        /// <param name="fullName"> Text representation of the full name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClinicalDocumentAuthor(string id, string fullName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            FullName = fullName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> author id. </summary>
        public string Id { get; set; }
        /// <summary> Text representation of the full name. </summary>
        public string FullName { get; set; }
    }
}
