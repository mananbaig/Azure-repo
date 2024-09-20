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
    public partial class SqlBackupSetInfo : IUtf8JsonSerializable, IJsonModel<SqlBackupSetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlBackupSetInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SqlBackupSetInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupSetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlBackupSetInfo)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(BackupSetId))
            {
                writer.WritePropertyName("backupSetId"u8);
                writer.WriteStringValue(BackupSetId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FirstLSN))
            {
                writer.WritePropertyName("firstLSN"u8);
                writer.WriteStringValue(FirstLSN);
            }
            if (options.Format != "W" && Optional.IsDefined(LastLSN))
            {
                writer.WritePropertyName("lastLSN"u8);
                writer.WriteStringValue(LastLSN);
            }
            if (options.Format != "W" && Optional.IsDefined(BackupType))
            {
                writer.WritePropertyName("backupType"u8);
                writer.WriteStringValue(BackupType);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ListOfBackupFiles))
            {
                writer.WritePropertyName("listOfBackupFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ListOfBackupFiles)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(BackupStartOn))
            {
                writer.WritePropertyName("backupStartDate"u8);
                writer.WriteStringValue(BackupStartOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(BackupFinishOn))
            {
                writer.WritePropertyName("backupFinishDate"u8);
                writer.WriteStringValue(BackupFinishOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(IsBackupRestored))
            {
                writer.WritePropertyName("isBackupRestored"u8);
                writer.WriteBooleanValue(IsBackupRestored.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(HasBackupChecksums))
            {
                writer.WritePropertyName("hasBackupChecksums"u8);
                writer.WriteBooleanValue(HasBackupChecksums.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(FamilyCount))
            {
                writer.WritePropertyName("familyCount"u8);
                writer.WriteNumberValue(FamilyCount.Value);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(IgnoreReasons))
            {
                writer.WritePropertyName("ignoreReasons"u8);
                writer.WriteStartArray();
                foreach (var item in IgnoreReasons)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
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

        SqlBackupSetInfo IJsonModel<SqlBackupSetInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupSetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SqlBackupSetInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlBackupSetInfo(document.RootElement, options);
        }

        internal static SqlBackupSetInfo DeserializeSqlBackupSetInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? backupSetId = default;
            string firstLSN = default;
            string lastLSN = default;
            string backupType = default;
            IReadOnlyList<SqlBackupFileInfo> listOfBackupFiles = default;
            DateTimeOffset? backupStartDate = default;
            DateTimeOffset? backupFinishDate = default;
            bool? isBackupRestored = default;
            bool? hasBackupChecksums = default;
            int? familyCount = default;
            IReadOnlyList<string> ignoreReasons = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupSetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupSetId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("firstLSN"u8))
                {
                    firstLSN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastLSN"u8))
                {
                    lastLSN = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupType"u8))
                {
                    backupType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("listOfBackupFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlBackupFileInfo> array = new List<SqlBackupFileInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlBackupFileInfo.DeserializeSqlBackupFileInfo(item, options));
                    }
                    listOfBackupFiles = array;
                    continue;
                }
                if (property.NameEquals("backupStartDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupStartDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("backupFinishDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFinishDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("isBackupRestored"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isBackupRestored = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hasBackupChecksums"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasBackupChecksums = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("familyCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ignoreReasons"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ignoreReasons = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SqlBackupSetInfo(
                backupSetId,
                firstLSN,
                lastLSN,
                backupType,
                listOfBackupFiles ?? new ChangeTrackingList<SqlBackupFileInfo>(),
                backupStartDate,
                backupFinishDate,
                isBackupRestored,
                hasBackupChecksums,
                familyCount,
                ignoreReasons ?? new ChangeTrackingList<string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlBackupSetInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupSetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SqlBackupSetInfo)} does not support writing '{options.Format}' format.");
            }
        }

        SqlBackupSetInfo IPersistableModel<SqlBackupSetInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlBackupSetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlBackupSetInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SqlBackupSetInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlBackupSetInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
