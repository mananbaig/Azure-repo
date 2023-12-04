// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema. </summary>
    internal partial class Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema
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

        /// <summary> Initializes a new instance of <see cref="Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema"/>. </summary>
        /// <param name="grantType"> Can take a value of access_token_refresh_token, or access_token, or refresh_token. </param>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="service"/> is null. </exception>
        internal Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema(PostContentSchemaGrantType grantType, string service)
        {
            Argument.AssertNotNull(service, nameof(service));

            GrantType = grantType;
            Service = service;
        }

        /// <summary> Initializes a new instance of <see cref="Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema"/>. </summary>
        /// <param name="grantType"> Can take a value of access_token_refresh_token, or access_token, or refresh_token. </param>
        /// <param name="service"> Indicates the name of your Azure container registry. </param>
        /// <param name="tenant"> AAD tenant associated to the AAD credentials. </param>
        /// <param name="refreshToken"> AAD refresh token, mandatory when grant_type is access_token_refresh_token or refresh_token. </param>
        /// <param name="aadAccessToken"> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema(PostContentSchemaGrantType grantType, string service, string tenant, string refreshToken, string aadAccessToken, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            GrantType = grantType;
            Service = service;
            Tenant = tenant;
            RefreshToken = refreshToken;
            AadAccessToken = aadAccessToken;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema"/> for deserialization. </summary>
        internal Paths108HwamOauth2ExchangePostRequestbodyContentApplicationXWwwFormUrlencodedSchema()
        {
        }

        /// <summary> Can take a value of access_token_refresh_token, or access_token, or refresh_token. </summary>
        public PostContentSchemaGrantType GrantType { get; }
        /// <summary> Indicates the name of your Azure container registry. </summary>
        public string Service { get; }
        /// <summary> AAD tenant associated to the AAD credentials. </summary>
        public string Tenant { get; }
        /// <summary> AAD refresh token, mandatory when grant_type is access_token_refresh_token or refresh_token. </summary>
        public string RefreshToken { get; }
        /// <summary> AAD access token, mandatory when grant_type is access_token_refresh_token or access_token. </summary>
        public string AadAccessToken { get; }
    }
}
