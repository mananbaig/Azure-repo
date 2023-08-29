// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters to compare with network configuration. </summary>
    public partial class NetworkConfigurationDiagnosticProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticProfile"/>. </summary>
        /// <param name="direction"> The direction of the traffic. </param>
        /// <param name="protocol"> Protocol to be verified on. Accepted values are '*', TCP, UDP. </param>
        /// <param name="source"> Traffic source. Accepted values are '*', IP Address/CIDR, Service Tag. </param>
        /// <param name="destination"> Traffic destination. Accepted values are: '*', IP Address/CIDR, Service Tag. </param>
        /// <param name="destinationPort"> Traffic destination port. Accepted values are '*' and a single port in the range (0 - 65535). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="protocol"/>, <paramref name="source"/>, <paramref name="destination"/> or <paramref name="destinationPort"/> is null. </exception>
        public NetworkConfigurationDiagnosticProfile(NetworkTrafficDirection direction, string protocol, string source, string destination, string destinationPort)
        {
            Argument.AssertNotNull(protocol, nameof(protocol));
            Argument.AssertNotNull(source, nameof(source));
            Argument.AssertNotNull(destination, nameof(destination));
            Argument.AssertNotNull(destinationPort, nameof(destinationPort));

            Direction = direction;
            Protocol = protocol;
            Source = source;
            Destination = destination;
            DestinationPort = destinationPort;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticProfile"/>. </summary>
        /// <param name="direction"> The direction of the traffic. </param>
        /// <param name="protocol"> Protocol to be verified on. Accepted values are '*', TCP, UDP. </param>
        /// <param name="source"> Traffic source. Accepted values are '*', IP Address/CIDR, Service Tag. </param>
        /// <param name="destination"> Traffic destination. Accepted values are: '*', IP Address/CIDR, Service Tag. </param>
        /// <param name="destinationPort"> Traffic destination port. Accepted values are '*' and a single port in the range (0 - 65535). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkConfigurationDiagnosticProfile(NetworkTrafficDirection direction, string protocol, string source, string destination, string destinationPort, Dictionary<string, BinaryData> rawData)
        {
            Direction = direction;
            Protocol = protocol;
            Source = source;
            Destination = destination;
            DestinationPort = destinationPort;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetworkConfigurationDiagnosticProfile"/> for deserialization. </summary>
        internal NetworkConfigurationDiagnosticProfile()
        {
        }

        /// <summary> The direction of the traffic. </summary>
        public NetworkTrafficDirection Direction { get; set; }
        /// <summary> Protocol to be verified on. Accepted values are '*', TCP, UDP. </summary>
        public string Protocol { get; set; }
        /// <summary> Traffic source. Accepted values are '*', IP Address/CIDR, Service Tag. </summary>
        public string Source { get; set; }
        /// <summary> Traffic destination. Accepted values are: '*', IP Address/CIDR, Service Tag. </summary>
        public string Destination { get; set; }
        /// <summary> Traffic destination port. Accepted values are '*' and a single port in the range (0 - 65535). </summary>
        public string DestinationPort { get; set; }
    }
}
