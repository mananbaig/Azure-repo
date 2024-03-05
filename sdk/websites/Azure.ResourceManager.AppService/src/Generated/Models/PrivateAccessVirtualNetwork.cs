// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description of a Virtual Network that is useable for private site access. </summary>
    public partial class PrivateAccessVirtualNetwork
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

        /// <summary> Initializes a new instance of <see cref="PrivateAccessVirtualNetwork"/>. </summary>
        public PrivateAccessVirtualNetwork()
        {
            Subnets = new ChangeTrackingList<PrivateAccessSubnet>();
        }

        /// <summary> Initializes a new instance of <see cref="PrivateAccessVirtualNetwork"/>. </summary>
        /// <param name="name"> The name of the Virtual Network. </param>
        /// <param name="key"> The key (ID) of the Virtual Network. </param>
        /// <param name="resourceId"> The ARM uri of the Virtual Network. </param>
        /// <param name="subnets"> A List of subnets that access is allowed to on this Virtual Network. An empty array (but not null) is interpreted to mean that all subnets are allowed within this Virtual Network. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PrivateAccessVirtualNetwork(string name, int? key, ResourceIdentifier resourceId, IList<PrivateAccessSubnet> subnets, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Key = key;
            ResourceId = resourceId;
            Subnets = subnets;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the Virtual Network. </summary>
        public string Name { get; set; }
        /// <summary> The key (ID) of the Virtual Network. </summary>
        public int? Key { get; set; }
        /// <summary> The ARM uri of the Virtual Network. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> A List of subnets that access is allowed to on this Virtual Network. An empty array (but not null) is interpreted to mean that all subnets are allowed within this Virtual Network. </summary>
        public IList<PrivateAccessSubnet> Subnets { get; }
    }
}
