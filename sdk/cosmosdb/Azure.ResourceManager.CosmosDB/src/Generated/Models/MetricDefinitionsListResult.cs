// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The response to a list metric definitions request. </summary>
    public partial class MetricDefinitionsListResult
    {
        /// <summary> Initializes a new instance of MetricDefinitionsListResult. </summary>
        internal MetricDefinitionsListResult()
        {
            Value = new ChangeTrackingList<MetricDefinition>();
        }

        /// <summary> Initializes a new instance of MetricDefinitionsListResult. </summary>
        /// <param name="value"> The list of metric definitions for the account. </param>
        internal MetricDefinitionsListResult(IReadOnlyList<MetricDefinition> value)
        {
            Value = value;
        }

        /// <summary> The list of metric definitions for the account. </summary>
        public IReadOnlyList<MetricDefinition> Value { get; }
    }
}
