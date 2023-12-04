// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB Gremlin graph event. </summary>
    public partial class ExtendedRestorableGremlinGraphResourceInfo
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

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableGremlinGraphResourceInfo"/>. </summary>
        internal ExtendedRestorableGremlinGraphResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableGremlinGraphResourceInfo"/>. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this graph event. </param>
        /// <param name="eventTimestamp"> The time when this graph event happened. </param>
        /// <param name="graphName"> The name of this Gremlin graph. </param>
        /// <param name="graphId"> The resource ID of this Gremlin graph. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedRestorableGremlinGraphResourceInfo(string rid, CosmosDBOperationType? operationType, string eventTimestamp, string graphName, string graphId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rid = rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            GraphName = graphName;
            GraphId = graphId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> The operation type of this graph event. </summary>
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> The time when this graph event happened. </summary>
        public string EventTimestamp { get; }
        /// <summary> The name of this Gremlin graph. </summary>
        public string GraphName { get; }
        /// <summary> The resource ID of this Gremlin graph. </summary>
        public string GraphId { get; }
    }
}
