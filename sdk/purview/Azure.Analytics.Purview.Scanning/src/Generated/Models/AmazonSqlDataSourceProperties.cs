// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AmazonSqlDataSourceProperties. </summary>
    public partial class AmazonSqlDataSourceProperties : AmazonSqlProperties
    {
        /// <summary> Initializes a new instance of AmazonSqlDataSourceProperties. </summary>
        public AmazonSqlDataSourceProperties()
        {
        }

        /// <summary> Initializes a new instance of AmazonSqlDataSourceProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="collection"></param>
        /// <param name="serverEndpoint"></param>
        internal AmazonSqlDataSourceProperties(DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, DataSourcePropertiesCollection collection, string serverEndpoint) : base(createdAt, lastModifiedAt, collection, serverEndpoint)
        {
        }
    }
}
