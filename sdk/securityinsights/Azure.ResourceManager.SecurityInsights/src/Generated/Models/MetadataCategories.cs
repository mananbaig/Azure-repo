// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// ies for the solution content item
    /// Serialized Name: MetadataCategories
    /// </summary>
    public partial class MetadataCategories
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

        /// <summary> Initializes a new instance of <see cref="MetadataCategories"/>. </summary>
        public MetadataCategories()
        {
            Domains = new ChangeTrackingList<string>();
            Verticals = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="MetadataCategories"/>. </summary>
        /// <param name="domains">
        /// domain for the solution content item
        /// Serialized Name: MetadataCategories.domains
        /// </param>
        /// <param name="verticals">
        /// Industry verticals for the solution content item
        /// Serialized Name: MetadataCategories.verticals
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MetadataCategories(IList<string> domains, IList<string> verticals, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Domains = domains;
            Verticals = verticals;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// domain for the solution content item
        /// Serialized Name: MetadataCategories.domains
        /// </summary>
        public IList<string> Domains { get; }
        /// <summary>
        /// Industry verticals for the solution content item
        /// Serialized Name: MetadataCategories.verticals
        /// </summary>
        public IList<string> Verticals { get; }
    }
}
