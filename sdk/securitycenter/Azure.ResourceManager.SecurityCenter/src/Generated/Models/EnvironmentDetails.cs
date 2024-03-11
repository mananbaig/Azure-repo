// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The environment details of the resource. </summary>
    public partial class EnvironmentDetails
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

        /// <summary> Initializes a new instance of <see cref="EnvironmentDetails"/>. </summary>
        public EnvironmentDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EnvironmentDetails"/>. </summary>
        /// <param name="nativeResourceId"> The native resource id of the resource (in case of Azure - the resource Id, in case of MC - the native resource id). </param>
        /// <param name="environmentHierarchyId"> The hierarchy id of the connector (in case of Azure - the subscription Id, in case of MC - the hierarchyId id). </param>
        /// <param name="organizationalHierarchyId"> The organizational hierarchy id of the connector (in case of Azure - the subscription Id, in case of MC - the organizational hierarchyId id). </param>
        /// <param name="subscriptionId"> The subscription Id. </param>
        /// <param name="tenantId"> The tenant Id. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnvironmentDetails(ResourceIdentifier nativeResourceId, string environmentHierarchyId, string organizationalHierarchyId, string subscriptionId, Guid? tenantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NativeResourceId = nativeResourceId;
            EnvironmentHierarchyId = environmentHierarchyId;
            OrganizationalHierarchyId = organizationalHierarchyId;
            SubscriptionId = subscriptionId;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The native resource id of the resource (in case of Azure - the resource Id, in case of MC - the native resource id). </summary>
        public ResourceIdentifier NativeResourceId { get; set; }
        /// <summary> The hierarchy id of the connector (in case of Azure - the subscription Id, in case of MC - the hierarchyId id). </summary>
        public string EnvironmentHierarchyId { get; set; }
        /// <summary> The organizational hierarchy id of the connector (in case of Azure - the subscription Id, in case of MC - the organizational hierarchyId id). </summary>
        public string OrganizationalHierarchyId { get; set; }
        /// <summary> The subscription Id. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> The tenant Id. </summary>
        public Guid? TenantId { get; set; }
    }
}
