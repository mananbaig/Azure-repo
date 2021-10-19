// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recurrence pattern of a lab schedule.
    /// </summary>
    public partial class RecurrencePattern
    {
        /// <summary>
        /// Initializes a new instance of the RecurrencePattern class.
        /// </summary>
        public RecurrencePattern()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RecurrencePattern class.
        /// </summary>
        /// <param name="frequency">The frequency of the recurrence. Possible
        /// values include: 'Daily', 'Weekly'</param>
        /// <param name="expirationDate">When the recurrence will expire. This
        /// date is inclusive.</param>
        /// <param name="weekDays">The week days the schedule runs. Used for
        /// when the Frequency is set to Weekly.</param>
        /// <param name="interval">The interval to invoke the schedule on. For
        /// example, interval = 2 and RecurrenceFrequency.Daily will run every
        /// 2 days. When no interval is supplied, an interval of 1 is
        /// used.</param>
        public RecurrencePattern(RecurrenceFrequency frequency, System.DateTime expirationDate, IList<WeekDay?> weekDays = default(IList<WeekDay?>), int? interval = default(int?))
        {
            Frequency = frequency;
            WeekDays = weekDays;
            Interval = interval;
            ExpirationDate = expirationDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the frequency of the recurrence. Possible values
        /// include: 'Daily', 'Weekly'
        /// </summary>
        [JsonProperty(PropertyName = "frequency")]
        public RecurrenceFrequency Frequency { get; set; }

        /// <summary>
        /// Gets or sets the week days the schedule runs. Used for when the
        /// Frequency is set to Weekly.
        /// </summary>
        [JsonProperty(PropertyName = "weekDays")]
        public IList<WeekDay?> WeekDays { get; set; }

        /// <summary>
        /// Gets or sets the interval to invoke the schedule on. For example,
        /// interval = 2 and RecurrenceFrequency.Daily will run every 2 days.
        /// When no interval is supplied, an interval of 1 is used.
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public int? Interval { get; set; }

        /// <summary>
        /// Gets or sets when the recurrence will expire. This date is
        /// inclusive.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "expirationDate")]
        public System.DateTime ExpirationDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Interval != null)
            {
                if (Interval > 365)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Interval", 365);
                }
                if (Interval < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Interval", 1);
                }
            }
        }
    }
}
