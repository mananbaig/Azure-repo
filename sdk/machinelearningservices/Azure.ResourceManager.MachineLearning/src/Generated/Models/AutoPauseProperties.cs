// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Auto pause properties. </summary>
    public partial class AutoPauseProperties
    {
        /// <summary> Initializes a new instance of AutoPauseProperties. </summary>
        public AutoPauseProperties()
        {
        }

        /// <summary> Initializes a new instance of AutoPauseProperties. </summary>
        /// <param name="delayInMinutes"></param>
        /// <param name="enabled"></param>
        internal AutoPauseProperties(int? delayInMinutes, bool? enabled)
        {
            DelayInMinutes = delayInMinutes;
            Enabled = enabled;
        }

        /// <summary> Gets or sets the delay in minutes. </summary>
        public int? DelayInMinutes { get; set; }
        /// <summary> Gets or sets the enabled. </summary>
        public bool? Enabled { get; set; }
    }
}
