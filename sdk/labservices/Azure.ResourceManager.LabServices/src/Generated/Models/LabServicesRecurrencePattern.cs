// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    /// <summary> Recurrence pattern of a lab schedule. </summary>
    public partial class LabServicesRecurrencePattern
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="LabServicesRecurrencePattern"/>. </summary>
        /// <param name="frequency"> The frequency of the recurrence. </param>
        /// <param name="expireOn"> When the recurrence will expire. This date is inclusive. </param>
        public LabServicesRecurrencePattern(LabServicesRecurrenceFrequency frequency, DateTimeOffset expireOn)
        {
            Frequency = frequency;
            WeekDays = new ChangeTrackingList<LabServicesDayOfWeek>();
            ExpireOn = expireOn;
        }

        /// <summary> Initializes a new instance of <see cref="LabServicesRecurrencePattern"/>. </summary>
        /// <param name="frequency"> The frequency of the recurrence. </param>
        /// <param name="weekDays"> The week days the schedule runs. Used for when the Frequency is set to Weekly. </param>
        /// <param name="interval"> The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days. When no interval is supplied, an interval of 1 is used. </param>
        /// <param name="expireOn"> When the recurrence will expire. This date is inclusive. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal LabServicesRecurrencePattern(LabServicesRecurrenceFrequency frequency, IList<LabServicesDayOfWeek> weekDays, int? interval, DateTimeOffset expireOn, Dictionary<string, BinaryData> rawData)
        {
            Frequency = frequency;
            WeekDays = weekDays;
            Interval = interval;
            ExpireOn = expireOn;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="LabServicesRecurrencePattern"/> for deserialization. </summary>
        internal LabServicesRecurrencePattern()
        {
        }

        /// <summary> The frequency of the recurrence. </summary>
        public LabServicesRecurrenceFrequency Frequency { get; set; }
        /// <summary> The week days the schedule runs. Used for when the Frequency is set to Weekly. </summary>
        public IList<LabServicesDayOfWeek> WeekDays { get; }
        /// <summary> The interval to invoke the schedule on. For example, interval = 2 and RecurrenceFrequency.Daily will run every 2 days. When no interval is supplied, an interval of 1 is used. </summary>
        public int? Interval { get; set; }
        /// <summary> When the recurrence will expire. This date is inclusive. </summary>
        public DateTimeOffset ExpireOn { get; set; }
    }
}
