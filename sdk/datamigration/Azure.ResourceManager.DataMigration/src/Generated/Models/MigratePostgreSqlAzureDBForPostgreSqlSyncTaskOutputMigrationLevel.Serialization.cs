// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel : IUtf8JsonSerializable, IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DatabaseCount))
            {
                writer.WritePropertyName("databaseCount"u8);
                writer.WriteNumberValue(DatabaseCount.Value);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServer = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServer = default;
            Optional<ScenarioSource> sourceServerType = default;
            Optional<ScenarioTarget> targetServerType = default;
            Optional<ReplicateMigrationState> state = default;
            Optional<float> databaseCount = default;
            Optional<string> id = default;
            string resultType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(id.Value, resultType, Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), sourceServerVersion.Value, sourceServer.Value, targetServerVersion.Value, targetServer.Value, Optional.ToNullable(sourceServerType), Optional.ToNullable(targetServerType), Optional.ToNullable(state), Optional.ToNullable(databaseCount), rawData);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel IModelJsonSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel IModelSerializable<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel"/> to convert. </param>
        public static implicit operator RequestContent(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
