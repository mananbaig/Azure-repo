// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A copy activity MongoDB sink. </summary>
    public partial class MongoDBV2Sink : CopySink
    {
        /// <summary> Initializes a new instance of MongoDBV2Sink. </summary>
        public MongoDBV2Sink()
        {
            CopySinkType = "MongoDbV2Sink";
        }

        /// <summary> Initializes a new instance of MongoDBV2Sink. </summary>
        /// <param name="copySinkType"> Copy sink type. </param>
        /// <param name="writeBatchSize"> Write batch size. Type: integer (or Expression with resultType integer), minimum: 0. </param>
        /// <param name="writeBatchTimeout"> Write batch timeout. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="sinkRetryCount"> Sink retry count. Type: integer (or Expression with resultType integer). </param>
        /// <param name="sinkRetryWait"> Sink retry wait. Type: string (or Expression with resultType string), pattern: ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])). </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the sink data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="disableMetricsCollection"> If true, disable data store metrics collection. Default is false. Type: boolean (or Expression with resultType boolean). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="writeBehavior"> Specifies whether the document with same key to be overwritten (upsert) rather than throw exception (insert). The default value is &quot;insert&quot;. Type: string (or Expression with resultType string). Type: string (or Expression with resultType string). </param>
        internal MongoDBV2Sink(string copySinkType, BinaryData writeBatchSize, BinaryData writeBatchTimeout, BinaryData sinkRetryCount, BinaryData sinkRetryWait, BinaryData maxConcurrentConnections, BinaryData disableMetricsCollection, IDictionary<string, BinaryData> additionalProperties, BinaryData writeBehavior) : base(copySinkType, writeBatchSize, writeBatchTimeout, sinkRetryCount, sinkRetryWait, maxConcurrentConnections, disableMetricsCollection, additionalProperties)
        {
            WriteBehavior = writeBehavior;
            CopySinkType = copySinkType ?? "MongoDbV2Sink";
        }

        /// <summary>
        /// Specifies whether the document with same key to be overwritten (upsert) rather than throw exception (insert). The default value is &quot;insert&quot;. Type: string (or Expression with resultType string). Type: string (or Expression with resultType string).
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData WriteBehavior { get; set; }
    }
}
