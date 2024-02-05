// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtProtectionContainerMappingDetails : IUtf8JsonSerializable, IJsonModel<VMwareCbtProtectionContainerMappingDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtProtectionContainerMappingDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtProtectionContainerMappingDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(KeyVaultId))
            {
                writer.WritePropertyName("keyVaultId"u8);
                writer.WriteStringValue(KeyVaultId);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultUri))
            {
                writer.WritePropertyName("keyVaultUri"u8);
                writer.WriteStringValue(KeyVaultUri.AbsoluteUri);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (options.Format != "W" && Optional.IsDefined(StorageAccountSasSecretName))
            {
                writer.WritePropertyName("storageAccountSasSecretName"u8);
                writer.WriteStringValue(StorageAccountSasSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(ServiceBusConnectionStringSecretName))
            {
                writer.WritePropertyName("serviceBusConnectionStringSecretName"u8);
                writer.WriteStringValue(ServiceBusConnectionStringSecretName);
            }
            if (options.Format != "W" && Optional.IsDefined(TargetLocation))
            {
                writer.WritePropertyName("targetLocation"u8);
                writer.WriteStringValue(TargetLocation);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(RoleSizeToNicCountMap))
            {
                writer.WritePropertyName("roleSizeToNicCountMap"u8);
                writer.WriteStartObject();
                foreach (var item in RoleSizeToNicCountMap)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(ExcludedSkus))
            {
                writer.WritePropertyName("excludedSkus"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludedSkus)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareCbtProtectionContainerMappingDetails IJsonModel<VMwareCbtProtectionContainerMappingDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtProtectionContainerMappingDetails(document.RootElement, options);
        }

        internal static VMwareCbtProtectionContainerMappingDetails DeserializeVMwareCbtProtectionContainerMappingDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> keyVaultId = default;
            Optional<Uri> keyVaultUri = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<string> storageAccountSasSecretName = default;
            Optional<string> serviceBusConnectionStringSecretName = default;
            Optional<string> targetLocation = default;
            Optional<IReadOnlyDictionary<string, int>> roleSizeToNicCountMap = default;
            Optional<IReadOnlyList<string>> excludedSkus = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountSasSecretName"u8))
                {
                    storageAccountSasSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serviceBusConnectionStringSecretName"u8))
                {
                    serviceBusConnectionStringSecretName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roleSizeToNicCountMap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    roleSizeToNicCountMap = dictionary;
                    continue;
                }
                if (property.NameEquals("excludedSkus"u8))
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
                    excludedSkus = array;
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtProtectionContainerMappingDetails(instanceType, serializedAdditionalRawData, keyVaultId.Value, keyVaultUri.Value, storageAccountId.Value, storageAccountSasSecretName.Value, serviceBusConnectionStringSecretName.Value, targetLocation.Value, Optional.ToDictionary(roleSizeToNicCountMap), Optional.ToList(excludedSkus));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(KeyVaultId))
            {
                builder.Append("  keyVaultId:");
                builder.AppendLine($" '{KeyVaultId.ToString()}'");
            }

            if (Optional.IsDefined(KeyVaultUri))
            {
                builder.Append("  keyVaultUri:");
                builder.AppendLine($" '{KeyVaultUri.AbsoluteUri}'");
            }

            if (Optional.IsDefined(StorageAccountId))
            {
                builder.Append("  storageAccountId:");
                builder.AppendLine($" '{StorageAccountId.ToString()}'");
            }

            if (Optional.IsDefined(StorageAccountSasSecretName))
            {
                builder.Append("  storageAccountSasSecretName:");
                builder.AppendLine($" '{StorageAccountSasSecretName}'");
            }

            if (Optional.IsDefined(ServiceBusConnectionStringSecretName))
            {
                builder.Append("  serviceBusConnectionStringSecretName:");
                builder.AppendLine($" '{ServiceBusConnectionStringSecretName}'");
            }

            if (Optional.IsDefined(TargetLocation))
            {
                builder.Append("  targetLocation:");
                builder.AppendLine($" '{TargetLocation}'");
            }

            if (Optional.IsCollectionDefined(RoleSizeToNicCountMap))
            {
                if (RoleSizeToNicCountMap.Any())
                {
                    builder.Append("  roleSizeToNicCountMap:");
                    builder.AppendLine(" {");
                    foreach (var item in RoleSizeToNicCountMap)
                    {
                        builder.Append($"    {item.Key}: ");
                        builder.AppendLine($" {item.Value}");
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsCollectionDefined(ExcludedSkus))
            {
                if (ExcludedSkus.Any())
                {
                    builder.Append("  excludedSkus:");
                    builder.AppendLine(" [");
                    foreach (var item in ExcludedSkus)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"    '{item}'");
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(InstanceType))
            {
                builder.Append("  instanceType:");
                builder.AppendLine($" '{InstanceType}'");
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

        BinaryData IPersistableModel<VMwareCbtProtectionContainerMappingDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support '{options.Format}' format.");
            }
        }

        VMwareCbtProtectionContainerMappingDetails IPersistableModel<VMwareCbtProtectionContainerMappingDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareCbtProtectionContainerMappingDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareCbtProtectionContainerMappingDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VMwareCbtProtectionContainerMappingDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareCbtProtectionContainerMappingDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
