// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The Analytics query. Learn more about the [Analytics query syntax](https://azure.microsoft.com/documentation/articles/app-insights-analytics-reference/). </summary>
    internal partial class QueryBody
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

        /// <summary> Initializes a new instance of <see cref="QueryBody"/>. </summary>
        /// <param name="query"> The query to execute. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="query"/> is null. </exception>
        public QueryBody(string query)
        {
            Argument.AssertNotNull(query, nameof(query));

            Query = query;
            Workspaces = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="QueryBody"/>. </summary>
        /// <param name="query"> The query to execute. </param>
        /// <param name="timespan"> Optional. The timespan over which to query data. This is an ISO8601 time period value.  This timespan is applied in addition to any that are specified in the query expression. </param>
        /// <param name="workspaces"> A list of workspaces to query in addition to the primary workspace. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueryBody(string query, string timespan, IList<string> workspaces, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Query = query;
            Timespan = timespan;
            Workspaces = workspaces;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="QueryBody"/> for deserialization. </summary>
        internal QueryBody()
        {
        }

        /// <summary> The query to execute. </summary>
        public string Query { get; }
        /// <summary> Optional. The timespan over which to query data. This is an ISO8601 time period value.  This timespan is applied in addition to any that are specified in the query expression. </summary>
        public string Timespan { get; set; }
    }
}
