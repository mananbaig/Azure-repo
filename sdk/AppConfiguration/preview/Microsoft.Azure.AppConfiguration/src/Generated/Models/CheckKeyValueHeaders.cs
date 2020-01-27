// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.AppConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for CheckKeyValue operation.
    /// </summary>
    public partial class CheckKeyValueHeaders
    {
        /// <summary>
        /// Initializes a new instance of the CheckKeyValueHeaders class.
        /// </summary>
        public CheckKeyValueHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckKeyValueHeaders class.
        /// </summary>
        /// <param name="syncToken">Enables real-time consistency between
        /// requests by providing the returned value in the next request made
        /// to the server.</param>
        /// <param name="eTag">An identifier representing the returned state of
        /// the resource.</param>
        /// <param name="lastModified">A UTC datetime that specifies the last
        /// time the resource was modified.</param>
        public CheckKeyValueHeaders(string syncToken = default(string), string eTag = default(string), string lastModified = default(string))
        {
            SyncToken = syncToken;
            ETag = eTag;
            LastModified = lastModified;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets enables real-time consistency between requests by
        /// providing the returned value in the next request made to the
        /// server.
        /// </summary>
        [JsonProperty(PropertyName = "Sync-Token")]
        public string SyncToken { get; set; }

        /// <summary>
        /// Gets or sets an identifier representing the returned state of the
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets a UTC datetime that specifies the last time the
        /// resource was modified.
        /// </summary>
        [JsonProperty(PropertyName = "Last-Modified")]
        public string LastModified { get; set; }

    }
}
