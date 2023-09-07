// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Represents server metrics. </summary>
    public partial class SynapseServerUsage
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseServerUsage"/>. </summary>
        internal SynapseServerUsage()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SynapseServerUsage"/>. </summary>
        /// <param name="name"> Name of the server usage metric. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="displayName"> The metric display name. </param>
        /// <param name="currentValue"> The current value of the metric. </param>
        /// <param name="limit"> The current limit of the metric. </param>
        /// <param name="unit"> The units of the metric. </param>
        /// <param name="nextResetOn"> The next reset time for the metric (ISO8601 format). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseServerUsage(string name, string resourceName, string displayName, double? currentValue, double? limit, string unit, DateTimeOffset? nextResetOn, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ResourceName = resourceName;
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            NextResetOn = nextResetOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the server usage metric. </summary>
        public string Name { get; }
        /// <summary> The name of the resource. </summary>
        public string ResourceName { get; }
        /// <summary> The metric display name. </summary>
        public string DisplayName { get; }
        /// <summary> The current value of the metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> The current limit of the metric. </summary>
        public double? Limit { get; }
        /// <summary> The units of the metric. </summary>
        public string Unit { get; }
        /// <summary> The next reset time for the metric (ISO8601 format). </summary>
        public DateTimeOffset? NextResetOn { get; }
    }
}
