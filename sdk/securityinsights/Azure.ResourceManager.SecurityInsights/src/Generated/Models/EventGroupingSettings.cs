// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Event grouping settings property bag. </summary>
    internal partial class EventGroupingSettings
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EventGroupingSettings"/>. </summary>
        public EventGroupingSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventGroupingSettings"/>. </summary>
        /// <param name="aggregationKind"> The event grouping aggregation kinds. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EventGroupingSettings(EventGroupingAggregationKind? aggregationKind, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AggregationKind = aggregationKind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The event grouping aggregation kinds. </summary>
        public EventGroupingAggregationKind? AggregationKind { get; set; }
    }
}
