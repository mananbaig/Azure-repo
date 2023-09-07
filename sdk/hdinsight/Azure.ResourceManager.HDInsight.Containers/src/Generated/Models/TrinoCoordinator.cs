// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Trino Coordinator. </summary>
    public partial class TrinoCoordinator
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TrinoCoordinator"/>. </summary>
        public TrinoCoordinator()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TrinoCoordinator"/>. </summary>
        /// <param name="highAvailabilityEnabled"> The flag that if enable coordinator HA, uses multiple coordinator replicas with auto failover, one per each head node. Default: true. </param>
        /// <param name="isEnabled"> The flag that if enable debug or not. </param>
        /// <param name="port"> The debug port. </param>
        /// <param name="suspend"> The flag that if suspend debug or not. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TrinoCoordinator(bool? highAvailabilityEnabled, bool? isEnabled, int? port, bool? suspend, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HighAvailabilityEnabled = highAvailabilityEnabled;
            IsEnabled = isEnabled;
            Port = port;
            Suspend = suspend;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The flag that if enable coordinator HA, uses multiple coordinator replicas with auto failover, one per each head node. Default: true. </summary>
        public bool? HighAvailabilityEnabled { get; set; }
        /// <summary> The flag that if enable debug or not. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The debug port. </summary>
        public int? Port { get; set; }
        /// <summary> The flag that if suspend debug or not. </summary>
        public bool? Suspend { get; set; }
    }
}
