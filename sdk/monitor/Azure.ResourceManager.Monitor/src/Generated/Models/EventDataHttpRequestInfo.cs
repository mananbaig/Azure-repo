// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The Http request info. </summary>
    public partial class EventDataHttpRequestInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EventDataHttpRequestInfo"/>. </summary>
        internal EventDataHttpRequestInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EventDataHttpRequestInfo"/>. </summary>
        /// <param name="clientRequestId"> the client request id. </param>
        /// <param name="clientIPAddress"> the client Ip Address. </param>
        /// <param name="method"> the Http request method. </param>
        /// <param name="uri"> the Uri. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EventDataHttpRequestInfo(string clientRequestId, IPAddress clientIPAddress, string method, Uri uri, Dictionary<string, BinaryData> rawData)
        {
            ClientRequestId = clientRequestId;
            ClientIPAddress = clientIPAddress;
            Method = method;
            Uri = uri;
            _rawData = rawData;
        }

        /// <summary> the client request id. </summary>
        public string ClientRequestId { get; }
        /// <summary> the client Ip Address. </summary>
        public IPAddress ClientIPAddress { get; }
        /// <summary> the Http request method. </summary>
        public string Method { get; }
        /// <summary> the Uri. </summary>
        public Uri Uri { get; }
    }
}
