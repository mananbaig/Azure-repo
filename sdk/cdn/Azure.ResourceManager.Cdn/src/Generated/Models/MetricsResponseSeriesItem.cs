// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The MetricsResponseSeriesItem. </summary>
    public partial class MetricsResponseSeriesItem
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MetricsResponseSeriesItem"/>. </summary>
        internal MetricsResponseSeriesItem()
        {
            Groups = new ChangeTrackingList<MetricsResponseSeriesPropertiesItemsItem>();
            Data = new ChangeTrackingList<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems>();
        }

        /// <summary> Initializes a new instance of <see cref="MetricsResponseSeriesItem"/>. </summary>
        /// <param name="metric"></param>
        /// <param name="unit"></param>
        /// <param name="groups"></param>
        /// <param name="data"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MetricsResponseSeriesItem(string metric, MetricsResponseSeriesItemUnit? unit, IReadOnlyList<MetricsResponseSeriesPropertiesItemsItem> groups, IReadOnlyList<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems> data, Dictionary<string, BinaryData> rawData)
        {
            Metric = metric;
            Unit = unit;
            Groups = groups;
            Data = data;
            _rawData = rawData;
        }

        /// <summary> Gets the metric. </summary>
        public string Metric { get; }
        /// <summary> Gets the unit. </summary>
        public MetricsResponseSeriesItemUnit? Unit { get; }
        /// <summary> Gets the groups. </summary>
        public IReadOnlyList<MetricsResponseSeriesPropertiesItemsItem> Groups { get; }
        /// <summary> Gets the data. </summary>
        public IReadOnlyList<Components1Gs0LlpSchemasMetricsresponsePropertiesSeriesItemsPropertiesDataItems> Data { get; }
    }
}
