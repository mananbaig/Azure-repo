// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The supported capabilities. </summary>
    public partial class ContainerSupportedCapabilities
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerSupportedCapabilities"/>. </summary>
        internal ContainerSupportedCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerSupportedCapabilities"/>. </summary>
        /// <param name="maxMemoryInGB"> The maximum allowed memory request in GB. </param>
        /// <param name="maxCpu"> The maximum allowed CPU request in cores. </param>
        /// <param name="maxGpuCount"> The maximum allowed GPU count. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerSupportedCapabilities(float? maxMemoryInGB, float? maxCpu, float? maxGpuCount, Dictionary<string, BinaryData> rawData)
        {
            MaxMemoryInGB = maxMemoryInGB;
            MaxCpu = maxCpu;
            MaxGpuCount = maxGpuCount;
            _rawData = rawData;
        }

        /// <summary> The maximum allowed memory request in GB. </summary>
        public float? MaxMemoryInGB { get; }
        /// <summary> The maximum allowed CPU request in cores. </summary>
        public float? MaxCpu { get; }
        /// <summary> The maximum allowed GPU count. </summary>
        public float? MaxGpuCount { get; }
    }
}
