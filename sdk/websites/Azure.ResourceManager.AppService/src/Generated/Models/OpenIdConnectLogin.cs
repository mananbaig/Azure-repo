// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the login flow of the custom Open ID Connect provider. </summary>
    public partial class OpenIdConnectLogin
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

        /// <summary> Initializes a new instance of <see cref="OpenIdConnectLogin"/>. </summary>
        public OpenIdConnectLogin()
        {
            Scopes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="OpenIdConnectLogin"/>. </summary>
        /// <param name="nameClaimType"> The name of the claim that contains the users name. </param>
        /// <param name="scopes"> A list of the scopes that should be requested while authenticating. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OpenIdConnectLogin(string nameClaimType, IList<string> scopes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NameClaimType = nameClaimType;
            Scopes = scopes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the claim that contains the users name. </summary>
        public string NameClaimType { get; set; }
        /// <summary> A list of the scopes that should be requested while authenticating. </summary>
        public IList<string> Scopes { get; }
    }
}
