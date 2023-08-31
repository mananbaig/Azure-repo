// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The List incidents operation response. </summary>
    internal partial class IncidentListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IncidentListResult"/>. </summary>
        internal IncidentListResult()
        {
            Value = new ChangeTrackingList<MonitorIncident>();
        }

        /// <summary> Initializes a new instance of <see cref="IncidentListResult"/>. </summary>
        /// <param name="value"> the incident collection. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IncidentListResult(IReadOnlyList<MonitorIncident> value, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            _rawData = rawData;
        }

        /// <summary> the incident collection. </summary>
        public IReadOnlyList<MonitorIncident> Value { get; }
    }
}
