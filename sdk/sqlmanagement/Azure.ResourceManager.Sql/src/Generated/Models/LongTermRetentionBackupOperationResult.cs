// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A LongTermRetentionBackup operation result resource. </summary>
    public partial class LongTermRetentionBackupOperationResult : ResourceData
    {
        /// <summary> Initializes a new instance of LongTermRetentionBackupOperationResult. </summary>
        public LongTermRetentionBackupOperationResult()
        {
        }

        /// <summary> Initializes a new instance of LongTermRetentionBackupOperationResult. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="requestId"> Request Id. </param>
        /// <param name="operationType"> Operation type. </param>
        /// <param name="fromBackupResourceId"> Source backup resource id. </param>
        /// <param name="toBackupResourceId"> Target backup resource id. </param>
        /// <param name="targetBackupStorageRedundancy"> The storage redundancy type of the copied backup. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="message"> Progress message. </param>
        internal LongTermRetentionBackupOperationResult(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, Guid? requestId, string operationType, string fromBackupResourceId, string toBackupResourceId, BackupStorageRedundancy? targetBackupStorageRedundancy, string status, string message) : base(id, name, type, systemData)
        {
            RequestId = requestId;
            OperationType = operationType;
            FromBackupResourceId = fromBackupResourceId;
            ToBackupResourceId = toBackupResourceId;
            TargetBackupStorageRedundancy = targetBackupStorageRedundancy;
            Status = status;
            Message = message;
        }

        /// <summary> Request Id. </summary>
        public Guid? RequestId { get; }
        /// <summary> Operation type. </summary>
        public string OperationType { get; }
        /// <summary> Source backup resource id. </summary>
        public string FromBackupResourceId { get; }
        /// <summary> Target backup resource id. </summary>
        public string ToBackupResourceId { get; }
        /// <summary> The storage redundancy type of the copied backup. </summary>
        public BackupStorageRedundancy? TargetBackupStorageRedundancy { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> Progress message. </summary>
        public string Message { get; }
    }
}
