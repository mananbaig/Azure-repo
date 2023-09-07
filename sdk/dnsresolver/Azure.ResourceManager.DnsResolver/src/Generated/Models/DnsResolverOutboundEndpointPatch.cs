// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> Describes an outbound endpoint for a DNS resolver for PATCH operation. </summary>
    public partial class DnsResolverOutboundEndpointPatch
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DnsResolverOutboundEndpointPatch"/>. </summary>
        public DnsResolverOutboundEndpointPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DnsResolverOutboundEndpointPatch"/>. </summary>
        /// <param name="tags"> Tags for outbound endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DnsResolverOutboundEndpointPatch(IDictionary<string, string> tags, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tags for outbound endpoint. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
