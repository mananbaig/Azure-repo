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
    /// A copy activity Azure CosmosDB (SQL API) Collection source.
    /// </summary>
    [Newtonsoft.Json.JsonObject("CosmosDbSqlApiSource")]
    public partial class CosmosDbSqlApiSource : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the CosmosDbSqlApiSource class.
        /// </summary>
        public CosmosDbSqlApiSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CosmosDbSqlApiSource class.
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
        /// <param name="query">SQL API query. Type: string (or Expression with
        /// resultType string).</param>
        /// <param name="pageSize">Page size of the result. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="preferredRegions">Preferred regions. Type: array of
        /// strings (or Expression with resultType array of strings).</param>
        /// <param name="additionalColumns">Specifies the additional columns to
        /// be added to source data. Type: array of objects (or Expression with
        /// resultType array of objects).</param>
        public CosmosDbSqlApiSource(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object query = default(object), object pageSize = default(object), object preferredRegions = default(object), IList<AdditionalColumns> additionalColumns = default(IList<AdditionalColumns>))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            Query = query;
            PageSize = pageSize;
            PreferredRegions = preferredRegions;
            AdditionalColumns = additionalColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets SQL API query. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "query")]
        public object Query { get; set; }

        /// <summary>
        /// Gets or sets page size of the result. Type: integer (or Expression
        /// with resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "pageSize")]
        public object PageSize { get; set; }

        /// <summary>
        /// Gets or sets preferred regions. Type: array of strings (or
        /// Expression with resultType array of strings).
        /// </summary>
        [JsonProperty(PropertyName = "preferredRegions")]
        public object PreferredRegions { get; set; }

        /// <summary>
        /// Gets or sets specifies the additional columns to be added to source
        /// data. Type: array of objects (or Expression with resultType array
        /// of objects).
        /// </summary>
        [JsonProperty(PropertyName = "additionalColumns")]
        public IList<AdditionalColumns> AdditionalColumns { get; set; }

    }
}
