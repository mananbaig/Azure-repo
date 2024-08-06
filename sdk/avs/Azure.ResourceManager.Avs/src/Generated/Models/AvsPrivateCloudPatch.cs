// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> An update to a private cloud resource. </summary>
    public partial class AvsPrivateCloudPatch
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

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudPatch"/>. </summary>
        public AvsPrivateCloudPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AvsPrivateCloudPatch"/>. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="sku"> The SKU (Stock Keeping Unit) assigned to this resource. </param>
        /// <param name="identity"> The managed service identities assigned to this resource. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="properties"> The updatable properties of a private cloud resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AvsPrivateCloudPatch(IDictionary<string, string> tags, AvsSku sku, ManagedServiceIdentity identity, PrivateCloudUpdateProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Sku = sku;
            Identity = identity;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The SKU (Stock Keeping Unit) assigned to this resource. </summary>
        public AvsSku Sku { get; set; }
        /// <summary> The managed service identities assigned to this resource. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The updatable properties of a private cloud resource. </summary>
        public PrivateCloudUpdateProperties Properties { get; set; }
    }
}
