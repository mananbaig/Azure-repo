// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlMISyncTaskOutputMigrationLevel : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DatabaseCount))
            {
                writer.WritePropertyName("databaseCount"u8);
                writer.WriteNumberValue(DatabaseCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(EndedOn))
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerName))
            {
                writer.WritePropertyName("sourceServerName"u8);
                writer.WriteStringValue(SourceServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerVersion))
            {
                writer.WritePropertyName("sourceServerVersion"u8);
                writer.WriteStringValue(SourceServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(SourceServerBrandVersion))
            {
                writer.WritePropertyName("sourceServerBrandVersion"u8);
                writer.WriteStringValue(SourceServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerName))
            {
                writer.WritePropertyName("targetServerName"u8);
                writer.WriteStringValue(TargetServerName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerVersion))
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetServerBrandVersion))
            {
                writer.WritePropertyName("targetServerBrandVersion"u8);
                writer.WriteStringValue(TargetServerBrandVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(DatabaseErrorCount))
            {
                writer.WritePropertyName("databaseErrorCount"u8);
                writer.WriteNumberValue(DatabaseErrorCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        MigrateSqlServerSqlMISyncTaskOutputMigrationLevel IJsonModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlMISyncTaskOutputMigrationLevel DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> databaseCount = default;
            Optional<MigrationState> state = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<string> sourceServerName = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServerBrandVersion = default;
            Optional<string> targetServerName = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServerBrandVersion = default;
            Optional<int> databaseErrorCount = default;
            Optional<string> id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new MigrationState(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("sourceServerName"u8))
                {
                    sourceServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerBrandVersion"u8))
                {
                    sourceServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerName"u8))
                {
                    targetServerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerBrandVersion"u8))
                {
                    targetServerBrandVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseErrorCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseErrorCount = property.Value.GetInt32();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlMISyncTaskOutputMigrationLevel(id.Value, resultType, serializedAdditionalRawData, Optional.ToNullable(databaseCount), Optional.ToNullable(state), Optional.ToNullable(startedOn), Optional.ToNullable(endedOn), sourceServerName.Value, sourceServerVersion.Value, sourceServerBrandVersion.Value, targetServerName.Value, targetServerVersion.Value, targetServerBrandVersion.Value, Optional.ToNullable(databaseErrorCount));
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlMISyncTaskOutputMigrationLevel IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlMISyncTaskOutputMigrationLevel(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputMigrationLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
