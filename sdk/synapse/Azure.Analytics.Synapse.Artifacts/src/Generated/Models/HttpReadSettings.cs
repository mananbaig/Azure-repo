// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Sftp read settings. </summary>
    public partial class HttpReadSettings : StoreReadSettings
    {
        /// <summary> Initializes a new instance of <see cref="HttpReadSettings"/>. </summary>
        public HttpReadSettings()
        {
            Type = "HttpReadSettings";
        }

        /// <summary> Initializes a new instance of <see cref="HttpReadSettings"/>. </summary>
        /// <param name="type"> The read setting type. </param>
        /// <param name="maxConcurrentConnections"> The maximum concurrent connection count for the source data store. Type: integer (or Expression with resultType integer). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="requestMethod"> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </param>
        /// <param name="requestBody"> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalHeaders"> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </param>
        /// <param name="requestTimeout"> Specifies the timeout for a HTTP client to get HTTP response from HTTP server. </param>
        /// <param name="enablePartitionDiscovery"> Indicates whether to enable partition discovery. </param>
        /// <param name="partitionRootPath"> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </param>
        internal HttpReadSettings(string type, object maxConcurrentConnections, IDictionary<string, object> additionalProperties, object requestMethod, object requestBody, object additionalHeaders, object requestTimeout, bool? enablePartitionDiscovery, object partitionRootPath) : base(type, maxConcurrentConnections, additionalProperties)
        {
            RequestMethod = requestMethod;
            RequestBody = requestBody;
            AdditionalHeaders = additionalHeaders;
            RequestTimeout = requestTimeout;
            EnablePartitionDiscovery = enablePartitionDiscovery;
            PartitionRootPath = partitionRootPath;
            Type = type ?? "HttpReadSettings";
        }

        /// <summary> The HTTP method used to call the RESTful API. The default is GET. Type: string (or Expression with resultType string). </summary>
        public object RequestMethod { get; set; }
        /// <summary> The HTTP request body to the RESTful API if requestMethod is POST. Type: string (or Expression with resultType string). </summary>
        public object RequestBody { get; set; }
        /// <summary> The additional HTTP headers in the request to the RESTful API. Type: string (or Expression with resultType string). </summary>
        public object AdditionalHeaders { get; set; }
        /// <summary> Specifies the timeout for a HTTP client to get HTTP response from HTTP server. </summary>
        public object RequestTimeout { get; set; }
        /// <summary> Indicates whether to enable partition discovery. </summary>
        public bool? EnablePartitionDiscovery { get; set; }
        /// <summary> Specify the root path where partition discovery starts from. Type: string (or Expression with resultType string). </summary>
        public object PartitionRootPath { get; set; }
    }
}
