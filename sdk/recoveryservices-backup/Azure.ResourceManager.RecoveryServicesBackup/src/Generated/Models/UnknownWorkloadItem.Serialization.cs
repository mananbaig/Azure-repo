// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    internal partial class UnknownWorkloadItem : IUtf8JsonSerializable, IJsonModel<WorkloadItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WorkloadItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WorkloadItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("workloadItemType"u8);
            writer.WriteStringValue(WorkloadItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        WorkloadItem IJsonModel<WorkloadItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownWorkloadItem(document.RootElement, options);
        }

        internal static UnknownWorkloadItem DeserializeUnknownWorkloadItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string workloadItemType = "Unknown";
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadItemType"u8))
                {
                    workloadItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownWorkloadItem(backupManagementType.Value, workloadType.Value, workloadItemType, friendlyName.Value, Optional.ToNullable(protectionState), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                builder.AppendLine($" '{BackupManagementType}'");
            }

            if (Optional.IsDefined(WorkloadType))
            {
                builder.Append("  workloadType:");
                builder.AppendLine($" '{WorkloadType}'");
            }

            if (Optional.IsDefined(WorkloadItemType))
            {
                builder.Append("  workloadItemType:");
                builder.AppendLine($" '{WorkloadItemType}'");
            }

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("  friendlyName:");
                builder.AppendLine($" '{FriendlyName}'");
            }

            if (Optional.IsDefined(ProtectionState))
            {
                builder.Append("  protectionState:");
                builder.AppendLine($" '{ProtectionState.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        private void AppendChildObject(StringBuilder stringBuilder, object childObject, ModelReaderWriterOptions options, int spaces, bool indentFirstLine)
        {
            string indent = new string(' ', spaces);
            BinaryData data = ModelReaderWriter.Write(childObject, options);
            string[] lines = data.ToString().Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (i == 0 && !indentFirstLine)
                {
                    stringBuilder.AppendLine($" {line}");
                }
                else
                {
                    stringBuilder.AppendLine($"{indent}{line}");
                }
            }
        }

        BinaryData IPersistableModel<WorkloadItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{options.Format}' format.");
            }
        }

        WorkloadItem IPersistableModel<WorkloadItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<WorkloadItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownWorkloadItem(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(WorkloadItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<WorkloadItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
