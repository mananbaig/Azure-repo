// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CostManagement.Models
{
    /// <summary> The schedule associated with the export. </summary>
    public partial class ExportSchedule
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExportSchedule"/>. </summary>
        public ExportSchedule()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExportSchedule"/>. </summary>
        /// <param name="status"> The status of the export's schedule. If 'Inactive', the export's schedule is paused. </param>
        /// <param name="recurrence"> The schedule recurrence. </param>
        /// <param name="recurrencePeriod"> Has start and end date of the recurrence. The start date must be in future. If present, the end date must be greater than start date. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExportSchedule(ExportScheduleStatusType? status, ExportScheduleRecurrenceType? recurrence, ExportRecurrencePeriod recurrencePeriod, Dictionary<string, BinaryData> rawData)
        {
            Status = status;
            Recurrence = recurrence;
            RecurrencePeriod = recurrencePeriod;
            _rawData = rawData;
        }

        /// <summary> The status of the export's schedule. If 'Inactive', the export's schedule is paused. </summary>
        public ExportScheduleStatusType? Status { get; set; }
        /// <summary> The schedule recurrence. </summary>
        public ExportScheduleRecurrenceType? Recurrence { get; set; }
        /// <summary> Has start and end date of the recurrence. The start date must be in future. If present, the end date must be greater than start date. </summary>
        public ExportRecurrencePeriod RecurrencePeriod { get; set; }
    }
}
