// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> This class represents details for switch protection job. </summary>
    public partial class SwitchProtectionJobDetails : SiteRecoveryJobDetails
    {
        /// <summary> Initializes a new instance of <see cref="SwitchProtectionJobDetails"/>. </summary>
        internal SwitchProtectionJobDetails()
        {
            InstanceType = "SwitchProtectionJobDetails";
        }

        /// <summary> Initializes a new instance of <see cref="SwitchProtectionJobDetails"/>. </summary>
        /// <param name="instanceType"> Gets the type of job details (see JobDetailsTypes enum for possible values). </param>
        /// <param name="affectedObjectDetails"> The affected object properties like source server, source cloud, target server, target cloud etc. based on the workflow object details. </param>
        /// <param name="newReplicationProtectedItemId"> ARM Id of the new replication protected item. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SwitchProtectionJobDetails(string instanceType, IReadOnlyDictionary<string, string> affectedObjectDetails, ResourceIdentifier newReplicationProtectedItemId, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(instanceType, affectedObjectDetails, serializedAdditionalRawData)
        {
            NewReplicationProtectedItemId = newReplicationProtectedItemId;
            InstanceType = instanceType ?? "SwitchProtectionJobDetails";
        }

        /// <summary> ARM Id of the new replication protected item. </summary>
        public ResourceIdentifier NewReplicationProtectedItemId { get; }
    }
}
