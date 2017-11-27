// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.IotHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Quota metrics properties.
    /// </summary>
    public partial class IotHubQuotaMetricInfo
    {
        /// <summary>
        /// Initializes a new instance of the IotHubQuotaMetricInfo class.
        /// </summary>
        public IotHubQuotaMetricInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IotHubQuotaMetricInfo class.
        /// </summary>
        /// <param name="name">The name of the quota metric.</param>
        /// <param name="currentValue">The current value for the quota
        /// metric.</param>
        /// <param name="maxValue">The maximum value of the quota
        /// metric.</param>
        public IotHubQuotaMetricInfo(string name = default(string), long? currentValue = default(long?), long? maxValue = default(long?))
        {
            Name = name;
            CurrentValue = currentValue;
            MaxValue = maxValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name of the quota metric.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the current value for the quota metric.
        /// </summary>
        [JsonProperty(PropertyName = "CurrentValue")]
        public long? CurrentValue { get; private set; }

        /// <summary>
        /// Gets the maximum value of the quota metric.
        /// </summary>
        [JsonProperty(PropertyName = "MaxValue")]
        public long? MaxValue { get; private set; }

    }
}
