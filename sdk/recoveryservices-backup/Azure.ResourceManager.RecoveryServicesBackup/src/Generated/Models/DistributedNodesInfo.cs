// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> This is used to represent the various nodes of the distributed container. </summary>
    public partial class DistributedNodesInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DistributedNodesInfo"/>. </summary>
        public DistributedNodesInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DistributedNodesInfo"/>. </summary>
        /// <param name="nodeName"> Name of the node under a distributed container. </param>
        /// <param name="status">
        /// Status of this Node.
        /// Failed | Succeeded
        /// </param>
        /// <param name="errorDetail"> Error Details if the Status is non-success. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DistributedNodesInfo(string nodeName, string status, BackupErrorDetail errorDetail, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NodeName = nodeName;
            Status = status;
            ErrorDetail = errorDetail;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the node under a distributed container. </summary>
        public string NodeName { get; set; }
        /// <summary>
        /// Status of this Node.
        /// Failed | Succeeded
        /// </summary>
        public string Status { get; set; }
        /// <summary> Error Details if the Status is non-success. </summary>
        public BackupErrorDetail ErrorDetail { get; set; }
    }
}
