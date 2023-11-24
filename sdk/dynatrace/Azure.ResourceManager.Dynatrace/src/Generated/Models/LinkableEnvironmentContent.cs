// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Request for getting all the linkable environments for a user. </summary>
    public partial class LinkableEnvironmentContent
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

        /// <summary> Initializes a new instance of <see cref="LinkableEnvironmentContent"/>. </summary>
        public LinkableEnvironmentContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="LinkableEnvironmentContent"/>. </summary>
        /// <param name="tenantId"> Tenant Id of the user in which they want to link the environment. </param>
        /// <param name="userPrincipal"> user principal id of the user. </param>
        /// <param name="region"> Azure region in which we want to link the environment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal LinkableEnvironmentContent(Guid? tenantId, string userPrincipal, AzureLocation? region, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TenantId = tenantId;
            UserPrincipal = userPrincipal;
            Region = region;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tenant Id of the user in which they want to link the environment. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> user principal id of the user. </summary>
        public string UserPrincipal { get; set; }
        /// <summary> Azure region in which we want to link the environment. </summary>
        public AzureLocation? Region { get; set; }
    }
}
