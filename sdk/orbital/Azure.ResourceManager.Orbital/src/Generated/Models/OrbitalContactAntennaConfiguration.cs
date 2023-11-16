// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> The configuration associated with the allocated antenna. </summary>
    public partial class OrbitalContactAntennaConfiguration
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="OrbitalContactAntennaConfiguration"/>. </summary>
        internal OrbitalContactAntennaConfiguration()
        {
            SourceIPs = new ChangeTrackingList<IPAddress>();
        }

        /// <summary> Initializes a new instance of <see cref="OrbitalContactAntennaConfiguration"/>. </summary>
        /// <param name="destinationIP"> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </param>
        /// <param name="sourceIPs"> List of Source IP. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal OrbitalContactAntennaConfiguration(IPAddress destinationIP, IReadOnlyList<IPAddress> sourceIPs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DestinationIP = destinationIP;
            SourceIPs = sourceIPs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The destination IP a packet can be sent to. This would for example be the TCP endpoint you would send data to. </summary>
        public IPAddress DestinationIP { get; }
        /// <summary> List of Source IP. </summary>
        public IReadOnlyList<IPAddress> SourceIPs { get; }
    }
}
