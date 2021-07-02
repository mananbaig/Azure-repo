﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core;
using Azure.AI.MetricsAdvisor.Models;

namespace Azure.AI.MetricsAdvisor
{
    /// <summary>
    /// Feedback indicating that this is an interval of seasonality.
    /// </summary>
    [CodeGenModel("PeriodFeedback")]
    [CodeGenSuppress(nameof(MetricPeriodFeedback), typeof(string), typeof(FeedbackFilter))]
    public partial class MetricPeriodFeedback : MetricFeedback
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricPeriodFeedback"/> class.
        /// </summary>
        /// <param name="metricId">The identifier of the metric to which the <see cref="MetricPeriodFeedback"/> applies.</param>
        /// <param name="dimensionKey">
        /// A key that identifies a set of time series to which the <see cref="MetricPeriodFeedback"/> applies.
        /// If all possible dimensions are set, this key uniquely identifies a single time series
        /// for the specified <paramref name="metricId"/>. If only a subset of dimensions are set, this
        /// key uniquely identifies a group of time series.
        /// </param>
        /// <param name="periodType">The <see cref="MetricPeriodType"/>.</param>
        /// <param name="periodValue">The period value.</param>
        /// <exception cref="ArgumentNullException"><paramref name="metricId"/> or <paramref name="dimensionKey"/> is <c>null</c>.</exception>
        /// <exception cref="ArgumentException"><paramref name="metricId"/> is empty.</exception>
        public MetricPeriodFeedback(string metricId, DimensionKey dimensionKey, MetricPeriodType periodType, int periodValue)
            : base(metricId, dimensionKey)
        {
            ValueInternal = new PeriodFeedbackValue(periodType, periodValue);
            FeedbackKind = MetricFeedbackKind.Period;
        }

        /// <summary> Initializes a new instance of MetricPeriodFeedback. </summary>
        /// <param name="metricId"> metric unique id. </param>
        /// <param name="feedbackFilter"> . </param>
        /// <param name="valueInternal"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricId"/>, <paramref name="feedbackFilter"/>, or <paramref name="valueInternal"/> is null. </exception>
        internal MetricPeriodFeedback(string metricId, FeedbackFilter feedbackFilter, PeriodFeedbackValue valueInternal)
            : base(metricId, feedbackFilter.DimensionKey)
        {
            if (valueInternal == null)
            {
                throw new ArgumentNullException(nameof(valueInternal));
            }

            ValueInternal = valueInternal;
            FeedbackKind = MetricFeedbackKind.Period;
        }

        /// <summary>
        /// The <see cref="MetricPeriodType"/>.
        /// </summary>
        public MetricPeriodType PeriodType => ValueInternal.PeriodType;

        /// <summary>
        /// The period value.
        /// </summary>
        public int PeriodValue => ValueInternal.PeriodValue;

        [CodeGenMember("Value")]
        internal PeriodFeedbackValue ValueInternal { get; }
    }
}
