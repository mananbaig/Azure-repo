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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NodeTypeFrontendConfiguration : IUtf8JsonSerializable, IJsonModel<NodeTypeFrontendConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NodeTypeFrontendConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NodeTypeFrontendConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IPAddressType))
            {
                writer.WritePropertyName("ipAddressType"u8);
                writer.WriteStringValue(IPAddressType.Value.ToString());
            }
            if (Optional.IsDefined(LoadBalancerBackendAddressPoolId))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPoolId"u8);
                writer.WriteStringValue(LoadBalancerBackendAddressPoolId);
            }
            if (Optional.IsDefined(LoadBalancerInboundNatPoolId))
            {
                writer.WritePropertyName("loadBalancerInboundNatPoolId"u8);
                writer.WriteStringValue(LoadBalancerInboundNatPoolId);
            }
            if (Optional.IsDefined(ApplicationGatewayBackendAddressPoolId))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPoolId"u8);
                writer.WriteStringValue(ApplicationGatewayBackendAddressPoolId);
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

        NodeTypeFrontendConfiguration IJsonModel<NodeTypeFrontendConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNodeTypeFrontendConfiguration(document.RootElement, options);
        }

        internal static NodeTypeFrontendConfiguration DeserializeNodeTypeFrontendConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NodeTypeFrontendConfigurationIPAddressType> ipAddressType = default;
            Optional<ResourceIdentifier> loadBalancerBackendAddressPoolId = default;
            Optional<ResourceIdentifier> loadBalancerInboundNatPoolId = default;
            Optional<ResourceIdentifier> applicationGatewayBackendAddressPoolId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipAddressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ipAddressType = new NodeTypeFrontendConfigurationIPAddressType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("loadBalancerInboundNatPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    loadBalancerInboundNatPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationGatewayBackendAddressPoolId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null || property.Value.ValueKind == JsonValueKind.String && property.Value.GetString().Length == 0)
                    {
                        continue;
                    }
                    applicationGatewayBackendAddressPoolId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NodeTypeFrontendConfiguration(Optional.ToNullable(ipAddressType), loadBalancerBackendAddressPoolId.Value, loadBalancerInboundNatPoolId.Value, applicationGatewayBackendAddressPoolId.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(IPAddressType))
            {
                builder.Append("  ipAddressType:");
                builder.AppendLine($" '{IPAddressType.ToString()}'");
            }

            if (Optional.IsDefined(LoadBalancerBackendAddressPoolId))
            {
                builder.Append("  loadBalancerBackendAddressPoolId:");
                builder.AppendLine($" '{LoadBalancerBackendAddressPoolId.ToString()}'");
            }

            if (Optional.IsDefined(LoadBalancerInboundNatPoolId))
            {
                builder.Append("  loadBalancerInboundNatPoolId:");
                builder.AppendLine($" '{LoadBalancerInboundNatPoolId.ToString()}'");
            }

            if (Optional.IsDefined(ApplicationGatewayBackendAddressPoolId))
            {
                builder.Append("  applicationGatewayBackendAddressPoolId:");
                builder.AppendLine($" '{ApplicationGatewayBackendAddressPoolId.ToString()}'");
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

        BinaryData IPersistableModel<NodeTypeFrontendConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support '{options.Format}' format.");
            }
        }

        NodeTypeFrontendConfiguration IPersistableModel<NodeTypeFrontendConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NodeTypeFrontendConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNodeTypeFrontendConfiguration(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(NodeTypeFrontendConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NodeTypeFrontendConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
