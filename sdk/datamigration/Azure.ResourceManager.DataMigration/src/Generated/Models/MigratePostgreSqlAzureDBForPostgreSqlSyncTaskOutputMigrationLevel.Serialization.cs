// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel
    {
        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DateTimeOffset> startedOn = default;
            Core.Optional<DateTimeOffset> endedOn = default;
            Core.Optional<string> sourceServerVersion = default;
            Core.Optional<string> sourceServer = default;
            Core.Optional<string> targetServerVersion = default;
            Core.Optional<string> targetServer = default;
            Core.Optional<ScenarioSource> sourceServerType = default;
            Core.Optional<ScenarioTarget> targetServerType = default;
            Core.Optional<ReplicateMigrationState> state = default;
            Core.Optional<float> databaseCount = default;
            Core.Optional<string> id = default;
            string resultType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServer"u8))
                {
                    sourceServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServer"u8))
                {
                    targetServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceServerType = new ScenarioSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetServerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetServerType = new ScenarioTarget(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ReplicateMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
            }
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(id.Value, resultType, Core.Optional.ToNullable(startedOn), Core.Optional.ToNullable(endedOn), sourceServerVersion.Value, sourceServer.Value, targetServerVersion.Value, targetServer.Value, Core.Optional.ToNullable(sourceServerType), Core.Optional.ToNullable(targetServerType), Core.Optional.ToNullable(state), Core.Optional.ToNullable(databaseCount));
        }
    }
}
