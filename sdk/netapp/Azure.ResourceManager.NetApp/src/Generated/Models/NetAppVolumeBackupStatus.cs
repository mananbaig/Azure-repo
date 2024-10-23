// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary>
    /// Backup status
    /// Serialized Name: BackupStatus
    /// </summary>
    public partial class NetAppVolumeBackupStatus
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

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupStatus"/>. </summary>
        internal NetAppVolumeBackupStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumeBackupStatus"/>. </summary>
        /// <param name="isHealthy">
        /// Backup health status
        /// Serialized Name: BackupStatus.healthy
        /// </param>
        /// <param name="relationshipStatus">
        /// Status of the backup mirror relationship
        /// Serialized Name: BackupStatus.relationshipStatus
        /// </param>
        /// <param name="mirrorState">
        /// The status of the backup
        /// Serialized Name: BackupStatus.mirrorState
        /// </param>
        /// <param name="unhealthyReason">
        /// Reason for the unhealthy backup relationship
        /// Serialized Name: BackupStatus.unhealthyReason
        /// </param>
        /// <param name="errorMessage">
        /// Displays error message if the backup is in an error state
        /// Serialized Name: BackupStatus.errorMessage
        /// </param>
        /// <param name="lastTransferSize">
        /// Displays the last transfer size
        /// Serialized Name: BackupStatus.lastTransferSize
        /// </param>
        /// <param name="lastTransferType">
        /// Displays the last transfer type
        /// Serialized Name: BackupStatus.lastTransferType
        /// </param>
        /// <param name="totalTransferBytes">
        /// Displays the total bytes transferred
        /// Serialized Name: BackupStatus.totalTransferBytes
        /// </param>
        /// <param name="transferProgressBytes">
        /// Displays the total number of bytes transferred for the ongoing operation
        /// Serialized Name: BackupStatus.transferProgressBytes
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumeBackupStatus(bool? isHealthy, NetAppRelationshipStatus? relationshipStatus, NetAppMirrorState? mirrorState, string unhealthyReason, string errorMessage, long? lastTransferSize, string lastTransferType, long? totalTransferBytes, long? transferProgressBytes, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsHealthy = isHealthy;
            RelationshipStatus = relationshipStatus;
            MirrorState = mirrorState;
            UnhealthyReason = unhealthyReason;
            ErrorMessage = errorMessage;
            LastTransferSize = lastTransferSize;
            LastTransferType = lastTransferType;
            TotalTransferBytes = totalTransferBytes;
            TransferProgressBytes = transferProgressBytes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Backup health status
        /// Serialized Name: BackupStatus.healthy
        /// </summary>
        public bool? IsHealthy { get; }
        /// <summary>
        /// Status of the backup mirror relationship
        /// Serialized Name: BackupStatus.relationshipStatus
        /// </summary>
        public NetAppRelationshipStatus? RelationshipStatus { get; }
        /// <summary>
        /// The status of the backup
        /// Serialized Name: BackupStatus.mirrorState
        /// </summary>
        public NetAppMirrorState? MirrorState { get; }
        /// <summary>
        /// Reason for the unhealthy backup relationship
        /// Serialized Name: BackupStatus.unhealthyReason
        /// </summary>
        public string UnhealthyReason { get; }
        /// <summary>
        /// Displays error message if the backup is in an error state
        /// Serialized Name: BackupStatus.errorMessage
        /// </summary>
        public string ErrorMessage { get; }
        /// <summary>
        /// Displays the last transfer size
        /// Serialized Name: BackupStatus.lastTransferSize
        /// </summary>
        public long? LastTransferSize { get; }
        /// <summary>
        /// Displays the last transfer type
        /// Serialized Name: BackupStatus.lastTransferType
        /// </summary>
        public string LastTransferType { get; }
        /// <summary>
        /// Displays the total bytes transferred
        /// Serialized Name: BackupStatus.totalTransferBytes
        /// </summary>
        public long? TotalTransferBytes { get; }
        /// <summary>
        /// Displays the total number of bytes transferred for the ongoing operation
        /// Serialized Name: BackupStatus.transferProgressBytes
        /// </summary>
        public long? TransferProgressBytes { get; }
    }
}
