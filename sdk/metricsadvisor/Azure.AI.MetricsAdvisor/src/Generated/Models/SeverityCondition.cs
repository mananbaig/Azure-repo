// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The SeverityCondition. </summary>
    public partial class SeverityCondition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SeverityCondition"/>. </summary>
        /// <param name="minimumAlertSeverity"> min alert severity. </param>
        /// <param name="maximumAlertSeverity"> max alert severity. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SeverityCondition(AnomalySeverity minimumAlertSeverity, AnomalySeverity maximumAlertSeverity, Dictionary<string, BinaryData> rawData)
        {
            MinimumAlertSeverity = minimumAlertSeverity;
            MaximumAlertSeverity = maximumAlertSeverity;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="SeverityCondition"/> for deserialization. </summary>
        internal SeverityCondition()
        {
        }
    }
}
