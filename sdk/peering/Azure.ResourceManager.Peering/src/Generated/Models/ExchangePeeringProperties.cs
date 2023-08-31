// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The properties that define an exchange peering. </summary>
    public partial class ExchangePeeringProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ExchangePeeringProperties"/>. </summary>
        public ExchangePeeringProperties()
        {
            Connections = new ChangeTrackingList<PeeringExchangeConnection>();
        }

        /// <summary> Initializes a new instance of <see cref="ExchangePeeringProperties"/>. </summary>
        /// <param name="connections"> The set of connections that constitute an exchange peering. </param>
        /// <param name="peerAsn"> The reference of the peer ASN. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ExchangePeeringProperties(IList<PeeringExchangeConnection> connections, WritableSubResource peerAsn, Dictionary<string, BinaryData> rawData)
        {
            Connections = connections;
            PeerAsn = peerAsn;
            _rawData = rawData;
        }

        /// <summary> The set of connections that constitute an exchange peering. </summary>
        public IList<PeeringExchangeConnection> Connections { get; }
        /// <summary> The reference of the peer ASN. </summary>
        internal WritableSubResource PeerAsn { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PeerAsnId
        {
            get => PeerAsn is null ? default : PeerAsn.Id;
            set
            {
                if (PeerAsn is null)
                    PeerAsn = new WritableSubResource();
                PeerAsn.Id = value;
            }
        }
    }
}
