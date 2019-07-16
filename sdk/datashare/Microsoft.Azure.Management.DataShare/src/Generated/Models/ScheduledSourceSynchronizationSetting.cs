// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A type of synchronization setting based on schedule
    /// </summary>
    [Newtonsoft.Json.JsonObject("ScheduleBased")]
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduledSourceSynchronizationSetting : SourceShareSynchronizationSetting
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ScheduledSourceSynchronizationSetting class.
        /// </summary>
        public ScheduledSourceSynchronizationSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ScheduledSourceSynchronizationSetting class.
        /// </summary>
        /// <param name="recurrenceInterval">Recurrence Interval. Possible
        /// values include: 'Hour', 'Day'</param>
        /// <param name="synchronizationTime">Synchronization time</param>
        public ScheduledSourceSynchronizationSetting(string recurrenceInterval = default(string), System.DateTime? synchronizationTime = default(System.DateTime?))
        {
            RecurrenceInterval = recurrenceInterval;
            SynchronizationTime = synchronizationTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets recurrence Interval. Possible values include: 'Hour',
        /// 'Day'
        /// </summary>
        [JsonProperty(PropertyName = "properties.recurrenceInterval")]
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// Gets or sets synchronization time
        /// </summary>
        [JsonProperty(PropertyName = "properties.synchronizationTime")]
        public System.DateTime? SynchronizationTime { get; set; }

    }
}
