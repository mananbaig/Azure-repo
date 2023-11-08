// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Weekly retention format. </summary>
    public partial class WeeklyRetentionFormat
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="WeeklyRetentionFormat"/>. </summary>
        public WeeklyRetentionFormat()
        {
            DaysOfTheWeek = new ChangeTrackingList<BackupDayOfWeek>();
            WeeksOfTheMonth = new ChangeTrackingList<BackupWeekOfMonth>();
        }

        /// <summary> Initializes a new instance of <see cref="WeeklyRetentionFormat"/>. </summary>
        /// <param name="daysOfTheWeek"> List of days of the week. </param>
        /// <param name="weeksOfTheMonth"> List of weeks of month. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal WeeklyRetentionFormat(IList<BackupDayOfWeek> daysOfTheWeek, IList<BackupWeekOfMonth> weeksOfTheMonth, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DaysOfTheWeek = daysOfTheWeek;
            WeeksOfTheMonth = weeksOfTheMonth;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> List of days of the week. </summary>
        public IList<BackupDayOfWeek> DaysOfTheWeek { get; }
        /// <summary> List of weeks of month. </summary>
        public IList<BackupWeekOfMonth> WeeksOfTheMonth { get; }
    }
}
