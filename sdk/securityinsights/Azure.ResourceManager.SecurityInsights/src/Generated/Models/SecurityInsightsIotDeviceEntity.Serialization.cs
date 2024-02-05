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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIotDeviceEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIotDeviceEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIotDeviceEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIotDeviceEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIotDeviceEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIotDeviceEntity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(AdditionalData))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceName))
            {
                writer.WritePropertyName("deviceName"u8);
                writer.WriteStringValue(DeviceName);
            }
            if (options.Format != "W" && Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (options.Format != "W" && Optional.IsDefined(IotSecurityAgentId))
            {
                writer.WritePropertyName("iotSecurityAgentId"u8);
                writer.WriteStringValue(IotSecurityAgentId.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceType))
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType);
            }
            if (options.Format != "W" && Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (options.Format != "W" && Optional.IsDefined(EdgeId))
            {
                writer.WritePropertyName("edgeId"u8);
                writer.WriteStringValue(EdgeId);
            }
            if (options.Format != "W" && Optional.IsDefined(MacAddress))
            {
                writer.WritePropertyName("macAddress"u8);
                writer.WriteStringValue(MacAddress);
            }
            if (options.Format != "W" && Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(FirmwareVersion))
            {
                writer.WritePropertyName("firmwareVersion"u8);
                writer.WriteStringValue(FirmwareVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(OperatingSystem))
            {
                writer.WritePropertyName("operatingSystem"u8);
                writer.WriteStringValue(OperatingSystem);
            }
            if (options.Format != "W" && Optional.IsDefined(IotHubEntityId))
            {
                writer.WritePropertyName("iotHubEntityId"u8);
                writer.WriteStringValue(IotHubEntityId);
            }
            if (options.Format != "W" && Optional.IsDefined(HostEntityId))
            {
                writer.WritePropertyName("hostEntityId"u8);
                writer.WriteStringValue(HostEntityId);
            }
            if (options.Format != "W" && Optional.IsDefined(IPAddressEntityId))
            {
                writer.WritePropertyName("ipAddressEntityId"u8);
                writer.WriteStringValue(IPAddressEntityId);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ThreatIntelligence))
            {
                writer.WritePropertyName("threatIntelligence"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatIntelligence)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        SecurityInsightsIotDeviceEntity IJsonModel<SecurityInsightsIotDeviceEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIotDeviceEntity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIotDeviceEntity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIotDeviceEntity(document.RootElement, options);
        }

        internal static SecurityInsightsIotDeviceEntity DeserializeSecurityInsightsIotDeviceEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> deviceId = default;
            Optional<string> deviceName = default;
            Optional<string> source = default;
            Optional<Guid> iotSecurityAgentId = default;
            Optional<string> deviceType = default;
            Optional<string> vendor = default;
            Optional<string> edgeId = default;
            Optional<string> macAddress = default;
            Optional<string> model = default;
            Optional<string> serialNumber = default;
            Optional<string> firmwareVersion = default;
            Optional<string> operatingSystem = default;
            Optional<string> iotHubEntityId = default;
            Optional<string> hostEntityId = default;
            Optional<string> ipAddressEntityId = default;
            Optional<IReadOnlyList<SecurityInsightsThreatIntelligence>> threatIntelligence = default;
            Optional<IReadOnlyList<string>> protocols = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceId"u8))
                        {
                            deviceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceName"u8))
                        {
                            deviceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iotSecurityAgentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iotSecurityAgentId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("deviceType"u8))
                        {
                            deviceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("edgeId"u8))
                        {
                            edgeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("macAddress"u8))
                        {
                            macAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("model"u8))
                        {
                            model = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("firmwareVersion"u8))
                        {
                            firmwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operatingSystem"u8))
                        {
                            operatingSystem = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iotHubEntityId"u8))
                        {
                            iotHubEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"u8))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipAddressEntityId"u8))
                        {
                            ipAddressEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("threatIntelligence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsThreatIntelligence> array = new List<SecurityInsightsThreatIntelligence>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsThreatIntelligence.DeserializeSecurityInsightsThreatIntelligence(item));
                            }
                            threatIntelligence = array;
                            continue;
                        }
                        if (property0.NameEquals("protocols"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            protocols = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIotDeviceEntity(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, deviceId.Value, deviceName.Value, source.Value, Optional.ToNullable(iotSecurityAgentId), deviceType.Value, vendor.Value, edgeId.Value, macAddress.Value, model.Value, serialNumber.Value, firmwareVersion.Value, operatingSystem.Value, iotHubEntityId.Value, hostEntityId.Value, ipAddressEntityId.Value, Optional.ToList(threatIntelligence), Optional.ToList(protocols));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
            }

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(ResourceType))
            {
                builder.Append("  type:");
                builder.AppendLine($" '{ResourceType.ToString()}'");
            }

            if (Optional.IsDefined(SystemData))
            {
                builder.Append("  systemData:");
                builder.AppendLine($" '{SystemData.ToString()}'");
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            if (Optional.IsCollectionDefined(AdditionalData))
            {
                if (AdditionalData.Any())
                {
                    builder.Append("    additionalData:");
                    builder.AppendLine(" {");
                    foreach (var item in AdditionalData)
                    {
                        builder.Append($"        {item.Key}: ");
                        if (item.Value == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($" '{item.Value.ToString()}'");
                    }
                    builder.AppendLine("    }");
                }
            }

            if (Optional.IsDefined(FriendlyName))
            {
                builder.Append("    friendlyName:");
                builder.AppendLine($" '{FriendlyName}'");
            }

            if (Optional.IsDefined(DeviceId))
            {
                builder.Append("    deviceId:");
                builder.AppendLine($" '{DeviceId}'");
            }

            if (Optional.IsDefined(DeviceName))
            {
                builder.Append("    deviceName:");
                builder.AppendLine($" '{DeviceName}'");
            }

            if (Optional.IsDefined(Source))
            {
                builder.Append("    source:");
                builder.AppendLine($" '{Source}'");
            }

            if (Optional.IsDefined(IotSecurityAgentId))
            {
                builder.Append("    iotSecurityAgentId:");
                builder.AppendLine($" '{IotSecurityAgentId.Value.ToString()}'");
            }

            if (Optional.IsDefined(DeviceType))
            {
                builder.Append("    deviceType:");
                builder.AppendLine($" '{DeviceType}'");
            }

            if (Optional.IsDefined(Vendor))
            {
                builder.Append("    vendor:");
                builder.AppendLine($" '{Vendor}'");
            }

            if (Optional.IsDefined(EdgeId))
            {
                builder.Append("    edgeId:");
                builder.AppendLine($" '{EdgeId}'");
            }

            if (Optional.IsDefined(MacAddress))
            {
                builder.Append("    macAddress:");
                builder.AppendLine($" '{MacAddress}'");
            }

            if (Optional.IsDefined(Model))
            {
                builder.Append("    model:");
                builder.AppendLine($" '{Model}'");
            }

            if (Optional.IsDefined(SerialNumber))
            {
                builder.Append("    serialNumber:");
                builder.AppendLine($" '{SerialNumber}'");
            }

            if (Optional.IsDefined(FirmwareVersion))
            {
                builder.Append("    firmwareVersion:");
                builder.AppendLine($" '{FirmwareVersion}'");
            }

            if (Optional.IsDefined(OperatingSystem))
            {
                builder.Append("    operatingSystem:");
                builder.AppendLine($" '{OperatingSystem}'");
            }

            if (Optional.IsDefined(IotHubEntityId))
            {
                builder.Append("    iotHubEntityId:");
                builder.AppendLine($" '{IotHubEntityId}'");
            }

            if (Optional.IsDefined(HostEntityId))
            {
                builder.Append("    hostEntityId:");
                builder.AppendLine($" '{HostEntityId}'");
            }

            if (Optional.IsDefined(IPAddressEntityId))
            {
                builder.Append("    ipAddressEntityId:");
                builder.AppendLine($" '{IPAddressEntityId}'");
            }

            if (Optional.IsCollectionDefined(ThreatIntelligence))
            {
                if (ThreatIntelligence.Any())
                {
                    builder.Append("    threatIntelligence:");
                    builder.AppendLine(" [");
                    foreach (var item in ThreatIntelligence)
                    {
                        AppendChildObject(builder, item, options, 6, true);
                    }
                    builder.AppendLine("    ]");
                }
            }

            if (Optional.IsCollectionDefined(Protocols))
            {
                if (Protocols.Any())
                {
                    builder.Append("    protocols:");
                    builder.AppendLine(" [");
                    foreach (var item in Protocols)
                    {
                        if (item == null)
                        {
                            builder.Append("null");
                            continue;
                        }
                        builder.AppendLine($"      '{item}'");
                    }
                    builder.AppendLine("    ]");
                }
            }

            builder.AppendLine("  }");
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

        BinaryData IPersistableModel<SecurityInsightsIotDeviceEntity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIotDeviceEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIotDeviceEntity)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsIotDeviceEntity IPersistableModel<SecurityInsightsIotDeviceEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsIotDeviceEntity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsIotDeviceEntity(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsIotDeviceEntity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsIotDeviceEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
