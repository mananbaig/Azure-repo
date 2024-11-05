// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Data about a user or client application. </summary>
    public partial class ThreatIntelligenceUserInfo
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

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceUserInfo"/>. </summary>
        internal ThreatIntelligenceUserInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ThreatIntelligenceUserInfo"/>. </summary>
        /// <param name="objectId"> The user's object ID. </param>
        /// <param name="email"> The user's email address. </param>
        /// <param name="name"> The user's name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ThreatIntelligenceUserInfo(Guid? objectId, string email, string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectId = objectId;
            Email = email;
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The user's object ID. </summary>
        [WirePath("objectId")]
        public Guid? ObjectId { get; }
        /// <summary> The user's email address. </summary>
        [WirePath("email")]
        public string Email { get; }
        /// <summary> The user's name. </summary>
        [WirePath("name")]
        public string Name { get; }
    }
}
