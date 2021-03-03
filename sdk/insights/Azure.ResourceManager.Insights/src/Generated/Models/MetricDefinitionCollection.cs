// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Represents collection of metric definitions. </summary>
    internal partial class MetricDefinitionCollection
    {
        /// <summary> Initializes a new instance of MetricDefinitionCollection. </summary>
        /// <param name="value"> the values for the metric definitions. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal MetricDefinitionCollection(IEnumerable<MetricDefinition> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of MetricDefinitionCollection. </summary>
        /// <param name="value"> the values for the metric definitions. </param>
        internal MetricDefinitionCollection(IReadOnlyList<MetricDefinition> value)
        {
            Value = value;
        }

        /// <summary> the values for the metric definitions. </summary>
        public IReadOnlyList<MetricDefinition> Value { get; }
    }
}
