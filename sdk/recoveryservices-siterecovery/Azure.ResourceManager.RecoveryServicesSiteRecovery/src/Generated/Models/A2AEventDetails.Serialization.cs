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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2AEventDetails : IUtf8JsonSerializable, IJsonModel<A2AEventDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2AEventDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2AEventDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AEventDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProtectedItemName))
            {
                writer.WritePropertyName("protectedItemName"u8);
                writer.WriteStringValue(ProtectedItemName);
            }
            if (Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (Optional.IsDefined(FabricName))
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName);
            }
            if (Optional.IsDefined(FabricLocation))
            {
                writer.WritePropertyName("fabricLocation"u8);
                writer.WriteStringValue(FabricLocation.Value);
            }
            if (Optional.IsDefined(RemoteFabricName))
            {
                writer.WritePropertyName("remoteFabricName"u8);
                writer.WriteStringValue(RemoteFabricName);
            }
            if (Optional.IsDefined(RemoteFabricLocation))
            {
                writer.WritePropertyName("remoteFabricLocation"u8);
                writer.WriteStringValue(RemoteFabricLocation.Value);
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

        A2AEventDetails IJsonModel<A2AEventDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEventDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(A2AEventDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AEventDetails(document.RootElement, options);
        }

        internal static A2AEventDetails DeserializeA2AEventDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> protectedItemName = default;
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<string> fabricName = default;
            Optional<AzureLocation> fabricLocation = default;
            Optional<string> remoteFabricName = default;
            Optional<AzureLocation> remoteFabricLocation = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("protectedItemName"u8))
                {
                    protectedItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteFabricName"u8))
                {
                    remoteFabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remoteFabricLocation = new AzureLocation(property.Value.GetString());
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
            return new A2AEventDetails(instanceType, serializedAdditionalRawData, protectedItemName.Value, fabricObjectId.Value, fabricName.Value, Optional.ToNullable(fabricLocation), remoteFabricName.Value, Optional.ToNullable(remoteFabricLocation));
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(ProtectedItemName))
            {
                builder.Append("  protectedItemName:");
                builder.AppendLine($" '{ProtectedItemName}'");
            }

            if (Optional.IsDefined(FabricObjectId))
            {
                builder.Append("  fabricObjectId:");
                builder.AppendLine($" '{FabricObjectId.ToString()}'");
            }

            if (Optional.IsDefined(FabricName))
            {
                builder.Append("  fabricName:");
                builder.AppendLine($" '{FabricName}'");
            }

            if (Optional.IsDefined(FabricLocation))
            {
                builder.Append("  fabricLocation:");
                builder.AppendLine($" '{FabricLocation.Value.ToString()}'");
            }

            if (Optional.IsDefined(RemoteFabricName))
            {
                builder.Append("  remoteFabricName:");
                builder.AppendLine($" '{RemoteFabricName}'");
            }

            if (Optional.IsDefined(RemoteFabricLocation))
            {
                builder.Append("  remoteFabricLocation:");
                builder.AppendLine($" '{RemoteFabricLocation.Value.ToString()}'");
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

        BinaryData IPersistableModel<A2AEventDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(A2AEventDetails)} does not support '{options.Format}' format.");
            }
        }

        A2AEventDetails IPersistableModel<A2AEventDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<A2AEventDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeA2AEventDetails(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(A2AEventDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<A2AEventDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
