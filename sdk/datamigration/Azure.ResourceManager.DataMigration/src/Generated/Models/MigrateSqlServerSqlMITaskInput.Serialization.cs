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
    public partial class MigrateSqlServerSqlMITaskInput : IUtf8JsonSerializable, IJsonModel<MigrateSqlServerSqlMITaskInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateSqlServerSqlMITaskInput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateSqlServerSqlMITaskInput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMITaskInput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("selectedDatabases"u8);
            writer.WriteStartArray();
            foreach (var item in SelectedDatabases)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(StartedOn))
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn);
            }
            if (Optional.IsCollectionDefined(SelectedLogins))
            {
                writer.WritePropertyName("selectedLogins"u8);
                writer.WriteStartArray();
                foreach (var item in SelectedLogins)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SelectedAgentJobs))
            {
                writer.WritePropertyName("selectedAgentJobs"u8);
                writer.WriteStartArray();
                foreach (var item in SelectedAgentJobs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BackupFileShare))
            {
                writer.WritePropertyName("backupFileShare"u8);
                writer.WriteObjectValue(BackupFileShare);
            }
            writer.WritePropertyName("backupBlobShare"u8);
            writer.WriteObjectValue(BackupBlobShare);
            if (Optional.IsDefined(BackupMode))
            {
                writer.WritePropertyName("backupMode"u8);
                writer.WriteStringValue(BackupMode.Value.ToString());
            }
            if (Optional.IsDefined(AadDomainName))
            {
                writer.WritePropertyName("aadDomainName"u8);
                writer.WriteStringValue(AadDomainName);
            }
            if (Optional.IsDefined(EncryptedKeyForSecureFields))
            {
                writer.WritePropertyName("encryptedKeyForSecureFields"u8);
                writer.WriteStringValue(EncryptedKeyForSecureFields);
            }
            writer.WritePropertyName("sourceConnectionInfo"u8);
            writer.WriteObjectValue(SourceConnectionInfo);
            writer.WritePropertyName("targetConnectionInfo"u8);
            writer.WriteObjectValue(TargetConnectionInfo);
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

        MigrateSqlServerSqlMITaskInput IJsonModel<MigrateSqlServerSqlMITaskInput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMITaskInput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateSqlServerSqlMITaskInput(document.RootElement, options);
        }

        internal static MigrateSqlServerSqlMITaskInput DeserializeMigrateSqlServerSqlMITaskInput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MigrateSqlServerSqlMIDatabaseInput> selectedDatabases = default;
            Optional<string> startedOn = default;
            Optional<IList<string>> selectedLogins = default;
            Optional<IList<string>> selectedAgentJobs = default;
            Optional<FileShare> backupFileShare = default;
            BlobShare backupBlobShare = default;
            Optional<BackupMode> backupMode = default;
            Optional<string> aadDomainName = default;
            Optional<string> encryptedKeyForSecureFields = default;
            SqlConnectionInfo sourceConnectionInfo = default;
            SqlConnectionInfo targetConnectionInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("selectedDatabases"u8))
                {
                    List<MigrateSqlServerSqlMIDatabaseInput> array = new List<MigrateSqlServerSqlMIDatabaseInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MigrateSqlServerSqlMIDatabaseInput.DeserializeMigrateSqlServerSqlMIDatabaseInput(item));
                    }
                    selectedDatabases = array;
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    startedOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("selectedLogins"u8))
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
                    selectedLogins = array;
                    continue;
                }
                if (property.NameEquals("selectedAgentJobs"u8))
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
                    selectedAgentJobs = array;
                    continue;
                }
                if (property.NameEquals("backupFileShare"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFileShare = FileShare.DeserializeFileShare(property.Value);
                    continue;
                }
                if (property.NameEquals("backupBlobShare"u8))
                {
                    backupBlobShare = BlobShare.DeserializeBlobShare(property.Value);
                    continue;
                }
                if (property.NameEquals("backupMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupMode = new BackupMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("aadDomainName"u8))
                {
                    aadDomainName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptedKeyForSecureFields"u8))
                {
                    encryptedKeyForSecureFields = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceConnectionInfo"u8))
                {
                    sourceConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("targetConnectionInfo"u8))
                {
                    targetConnectionInfo = SqlConnectionInfo.DeserializeSqlConnectionInfo(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateSqlServerSqlMITaskInput(sourceConnectionInfo, targetConnectionInfo, serializedAdditionalRawData, selectedDatabases, startedOn.Value, Optional.ToList(selectedLogins), Optional.ToList(selectedAgentJobs), backupFileShare.Value, backupBlobShare, Optional.ToNullable(backupMode), aadDomainName.Value, encryptedKeyForSecureFields.Value);
        }

        BinaryData IPersistableModel<MigrateSqlServerSqlMITaskInput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMITaskInput)} does not support '{options.Format}' format.");
            }
        }

        MigrateSqlServerSqlMITaskInput IPersistableModel<MigrateSqlServerSqlMITaskInput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateSqlServerSqlMITaskInput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateSqlServerSqlMITaskInput(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MigrateSqlServerSqlMITaskInput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateSqlServerSqlMITaskInput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
