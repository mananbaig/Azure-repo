// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The identity information for retrieving the certificate for the custom domain. </summary>
    public partial class CustomDomainIdentity
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

        /// <summary> Initializes a new instance of <see cref="CustomDomainIdentity"/>. </summary>
        public CustomDomainIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CustomDomainIdentity"/>. </summary>
        /// <param name="identityType"> The type of managed identity used. Can be either 'SystemAssigned' or 'UserAssigned'. </param>
        /// <param name="userAssignedIdentity"> The user identity associated with the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomDomainIdentity(CustomDomainIdentityType? identityType, string userAssignedIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IdentityType = identityType;
            UserAssignedIdentity = userAssignedIdentity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of managed identity used. Can be either 'SystemAssigned' or 'UserAssigned'. </summary>
        [WirePath("type")]
        public CustomDomainIdentityType? IdentityType { get; set; }
        /// <summary> The user identity associated with the resource. </summary>
        [WirePath("userAssignedIdentity")]
        public string UserAssignedIdentity { get; set; }
    }
}
