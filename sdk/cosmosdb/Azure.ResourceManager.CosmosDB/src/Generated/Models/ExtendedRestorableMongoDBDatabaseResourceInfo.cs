// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The resource of an Azure Cosmos DB MongoDB database event. </summary>
    public partial class ExtendedRestorableMongoDBDatabaseResourceInfo
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

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableMongoDBDatabaseResourceInfo"/>. </summary>
        internal ExtendedRestorableMongoDBDatabaseResourceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExtendedRestorableMongoDBDatabaseResourceInfo"/>. </summary>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="operationType"> The operation type of this database event. </param>
        /// <param name="eventTimestamp"> The time when this database event happened. </param>
        /// <param name="databaseName"> The name of this MongoDB database. </param>
        /// <param name="databaseId"> The resource ID of this MongoDB database. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ExtendedRestorableMongoDBDatabaseResourceInfo(string rid, CosmosDBOperationType? operationType, string eventTimestamp, string databaseName, string databaseId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Rid = rid;
            OperationType = operationType;
            EventTimestamp = eventTimestamp;
            DatabaseName = databaseName;
            DatabaseId = databaseId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> The operation type of this database event. </summary>
        public CosmosDBOperationType? OperationType { get; }
        /// <summary> The time when this database event happened. </summary>
        public string EventTimestamp { get; }
        /// <summary> The name of this MongoDB database. </summary>
        public string DatabaseName { get; }
        /// <summary> The resource ID of this MongoDB database. </summary>
        public string DatabaseId { get; }
    }
}
