// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For schedules like: 'recur every day' or 'recur every 3 days'. </summary>
    internal partial class DailySchedule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DailySchedule"/>. </summary>
        /// <param name="intervalDays"> Specifies the number of days between each set of occurrences. </param>
        public DailySchedule(int intervalDays)
        {
            IntervalDays = intervalDays;
        }

        /// <summary> Initializes a new instance of <see cref="DailySchedule"/>. </summary>
        /// <param name="intervalDays"> Specifies the number of days between each set of occurrences. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DailySchedule(int intervalDays, Dictionary<string, BinaryData> rawData)
        {
            IntervalDays = intervalDays;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DailySchedule"/> for deserialization. </summary>
        internal DailySchedule()
        {
        }

        /// <summary> Specifies the number of days between each set of occurrences. </summary>
        public int IntervalDays { get; set; }
    }
}
