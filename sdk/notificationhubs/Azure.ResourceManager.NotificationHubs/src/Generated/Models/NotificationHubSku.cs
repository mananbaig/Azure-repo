// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> The Sku description for a namespace. </summary>
    public partial class NotificationHubSku
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

        /// <summary> Initializes a new instance of <see cref="NotificationHubSku"/>. </summary>
        /// <param name="name"> Namespace SKU name. </param>
        public NotificationHubSku(NotificationHubSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubSku"/>. </summary>
        /// <param name="name"> Namespace SKU name. </param>
        /// <param name="tier"> Gets or sets the tier of particular sku. </param>
        /// <param name="size"> Gets or sets the Sku size. </param>
        /// <param name="family"> Gets or sets the Sku Family. </param>
        /// <param name="capacity"> Gets or sets the capacity of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NotificationHubSku(NotificationHubSkuName name, string tier, string size, string family, int? capacity, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Capacity = capacity;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NotificationHubSku"/> for deserialization. </summary>
        internal NotificationHubSku()
        {
        }

        /// <summary> Namespace SKU name. </summary>
        public NotificationHubSkuName Name { get; set; }
        /// <summary> Gets or sets the tier of particular sku. </summary>
        public string Tier { get; set; }
        /// <summary> Gets or sets the Sku size. </summary>
        public string Size { get; set; }
        /// <summary> Gets or sets the Sku Family. </summary>
        public string Family { get; set; }
        /// <summary> Gets or sets the capacity of the resource. </summary>
        public int? Capacity { get; set; }
    }
}
