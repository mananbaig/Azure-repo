// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing the AppServiceVirtualNetwork data model.
    /// Virtual Network information ARM resource.
    /// </summary>
    public partial class AppServiceVirtualNetworkData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceVirtualNetworkData"/>. </summary>
        public AppServiceVirtualNetworkData()
        {
            Routes = new ChangeTrackingList<AppServiceVirtualNetworkRoute>();
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceVirtualNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="vnetResourceId"> The Virtual Network's resource ID. </param>
        /// <param name="certThumbprintString"> The client certificate thumbprint. </param>
        /// <param name="certBlob">
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </param>
        /// <param name="routes"> The routes that this Virtual Network connection uses. </param>
        /// <param name="isResyncRequired"> &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="dnsServers"> DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. </param>
        /// <param name="isSwift"> Flag that is used to denote if this is VNET injection. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceVirtualNetworkData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier vnetResourceId, string certThumbprintString, string certBlob, IReadOnlyList<AppServiceVirtualNetworkRoute> routes, bool? isResyncRequired, string dnsServers, bool? isSwift, string kind, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            VnetResourceId = vnetResourceId;
            CertThumbprintString = certThumbprintString;
            CertBlob = certBlob;
            Routes = routes;
            IsResyncRequired = isResyncRequired;
            DnsServers = dnsServers;
            IsSwift = isSwift;
            Kind = kind;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The Virtual Network's resource ID. </summary>
        public ResourceIdentifier VnetResourceId { get; set; }
        /// <summary> The client certificate thumbprint. </summary>
        public string CertThumbprintString { get; }
        /// <summary>
        /// A certificate file (.cer) blob containing the public key of the private key used to authenticate a
        /// Point-To-Site VPN connection.
        /// </summary>
        public string CertBlob { get; set; }
        /// <summary> The routes that this Virtual Network connection uses. </summary>
        public IReadOnlyList<AppServiceVirtualNetworkRoute> Routes { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if a resync is required; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? IsResyncRequired { get; }
        /// <summary> DNS servers to be used by this Virtual Network. This should be a comma-separated list of IP addresses. </summary>
        public string DnsServers { get; set; }
        /// <summary> Flag that is used to denote if this is VNET injection. </summary>
        public bool? IsSwift { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
