// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Models;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary> The PeriodFeedback. </summary>
    public partial class MetricPeriodFeedback : MetricFeedback
    {
        /// <summary> Initializes a new instance of <see cref="MetricPeriodFeedback"/>. </summary>
        /// <param name="feedbackKind"> feedback type. </param>
        /// <param name="id"> feedback unique id. </param>
        /// <param name="createdOn"> feedback created time. </param>
        /// <param name="userPrincipal"> user who gives this feedback. </param>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="dimensionFilter"></param>
        /// <param name="valueInternal"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricPeriodFeedback(MetricFeedbackKind feedbackKind, string id, DateTimeOffset? createdOn, string userPrincipal, string metricId, FeedbackFilter dimensionFilter, PeriodFeedbackValue valueInternal, Dictionary<string, BinaryData> rawData) : base(feedbackKind, id, createdOn, userPrincipal, metricId, dimensionFilter, rawData)
        {
            ValueInternal = valueInternal;
            FeedbackKind = feedbackKind;
        }

        /// <summary> Initializes a new instance of <see cref="MetricPeriodFeedback"/> for deserialization. </summary>
        internal MetricPeriodFeedback()
        {
        }
    }
}
