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
    public partial class PartitionInstanceCountScalingMechanism : IUtf8JsonSerializable, IJsonModel<PartitionInstanceCountScalingMechanism>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartitionInstanceCountScalingMechanism>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartitionInstanceCountScalingMechanism>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("minInstanceCount"u8);
            writer.WriteNumberValue(MinInstanceCount);
            writer.WritePropertyName("maxInstanceCount"u8);
            writer.WriteNumberValue(MaxInstanceCount);
            writer.WritePropertyName("scaleIncrement"u8);
            writer.WriteNumberValue(ScaleIncrement);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        PartitionInstanceCountScalingMechanism IJsonModel<PartitionInstanceCountScalingMechanism>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartitionInstanceCountScalingMechanism(document.RootElement, options);
        }

        internal static PartitionInstanceCountScalingMechanism DeserializePartitionInstanceCountScalingMechanism(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minInstanceCount = default;
            int maxInstanceCount = default;
            int scaleIncrement = default;
            ServiceScalingMechanismKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minInstanceCount"u8))
                {
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxInstanceCount"u8))
                {
                    maxInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleIncrement"u8))
                {
                    scaleIncrement = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingMechanismKind(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartitionInstanceCountScalingMechanism(kind, serializedAdditionalRawData, minInstanceCount, maxInstanceCount, scaleIncrement);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(MinInstanceCount))
            {
                builder.Append("  minInstanceCount:");
                builder.AppendLine($" {MinInstanceCount}");
            }

            if (Optional.IsDefined(MaxInstanceCount))
            {
                builder.Append("  maxInstanceCount:");
                builder.AppendLine($" {MaxInstanceCount}");
            }

            if (Optional.IsDefined(ScaleIncrement))
            {
                builder.Append("  scaleIncrement:");
                builder.AppendLine($" {ScaleIncrement}");
            }

            if (Optional.IsDefined(Kind))
            {
                builder.Append("  kind:");
                builder.AppendLine($" '{Kind.ToString()}'");
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

        BinaryData IPersistableModel<PartitionInstanceCountScalingMechanism>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support '{options.Format}' format.");
            }
        }

        PartitionInstanceCountScalingMechanism IPersistableModel<PartitionInstanceCountScalingMechanism>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartitionInstanceCountScalingMechanism>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartitionInstanceCountScalingMechanism(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(PartitionInstanceCountScalingMechanism)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartitionInstanceCountScalingMechanism>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
