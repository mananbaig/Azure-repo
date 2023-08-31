// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Describes a field reference within a MongoDB shard key. </summary>
    public partial class MongoDBShardKeyField
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeyField"/>. </summary>
        /// <param name="name"> The name of the field. </param>
        /// <param name="order"> The field ordering. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MongoDBShardKeyField(string name, MongoDBShardKeyOrder order)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Order = order;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeyField"/>. </summary>
        /// <param name="name"> The name of the field. </param>
        /// <param name="order"> The field ordering. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MongoDBShardKeyField(string name, MongoDBShardKeyOrder order, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Order = order;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="MongoDBShardKeyField"/> for deserialization. </summary>
        internal MongoDBShardKeyField()
        {
        }

        /// <summary> The name of the field. </summary>
        public string Name { get; set; }
        /// <summary> The field ordering. </summary>
        public MongoDBShardKeyOrder Order { get; set; }
    }
}
