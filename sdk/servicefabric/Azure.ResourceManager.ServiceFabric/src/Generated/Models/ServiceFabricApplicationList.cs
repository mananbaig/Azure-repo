// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.ServiceFabric;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> The list of application resources. </summary>
    internal partial class ServiceFabricApplicationList
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

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationList"/>. </summary>
        internal ServiceFabricApplicationList()
        {
            Value = new ChangeTrackingList<ServiceFabricApplicationData>();
        }

        /// <summary> Initializes a new instance of <see cref="ServiceFabricApplicationList"/>. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"> URL to get the next set of application list results if there are any. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServiceFabricApplicationList(IReadOnlyList<ServiceFabricApplicationData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<ServiceFabricApplicationData> Value { get; }
        /// <summary> URL to get the next set of application list results if there are any. </summary>
        public string NextLink { get; }
    }
}
