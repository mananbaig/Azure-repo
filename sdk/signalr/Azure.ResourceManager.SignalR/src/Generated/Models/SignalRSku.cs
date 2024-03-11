// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Describes an available sku.". </summary>
    public partial class SignalRSku
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

        /// <summary> Initializes a new instance of <see cref="SignalRSku"/>. </summary>
        internal SignalRSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SignalRSku"/>. </summary>
        /// <param name="resourceType"> The resource type that this object applies to. </param>
        /// <param name="sku"> The billing information of the resource. </param>
        /// <param name="capacity"> Describes scaling information of a sku. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SignalRSku(ResourceType? resourceType, SignalRResourceSku sku, SignalRSkuCapacity capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ResourceType = resourceType;
            Sku = sku;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The resource type that this object applies to. </summary>
        public ResourceType? ResourceType { get; }
        /// <summary> The billing information of the resource. </summary>
        public SignalRResourceSku Sku { get; }
        /// <summary> Describes scaling information of a sku. </summary>
        public SignalRSkuCapacity Capacity { get; }
    }
}
