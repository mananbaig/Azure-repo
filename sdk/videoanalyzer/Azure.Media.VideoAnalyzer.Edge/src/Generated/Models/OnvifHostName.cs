// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The ONVIF device DNS properties. </summary>
    public partial class OnvifHostName
    {
        /// <summary> Initializes a new instance of OnvifHostName. </summary>
        public OnvifHostName()
        {
        }

        /// <summary> Initializes a new instance of OnvifHostName. </summary>
        /// <param name="fromDhcp"> Result value showing if the ONVIF device is configured to use DHCP. </param>
        /// <param name="hostname"> The hostname of the ONVIF device. </param>
        internal OnvifHostName(bool? fromDhcp, string hostname)
        {
            FromDhcp = fromDhcp;
            Hostname = hostname;
        }

        /// <summary> Result value showing if the ONVIF device is configured to use DHCP. </summary>
        public bool? FromDhcp { get; set; }
        /// <summary> The hostname of the ONVIF device. </summary>
        public string Hostname { get; set; }
    }
}
