// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Integration Runtime Monitoring Data. </summary>
    public partial class IntegrationRuntimeMonitoringData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeMonitoringData"/>. </summary>
        internal IntegrationRuntimeMonitoringData()
        {
            Nodes = new ChangeTrackingList<NodeMonitoringData>();
        }

        /// <summary> Initializes a new instance of <see cref="IntegrationRuntimeMonitoringData"/>. </summary>
        /// <param name="name"> The name of Integration Runtime. </param>
        /// <param name="nodes"> Integration Runtime node monitoring data. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IntegrationRuntimeMonitoringData(string name, IReadOnlyList<NodeMonitoringData> nodes, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Nodes = nodes;
            _rawData = rawData;
        }

        /// <summary> The name of Integration Runtime. </summary>
        public string Name { get; }
        /// <summary> Integration Runtime node monitoring data. </summary>
        public IReadOnlyList<NodeMonitoringData> Nodes { get; }
    }
}
