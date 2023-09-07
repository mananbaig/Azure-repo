// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Number of twin updates is not in allowed range. </summary>
    public partial class TwinUpdatesNotInAllowedRange : TimeWindowCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="TwinUpdatesNotInAllowedRange"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        public TwinUpdatesNotInAllowedRange(bool isEnabled, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(isEnabled, minThreshold, maxThreshold, timeWindowSize)
        {
            RuleType = "TwinUpdatesNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of <see cref="TwinUpdatesNotInAllowedRange"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TwinUpdatesNotInAllowedRange(string displayName, string description, bool isEnabled, string ruleType, int minThreshold, int maxThreshold, TimeSpan timeWindowSize, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(displayName, description, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize, serializedAdditionalRawData)
        {
            RuleType = ruleType ?? "TwinUpdatesNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of <see cref="TwinUpdatesNotInAllowedRange"/> for deserialization. </summary>
        internal TwinUpdatesNotInAllowedRange()
        {
        }
    }
}
