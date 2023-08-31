// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> A metric name. </summary>
    public partial class CosmosDBMetricName
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBMetricName"/>. </summary>
        internal CosmosDBMetricName()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBMetricName"/>. </summary>
        /// <param name="value"> The name of the metric. </param>
        /// <param name="localizedValue"> The friendly name of the metric. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBMetricName(string value, string localizedValue, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            LocalizedValue = localizedValue;
            _rawData = rawData;
        }

        /// <summary> The name of the metric. </summary>
        public string Value { get; }
        /// <summary> The friendly name of the metric. </summary>
        public string LocalizedValue { get; }
    }
}
