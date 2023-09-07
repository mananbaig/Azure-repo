// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Azure VM workload specific job task details. </summary>
    public partial class WorkloadBackupJobTaskDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WorkloadBackupJobTaskDetails"/>. </summary>
        public WorkloadBackupJobTaskDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadBackupJobTaskDetails"/>. </summary>
        /// <param name="taskId"> The task display name. </param>
        /// <param name="status"> The status. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadBackupJobTaskDetails(string taskId, string status, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TaskId = taskId;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The task display name. </summary>
        public string TaskId { get; set; }
        /// <summary> The status. </summary>
        public string Status { get; set; }
    }
}
