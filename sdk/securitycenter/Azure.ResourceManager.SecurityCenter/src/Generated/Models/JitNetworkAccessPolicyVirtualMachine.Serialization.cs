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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessPolicyVirtualMachine : IUtf8JsonSerializable, IJsonModel<JitNetworkAccessPolicyVirtualMachine>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JitNetworkAccessPolicyVirtualMachine>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JitNetworkAccessPolicyVirtualMachine>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessPolicyVirtualMachine)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WritePropertyName("ports"u8);
            writer.WriteStartArray();
            foreach (var item in Ports)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(PublicIPAddress))
            {
                writer.WritePropertyName("publicIpAddress"u8);
                writer.WriteStringValue(PublicIPAddress);
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

        JitNetworkAccessPolicyVirtualMachine IJsonModel<JitNetworkAccessPolicyVirtualMachine>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JitNetworkAccessPolicyVirtualMachine)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessPolicyVirtualMachine(document.RootElement, options);
        }

        internal static JitNetworkAccessPolicyVirtualMachine DeserializeJitNetworkAccessPolicyVirtualMachine(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            IList<JitNetworkAccessPortRule> ports = default;
            Optional<string> publicIPAddress = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    List<JitNetworkAccessPortRule> array = new List<JitNetworkAccessPortRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JitNetworkAccessPortRule.DeserializeJitNetworkAccessPortRule(item));
                    }
                    ports = array;
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    publicIPAddress = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JitNetworkAccessPolicyVirtualMachine(id, ports, publicIPAddress.Value, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Id))
            {
                builder.Append("  id:");
                builder.AppendLine($" '{Id.ToString()}'");
            }

            if (Optional.IsCollectionDefined(Ports))
            {
                if (Ports.Any())
                {
                    builder.Append("  ports:");
                    builder.AppendLine(" [");
                    foreach (var item in Ports)
                    {
                        AppendChildObject(builder, item, options, 4, true);
                    }
                    builder.AppendLine("  ]");
                }
            }

            if (Optional.IsDefined(PublicIPAddress))
            {
                builder.Append("  publicIpAddress:");
                builder.AppendLine($" '{PublicIPAddress}'");
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

        BinaryData IPersistableModel<JitNetworkAccessPolicyVirtualMachine>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessPolicyVirtualMachine)} does not support '{options.Format}' format.");
            }
        }

        JitNetworkAccessPolicyVirtualMachine IPersistableModel<JitNetworkAccessPolicyVirtualMachine>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JitNetworkAccessPolicyVirtualMachine>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJitNetworkAccessPolicyVirtualMachine(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(JitNetworkAccessPolicyVirtualMachine)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JitNetworkAccessPolicyVirtualMachine>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
