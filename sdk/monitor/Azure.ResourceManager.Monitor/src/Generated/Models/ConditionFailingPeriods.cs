// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The minimum number of violations required within the selected lookback time window required to raise an alert. Relevant only for rules of the kind LogAlert. </summary>
    public partial class ConditionFailingPeriods
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConditionFailingPeriods"/>. </summary>
        public ConditionFailingPeriods()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConditionFailingPeriods"/>. </summary>
        /// <param name="numberOfEvaluationPeriods"> The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (windowSize) and the selected number of aggregated points. Default value is 1. </param>
        /// <param name="minFailingPeriodsToAlert"> The number of violations to trigger an alert. Should be smaller or equal to numberOfEvaluationPeriods. Default value is 1. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConditionFailingPeriods(long? numberOfEvaluationPeriods, long? minFailingPeriodsToAlert, Dictionary<string, BinaryData> rawData)
        {
            NumberOfEvaluationPeriods = numberOfEvaluationPeriods;
            MinFailingPeriodsToAlert = minFailingPeriodsToAlert;
            _rawData = rawData;
        }

        /// <summary> The number of aggregated lookback points. The lookback time window is calculated based on the aggregation granularity (windowSize) and the selected number of aggregated points. Default value is 1. </summary>
        public long? NumberOfEvaluationPeriods { get; set; }
        /// <summary> The number of violations to trigger an alert. Should be smaller or equal to numberOfEvaluationPeriods. Default value is 1. </summary>
        public long? MinFailingPeriodsToAlert { get; set; }
    }
}
