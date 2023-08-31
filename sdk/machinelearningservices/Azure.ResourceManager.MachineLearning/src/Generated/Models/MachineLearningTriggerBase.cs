// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MachineLearningTriggerBase.
    /// Please note <see cref="MachineLearningTriggerBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="CronTrigger"/> and <see cref="MachineLearningRecurrenceTrigger"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownTriggerBase))]
    public abstract partial class MachineLearningTriggerBase
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningTriggerBase"/>. </summary>
        protected MachineLearningTriggerBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningTriggerBase"/>. </summary>
        /// <param name="endTime">
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </param>
        /// <param name="startTime"> Specifies start time of schedule in ISO 8601 format, but without a UTC offset. </param>
        /// <param name="timeZone">
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </param>
        /// <param name="triggerType"> [Required]. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningTriggerBase(string endTime, string startTime, string timeZone, MachineLearningTriggerType triggerType, Dictionary<string, BinaryData> rawData)
        {
            EndTime = endTime;
            StartTime = startTime;
            TimeZone = timeZone;
            TriggerType = triggerType;
            _rawData = rawData;
        }

        /// <summary>
        /// Specifies end time of schedule in ISO 8601, but without a UTC offset. Refer https://en.wikipedia.org/wiki/ISO_8601.
        /// Recommented format would be "2022-06-01T00:00:01"
        /// If not present, the schedule will run indefinitely
        /// </summary>
        public string EndTime { get; set; }
        /// <summary> Specifies start time of schedule in ISO 8601 format, but without a UTC offset. </summary>
        public string StartTime { get; set; }
        /// <summary>
        /// Specifies time zone in which the schedule runs.
        /// TimeZone should follow Windows time zone format. Refer: https://docs.microsoft.com/en-us/windows-hardware/manufacture/desktop/default-time-zones?view=windows-11
        /// </summary>
        public string TimeZone { get; set; }
        /// <summary> [Required]. </summary>
        internal MachineLearningTriggerType TriggerType { get; set; }
    }
}
