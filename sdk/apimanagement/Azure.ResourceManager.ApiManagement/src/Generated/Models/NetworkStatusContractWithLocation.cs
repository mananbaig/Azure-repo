// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Network Status in the Location. </summary>
    public partial class NetworkStatusContractWithLocation
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

        /// <summary> Initializes a new instance of <see cref="NetworkStatusContractWithLocation"/>. </summary>
        internal NetworkStatusContractWithLocation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkStatusContractWithLocation"/>. </summary>
        /// <param name="location"> Location of service. </param>
        /// <param name="networkStatus"> Network status in Location. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkStatusContractWithLocation(AzureLocation? location, NetworkStatusContract networkStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Location = location;
            NetworkStatus = networkStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Location of service. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; }
        /// <summary> Network status in Location. </summary>
        [WirePath("networkStatus")]
        public NetworkStatusContract NetworkStatus { get; }
    }
}
