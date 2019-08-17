// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Returns the requested multi-arch-manifest file
    /// </summary>
    public partial class SuperManifest
    {
        /// <summary>
        /// Initializes a new instance of the SuperManifest class.
        /// </summary>
        public SuperManifest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SuperManifest class.
        /// </summary>
        /// <param name="schemaVersion">Schema version</param>
        public SuperManifest(int? schemaVersion = default(int?))
        {
            SchemaVersion = schemaVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets schema version
        /// </summary>
        [JsonProperty(PropertyName = "schemaVersion")]
        public int? SchemaVersion { get; set; }

    }
}
