// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Number of cloud to device messages (HTTP protocol) is not in allowed range. </summary>
    public partial class HttpC2DMessagesNotInAllowedRange : TimeWindowCustomAlertRule
    {
        /// <summary> Initializes a new instance of <see cref="HttpC2DMessagesNotInAllowedRange"/>. </summary>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        public HttpC2DMessagesNotInAllowedRange(bool isEnabled, int minThreshold, int maxThreshold, TimeSpan timeWindowSize) : base(isEnabled, minThreshold, maxThreshold, timeWindowSize)
        {
            RuleType = "HttpC2DMessagesNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of <see cref="HttpC2DMessagesNotInAllowedRange"/>. </summary>
        /// <param name="displayName"> The display name of the custom alert. </param>
        /// <param name="description"> The description of the custom alert. </param>
        /// <param name="isEnabled"> Status of the custom alert. </param>
        /// <param name="ruleType"> The type of the custom alert rule. </param>
        /// <param name="minThreshold"> The minimum threshold. </param>
        /// <param name="maxThreshold"> The maximum threshold. </param>
        /// <param name="timeWindowSize"> The time window size in iso8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HttpC2DMessagesNotInAllowedRange(string displayName, string description, bool isEnabled, string ruleType, int minThreshold, int maxThreshold, TimeSpan timeWindowSize, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(displayName, description, isEnabled, ruleType, minThreshold, maxThreshold, timeWindowSize, serializedAdditionalRawData)
        {
            RuleType = ruleType ?? "HttpC2DMessagesNotInAllowedRange";
        }

        /// <summary> Initializes a new instance of <see cref="HttpC2DMessagesNotInAllowedRange"/> for deserialization. </summary>
        internal HttpC2DMessagesNotInAllowedRange()
        {
        }
    }
}
