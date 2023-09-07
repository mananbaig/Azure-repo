// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The BackupWeeklySchedule. </summary>
    public partial class BackupWeeklySchedule
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupWeeklySchedule"/>. </summary>
        public BackupWeeklySchedule()
        {
            ScheduleRunDays = new ChangeTrackingList<BackupDayOfWeek>();
            ScheduleRunTimes = new ChangeTrackingList<DateTimeOffset>();
        }

        /// <summary> Initializes a new instance of <see cref="BackupWeeklySchedule"/>. </summary>
        /// <param name="scheduleRunDays"></param>
        /// <param name="scheduleRunTimes"> List of times of day this schedule has to be run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupWeeklySchedule(IList<BackupDayOfWeek> scheduleRunDays, IList<DateTimeOffset> scheduleRunTimes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ScheduleRunDays = scheduleRunDays;
            ScheduleRunTimes = scheduleRunTimes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the schedule run days. </summary>
        public IList<BackupDayOfWeek> ScheduleRunDays { get; }
        /// <summary> List of times of day this schedule has to be run. </summary>
        public IList<DateTimeOffset> ScheduleRunTimes { get; }
    }
}
