// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Storage.DirectoryCreated event. </summary>
    public partial class StorageDirectoryCreatedEventData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryCreatedEventData"/>. </summary>
        internal StorageDirectoryCreatedEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageDirectoryCreatedEventData"/>. </summary>
        /// <param name="api"> The name of the API/operation that triggered this event. </param>
        /// <param name="clientRequestId"> A request id provided by the client of the storage API operation that triggered this event. </param>
        /// <param name="requestId"> The request id generated by the storage service for the storage API operation that triggered this event. </param>
        /// <param name="eTag"> The etag of the directory at the time this event was triggered. </param>
        /// <param name="url"> The path to the directory. </param>
        /// <param name="sequencer"> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </param>
        /// <param name="identity"> The identity of the requester that triggered this event. </param>
        /// <param name="storageDiagnostics"> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageDirectoryCreatedEventData(string api, string clientRequestId, string requestId, string eTag, string url, string sequencer, string identity, object storageDiagnostics, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Api = api;
            ClientRequestId = clientRequestId;
            RequestId = requestId;
            ETag = eTag;
            Url = url;
            Sequencer = sequencer;
            Identity = identity;
            StorageDiagnostics = storageDiagnostics;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the API/operation that triggered this event. </summary>
        public string Api { get; }
        /// <summary> A request id provided by the client of the storage API operation that triggered this event. </summary>
        public string ClientRequestId { get; }
        /// <summary> The request id generated by the storage service for the storage API operation that triggered this event. </summary>
        public string RequestId { get; }
        /// <summary> The etag of the directory at the time this event was triggered. </summary>
        public string ETag { get; }
        /// <summary> The path to the directory. </summary>
        public string Url { get; }
        /// <summary> An opaque string value representing the logical sequence of events for any particular directory name. Users can use standard string comparison to understand the relative sequence of two events on the same directory name. </summary>
        public string Sequencer { get; }
        /// <summary> The identity of the requester that triggered this event. </summary>
        public string Identity { get; }
        /// <summary> For service use only. Diagnostic data occasionally included by the Azure Storage service. This property should be ignored by event consumers. </summary>
        public object StorageDiagnostics { get; }
    }
}
