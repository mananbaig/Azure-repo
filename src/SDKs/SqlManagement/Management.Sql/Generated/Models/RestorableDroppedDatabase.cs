// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Sql;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A restorable dropped database
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RestorableDroppedDatabase : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RestorableDroppedDatabase class.
        /// </summary>
        public RestorableDroppedDatabase()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RestorableDroppedDatabase class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="databaseName">The name of the database</param>
        /// <param name="edition">The edition of the database</param>
        /// <param name="maxSizeBytes">The max size in bytes of the
        /// database</param>
        /// <param name="serviceLevelObjective">The service level objective
        /// name of the database</param>
        /// <param name="elasticPoolName">The elastic pool name of the
        /// database</param>
        /// <param name="creationDate">The creation date of the database
        /// (ISO8601 format)</param>
        /// <param name="deletionDate">The deletion date of the database
        /// (ISO8601 format)</param>
        /// <param name="earliestRestoreDate">The earliest restore date of the
        /// database (ISO8601 format)</param>
        public RestorableDroppedDatabase(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string databaseName = default(string), string edition = default(string), long? maxSizeBytes = default(long?), string serviceLevelObjective = default(string), string elasticPoolName = default(string), System.DateTime? creationDate = default(System.DateTime?), System.DateTime? deletionDate = default(System.DateTime?), System.DateTime? earliestRestoreDate = default(System.DateTime?))
            : base(id, name, type)
        {
            Location = location;
            DatabaseName = databaseName;
            Edition = edition;
            MaxSizeBytes = maxSizeBytes;
            ServiceLevelObjective = serviceLevelObjective;
            ElasticPoolName = elasticPoolName;
            CreationDate = creationDate;
            DeletionDate = deletionDate;
            EarliestRestoreDate = earliestRestoreDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the geo-location where the resource lives
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets the name of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; private set; }

        /// <summary>
        /// Gets the edition of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.edition")]
        public string Edition { get; private set; }

        /// <summary>
        /// Gets the max size in bytes of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.maxSizeBytes")]
        public long? MaxSizeBytes { get; private set; }

        /// <summary>
        /// Gets the service level objective name of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLevelObjective")]
        public string ServiceLevelObjective { get; private set; }

        /// <summary>
        /// Gets the elastic pool name of the database
        /// </summary>
        [JsonProperty(PropertyName = "properties.elasticPoolName")]
        public string ElasticPoolName { get; private set; }

        /// <summary>
        /// Gets the creation date of the database (ISO8601 format)
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets the deletion date of the database (ISO8601 format)
        /// </summary>
        [JsonProperty(PropertyName = "properties.deletionDate")]
        public System.DateTime? DeletionDate { get; private set; }

        /// <summary>
        /// Gets the earliest restore date of the database (ISO8601 format)
        /// </summary>
        [JsonProperty(PropertyName = "properties.earliestRestoreDate")]
        public System.DateTime? EarliestRestoreDate { get; private set; }

    }
}
