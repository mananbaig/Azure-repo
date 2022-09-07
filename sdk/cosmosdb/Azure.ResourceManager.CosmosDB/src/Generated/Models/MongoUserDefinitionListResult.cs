// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The relevant User Definition. </summary>
    internal partial class MongoUserDefinitionListResult
    {
        /// <summary> Initializes a new instance of MongoUserDefinitionListResult. </summary>
        internal MongoUserDefinitionListResult()
        {
            Value = new ChangeTrackingList<MongoUserDefinitionGetResultData>();
        }

        /// <summary> Initializes a new instance of MongoUserDefinitionListResult. </summary>
        /// <param name="value"> List of User Definition and their properties. </param>
        internal MongoUserDefinitionListResult(IReadOnlyList<MongoUserDefinitionGetResultData> value)
        {
            Value = value;
        }

        /// <summary> List of User Definition and their properties. </summary>
        public IReadOnlyList<MongoUserDefinitionGetResultData> Value { get; }
    }
}
