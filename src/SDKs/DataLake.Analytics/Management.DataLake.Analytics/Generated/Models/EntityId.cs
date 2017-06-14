// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics catalog entity identifier object.
    /// </summary>
    public partial class EntityId
    {
        /// <summary>
        /// Initializes a new instance of the EntityId class.
        /// </summary>
        public EntityId()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityId class.
        /// </summary>
        /// <param name="name">the name of the external table associated with
        /// this database, schema and table.</param>
        /// <param name="version">the version of the external data
        /// source.</param>
        public EntityId(DdlName name = default(DdlName), System.Guid? version = default(System.Guid?))
        {
            Name = name;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the external table associated with this
        /// database, schema and table.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public DdlName Name { get; set; }

        /// <summary>
        /// Gets or sets the version of the external data source.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public System.Guid? Version { get; set; }

    }
}
