// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Unknown version of MigratePostgreSqlAzureDbForPostgreSqlSyncTaskOutput. </summary>
    internal partial class UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput : MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, resultType, serializedAdditionalRawData)
        {
            ResultType = resultType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput"/> for deserialization. </summary>
        internal UnknownMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutput()
        {
        }
    }
}
