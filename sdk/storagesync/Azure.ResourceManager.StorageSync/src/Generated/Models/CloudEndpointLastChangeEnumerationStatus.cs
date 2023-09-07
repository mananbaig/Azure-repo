// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Cloud endpoint change enumeration status object. </summary>
    public partial class CloudEndpointLastChangeEnumerationStatus
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CloudEndpointLastChangeEnumerationStatus"/>. </summary>
        internal CloudEndpointLastChangeEnumerationStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CloudEndpointLastChangeEnumerationStatus"/>. </summary>
        /// <param name="startedOn"> Timestamp when change enumeration started. </param>
        /// <param name="completedOn"> Timestamp when change enumeration completed. </param>
        /// <param name="namespaceFilesCount"> Count of files in the namespace. </param>
        /// <param name="namespaceDirectoriesCount"> Count of directories in the namespace. </param>
        /// <param name="namespaceSizeInBytes"> Namespace size in bytes. </param>
        /// <param name="nextRunTimestamp"> Timestamp of when change enumeration is expected to run again. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CloudEndpointLastChangeEnumerationStatus(DateTimeOffset? startedOn, DateTimeOffset? completedOn, long? namespaceFilesCount, long? namespaceDirectoriesCount, long? namespaceSizeInBytes, DateTimeOffset? nextRunTimestamp, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartedOn = startedOn;
            CompletedOn = completedOn;
            NamespaceFilesCount = namespaceFilesCount;
            NamespaceDirectoriesCount = namespaceDirectoriesCount;
            NamespaceSizeInBytes = namespaceSizeInBytes;
            NextRunTimestamp = nextRunTimestamp;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Timestamp when change enumeration started. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Timestamp when change enumeration completed. </summary>
        public DateTimeOffset? CompletedOn { get; }
        /// <summary> Count of files in the namespace. </summary>
        public long? NamespaceFilesCount { get; }
        /// <summary> Count of directories in the namespace. </summary>
        public long? NamespaceDirectoriesCount { get; }
        /// <summary> Namespace size in bytes. </summary>
        public long? NamespaceSizeInBytes { get; }
        /// <summary> Timestamp of when change enumeration is expected to run again. </summary>
        public DateTimeOffset? NextRunTimestamp { get; }
    }
}
