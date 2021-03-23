// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Cosmos DB Cassandra keyspace resource object. </summary>
    public partial class CassandraKeyspaceResource
    {
        /// <summary> Initializes a new instance of CassandraKeyspaceResource. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra keyspace. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public CassandraKeyspaceResource(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Name of the Cosmos DB Cassandra keyspace. </summary>
        public string Id { get; set; }
    }
}
