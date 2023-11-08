// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Schedule info describing when the server should be started or stopped. </summary>
    public partial class SqlScheduleItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SqlScheduleItem"/>. </summary>
        /// <param name="startDay"> Start day. </param>
        /// <param name="startTime"> Start time. </param>
        /// <param name="stopDay"> Stop day. </param>
        /// <param name="stopTime"> Stop time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="startTime"/> or <paramref name="stopTime"/> is null. </exception>
        public SqlScheduleItem(SqlDayOfWeek startDay, string startTime, SqlDayOfWeek stopDay, string stopTime)
        {
            Argument.AssertNotNull(startTime, nameof(startTime));
            Argument.AssertNotNull(stopTime, nameof(stopTime));

            StartDay = startDay;
            StartTime = startTime;
            StopDay = stopDay;
            StopTime = stopTime;
        }

        /// <summary> Initializes a new instance of <see cref="SqlScheduleItem"/>. </summary>
        /// <param name="startDay"> Start day. </param>
        /// <param name="startTime"> Start time. </param>
        /// <param name="stopDay"> Stop day. </param>
        /// <param name="stopTime"> Stop time. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlScheduleItem(SqlDayOfWeek startDay, string startTime, SqlDayOfWeek stopDay, string stopTime, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            StartDay = startDay;
            StartTime = startTime;
            StopDay = stopDay;
            StopTime = stopTime;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="SqlScheduleItem"/> for deserialization. </summary>
        internal SqlScheduleItem()
        {
        }

        /// <summary> Start day. </summary>
        public SqlDayOfWeek StartDay { get; set; }
        /// <summary> Start time. </summary>
        public string StartTime { get; set; }
        /// <summary> Stop day. </summary>
        public SqlDayOfWeek StopDay { get; set; }
        /// <summary> Stop time. </summary>
        public string StopTime { get; set; }
    }
}
