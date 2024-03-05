// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Search;

namespace Azure.ResourceManager.Search.Models
{
    /// <summary> Response containing the quota usage information for all the supported skus of Azure Cognitive Search service. </summary>
    internal partial class QuotaUsagesListResult
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

        /// <summary> Initializes a new instance of <see cref="QuotaUsagesListResult"/>. </summary>
        internal QuotaUsagesListResult()
        {
            Value = new ChangeTrackingList<QuotaUsageResult>();
        }

        /// <summary> Initializes a new instance of <see cref="QuotaUsagesListResult"/>. </summary>
        /// <param name="value"> The quota usages for the SKUs supported by Azure Cognitive Search. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of quota usages. Returned when the total number of requested quota usages exceed maximum page size. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaUsagesListResult(IReadOnlyList<QuotaUsageResult> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The quota usages for the SKUs supported by Azure Cognitive Search. </summary>
        public IReadOnlyList<QuotaUsageResult> Value { get; }
        /// <summary> Request URL that can be used to query next page of quota usages. Returned when the total number of requested quota usages exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
