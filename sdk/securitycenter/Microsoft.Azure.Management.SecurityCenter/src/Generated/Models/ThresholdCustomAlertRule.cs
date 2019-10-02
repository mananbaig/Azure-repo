// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A custom alert rule that checks if a value (depends on the custom alert
    /// type) is within the given range.
    /// </summary>
    public partial class ThresholdCustomAlertRule : CustomAlertRule
    {
        /// <summary>
        /// Initializes a new instance of the ThresholdCustomAlertRule class.
        /// </summary>
        public ThresholdCustomAlertRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ThresholdCustomAlertRule class.
        /// </summary>
        /// <param name="isEnabled">Status of the custom alert.</param>
        /// <param name="ruleType">The type of the custom alert rule.</param>
        /// <param name="minThreshold">The minimum threshold.</param>
        /// <param name="maxThreshold">The maximum threshold.</param>
        /// <param name="displayName">The display name of the custom
        /// alert.</param>
        /// <param name="description">The description of the custom
        /// alert.</param>
        public ThresholdCustomAlertRule(bool isEnabled, string ruleType, int minThreshold, int maxThreshold, string displayName = default(string), string description = default(string))
            : base(isEnabled, ruleType, displayName, description)
        {
            MinThreshold = minThreshold;
            MaxThreshold = maxThreshold;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the minimum threshold.
        /// </summary>
        [JsonProperty(PropertyName = "minThreshold")]
        public int MinThreshold { get; set; }

        /// <summary>
        /// Gets or sets the maximum threshold.
        /// </summary>
        [JsonProperty(PropertyName = "maxThreshold")]
        public int MaxThreshold { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
