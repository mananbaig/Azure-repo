// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The ContainerInfo. </summary>
    public partial class ContainerInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerInfo"/>. </summary>
        public ContainerInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerInfo"/>. </summary>
        /// <param name="currentTimeStamp"></param>
        /// <param name="previousTimeStamp"></param>
        /// <param name="currentCpuStats"></param>
        /// <param name="previousCpuStats"></param>
        /// <param name="memoryStats"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="eth0"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerInfo(DateTimeOffset? currentTimeStamp, DateTimeOffset? previousTimeStamp, ContainerCpuStatistics currentCpuStats, ContainerCpuStatistics previousCpuStats, ContainerMemoryStatistics memoryStats, string name, string id, ContainerNetworkInterfaceStatistics eth0, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            CurrentTimeStamp = currentTimeStamp;
            PreviousTimeStamp = previousTimeStamp;
            CurrentCpuStats = currentCpuStats;
            PreviousCpuStats = previousCpuStats;
            MemoryStats = memoryStats;
            Name = name;
            Id = id;
            Eth0 = eth0;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the current time stamp. </summary>
        public DateTimeOffset? CurrentTimeStamp { get; set; }
        /// <summary> Gets or sets the previous time stamp. </summary>
        public DateTimeOffset? PreviousTimeStamp { get; set; }
        /// <summary> Gets or sets the current cpu stats. </summary>
        public ContainerCpuStatistics CurrentCpuStats { get; set; }
        /// <summary> Gets or sets the previous cpu stats. </summary>
        public ContainerCpuStatistics PreviousCpuStats { get; set; }
        /// <summary> Gets or sets the memory stats. </summary>
        public ContainerMemoryStatistics MemoryStats { get; set; }
        /// <summary> Gets or sets the name. </summary>
        public string Name { get; set; }
        /// <summary> Gets or sets the id. </summary>
        public string Id { get; set; }
        /// <summary> Gets or sets the eth 0. </summary>
        public ContainerNetworkInterfaceStatistics Eth0 { get; set; }
    }
}
