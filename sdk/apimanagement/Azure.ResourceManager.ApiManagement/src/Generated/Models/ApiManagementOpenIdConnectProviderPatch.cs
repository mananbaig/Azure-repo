// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Parameters supplied to the Update OpenID Connect Provider operation. </summary>
    public partial class ApiManagementOpenIdConnectProviderPatch
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

        /// <summary> Initializes a new instance of <see cref="ApiManagementOpenIdConnectProviderPatch"/>. </summary>
        public ApiManagementOpenIdConnectProviderPatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApiManagementOpenIdConnectProviderPatch"/>. </summary>
        /// <param name="displayName"> User-friendly OpenID Connect Provider name. </param>
        /// <param name="description"> User-friendly description of OpenID Connect Provider. </param>
        /// <param name="metadataEndpoint"> Metadata endpoint URI. </param>
        /// <param name="clientId"> Client ID of developer console which is the client application. </param>
        /// <param name="clientSecret"> Client Secret of developer console which is the client application. </param>
        /// <param name="useInTestConsole"> If true, the Open ID Connect provider may be used in the developer portal test console. True by default if no value is provided. </param>
        /// <param name="useInApiDocumentation"> If true, the Open ID Connect provider will be used in the API documentation in the developer portal. False by default if no value is provided. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApiManagementOpenIdConnectProviderPatch(string displayName, string description, string metadataEndpoint, string clientId, string clientSecret, bool? useInTestConsole, bool? useInApiDocumentation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DisplayName = displayName;
            Description = description;
            MetadataEndpoint = metadataEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            UseInTestConsole = useInTestConsole;
            UseInApiDocumentation = useInApiDocumentation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> User-friendly OpenID Connect Provider name. </summary>
        [WirePath("properties.displayName")]
        public string DisplayName { get; set; }
        /// <summary> User-friendly description of OpenID Connect Provider. </summary>
        [WirePath("properties.description")]
        public string Description { get; set; }
        /// <summary> Metadata endpoint URI. </summary>
        [WirePath("properties.metadataEndpoint")]
        public string MetadataEndpoint { get; set; }
        /// <summary> Client ID of developer console which is the client application. </summary>
        [WirePath("properties.clientId")]
        public string ClientId { get; set; }
        /// <summary> Client Secret of developer console which is the client application. </summary>
        [WirePath("properties.clientSecret")]
        public string ClientSecret { get; set; }
        /// <summary> If true, the Open ID Connect provider may be used in the developer portal test console. True by default if no value is provided. </summary>
        [WirePath("properties.useInTestConsole")]
        public bool? UseInTestConsole { get; set; }
        /// <summary> If true, the Open ID Connect provider will be used in the API documentation in the developer portal. False by default if no value is provided. </summary>
        [WirePath("properties.useInApiDocumentation")]
        public bool? UseInApiDocumentation { get; set; }
    }
}
