// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Akamai Signature Header authentication key. </summary>
    public partial class AkamaiSignatureHeaderAuthenticationKey
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

        /// <summary> Initializes a new instance of <see cref="AkamaiSignatureHeaderAuthenticationKey"/>. </summary>
        public AkamaiSignatureHeaderAuthenticationKey()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AkamaiSignatureHeaderAuthenticationKey"/>. </summary>
        /// <param name="identifier"> identifier of the key. </param>
        /// <param name="base64Key"> authentication key. </param>
        /// <param name="expireOn"> The expiration time of the authentication key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AkamaiSignatureHeaderAuthenticationKey(string identifier, string base64Key, DateTimeOffset? expireOn, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identifier = identifier;
            Base64Key = base64Key;
            ExpireOn = expireOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> identifier of the key. </summary>
        public string Identifier { get; set; }
        /// <summary> authentication key. </summary>
        public string Base64Key { get; set; }
        /// <summary> The expiration time of the authentication key. </summary>
        public DateTimeOffset? ExpireOn { get; set; }
    }
}
