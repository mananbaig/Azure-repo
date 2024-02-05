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

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    public partial class ProtectedItemDynamicMemoryConfig : IUtf8JsonSerializable, IJsonModel<ProtectedItemDynamicMemoryConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProtectedItemDynamicMemoryConfig>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProtectedItemDynamicMemoryConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maximumMemoryInMegaBytes"u8);
            writer.WriteNumberValue(MaximumMemoryInMegaBytes);
            writer.WritePropertyName("minimumMemoryInMegaBytes"u8);
            writer.WriteNumberValue(MinimumMemoryInMegaBytes);
            writer.WritePropertyName("targetMemoryBufferPercentage"u8);
            writer.WriteNumberValue(TargetMemoryBufferPercentage);
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

        ProtectedItemDynamicMemoryConfig IJsonModel<ProtectedItemDynamicMemoryConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProtectedItemDynamicMemoryConfig(document.RootElement, options);
        }

        internal static ProtectedItemDynamicMemoryConfig DeserializeProtectedItemDynamicMemoryConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            long maximumMemoryInMegaBytes = default;
            long minimumMemoryInMegaBytes = default;
            int targetMemoryBufferPercentage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maximumMemoryInMegaBytes"u8))
                {
                    maximumMemoryInMegaBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimumMemoryInMegaBytes"u8))
                {
                    minimumMemoryInMegaBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("targetMemoryBufferPercentage"u8))
                {
                    targetMemoryBufferPercentage = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProtectedItemDynamicMemoryConfig(maximumMemoryInMegaBytes, minimumMemoryInMegaBytes, targetMemoryBufferPercentage, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(MaximumMemoryInMegaBytes))
            {
                builder.Append("  maximumMemoryInMegaBytes:");
                builder.AppendLine($" '{MaximumMemoryInMegaBytes.ToString()}'");
            }

            if (Optional.IsDefined(MinimumMemoryInMegaBytes))
            {
                builder.Append("  minimumMemoryInMegaBytes:");
                builder.AppendLine($" '{MinimumMemoryInMegaBytes.ToString()}'");
            }

            if (Optional.IsDefined(TargetMemoryBufferPercentage))
            {
                builder.Append("  targetMemoryBufferPercentage:");
                builder.AppendLine($" {TargetMemoryBufferPercentage}");
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

        BinaryData IPersistableModel<ProtectedItemDynamicMemoryConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }
        }

        ProtectedItemDynamicMemoryConfig IPersistableModel<ProtectedItemDynamicMemoryConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProtectedItemDynamicMemoryConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProtectedItemDynamicMemoryConfig(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ProtectedItemDynamicMemoryConfig)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProtectedItemDynamicMemoryConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
