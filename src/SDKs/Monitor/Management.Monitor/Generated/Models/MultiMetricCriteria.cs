// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The types of conditions for a multi resource alert.
    /// </summary>
    public partial class MultiMetricCriteria
    {
        /// <summary>
        /// Initializes a new instance of the MultiMetricCriteria class.
        /// </summary>
        public MultiMetricCriteria()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MultiMetricCriteria class.
        /// </summary>
        /// <param name="name">Name of the criteria.</param>
        /// <param name="metricName">Name of the metric.</param>
        /// <param name="timeAggregation">the criteria time aggregation
        /// types.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="metricNamespace">Namespace of the metric.</param>
        /// <param name="dimensions">List of dimension conditions.</param>
        public MultiMetricCriteria(string name, string metricName, object timeAggregation, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string metricNamespace = default(string), IList<MetricDimension> dimensions = default(IList<MetricDimension>))
        {
            AdditionalProperties = additionalProperties;
            Name = name;
            MetricName = metricName;
            MetricNamespace = metricNamespace;
            TimeAggregation = timeAggregation;
            Dimensions = dimensions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets name of the criteria.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets name of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or sets namespace of the metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricNamespace")]
        public string MetricNamespace { get; set; }

        /// <summary>
        /// Gets or sets the criteria time aggregation types.
        /// </summary>
        [JsonProperty(PropertyName = "timeAggregation")]
        public object TimeAggregation { get; set; }

        /// <summary>
        /// Gets or sets list of dimension conditions.
        /// </summary>
        [JsonProperty(PropertyName = "dimensions")]
        public IList<MetricDimension> Dimensions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (MetricName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricName");
            }
            if (TimeAggregation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TimeAggregation");
            }
            if (Dimensions != null)
            {
                foreach (var element in Dimensions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
