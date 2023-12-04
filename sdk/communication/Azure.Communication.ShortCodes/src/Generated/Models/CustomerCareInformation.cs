// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.ShortCodes.Models
{
    /// <summary> Customer Care Information. </summary>
    public partial class CustomerCareInformation
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

        /// <summary> Initializes a new instance of <see cref="CustomerCareInformation"/>. </summary>
        public CustomerCareInformation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomerCareInformation"/>. </summary>
        /// <param name="tollFreeNumber"> Customer support phone number for the customer submitting the Program Brief. Use E164 format. e.g. +18005551212. </param>
        /// <param name="email"> Customer support email address for the customer submitting the Program Brief. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomerCareInformation(string tollFreeNumber, string email, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TollFreeNumber = tollFreeNumber;
            Email = email;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Customer support phone number for the customer submitting the Program Brief. Use E164 format. e.g. +18005551212. </summary>
        public string TollFreeNumber { get; set; }
        /// <summary> Customer support email address for the customer submitting the Program Brief. </summary>
        public string Email { get; set; }
    }
}
