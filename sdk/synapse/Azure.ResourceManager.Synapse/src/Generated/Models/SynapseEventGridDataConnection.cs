// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Class representing an Event Grid data connection. </summary>
    public partial class SynapseEventGridDataConnection : SynapseDataConnectionData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseEventGridDataConnection"/>. </summary>
        public SynapseEventGridDataConnection()
        {
            Kind = SynapseDataConnectionKind.EventGrid;
        }

        /// <summary> Initializes a new instance of <see cref="SynapseEventGridDataConnection"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="kind"> Kind of the endpoint for the data connection. </param>
        /// <param name="storageAccountResourceId"> The resource ID of the storage account where the data resides. </param>
        /// <param name="eventHubResourceId"> The resource ID where the event grid is configured to send events. </param>
        /// <param name="consumerGroup"> The event hub consumer group. </param>
        /// <param name="tableName"> The table where the data should be ingested. Optionally the table information can be added to each message. </param>
        /// <param name="mappingRuleName"> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </param>
        /// <param name="dataFormat"> The data format of the message. Optionally the data format can be added to each message. </param>
        /// <param name="ignoreFirstRecord"> A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file. </param>
        /// <param name="blobStorageEventType"> The name of blob storage event type to process. </param>
        /// <param name="provisioningState"> The provisioned state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseEventGridDataConnection(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, SynapseDataConnectionKind kind, ResourceIdentifier storageAccountResourceId, ResourceIdentifier eventHubResourceId, string consumerGroup, string tableName, string mappingRuleName, SynapseEventGridDataFormat? dataFormat, bool? ignoreFirstRecord, SynapseBlobStorageEventType? blobStorageEventType, ResourceProvisioningState? provisioningState, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, location, kind, serializedAdditionalRawData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            EventHubResourceId = eventHubResourceId;
            ConsumerGroup = consumerGroup;
            TableName = tableName;
            MappingRuleName = mappingRuleName;
            DataFormat = dataFormat;
            IgnoreFirstRecord = ignoreFirstRecord;
            BlobStorageEventType = blobStorageEventType;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> The resource ID of the storage account where the data resides. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; set; }
        /// <summary> The resource ID where the event grid is configured to send events. </summary>
        public ResourceIdentifier EventHubResourceId { get; set; }
        /// <summary> The event hub consumer group. </summary>
        public string ConsumerGroup { get; set; }
        /// <summary> The table where the data should be ingested. Optionally the table information can be added to each message. </summary>
        public string TableName { get; set; }
        /// <summary> The mapping rule to be used to ingest the data. Optionally the mapping information can be added to each message. </summary>
        public string MappingRuleName { get; set; }
        /// <summary> The data format of the message. Optionally the data format can be added to each message. </summary>
        public SynapseEventGridDataFormat? DataFormat { get; set; }
        /// <summary> A Boolean value that, if set to true, indicates that ingestion should ignore the first record of every file. </summary>
        public bool? IgnoreFirstRecord { get; set; }
        /// <summary> The name of blob storage event type to process. </summary>
        public SynapseBlobStorageEventType? BlobStorageEventType { get; set; }
        /// <summary> The provisioned state of the resource. </summary>
        public ResourceProvisioningState? ProvisioningState { get; }
    }
}
