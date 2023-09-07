// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents the fabric replication group task details. </summary>
    public partial class FabricReplicationGroupTaskDetails : SiteRecoveryJobTaskDetails
    {
        /// <summary> Initializes a new instance of <see cref="FabricReplicationGroupTaskDetails"/>. </summary>
        internal FabricReplicationGroupTaskDetails()
        {
            InstanceType = "FabricReplicationGroupTaskDetails";
        }

        /// <summary> Initializes a new instance of <see cref="FabricReplicationGroupTaskDetails"/>. </summary>
        /// <param name="instanceType"> The type of task details. </param>
        /// <param name="jobTask"> The job entity. </param>
        /// <param name="skippedReason"> The skipped reason. </param>
        /// <param name="skippedReasonString"> The skipped reason string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FabricReplicationGroupTaskDetails(string instanceType, SiteRecoveryJobEntity jobTask, string skippedReason, string skippedReasonString, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, jobTask, serializedAdditionalRawData)
        {
            SkippedReason = skippedReason;
            SkippedReasonString = skippedReasonString;
            InstanceType = instanceType ?? "FabricReplicationGroupTaskDetails";
        }

        /// <summary> The skipped reason. </summary>
        public string SkippedReason { get; }
        /// <summary> The skipped reason string. </summary>
        public string SkippedReasonString { get; }
    }
}
