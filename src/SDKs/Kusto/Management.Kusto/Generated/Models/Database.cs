// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Kusto.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class representing a Kusto database.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Database : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        public Database()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Database class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="softDeletePeriodInDays">The number of days data should
        /// be kept before it stops being accessible to queries.</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="etag">An ETag of the resource created.</param>
        /// <param name="provisioningState">The provisioned state of the
        /// resource. Possible values include: 'Running', 'Creating',
        /// 'Deleting', 'Succeeded', 'Failed'</param>
        /// <param name="hotCachePeriodInDays">The number of days of data that
        /// should be kept in cache for fast queries.</param>
        /// <param name="statistics">The statistics of the database.</param>
        public Database(string location, int softDeletePeriodInDays, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string provisioningState = default(string), int? hotCachePeriodInDays = default(int?), DatabaseStatistics statistics = default(DatabaseStatistics))
            : base(location, id, name, type, tags)
        {
            Etag = etag;
            ProvisioningState = provisioningState;
            SoftDeletePeriodInDays = softDeletePeriodInDays;
            HotCachePeriodInDays = hotCachePeriodInDays;
            Statistics = statistics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets an ETag of the resource created.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Gets the provisioned state of the resource. Possible values
        /// include: 'Running', 'Creating', 'Deleting', 'Succeeded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the number of days data should be kept before it stops
        /// being accessible to queries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.softDeletePeriodInDays")]
        public int SoftDeletePeriodInDays { get; set; }

        /// <summary>
        /// Gets or sets the number of days of data that should be kept in
        /// cache for fast queries.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hotCachePeriodInDays")]
        public int? HotCachePeriodInDays { get; set; }

        /// <summary>
        /// Gets or sets the statistics of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.statistics")]
        public DatabaseStatistics Statistics { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
