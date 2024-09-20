// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Account Info of the NewRelic account. </summary>
    public partial class NewRelicObservabilityAccountInfo
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

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityAccountInfo"/>. </summary>
        public NewRelicObservabilityAccountInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NewRelicObservabilityAccountInfo"/>. </summary>
        /// <param name="accountId"> Account id. </param>
        /// <param name="ingestionKey"> ingestion key of account. </param>
        /// <param name="region"> Region where New Relic account is present. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NewRelicObservabilityAccountInfo(string accountId, string ingestionKey, AzureLocation? region, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountId = accountId;
            IngestionKey = ingestionKey;
            Region = region;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Account id. </summary>
        [WirePath("accountId")]
        public string AccountId { get; set; }
        /// <summary> ingestion key of account. </summary>
        [WirePath("ingestionKey")]
        public string IngestionKey { get; set; }
        /// <summary> Region where New Relic account is present. </summary>
        [WirePath("region")]
        public AzureLocation? Region { get; set; }
    }
}
