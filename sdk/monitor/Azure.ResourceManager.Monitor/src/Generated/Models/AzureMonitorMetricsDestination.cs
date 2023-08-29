// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Azure Monitor Metrics destination. </summary>
    internal partial class AzureMonitorMetricsDestination
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AzureMonitorMetricsDestination"/>. </summary>
        public AzureMonitorMetricsDestination()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureMonitorMetricsDestination"/>. </summary>
        /// <param name="name">
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AzureMonitorMetricsDestination(string name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary>
        /// A friendly name for the destination.
        /// This name should be unique across all destinations (regardless of type) within the data collection rule.
        /// </summary>
        public string Name { get; set; }
    }
}
