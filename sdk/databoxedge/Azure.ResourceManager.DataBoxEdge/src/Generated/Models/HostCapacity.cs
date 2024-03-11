// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Host Capacity Data. </summary>
    public partial class HostCapacity
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HostCapacity"/>. </summary>
        public HostCapacity()
        {
            VmUsedMemory = new ChangeTrackingDictionary<string, DataBoxEdgeVmMemory>();
            NumaNodesData = new ChangeTrackingList<NumaNodeInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="HostCapacity"/>. </summary>
        /// <param name="hostName"> The name of the host. </param>
        /// <param name="effectiveAvailableMemoryInMBOnHost"> The available memory on the host accounting for VM placement size and any host VM reservations. </param>
        /// <param name="availableGpuCount"> The available amount of GPUs on the host to use after accounting for GPUS used by reservations on the host. </param>
        /// <param name="vmUsedMemory"> The VM used memory per VmId. </param>
        /// <param name="gpuType"> The GPU type of the VM. </param>
        /// <param name="numaNodesData"> The numa nodes information for Hpn VMs. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HostCapacity(string hostName, long? effectiveAvailableMemoryInMBOnHost, int? availableGpuCount, IDictionary<string, DataBoxEdgeVmMemory> vmUsedMemory, string gpuType, IList<NumaNodeInfo> numaNodesData, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HostName = hostName;
            EffectiveAvailableMemoryInMBOnHost = effectiveAvailableMemoryInMBOnHost;
            AvailableGpuCount = availableGpuCount;
            VmUsedMemory = vmUsedMemory;
            GpuType = gpuType;
            NumaNodesData = numaNodesData;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the host. </summary>
        public string HostName { get; set; }
        /// <summary> The available memory on the host accounting for VM placement size and any host VM reservations. </summary>
        public long? EffectiveAvailableMemoryInMBOnHost { get; set; }
        /// <summary> The available amount of GPUs on the host to use after accounting for GPUS used by reservations on the host. </summary>
        public int? AvailableGpuCount { get; set; }
        /// <summary> The VM used memory per VmId. </summary>
        public IDictionary<string, DataBoxEdgeVmMemory> VmUsedMemory { get; }
        /// <summary> The GPU type of the VM. </summary>
        public string GpuType { get; set; }
        /// <summary> The numa nodes information for Hpn VMs. </summary>
        public IList<NumaNodeInfo> NumaNodesData { get; }
    }
}
