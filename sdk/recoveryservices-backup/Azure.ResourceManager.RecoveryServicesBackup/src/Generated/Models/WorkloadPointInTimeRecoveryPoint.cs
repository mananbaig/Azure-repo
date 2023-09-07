// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Recovery point specific to PointInTime
    /// Please note <see cref="WorkloadPointInTimeRecoveryPoint"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="WorkloadSapHanaPointInTimeRecoveryPoint"/>.
    /// </summary>
    public partial class WorkloadPointInTimeRecoveryPoint : WorkloadRecoveryPoint
    {
        /// <summary> Initializes a new instance of <see cref="WorkloadPointInTimeRecoveryPoint"/>. </summary>
        public WorkloadPointInTimeRecoveryPoint()
        {
            TimeRanges = new ChangeTrackingList<PointInTimeRange>();
            ObjectType = "AzureWorkloadPointInTimeRecoveryPoint";
        }

        /// <summary> Initializes a new instance of <see cref="WorkloadPointInTimeRecoveryPoint"/>. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        /// <param name="recoveryPointCreatedOn"> UTC time at which recovery point was created. </param>
        /// <param name="restorePointType"> Type of restore point. </param>
        /// <param name="recoveryPointTierDetails"> Recovery point tier information. </param>
        /// <param name="recoveryPointMoveReadinessInfo"> Eligibility of RP to be moved to another tier. </param>
        /// <param name="recoveryPointProperties"> Properties of Recovery Point. </param>
        /// <param name="timeRanges"> List of log ranges. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WorkloadPointInTimeRecoveryPoint(string objectType, DateTimeOffset? recoveryPointCreatedOn, RestorePointType? restorePointType, IList<RecoveryPointTierInformationV2> recoveryPointTierDetails, IDictionary<string, RecoveryPointMoveReadinessInfo> recoveryPointMoveReadinessInfo, RecoveryPointProperties recoveryPointProperties, IList<PointInTimeRange> timeRanges, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(objectType, recoveryPointCreatedOn, restorePointType, recoveryPointTierDetails, recoveryPointMoveReadinessInfo, recoveryPointProperties, serializedAdditionalRawData)
        {
            TimeRanges = timeRanges;
            ObjectType = objectType ?? "AzureWorkloadPointInTimeRecoveryPoint";
        }

        /// <summary> List of log ranges. </summary>
        public IList<PointInTimeRange> TimeRanges { get; }
    }
}
