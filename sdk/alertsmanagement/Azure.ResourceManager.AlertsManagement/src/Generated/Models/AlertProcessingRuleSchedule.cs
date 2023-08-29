// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Scheduling configuration for a given alert processing rule. </summary>
    public partial class AlertProcessingRuleSchedule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleSchedule"/>. </summary>
        public AlertProcessingRuleSchedule()
        {
            Recurrences = new ChangeTrackingList<AlertProcessingRuleRecurrence>();
        }

        /// <summary> Initializes a new instance of <see cref="AlertProcessingRuleSchedule"/>. </summary>
        /// <param name="effectiveFrom"> Scheduling effective from time. Date-Time in ISO-8601 format without timezone suffix. </param>
        /// <param name="effectiveUntil"> Scheduling effective until time. Date-Time in ISO-8601 format without timezone suffix. </param>
        /// <param name="timeZone"> Scheduling time zone. </param>
        /// <param name="recurrences">
        /// List of recurrences.
        /// Please note <see cref="AlertProcessingRuleRecurrence"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DailyRecurrence"/>, <see cref="AlertProcessingRuleMonthlyRecurrence"/> and <see cref="AlertProcessingRuleWeeklyRecurrence"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AlertProcessingRuleSchedule(DateTimeOffset? effectiveFrom, DateTimeOffset? effectiveUntil, string timeZone, IList<AlertProcessingRuleRecurrence> recurrences, Dictionary<string, BinaryData> rawData)
        {
            EffectiveFrom = effectiveFrom;
            EffectiveUntil = effectiveUntil;
            TimeZone = timeZone;
            Recurrences = recurrences;
            _rawData = rawData;
        }

        /// <summary> Scheduling effective from time. Date-Time in ISO-8601 format without timezone suffix. </summary>
        public DateTimeOffset? EffectiveFrom { get; set; }
        /// <summary> Scheduling effective until time. Date-Time in ISO-8601 format without timezone suffix. </summary>
        public DateTimeOffset? EffectiveUntil { get; set; }
        /// <summary> Scheduling time zone. </summary>
        public string TimeZone { get; set; }
        /// <summary>
        /// List of recurrences.
        /// Please note <see cref="AlertProcessingRuleRecurrence"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DailyRecurrence"/>, <see cref="AlertProcessingRuleMonthlyRecurrence"/> and <see cref="AlertProcessingRuleWeeklyRecurrence"/>.
        /// </summary>
        public IList<AlertProcessingRuleRecurrence> Recurrences { get; }
    }
}
