// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity source for an HTTP file.
    /// </summary>
    public partial class HttpSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the HttpSource class.
        /// </summary>
        public HttpSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpSource class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="httpRequestTimeout">Specifies the timeout for a HTTP
        /// client to get HTTP response from HTTP server. The default value is
        /// equivalent to System.Net.HttpWebRequest.Timeout. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        public HttpSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object httpRequestTimeout = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            HttpRequestTimeout = httpRequestTimeout;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the timeout for a HTTP client to get HTTP
        /// response from HTTP server. The default value is equivalent to
        /// System.Net.HttpWebRequest.Timeout. Type: string (or Expression with
        /// resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).
        /// </summary>
        [JsonProperty(PropertyName = "httpRequestTimeout")]
        public object HttpRequestTimeout { get; set; }

    }
}
