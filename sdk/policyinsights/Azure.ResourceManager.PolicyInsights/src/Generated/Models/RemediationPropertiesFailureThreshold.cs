// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The remediation failure threshold settings. </summary>
    internal partial class RemediationPropertiesFailureThreshold
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemediationPropertiesFailureThreshold"/>. </summary>
        public RemediationPropertiesFailureThreshold()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RemediationPropertiesFailureThreshold"/>. </summary>
        /// <param name="percentage"> A number between 0.0 to 1.0 representing the percentage failure threshold. The remediation will fail if the percentage of failed remediation operations (i.e. failed deployments) exceeds this threshold. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationPropertiesFailureThreshold(float? percentage, Dictionary<string, BinaryData> rawData)
        {
            Percentage = percentage;
            _rawData = rawData;
        }

        /// <summary> A number between 0.0 to 1.0 representing the percentage failure threshold. The remediation will fail if the percentage of failed remediation operations (i.e. failed deployments) exceeds this threshold. </summary>
        public float? Percentage { get; set; }
    }
}
