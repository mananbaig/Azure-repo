// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Ports and any VIF attached to segment. </summary>
    public partial class WorkloadNetworkSegmentPortVif
    {
        /// <summary> Initializes a new instance of WorkloadNetworkSegmentPortVif. </summary>
        internal WorkloadNetworkSegmentPortVif()
        {
        }

        /// <summary> Initializes a new instance of WorkloadNetworkSegmentPortVif. </summary>
        /// <param name="portName"> Name of port or VIF attached to segment. </param>
        internal WorkloadNetworkSegmentPortVif(string portName)
        {
            PortName = portName;
        }

        /// <summary> Name of port or VIF attached to segment. </summary>
        public string PortName { get; }
    }
}
