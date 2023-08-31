// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> Represents the networkAdapter on a device. </summary>
    public partial class DataBoxEdgeNetworkAdapter
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeNetworkAdapter"/>. </summary>
        internal DataBoxEdgeNetworkAdapter()
        {
            DnsServers = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataBoxEdgeNetworkAdapter"/>. </summary>
        /// <param name="adapterId"> Instance ID of network adapter. </param>
        /// <param name="adapterPosition"> Hardware position of network adapter. </param>
        /// <param name="index"> Logical index of the adapter. </param>
        /// <param name="nodeId"> Node ID of the network adapter. </param>
        /// <param name="networkAdapterName"> Network adapter name. </param>
        /// <param name="label"> Hardware label for the adapter. </param>
        /// <param name="macAddress"> MAC address. </param>
        /// <param name="linkSpeed"> Link speed. </param>
        /// <param name="status"> Value indicating whether this adapter is valid. </param>
        /// <param name="rdmaStatus"> Value indicating whether this adapter is RDMA capable. </param>
        /// <param name="dhcpStatus"> Value indicating whether this adapter has DHCP enabled. </param>
        /// <param name="ipv4Configuration"> The IPv4 configuration of the network adapter. </param>
        /// <param name="ipv6Configuration"> The IPv6 configuration of the network adapter. </param>
        /// <param name="ipv6LinkLocalAddress"> The IPv6 local address. </param>
        /// <param name="dnsServers"> The list of DNS Servers of the device. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataBoxEdgeNetworkAdapter(string adapterId, DataBoxEdgeNetworkAdapterPosition adapterPosition, int? index, Guid? nodeId, string networkAdapterName, string label, string macAddress, long? linkSpeed, DataBoxEdgeNetworkAdapterStatus? status, DataBoxEdgeNetworkAdapterRdmaStatus? rdmaStatus, DataBoxEdgeNetworkAdapterDhcpStatus? dhcpStatus, DataBoxEdgeIPv4Config ipv4Configuration, DataBoxEdgeIPv6Config ipv6Configuration, string ipv6LinkLocalAddress, IReadOnlyList<string> dnsServers, Dictionary<string, BinaryData> rawData)
        {
            AdapterId = adapterId;
            AdapterPosition = adapterPosition;
            Index = index;
            NodeId = nodeId;
            NetworkAdapterName = networkAdapterName;
            Label = label;
            MacAddress = macAddress;
            LinkSpeed = linkSpeed;
            Status = status;
            RdmaStatus = rdmaStatus;
            DhcpStatus = dhcpStatus;
            IPv4Configuration = ipv4Configuration;
            IPv6Configuration = ipv6Configuration;
            IPv6LinkLocalAddress = ipv6LinkLocalAddress;
            DnsServers = dnsServers;
            _rawData = rawData;
        }

        /// <summary> Instance ID of network adapter. </summary>
        public string AdapterId { get; }
        /// <summary> Hardware position of network adapter. </summary>
        public DataBoxEdgeNetworkAdapterPosition AdapterPosition { get; }
        /// <summary> Logical index of the adapter. </summary>
        public int? Index { get; }
        /// <summary> Node ID of the network adapter. </summary>
        public Guid? NodeId { get; }
        /// <summary> Network adapter name. </summary>
        public string NetworkAdapterName { get; }
        /// <summary> Hardware label for the adapter. </summary>
        public string Label { get; }
        /// <summary> MAC address. </summary>
        public string MacAddress { get; }
        /// <summary> Link speed. </summary>
        public long? LinkSpeed { get; }
        /// <summary> Value indicating whether this adapter is valid. </summary>
        public DataBoxEdgeNetworkAdapterStatus? Status { get; }
        /// <summary> Value indicating whether this adapter is RDMA capable. </summary>
        public DataBoxEdgeNetworkAdapterRdmaStatus? RdmaStatus { get; }
        /// <summary> Value indicating whether this adapter has DHCP enabled. </summary>
        public DataBoxEdgeNetworkAdapterDhcpStatus? DhcpStatus { get; }
        /// <summary> The IPv4 configuration of the network adapter. </summary>
        public DataBoxEdgeIPv4Config IPv4Configuration { get; }
        /// <summary> The IPv6 configuration of the network adapter. </summary>
        public DataBoxEdgeIPv6Config IPv6Configuration { get; }
        /// <summary> The IPv6 local address. </summary>
        public string IPv6LinkLocalAddress { get; }
        /// <summary> The list of DNS Servers of the device. </summary>
        public IReadOnlyList<string> DnsServers { get; }
    }
}
