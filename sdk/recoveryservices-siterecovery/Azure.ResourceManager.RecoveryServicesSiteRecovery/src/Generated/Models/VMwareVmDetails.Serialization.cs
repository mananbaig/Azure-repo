// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareVmDetails : IUtf8JsonSerializable, IJsonModel<VMwareVmDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareVmDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareVmDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AgentGeneratedId))
            {
                writer.WritePropertyName("agentGeneratedId"u8);
                writer.WriteStringValue(AgentGeneratedId);
            }
            if (Optional.IsDefined(AgentInstalled))
            {
                writer.WritePropertyName("agentInstalled"u8);
                writer.WriteStringValue(AgentInstalled);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(AgentVersion))
            {
                writer.WritePropertyName("agentVersion"u8);
                writer.WriteStringValue(AgentVersion);
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress.ToString());
            }
            if (Optional.IsDefined(PoweredOn))
            {
                writer.WritePropertyName("poweredOn"u8);
                writer.WriteStringValue(PoweredOn);
            }
            if (Optional.IsDefined(VCenterInfrastructureId))
            {
                writer.WritePropertyName("vCenterInfrastructureId"u8);
                writer.WriteStringValue(VCenterInfrastructureId);
            }
            if (Optional.IsDefined(DiscoveryType))
            {
                writer.WritePropertyName("discoveryType"u8);
                writer.WriteStringValue(DiscoveryType);
            }
            if (Optional.IsCollectionDefined(DiskDetails))
            {
                writer.WritePropertyName("diskDetails"u8);
                writer.WriteStartArray();
                foreach (var item in DiskDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ValidationErrors))
            {
                writer.WritePropertyName("validationErrors"u8);
                writer.WriteStartArray();
                foreach (var item in ValidationErrors)
                {
                    writer.WriteObjectValue(item);
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

        VMwareVmDetails IJsonModel<VMwareVmDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareVmDetails(document.RootElement, options);
        }

        internal static VMwareVmDetails DeserializeVMwareVmDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentGeneratedId = default;
            Optional<string> agentInstalled = default;
            Optional<string> osType = default;
            Optional<string> agentVersion = default;
            Optional<IPAddress> ipAddress = default;
            Optional<string> poweredOn = default;
            Optional<string> vCenterInfrastructureId = default;
            Optional<string> discoveryType = default;
            Optional<IReadOnlyList<InMageDiskDetails>> diskDetails = default;
            Optional<IReadOnlyList<SiteRecoveryHealthError>> validationErrors = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentGeneratedId"u8))
                {
                    agentGeneratedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentInstalled"u8))
                {
                    agentInstalled = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("agentVersion"u8))
                {
                    agentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("poweredOn"u8))
                {
                    poweredOn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCenterInfrastructureId"u8))
                {
                    vCenterInfrastructureId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("discoveryType"u8))
                {
                    discoveryType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InMageDiskDetails> array = new List<InMageDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InMageDiskDetails.DeserializeInMageDiskDetails(item));
                    }
                    diskDetails = array;
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryHealthError> array = new List<SiteRecoveryHealthError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryHealthError.DeserializeSiteRecoveryHealthError(item));
                    }
                    validationErrors = array;
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
            return new VMwareVmDetails(instanceType, serializedAdditionalRawData, agentGeneratedId.Value, agentInstalled.Value, osType.Value, agentVersion.Value, ipAddress.Value, poweredOn.Value, vCenterInfrastructureId.Value, discoveryType.Value, Optional.ToList(diskDetails), Optional.ToList(validationErrors));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(AgentGeneratedId))
            {
                builder.Append("  agentGeneratedId:");
                builder.AppendLine($" '{AgentGeneratedId}'");
            }

            if (Optional.IsDefined(AgentInstalled))
            {
                builder.Append("  agentInstalled:");
                builder.AppendLine($" '{AgentInstalled}'");
            }

            if (Optional.IsDefined(OSType))
            {
                builder.Append("  osType:");
                builder.AppendLine($" '{OSType}'");
            }

            if (Optional.IsDefined(AgentVersion))
            {
                builder.Append("  agentVersion:");
                builder.AppendLine($" '{AgentVersion}'");
            }

            if (Optional.IsDefined(IPAddress))
            {
                builder.Append("  ipAddress:");
                builder.AppendLine($" '{IPAddress.ToString()}'");
            }

            if (Optional.IsDefined(PoweredOn))
            {
                builder.Append("  poweredOn:");
                builder.AppendLine($" '{PoweredOn}'");
            }

            if (Optional.IsDefined(VCenterInfrastructureId))
            {
                builder.Append("  vCenterInfrastructureId:");
                builder.AppendLine($" '{VCenterInfrastructureId}'");
            }

            if (Optional.IsDefined(DiscoveryType))
            {
                builder.Append("  discoveryType:");
                builder.AppendLine($" '{DiscoveryType}'");
            }

            if (Optional.IsCollectionDefined(DiskDetails))
            {
                if (DiskDetails.Any())
                {
                    builder.Append("  diskDetails:");
                    builder.AppendLine(" [");
                    foreach (var item in DiskDetails)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsCollectionDefined(ValidationErrors))
            {
                if (ValidationErrors.Any())
                {
                    builder.Append("  validationErrors:");
                    builder.AppendLine(" [");
                    foreach (var item in ValidationErrors)
                    {
                        AppendChildObject(builder, item, options, 4, true);
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

        BinaryData IPersistableModel<VMwareVmDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{options.Format}' format.");
            }
        }

        VMwareVmDetails IPersistableModel<VMwareVmDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareVmDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareVmDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(VMwareVmDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareVmDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
