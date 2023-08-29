// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ClusterMetricsConfigurationPatchParameters represents the body of the request to patch the metrics configuration of cluster. </summary>
    public partial class NetworkCloudClusterMetricsConfigurationPatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterMetricsConfigurationPatch"/>. </summary>
        public NetworkCloudClusterMetricsConfigurationPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            EnabledMetrics = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkCloudClusterMetricsConfigurationPatch"/>. </summary>
        /// <param name="tags"> The Azure resource tags that will replace the existing ones. </param>
        /// <param name="collectionInterval"> The interval in minutes by which metrics will be collected. </param>
        /// <param name="enabledMetrics"> The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkCloudClusterMetricsConfigurationPatch(IDictionary<string, string> tags, long? collectionInterval, IList<string> enabledMetrics, Dictionary<string, BinaryData> rawData)
        {
            Tags = tags;
            CollectionInterval = collectionInterval;
            EnabledMetrics = enabledMetrics;
            _rawData = rawData;
        }

        /// <summary> The Azure resource tags that will replace the existing ones. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The interval in minutes by which metrics will be collected. </summary>
        public long? CollectionInterval { get; set; }
        /// <summary> The list of metric names that have been chosen to be enabled in addition to the core set of enabled metrics. </summary>
        public IList<string> EnabledMetrics { get; }
    }
}
