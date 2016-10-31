// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn.Models
{
    using System.Linq;

    /// <summary>
    /// Origin properties needed for origin creation or update.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class OriginUpdateParameters : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the OriginUpdateParameters class.
        /// </summary>
        public OriginUpdateParameters() { }

        /// <summary>
        /// Initializes a new instance of the OriginUpdateParameters class.
        /// </summary>
        /// <param name="hostName">The address of the origin. Domain names,
        /// IPv4 addresses, and IPv6 addresses are supported.</param>
        /// <param name="httpPort">The value of the HTTP port. Must be between
        /// 1 and 65535.</param>
        /// <param name="httpsPort">The value of the HTTPS port. Must be
        /// between 1 and 65535.</param>
        public OriginUpdateParameters(string hostName = default(string), int? httpPort = default(int?), int? httpsPort = default(int?))
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
        }

        /// <summary>
        /// Gets or sets the address of the origin. Domain names, IPv4
        /// addresses, and IPv6 addresses are supported.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTP port. Must be between 1 and
        /// 65535.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpPort")]
        public int? HttpPort { get; set; }

        /// <summary>
        /// Gets or sets the value of the HTTPS port. Must be between 1 and
        /// 65535.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.httpsPort")]
        public int? HttpsPort { get; set; }

    }
}
