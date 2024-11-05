// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(SourceDatabaseName))
            {
                writer.WritePropertyName("sourceDatabaseName"u8);
                writer.WriteStringValue(SourceDatabaseName);
            }
            if (options.Format != "W" && Optional.IsDefined(MigrationState))
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteStringValue(MigrationState.Value.ToString());
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
            if (options.Format != "W" && Optional.IsDefined(FullBackupSetInfo))
            {
                writer.WritePropertyName("fullBackupSetInfo"u8);
                writer.WriteObjectValue(FullBackupSetInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(LastRestoredBackupSetInfo))
            {
                writer.WritePropertyName("lastRestoredBackupSetInfo"u8);
                writer.WriteObjectValue(LastRestoredBackupSetInfo, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ActiveBackupSets))
            {
                writer.WritePropertyName("activeBackupSets"u8);
                writer.WriteStartArray();
                foreach (var item in ActiveBackupSets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (options.Format != "W" && Optional.IsDefined(ErrorPrefix))
            {
                writer.WritePropertyName("errorPrefix"u8);
                writer.WriteStringValue(ErrorPrefix);
            }
            if (options.Format != "W" && Optional.IsDefined(IsFullBackupRestored))
            {
                writer.WritePropertyName("isFullBackupRestored"u8);
                writer.WriteBooleanValue(IsFullBackupRestored.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ExceptionsAndWarnings))
            {
                writer.WritePropertyName("exceptionsAndWarnings"u8);
                writer.WriteStartArray();
                foreach (var item in ExceptionsAndWarnings)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel IJsonModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel DeserializeMigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string sourceDatabaseName = default;
            DatabaseMigrationState? migrationState = default;
            DateTimeOffset? startedOn = default;
            DateTimeOffset? endedOn = default;
            BackupSetInfo fullBackupSetInfo = default;
            BackupSetInfo lastRestoredBackupSetInfo = default;
            IReadOnlyList<BackupSetInfo> activeBackupSets = default;
            string containerName = default;
            string errorPrefix = default;
            bool? isFullBackupRestored = default;
            IReadOnlyList<ReportableException> exceptionsAndWarnings = default;
            string id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceDatabaseName"u8))
                {
                    sourceDatabaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = new DatabaseMigrationState(property.Value.GetString());
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
                if (property.NameEquals("fullBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullBackupSetInfo = BackupSetInfo.DeserializeBackupSetInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("lastRestoredBackupSetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastRestoredBackupSetInfo = BackupSetInfo.DeserializeBackupSetInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("activeBackupSets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BackupSetInfo> array = new List<BackupSetInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BackupSetInfo.DeserializeBackupSetInfo(item, options));
                    }
                    activeBackupSets = array;
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorPrefix"u8))
                {
                    errorPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isFullBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isFullBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("exceptionsAndWarnings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReportableException> array = new List<ReportableException>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReportableException.DeserializeReportableException(item, options));
                    }
                    exceptionsAndWarnings = array;
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
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(
                id,
                resultType,
                serializedAdditionalRawData,
                sourceDatabaseName,
                migrationState,
                startedOn,
                endedOn,
                fullBackupSetInfo,
                lastRestoredBackupSetInfo,
                activeBackupSets ?? new ChangeTrackingList<BackupSetInfo>(),
                containerName,
                errorPrefix,
                isFullBackupRestored,
                exceptionsAndWarnings ?? new ChangeTrackingList<ReportableException>());
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel)} does not support writing '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlMISyncTaskOutputDatabaseLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlMISyncTaskOutputDatabaseLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
