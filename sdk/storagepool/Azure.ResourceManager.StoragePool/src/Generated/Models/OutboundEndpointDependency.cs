// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> A domain name that a service is reached at, including details of the current connection status. </summary>
    public partial class OutboundEndpointDependency
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OutboundEndpointDependency"/>. </summary>
        internal OutboundEndpointDependency()
        {
            EndpointDetails = new ChangeTrackingList<OutboundEndpointDetail>();
        }

        /// <summary> Initializes a new instance of <see cref="OutboundEndpointDependency"/>. </summary>
        /// <param name="domainName"> The domain name of the dependency. </param>
        /// <param name="endpointDetails"> The IP Addresses and Ports used when connecting to DomainName. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OutboundEndpointDependency(string domainName, IReadOnlyList<OutboundEndpointDetail> endpointDetails, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DomainName = domainName;
            EndpointDetails = endpointDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The domain name of the dependency. </summary>
        public string DomainName { get; }
        /// <summary> The IP Addresses and Ports used when connecting to DomainName. </summary>
        public IReadOnlyList<OutboundEndpointDetail> EndpointDetails { get; }
    }
}
