// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Result of the request to list import jobs. It contains a list of import jobs and a URL link to get the next set of results. </summary>
    internal partial class ImportJobsListResult
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

        /// <summary> Initializes a new instance of <see cref="ImportJobsListResult"/>. </summary>
        internal ImportJobsListResult()
        {
            Value = new ChangeTrackingList<StorageCacheImportJobData>();
        }

        /// <summary> Initializes a new instance of <see cref="ImportJobsListResult"/>. </summary>
        /// <param name="nextLink"> URL to get the next set of import job list results, if there are any. </param>
        /// <param name="value"> List of import jobs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ImportJobsListResult(string nextLink, IReadOnlyList<StorageCacheImportJobData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NextLink = nextLink;
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> URL to get the next set of import job list results, if there are any. </summary>
        public string NextLink { get; }
        /// <summary> List of import jobs. </summary>
        public IReadOnlyList<StorageCacheImportJobData> Value { get; }
    }
}
