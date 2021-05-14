// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SignalR.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object that describes a specific usage of the resources.
    /// </summary>
    public partial class SignalRUsage
    {
        /// <summary>
        /// Initializes a new instance of the SignalRUsage class.
        /// </summary>
        public SignalRUsage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SignalRUsage class.
        /// </summary>
        /// <param name="id">Fully qualified ARM resource id</param>
        /// <param name="currentValue">Current value for the usage
        /// quota.</param>
        /// <param name="limit">The maximum permitted value for the usage
        /// quota. If there is no limit, this value will be -1.</param>
        /// <param name="name">Localizable String object containing the name
        /// and a localized value.</param>
        /// <param name="unit">Representing the units of the usage quota.
        /// Possible values are: Count, Bytes, Seconds, Percent,
        /// CountPerSecond, BytesPerSecond.</param>
        public SignalRUsage(string id = default(string), long? currentValue = default(long?), long? limit = default(long?), SignalRUsageName name = default(SignalRUsageName), string unit = default(string))
        {
            Id = id;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            Unit = unit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified ARM resource id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets current value for the usage quota.
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public long? CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets the maximum permitted value for the usage quota. If
        /// there is no limit, this value will be -1.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public long? Limit { get; set; }

        /// <summary>
        /// Gets or sets localizable String object containing the name and a
        /// localized value.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public SignalRUsageName Name { get; set; }

        /// <summary>
        /// Gets or sets representing the units of the usage quota. Possible
        /// values are: Count, Bytes, Seconds, Percent, CountPerSecond,
        /// BytesPerSecond.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

    }
}
