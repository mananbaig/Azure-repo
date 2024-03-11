// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel. </summary>
    public partial class MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel : MigrateMySqlAzureDBForMySqlSyncTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel"/>. </summary>
        internal MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel()
        {
            ResultType = "MigrationLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServer"> Source server name. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServer"> Target server name. </param>
        internal MigrateMySqlAzureDBForMySqlSyncTaskOutputMigrationLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? startedOn, DateTimeOffset? endedOn, string sourceServerVersion, string sourceServer, string targetServerVersion, string targetServer) : base(id, resultType, serializedAdditionalRawData)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            SourceServerVersion = sourceServerVersion;
            SourceServer = sourceServer;
            TargetServerVersion = targetServerVersion;
            TargetServer = targetServer;
            ResultType = resultType ?? "MigrationLevelOutput";
        }

        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server name. </summary>
        public string SourceServer { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server name. </summary>
        public string TargetServer { get; }
    }
}
