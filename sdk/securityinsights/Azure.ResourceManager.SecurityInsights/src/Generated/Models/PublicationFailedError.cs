// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary>
    /// The error description for why a publication failed
    /// Serialized Name: Error
    /// </summary>
    public partial class PublicationFailedError
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

        /// <summary> Initializes a new instance of <see cref="PublicationFailedError"/>. </summary>
        /// <param name="memberResourceName">
        /// The member resource name for which the publication error occured
        /// Serialized Name: Error.memberResourceName
        /// </param>
        /// <param name="errorMessage">
        /// The error message
        /// Serialized Name: Error.errorMessage
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="memberResourceName"/> or <paramref name="errorMessage"/> is null. </exception>
        public PublicationFailedError(string memberResourceName, string errorMessage)
        {
            Argument.AssertNotNull(memberResourceName, nameof(memberResourceName));
            Argument.AssertNotNull(errorMessage, nameof(errorMessage));

            MemberResourceName = memberResourceName;
            ErrorMessage = errorMessage;
        }

        /// <summary> Initializes a new instance of <see cref="PublicationFailedError"/>. </summary>
        /// <param name="memberResourceName">
        /// The member resource name for which the publication error occured
        /// Serialized Name: Error.memberResourceName
        /// </param>
        /// <param name="errorMessage">
        /// The error message
        /// Serialized Name: Error.errorMessage
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PublicationFailedError(string memberResourceName, string errorMessage, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MemberResourceName = memberResourceName;
            ErrorMessage = errorMessage;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="PublicationFailedError"/> for deserialization. </summary>
        internal PublicationFailedError()
        {
        }

        /// <summary>
        /// The member resource name for which the publication error occured
        /// Serialized Name: Error.memberResourceName
        /// </summary>
        public string MemberResourceName { get; set; }
        /// <summary>
        /// The error message
        /// Serialized Name: Error.errorMessage
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
