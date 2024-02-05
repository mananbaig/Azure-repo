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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class MabContainer : IUtf8JsonSerializable, IJsonModel<MabContainer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MabContainer>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MabContainer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MabContainer)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CanReRegister))
            {
                writer.WritePropertyName("canReRegister"u8);
                writer.WriteBooleanValue(CanReRegister.Value);
            }
            if (Optional.IsDefined(ContainerId))
            {
                writer.WritePropertyName("containerId"u8);
                writer.WriteNumberValue(ContainerId.Value);
            }
            if (Optional.IsDefined(ProtectedItemCount))
            {
                writer.WritePropertyName("protectedItemCount"u8);
                writer.WriteNumberValue(ProtectedItemCount.Value);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                writer.WriteObjectValue(ExtendedInfo);
            }
            if (Optional.IsCollectionDefined(MabContainerHealthDetails))
            {
                writer.WritePropertyName("mabContainerHealthDetails"u8);
                writer.WriteStartArray();
                foreach (var item in MabContainerHealthDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContainerHealthState))
            {
                writer.WritePropertyName("containerHealthState"u8);
                writer.WriteStringValue(ContainerHealthState);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType.Value.ToString());
            }
            if (Optional.IsDefined(RegistrationStatus))
            {
                writer.WritePropertyName("registrationStatus"u8);
                writer.WriteStringValue(RegistrationStatus);
            }
            if (Optional.IsDefined(HealthStatus))
            {
                writer.WritePropertyName("healthStatus"u8);
                writer.WriteStringValue(HealthStatus);
            }
            writer.WritePropertyName("containerType"u8);
            writer.WriteStringValue(ContainerType.ToSerialString());
            if (Optional.IsDefined(ProtectableObjectType))
            {
                writer.WritePropertyName("protectableObjectType"u8);
                writer.WriteStringValue(ProtectableObjectType);
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

        MabContainer IJsonModel<MabContainer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MabContainer)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMabContainer(document.RootElement, options);
        }

        internal static MabContainer DeserializeMabContainer(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> canReRegister = default;
            Optional<long> containerId = default;
            Optional<long> protectedItemCount = default;
            Optional<string> agentVersion = default;
            Optional<MabContainerExtendedInfo> extendedInfo = default;
            Optional<IList<MabContainerHealthDetails>> mabContainerHealthDetails = default;
            Optional<string> containerHealthState = default;
            Optional<string> friendlyName = default;
            Optional<BackupManagementType> backupManagementType = default;
            Optional<string> registrationStatus = default;
            Optional<string> healthStatus = default;
            ProtectableContainerType containerType = default;
            Optional<string> protectableObjectType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("canReRegister"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    canReRegister = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("containerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerId = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("protectedItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectedItemCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = MabContainerExtendedInfo.DeserializeMabContainerExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("mabContainerHealthDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MabContainerHealthDetails> array = new List<MabContainerHealthDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.MabContainerHealthDetails.DeserializeMabContainerHealthDetails(item));
                    }
                    mabContainerHealthDetails = array;
                    continue;
                }
                if (property.NameEquals("containerHealthState"u8))
                {
                    containerHealthState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupManagementType = new BackupManagementType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("registrationStatus"u8))
                {
                    registrationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("healthStatus"u8))
                {
                    healthStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerType"u8))
                {
                    containerType = property.Value.GetString().ToProtectableContainerType();
                    continue;
                }
                if (property.NameEquals("protectableObjectType"u8))
                {
                    protectableObjectType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MabContainer(friendlyName.Value, Optional.ToNullable(backupManagementType), registrationStatus.Value, healthStatus.Value, containerType, protectableObjectType.Value, serializedAdditionalRawData, Optional.ToNullable(canReRegister), Optional.ToNullable(containerId), Optional.ToNullable(protectedItemCount), agentVersion.Value, extendedInfo.Value, Optional.ToList(mabContainerHealthDetails), containerHealthState.Value);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(CanReRegister))
            {
                builder.Append("  canReRegister:");
                var boolValue = CanReRegister.Value == true ? "true" : "false";
                builder.AppendLine($" {boolValue}");
            }

            if (Optional.IsDefined(ContainerId))
            {
                builder.Append("  containerId:");
                builder.AppendLine($" '{ContainerId.Value.ToString()}'");
            }

            if (Optional.IsDefined(ProtectedItemCount))
            {
                builder.Append("  protectedItemCount:");
                builder.AppendLine($" '{ProtectedItemCount.Value.ToString()}'");
            }

            if (Optional.IsDefined(AgentVersion))
            {
                builder.Append("  agentVersion:");
                builder.AppendLine($" '{AgentVersion}'");
            }

            if (Optional.IsDefined(ExtendedInfo))
            {
                builder.Append("  extendedInfo:");
                AppendChildObject(builder, ExtendedInfo, options, 2, false);
            }

            if (Optional.IsCollectionDefined(MabContainerHealthDetails))
            {
                if (MabContainerHealthDetails.Any())
                {
                    builder.Append("  mabContainerHealthDetails:");
                    builder.AppendLine(" [");
                    foreach (var item in MabContainerHealthDetails)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(ContainerHealthState))
            {
                builder.Append("  containerHealthState:");
                builder.AppendLine($" '{ContainerHealthState}'");
            }

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("  friendlyName:");
                builder.AppendLine($" '{FriendlyName}'");
            }

            if (Optional.IsDefined(BackupManagementType))
            {
                builder.Append("  backupManagementType:");
                builder.AppendLine($" '{BackupManagementType.ToString()}'");
            }

            if (Optional.IsDefined(RegistrationStatus))
            {
                builder.Append("  registrationStatus:");
                builder.AppendLine($" '{RegistrationStatus}'");
            }

            if (Optional.IsDefined(HealthStatus))
            {
                builder.Append("  healthStatus:");
                builder.AppendLine($" '{HealthStatus}'");
            }

            if (Optional.IsDefined(ContainerType))
            {
                builder.Append("  containerType:");
                builder.AppendLine($" '{ContainerType.ToString()}'");
            }

            if (Optional.IsDefined(ProtectableObjectType))
            {
                builder.Append("  protectableObjectType:");
                builder.AppendLine($" '{ProtectableObjectType}'");
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

        BinaryData IPersistableModel<MabContainer>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(MabContainer)} does not support '{options.Format}' format.");
            }
        }

        MabContainer IPersistableModel<MabContainer>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MabContainer>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMabContainer(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(MabContainer)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MabContainer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
