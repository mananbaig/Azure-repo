// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> A Microsoft Teams user. </summary>
    internal partial class MicrosoftTeamsUserIdentifierModel
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

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="userId"> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userId"/> is null. </exception>
        internal MicrosoftTeamsUserIdentifierModel(string userId)
        {
            Argument.AssertNotNull(userId, nameof(userId));

            UserId = userId;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/>. </summary>
        /// <param name="userId"> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </param>
        /// <param name="isAnonymous"> True if the Microsoft Teams user is anonymous. By default false if missing. </param>
        /// <param name="cloud"> The cloud that the Microsoft Teams user belongs to. By default 'public' if missing. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MicrosoftTeamsUserIdentifierModel(string userId, bool? isAnonymous, CommunicationCloudEnvironmentModel? cloud, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            UserId = userId;
            IsAnonymous = isAnonymous;
            Cloud = cloud;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MicrosoftTeamsUserIdentifierModel"/> for deserialization. </summary>
        internal MicrosoftTeamsUserIdentifierModel()
        {
        }

        /// <summary> The Id of the Microsoft Teams user. If not anonymous, this is the AAD object Id of the user. </summary>
        public string UserId { get; }
        /// <summary> True if the Microsoft Teams user is anonymous. By default false if missing. </summary>
        public bool? IsAnonymous { get; }
        /// <summary> The cloud that the Microsoft Teams user belongs to. By default 'public' if missing. </summary>
        public CommunicationCloudEnvironmentModel? Cloud { get; }
    }
}
