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
    /// A copy activity source for a MongoDB database.
    /// </summary>
    public partial class MongoDbV2Source : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the MongoDbV2Source class.
        /// </summary>
        public MongoDbV2Source()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MongoDbV2Source class.
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
        /// <param name="filter">Specifies selection filter using query
        /// operators. To return all documents in a collection, omit this
        /// parameter or pass an empty document ({}). Type: string (or
        /// Expression with resultType string).</param>
        /// <param name="cursorMethods">Cursor methods for Mongodb
        /// query</param>
        /// <param name="batchSize">Specifies the number of documents to return
        /// in each batch of the response from MongoDB instance. In most cases,
        /// modifying the batch size will not affect the user or the
        /// application. This property�s main purpose is to avoid hit the
        /// limitation of response size. Type: integer (or Expression with
        /// resultType integer).</param>
        public MongoDbV2Source(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object filter = default(object), MongoDbCursorMethodsProperties cursorMethods = default(MongoDbCursorMethodsProperties), object batchSize = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            Filter = filter;
            CursorMethods = cursorMethods;
            BatchSize = batchSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies selection filter using query operators. To
        /// return all documents in a collection, omit this parameter or pass
        /// an empty document ({}). Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "filter")]
        public object Filter { get; set; }

        /// <summary>
        /// Gets or sets cursor methods for Mongodb query
        /// </summary>
        [JsonProperty(PropertyName = "cursorMethods")]
        public MongoDbCursorMethodsProperties CursorMethods { get; set; }

        /// <summary>
        /// Gets or sets specifies the number of documents to return in each
        /// batch of the response from MongoDB instance. In most cases,
        /// modifying the batch size will not affect the user or the
        /// application. This property�s main purpose is to avoid hit the
        /// limitation of response size. Type: integer (or Expression with
        /// resultType integer).
        /// </summary>
        [JsonProperty(PropertyName = "batchSize")]
        public object BatchSize { get; set; }

    }
}
