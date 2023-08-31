// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Holds configuration customizations for IPVS. May only be specified if 'mode' is set to 'IPVS'. </summary>
    public partial class ContainerServiceNetworkProfileKubeProxyIPVSConfig
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfileKubeProxyIPVSConfig"/>. </summary>
        public ContainerServiceNetworkProfileKubeProxyIPVSConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerServiceNetworkProfileKubeProxyIPVSConfig"/>. </summary>
        /// <param name="scheduler"> IPVS scheduler, for more information please see http://www.linuxvirtualserver.org/docs/scheduling.html. </param>
        /// <param name="tcpTimeoutSeconds"> The timeout value used for idle IPVS TCP sessions in seconds. Must be a positive integer value. </param>
        /// <param name="tcpFinTimeoutSeconds"> The timeout value used for IPVS TCP sessions after receiving a FIN in seconds. Must be a positive integer value. </param>
        /// <param name="udpTimeoutSeconds"> The timeout value used for IPVS UDP packets in seconds. Must be a positive integer value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerServiceNetworkProfileKubeProxyIPVSConfig(ContainerServiceNetworkProfileKubeProxyIPVSScheduler? scheduler, int? tcpTimeoutSeconds, int? tcpFinTimeoutSeconds, int? udpTimeoutSeconds, Dictionary<string, BinaryData> rawData)
        {
            Scheduler = scheduler;
            TcpTimeoutSeconds = tcpTimeoutSeconds;
            TcpFinTimeoutSeconds = tcpFinTimeoutSeconds;
            UdpTimeoutSeconds = udpTimeoutSeconds;
            _rawData = rawData;
        }

        /// <summary> IPVS scheduler, for more information please see http://www.linuxvirtualserver.org/docs/scheduling.html. </summary>
        public ContainerServiceNetworkProfileKubeProxyIPVSScheduler? Scheduler { get; set; }
        /// <summary> The timeout value used for idle IPVS TCP sessions in seconds. Must be a positive integer value. </summary>
        public int? TcpTimeoutSeconds { get; set; }
        /// <summary> The timeout value used for IPVS TCP sessions after receiving a FIN in seconds. Must be a positive integer value. </summary>
        public int? TcpFinTimeoutSeconds { get; set; }
        /// <summary> The timeout value used for IPVS UDP packets in seconds. Must be a positive integer value. </summary>
        public int? UdpTimeoutSeconds { get; set; }
    }
}
