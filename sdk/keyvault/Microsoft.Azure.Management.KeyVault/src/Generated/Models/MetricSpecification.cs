// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Metric specification of operation.
    /// </summary>
    public partial class MetricSpecification
    {
        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        public MetricSpecification()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricSpecification class.
        /// </summary>
        /// <param name="name">Name of metric specification.</param>
        /// <param name="displayName">Display name of metric
        /// specification.</param>
        /// <param name="displayDescription">Display description of metric
        /// specification.</param>
        /// <param name="unit">The metric unit. Possible values include:
        /// 'Bytes', 'Count', 'Milliseconds'.</param>
        /// <param name="aggregationType">The metric aggregation type. Possible
        /// values include: 'Average', 'Count', 'Total'.</param>
        /// <param name="supportedAggregationTypes">The supported aggregation
        /// types for the metrics.</param>
        /// <param name="supportedTimeGrainTypes">The supported time grain
        /// types for the metrics.</param>
        /// <param name="lockAggregationType">The metric lock aggregation
        /// type.</param>
        /// <param name="dimensions">The dimensions of metric</param>
        /// <param name="fillGapWithZero">Property to specify whether to fill
        /// gap with zero.</param>
        /// <param name="internalMetricName">The internal metric name.</param>
        public MetricSpecification(string name = default(string), string displayName = default(string), string displayDescription = default(string), string unit = default(string), string aggregationType = default(string), IList<string> supportedAggregationTypes = default(IList<string>), IList<string> supportedTimeGrainTypes = default(IList<string>), string lockAggregationType = default(string), IList<DimensionProperties> dimensions = default(IList<DimensionProperties>), bool? fillGapWithZero = default(bool?), string internalMetricName = default(string))
        {
            Name = name;
            DisplayName = displayName;
            DisplayDescription = displayDescription;
            Unit = unit;
            AggregationType = aggregationType;
            SupportedAggregationTypes = supportedAggregationTypes;
            SupportedTimeGrainTypes = supportedTimeGrainTypes;
            LockAggregationType = lockAggregationType;
            Dimensions = dimensions;
            FillGapWithZero = fillGapWithZero;
            InternalMetricName = internalMetricName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets display name of metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets display description of metric specification.
        /// </summary>
        [JsonProperty(PropertyName = "displayDescription")]
        public string DisplayDescription { get; set; }

        /// <summary>
        /// Gets or sets the metric unit. Possible values include: 'Bytes',
        /// 'Count', 'Milliseconds'.
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public string Unit { get; set; }

        /// <summary>
        /// Gets or sets the metric aggregation type. Possible values include:
        /// 'Average', 'Count', 'Total'.
        /// </summary>
        [JsonProperty(PropertyName = "aggregationType")]
        public string AggregationType { get; set; }

        /// <summary>
        /// Gets or sets the supported aggregation types for the metrics.
        /// </summary>
        [JsonProperty(PropertyName = "supportedAggregationTypes")]
        public IList<string> SupportedAggregationTypes { get; set; }

        /// <summary>
        /// Gets or sets the supported time grain types for the metrics.
        /// </summary>
        [JsonProperty(PropertyName = "supportedTimeGrainTypes")]
        public IList<string> SupportedTimeGrainTypes { get; set; }

        /// <summary>
        /// Gets or sets the metric lock aggregation type.
        /// </summary>
        [JsonProperty(PropertyName = "lockAggregationType")]
        public string LockAggregationType { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of metric
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<DimensionProperties> Dimensions { get; set; }

        /// <summary>
        /// Gets or sets property to specify whether to fill gap with zero.
        /// </summary>
        [JsonProperty(PropertyName = "fillGapWithZero")]
        public bool? FillGapWithZero { get; set; }

        /// <summary>
        /// Gets or sets the internal metric name.
        /// </summary>
        [JsonProperty(PropertyName = "internalMetricName")]
        public string InternalMetricName { get; set; }

    }
}
