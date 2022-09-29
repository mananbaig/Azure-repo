// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Sub-protection policy which includes schedule and retention. </summary>
    public partial class SubProtectionPolicy
    {
        /// <summary> Initializes a new instance of SubProtectionPolicy. </summary>
        public SubProtectionPolicy()
        {
            TieringPolicy = new ChangeTrackingDictionary<string, TieringPolicy>();
        }

        /// <summary> Initializes a new instance of SubProtectionPolicy. </summary>
        /// <param name="policyType"> Type of backup policy type. </param>
        /// <param name="schedulePolicy">
        /// Backup schedule specified as part of backup policy.
        /// Please note <see cref="SchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </param>
        /// <param name="retentionPolicy">
        /// Retention policy with the details on backup copy retention ranges.
        /// Please note <see cref="RetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </param>
        /// <param name="tieringPolicy">
        /// Tiering policy to automatically move RPs to another tier.
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </param>
        internal SubProtectionPolicy(PolicyType? policyType, SchedulePolicy schedulePolicy, RetentionPolicy retentionPolicy, IDictionary<string, TieringPolicy> tieringPolicy)
        {
            PolicyType = policyType;
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            TieringPolicy = tieringPolicy;
        }

        /// <summary> Type of backup policy type. </summary>
        public PolicyType? PolicyType { get; set; }
        /// <summary>
        /// Backup schedule specified as part of backup policy.
        /// Please note <see cref="SchedulePolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LogSchedulePolicy"/>, <see cref="LongTermSchedulePolicy"/>, <see cref="SimpleSchedulePolicy"/> and <see cref="SimpleSchedulePolicyV2"/>.
        /// </summary>
        public SchedulePolicy SchedulePolicy { get; set; }
        /// <summary>
        /// Retention policy with the details on backup copy retention ranges.
        /// Please note <see cref="RetentionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="LongTermRetentionPolicy"/> and <see cref="SimpleRetentionPolicy"/>.
        /// </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
        /// <summary>
        /// Tiering policy to automatically move RPs to another tier.
        /// Key is Target Tier, defined in RecoveryPointTierType enum.
        /// Tiering policy specifies the criteria to move RP to the target tier.
        /// </summary>
        public IDictionary<string, TieringPolicy> TieringPolicy { get; }
    }
}
