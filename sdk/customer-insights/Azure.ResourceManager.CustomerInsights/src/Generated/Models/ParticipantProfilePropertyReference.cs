// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CustomerInsights;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The participant profile property reference. </summary>
    public partial class ParticipantProfilePropertyReference
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

        /// <summary> Initializes a new instance of <see cref="ParticipantProfilePropertyReference"/>. </summary>
        /// <param name="interactionPropertyName"> The source interaction property that maps to the target profile property. </param>
        /// <param name="profilePropertyName"> The target profile property that maps to the source interaction property. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="interactionPropertyName"/> or <paramref name="profilePropertyName"/> is null. </exception>
        public ParticipantProfilePropertyReference(string interactionPropertyName, string profilePropertyName)
        {
            Argument.AssertNotNull(interactionPropertyName, nameof(interactionPropertyName));
            Argument.AssertNotNull(profilePropertyName, nameof(profilePropertyName));

            InteractionPropertyName = interactionPropertyName;
            ProfilePropertyName = profilePropertyName;
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantProfilePropertyReference"/>. </summary>
        /// <param name="interactionPropertyName"> The source interaction property that maps to the target profile property. </param>
        /// <param name="profilePropertyName"> The target profile property that maps to the source interaction property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ParticipantProfilePropertyReference(string interactionPropertyName, string profilePropertyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InteractionPropertyName = interactionPropertyName;
            ProfilePropertyName = profilePropertyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ParticipantProfilePropertyReference"/> for deserialization. </summary>
        internal ParticipantProfilePropertyReference()
        {
        }

        /// <summary> The source interaction property that maps to the target profile property. </summary>
        public string InteractionPropertyName { get; set; }
        /// <summary> The target profile property that maps to the source interaction property. </summary>
        public string ProfilePropertyName { get; set; }
    }
}
