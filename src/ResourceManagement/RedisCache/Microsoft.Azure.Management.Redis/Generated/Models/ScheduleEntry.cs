// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Redis.Models
{
    using System.Linq;

    public partial class ScheduleEntry
    {
        /// <summary>
        /// Initializes a new instance of the ScheduleEntry class.
        /// </summary>
        public ScheduleEntry() { }

        /// <summary>
        /// Initializes a new instance of the ScheduleEntry class.
        /// </summary>
        /// <param name="dayOfWeek">Day of week when cache can be patched.
        /// Possible values include: 'Monday', 'Tuesday', 'Wednesday',
        /// 'Thursday', 'Friday', 'Saturday', 'Sunday'</param>
        /// <param name="startHourUtc">Start hour after which cache patching
        /// can start.</param>
        /// <param name="maintenanceWindow">ISO8601 timespan specifying how
        /// much time cache patching can take. </param>
        public ScheduleEntry(string dayOfWeek, int startHourUtc, System.TimeSpan? maintenanceWindow = default(System.TimeSpan?))
        {
            DayOfWeek = dayOfWeek;
            StartHourUtc = startHourUtc;
            MaintenanceWindow = maintenanceWindow;
        }

        /// <summary>
        /// Gets or sets day of week when cache can be patched. Possible
        /// values include: 'Monday', 'Tuesday', 'Wednesday', 'Thursday',
        /// 'Friday', 'Saturday', 'Sunday'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dayOfWeek")]
        public string DayOfWeek { get; set; }

        /// <summary>
        /// Gets or sets start hour after which cache patching can start.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startHourUtc")]
        public int StartHourUtc { get; set; }

        /// <summary>
        /// Gets or sets ISO8601 timespan specifying how much time cache
        /// patching can take.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maintenanceWindow")]
        public System.TimeSpan? MaintenanceWindow { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DayOfWeek == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "DayOfWeek");
            }
        }
    }
}
