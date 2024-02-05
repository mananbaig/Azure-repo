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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class IaasVmRecoveryPoint : IUtf8JsonSerializable, IJsonModel<IaasVmRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IaasVmRecoveryPoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<IaasVmRecoveryPoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmRecoveryPoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointType))
            {
                writer.WritePropertyName("recoveryPointType"u8);
                writer.WriteStringValue(RecoveryPointType);
            }
            if (Optional.IsDefined(RecoveryPointOn))
            {
                writer.WritePropertyName("recoveryPointTime"u8);
                writer.WriteStringValue(RecoveryPointOn.Value, "O");
            }
            if (Optional.IsDefined(RecoveryPointAdditionalInfo))
            {
                writer.WritePropertyName("recoveryPointAdditionalInfo"u8);
                writer.WriteStringValue(RecoveryPointAdditionalInfo);
            }
            if (Optional.IsDefined(SourceVmStorageType))
            {
                writer.WritePropertyName("sourceVMStorageType"u8);
                writer.WriteStringValue(SourceVmStorageType);
            }
            if (Optional.IsDefined(IsSourceVmEncrypted))
            {
                writer.WritePropertyName("isSourceVMEncrypted"u8);
                writer.WriteBooleanValue(IsSourceVmEncrypted.Value);
            }
            if (Optional.IsDefined(KeyAndSecret))
            {
                writer.WritePropertyName("keyAndSecret"u8);
                writer.WriteObjectValue(KeyAndSecret);
            }
            if (Optional.IsDefined(IsInstantIlrSessionActive))
            {
                writer.WritePropertyName("isInstantIlrSessionActive"u8);
                writer.WriteBooleanValue(IsInstantIlrSessionActive.Value);
            }
            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                writer.WritePropertyName("recoveryPointTierDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryPointTierDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsManagedVirtualMachine))
            {
                writer.WritePropertyName("isManagedVirtualMachine"u8);
                writer.WriteBooleanValue(IsManagedVirtualMachine.Value);
            }
            if (Optional.IsDefined(VirtualMachineSize))
            {
                writer.WritePropertyName("virtualMachineSize"u8);
                writer.WriteStringValue(VirtualMachineSize);
            }
            if (Optional.IsDefined(OriginalStorageAccountOption))
            {
                writer.WritePropertyName("originalStorageAccountOption"u8);
                writer.WriteBooleanValue(OriginalStorageAccountOption.Value);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(RecoveryPointDiskConfiguration))
            {
                writer.WritePropertyName("recoveryPointDiskConfiguration"u8);
                writer.WriteObjectValue(RecoveryPointDiskConfiguration);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                writer.WritePropertyName("recoveryPointMoveReadinessInfo"u8);
                writer.WriteStartObject();
                foreach (var item in RecoveryPointMoveReadinessInfo)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(SecurityType))
            {
                writer.WritePropertyName("securityType"u8);
                writer.WriteStringValue(SecurityType);
            }
            if (Optional.IsDefined(RecoveryPointProperties))
            {
                writer.WritePropertyName("recoveryPointProperties"u8);
                writer.WriteObjectValue(RecoveryPointProperties);
            }
            if (Optional.IsDefined(IsPrivateAccessEnabledOnAnyDisk))
            {
                writer.WritePropertyName("isPrivateAccessEnabledOnAnyDisk"u8);
                writer.WriteBooleanValue(IsPrivateAccessEnabledOnAnyDisk.Value);
            }
            if (Optional.IsDefined(ExtendedLocation))
            {
                writer.WritePropertyName("extendedLocation"u8);
                JsonSerializer.Serialize(writer, ExtendedLocation);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        IaasVmRecoveryPoint IJsonModel<IaasVmRecoveryPoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IaasVmRecoveryPoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmRecoveryPoint(document.RootElement, options);
        }

        internal static IaasVmRecoveryPoint DeserializeIaasVmRecoveryPoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryPointType = default;
            Optional<DateTimeOffset> recoveryPointTime = default;
            Optional<string> recoveryPointAdditionalInfo = default;
            Optional<string> sourceVmStorageType = default;
            Optional<bool> isSourceVmEncrypted = default;
            Optional<KeyAndSecretDetails> keyAndSecret = default;
            Optional<bool> isInstantIlrSessionActive = default;
            Optional<IList<RecoveryPointTierInformationV2>> recoveryPointTierDetails = default;
            Optional<bool> isManagedVirtualMachine = default;
            Optional<string> virtualMachineSize = default;
            Optional<bool> originalStorageAccountOption = default;
            Optional<string> osType = default;
            Optional<RecoveryPointDiskConfiguration> recoveryPointDiskConfiguration = default;
            Optional<IList<string>> zones = default;
            Optional<IDictionary<string, RecoveryPointMoveReadinessInfo>> recoveryPointMoveReadinessInfo = default;
            Optional<string> securityType = default;
            Optional<RecoveryPointProperties> recoveryPointProperties = default;
            Optional<bool> isPrivateAccessEnabledOnAnyDisk = default;
            Optional<ExtendedLocation> extendedLocation = default;
            string objectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveryPointAdditionalInfo"u8))
                {
                    recoveryPointAdditionalInfo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceVMStorageType"u8))
                {
                    sourceVmStorageType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSourceVMEncrypted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSourceVmEncrypted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyAndSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyAndSecret = KeyAndSecretDetails.DeserializeKeyAndSecretDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("isInstantIlrSessionActive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isInstantIlrSessionActive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("recoveryPointTierDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointTierInformationV2> array = new List<RecoveryPointTierInformationV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item));
                    }
                    recoveryPointTierDetails = array;
                    continue;
                }
                if (property.NameEquals("isManagedVirtualMachine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isManagedVirtualMachine = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualMachineSize"u8))
                {
                    virtualMachineSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("originalStorageAccountOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    originalStorageAccountOption = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointDiskConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointDiskConfiguration = RecoveryPointDiskConfiguration.DeserializeRecoveryPointDiskConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointMoveReadinessInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RecoveryPointMoveReadinessInfo> dictionary = new Dictionary<string, RecoveryPointMoveReadinessInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value));
                    }
                    recoveryPointMoveReadinessInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("securityType"u8))
                {
                    securityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryPointProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("isPrivateAccessEnabledOnAnyDisk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPrivateAccessEnabledOnAnyDisk = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("extendedLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedLocation = JsonSerializer.Deserialize<ExtendedLocation>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IaasVmRecoveryPoint(objectType, serializedAdditionalRawData, recoveryPointType.Value, Optional.ToNullable(recoveryPointTime), recoveryPointAdditionalInfo.Value, sourceVmStorageType.Value, Optional.ToNullable(isSourceVmEncrypted), keyAndSecret.Value, Optional.ToNullable(isInstantIlrSessionActive), Optional.ToList(recoveryPointTierDetails), Optional.ToNullable(isManagedVirtualMachine), virtualMachineSize.Value, Optional.ToNullable(originalStorageAccountOption), osType.Value, recoveryPointDiskConfiguration.Value, Optional.ToList(zones), Optional.ToDictionary(recoveryPointMoveReadinessInfo), securityType.Value, recoveryPointProperties.Value, Optional.ToNullable(isPrivateAccessEnabledOnAnyDisk), extendedLocation);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(RecoveryPointType))
            {
                builder.Append("  recoveryPointType:");
                builder.AppendLine($" '{RecoveryPointType}'");
            }

            if (Optional.IsDefined(RecoveryPointOn))
            {
                builder.Append("  recoveryPointTime:");
                var formattedDateTimeString = TypeFormatters.ToString(RecoveryPointOn.Value, "o");
                builder.AppendLine($" '{formattedDateTimeString}'");
            }

            if (Optional.IsDefined(RecoveryPointAdditionalInfo))
            {
                builder.Append("  recoveryPointAdditionalInfo:");
                builder.AppendLine($" '{RecoveryPointAdditionalInfo}'");
            }

            if (Optional.IsDefined(SourceVmStorageType))
            {
                builder.Append("  sourceVMStorageType:");
                builder.AppendLine($" '{SourceVmStorageType}'");
            }

            if (Optional.IsDefined(IsSourceVmEncrypted))
            {
                builder.Append("  isSourceVMEncrypted:");
                var boolValue = IsSourceVmEncrypted.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(KeyAndSecret))
            {
                builder.Append("  keyAndSecret:");
                AppendChildObject(builder, KeyAndSecret, options, 2, false);
            }

            if (Optional.IsDefined(IsInstantIlrSessionActive))
            {
                builder.Append("  isInstantIlrSessionActive:");
                var boolValue = IsInstantIlrSessionActive.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                if (RecoveryPointTierDetails.Any())
                {
                    builder.Append("  recoveryPointTierDetails:");
                    builder.AppendLine(" [");
                    foreach (var item in RecoveryPointTierDetails)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(IsManagedVirtualMachine))
            {
                builder.Append("  isManagedVirtualMachine:");
                var boolValue = IsManagedVirtualMachine.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(VirtualMachineSize))
            {
                builder.Append("  virtualMachineSize:");
                builder.AppendLine($" '{VirtualMachineSize}'");
            }

            if (Optional.IsDefined(OriginalStorageAccountOption))
            {
                builder.Append("  originalStorageAccountOption:");
                var boolValue = OriginalStorageAccountOption.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(OSType))
            {
                builder.Append("  osType:");
                builder.AppendLine($" '{OSType}'");
            }

            if (Optional.IsDefined(RecoveryPointDiskConfiguration))
            {
                builder.Append("  recoveryPointDiskConfiguration:");
                AppendChildObject(builder, RecoveryPointDiskConfiguration, options, 2, false);
            }

            if (Optional.IsCollectionDefined(Zones))
            {
                if (Zones.Any())
                {
                    builder.Append("  zones:");
                    builder.AppendLine(" [");
                    foreach (var item in Zones)
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

            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                if (RecoveryPointMoveReadinessInfo.Any())
                {
                    builder.Append("  recoveryPointMoveReadinessInfo:");
                    builder.AppendLine(" {");
                    foreach (var item in RecoveryPointMoveReadinessInfo)
                    {
                        builder.Append($"    {item.Key}: ");
                        AppendChildObject(builder, item.Value, options, 4, false);
                    }
                    builder.AppendLine("  }");
                }
            }

            if (Optional.IsDefined(SecurityType))
            {
                builder.Append("  securityType:");
                builder.AppendLine($" '{SecurityType}'");
            }

            if (Optional.IsDefined(RecoveryPointProperties))
            {
                builder.Append("  recoveryPointProperties:");
                AppendChildObject(builder, RecoveryPointProperties, options, 2, false);
            }

            if (Optional.IsDefined(IsPrivateAccessEnabledOnAnyDisk))
            {
                builder.Append("  isPrivateAccessEnabledOnAnyDisk:");
                var boolValue = IsPrivateAccessEnabledOnAnyDisk.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ExtendedLocation))
            {
                builder.Append("  extendedLocation:");
                AppendChildObject(builder, ExtendedLocation, options, 2, false);
            }

            if (Optional.IsDefined(ObjectType))
            {
                builder.Append("  objectType:");
                builder.AppendLine($" '{ObjectType}'");
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

        BinaryData IPersistableModel<IaasVmRecoveryPoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(IaasVmRecoveryPoint)} does not support '{options.Format}' format.");
            }
        }

        IaasVmRecoveryPoint IPersistableModel<IaasVmRecoveryPoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IaasVmRecoveryPoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIaasVmRecoveryPoint(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(IaasVmRecoveryPoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<IaasVmRecoveryPoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
