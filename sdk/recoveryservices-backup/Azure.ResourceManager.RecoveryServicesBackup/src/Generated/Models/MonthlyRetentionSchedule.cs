// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Monthly retention schedule. </summary>
    public partial class MonthlyRetentionSchedule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonthlyRetentionSchedule"/>. </summary>
        public MonthlyRetentionSchedule()
        {
            RetentionTimes = new ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of <see cref="MonthlyRetentionSchedule"/>. </summary>
        /// <param name="retentionScheduleFormatType"> Retention schedule format type for monthly retention policy. </param>
        /// <param name="retentionScheduleDaily"> Daily retention format for monthly retention policy. </param>
        /// <param name="retentionScheduleWeekly"> Weekly retention format for monthly retention policy. </param>
        /// <param name="retentionTimes"> Retention times of retention policy. </param>
        /// <param name="retentionDuration"> Retention duration of retention Policy. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonthlyRetentionSchedule(RetentionScheduleFormat? retentionScheduleFormatType, DailyRetentionFormat retentionScheduleDaily, WeeklyRetentionFormat retentionScheduleWeekly, IList<DateTimeOffset> retentionTimes, RetentionDuration retentionDuration, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RetentionScheduleFormatType = retentionScheduleFormatType;
            RetentionScheduleDaily = retentionScheduleDaily;
            RetentionScheduleWeekly = retentionScheduleWeekly;
            RetentionTimes = retentionTimes;
            RetentionDuration = retentionDuration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Retention schedule format type for monthly retention policy. </summary>
        public RetentionScheduleFormat? RetentionScheduleFormatType { get; set; }
        /// <summary> Daily retention format for monthly retention policy. </summary>
        internal DailyRetentionFormat RetentionScheduleDaily { get; set; }
        /// <summary> List of days of the month. </summary>
        public IList<BackupDay> RetentionScheduleDailyDaysOfTheMonth
        {
            get
            {
                if (RetentionScheduleDaily is null)
                    RetentionScheduleDaily = new DailyRetentionFormat();
                return RetentionScheduleDaily.DaysOfTheMonth;
            }
        }

        /// <summary> Weekly retention format for monthly retention policy. </summary>
        public WeeklyRetentionFormat RetentionScheduleWeekly { get; set; }
        /// <summary> Retention times of retention policy. </summary>
        public IList<DateTimeOffset> RetentionTimes { get; }
        /// <summary> Retention duration of retention Policy. </summary>
        public RetentionDuration RetentionDuration { get; set; }
    }
}
