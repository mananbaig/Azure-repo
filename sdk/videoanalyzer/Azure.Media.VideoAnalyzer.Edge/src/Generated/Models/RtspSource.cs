// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> RTSP source allows for media from an RTSP camera or generic RTSP server to be ingested into a live pipeline. </summary>
    public partial class RtspSource : SourceNodeBase
    {
        /// <summary> Initializes a new instance of RtspSource. </summary>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="endpoint"> RTSP endpoint information for Video Analyzer to connect to. This contains the required information for Video Analyzer to connect to RTSP cameras and/or generic RTSP servers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="endpoint"/> is null. </exception>
        public RtspSource(string name, EndpointBase endpoint) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }

            Endpoint = endpoint;
            Type = "#Microsoft.VideoAnalyzer.RtspSource";
        }

        /// <summary> Initializes a new instance of RtspSource. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="name"> Node name. Must be unique within the topology. </param>
        /// <param name="transport"> Network transport utilized by the RTSP and RTP exchange: TCP or HTTP. When using TCP, the RTP packets are interleaved on the TCP RTSP connection. When using HTTP, the RTSP messages are exchanged through long lived HTTP connections, and the RTP packages are interleaved in the HTTP connections alongside the RTSP messages. </param>
        /// <param name="endpoint"> RTSP endpoint information for Video Analyzer to connect to. This contains the required information for Video Analyzer to connect to RTSP cameras and/or generic RTSP servers. </param>
        internal RtspSource(string type, string name, RtspTransport? transport, EndpointBase endpoint) : base(type, name)
        {
            Transport = transport;
            Endpoint = endpoint;
            Type = type ?? "#Microsoft.VideoAnalyzer.RtspSource";
        }

        /// <summary> Network transport utilized by the RTSP and RTP exchange: TCP or HTTP. When using TCP, the RTP packets are interleaved on the TCP RTSP connection. When using HTTP, the RTSP messages are exchanged through long lived HTTP connections, and the RTP packages are interleaved in the HTTP connections alongside the RTSP messages. </summary>
        public RtspTransport? Transport { get; set; }
        /// <summary> RTSP endpoint information for Video Analyzer to connect to. This contains the required information for Video Analyzer to connect to RTSP cameras and/or generic RTSP servers. </summary>
        public EndpointBase Endpoint { get; set; }
    }
}
