// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownProtectionIntent))]
    public partial class BackupGenericProtectionIntent : IUtf8JsonSerializable, IJsonModel<BackupGenericProtectionIntent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupGenericProtectionIntent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupGenericProtectionIntent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("protectionIntentItemType"u8);
            writer.WriteStringValue(ProtectionIntentItemType.ToString());
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(ItemId))
            {
                writer.WritePropertyName("itemId"u8);
                writer.WriteStringValue(ItemId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
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

        BackupGenericProtectionIntent IJsonModel<BackupGenericProtectionIntent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericProtectionIntent(document.RootElement, options);
        }

        internal static BackupGenericProtectionIntent DeserializeBackupGenericProtectionIntent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("protectionIntentItemType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureResourceItem": return ResourceProtectionIntent.DeserializeResourceProtectionIntent(element);
                    case "AzureWorkloadAutoProtectionIntent": return WorkloadAutoProtectionIntent.DeserializeWorkloadAutoProtectionIntent(element);
                    case "AzureWorkloadContainerAutoProtectionIntent": return WorkloadContainerAutoProtectionIntent.DeserializeWorkloadContainerAutoProtectionIntent(element);
                    case "AzureWorkloadSQLAutoProtectionIntent": return WorkloadSqlAutoProtectionIntent.DeserializeWorkloadSqlAutoProtectionIntent(element);
                    case "RecoveryServiceVaultItem": return RecoveryServiceVaultProtectionIntent.DeserializeRecoveryServiceVaultProtectionIntent(element);
                }
            }
            return UnknownProtectionIntent.DeserializeUnknownProtectionIntent(element);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ProtectionIntentItemType))
            {
                builder.Append("  protectionIntentItemType:");
                builder.AppendLine($" '{ProtectionIntentItemType.ToString()}'");
            }

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                builder.AppendLine($" '{BackupManagementType.ToString()}'");
            }

            if (Optional.IsDefined(SourceResourceId))
            {
                builder.Append("  sourceResourceId:");
                builder.AppendLine($" '{SourceResourceId.ToString()}'");
            }

            if (Optional.IsDefined(ItemId))
            {
                builder.Append("  itemId:");
                builder.AppendLine($" '{ItemId.ToString()}'");
            }

            if (Optional.IsDefined(PolicyId))
            {
                builder.Append("  policyId:");
                builder.AppendLine($" '{PolicyId.ToString()}'");
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

        BinaryData IPersistableModel<BackupGenericProtectionIntent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{options.Format}' format.");
            }
        }

        BackupGenericProtectionIntent IPersistableModel<BackupGenericProtectionIntent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupGenericProtectionIntent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupGenericProtectionIntent(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(BackupGenericProtectionIntent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupGenericProtectionIntent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
