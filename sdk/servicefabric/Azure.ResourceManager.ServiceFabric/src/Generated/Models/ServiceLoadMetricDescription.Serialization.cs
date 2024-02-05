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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceLoadMetricDescription : IUtf8JsonSerializable, IJsonModel<ServiceLoadMetricDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceLoadMetricDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceLoadMetricDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadMetricDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceLoadMetricDescription)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Weight))
            {
                writer.WritePropertyName("weight"u8);
                writer.WriteStringValue(Weight.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryDefaultLoad))
            {
                writer.WritePropertyName("primaryDefaultLoad"u8);
                writer.WriteNumberValue(PrimaryDefaultLoad.Value);
            }
            if (Optional.IsDefined(SecondaryDefaultLoad))
            {
                writer.WritePropertyName("secondaryDefaultLoad"u8);
                writer.WriteNumberValue(SecondaryDefaultLoad.Value);
            }
            if (Optional.IsDefined(DefaultLoad))
            {
                writer.WritePropertyName("defaultLoad"u8);
                writer.WriteNumberValue(DefaultLoad.Value);
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

        ServiceLoadMetricDescription IJsonModel<ServiceLoadMetricDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadMetricDescription>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceLoadMetricDescription)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceLoadMetricDescription(document.RootElement, options);
        }

        internal static ServiceLoadMetricDescription DeserializeServiceLoadMetricDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<ServiceLoadMetricWeight> weight = default;
            Optional<int> primaryDefaultLoad = default;
            Optional<int> secondaryDefaultLoad = default;
            Optional<int> defaultLoad = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("weight"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weight = new ServiceLoadMetricWeight(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryDefaultLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryDefaultLoad = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("secondaryDefaultLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryDefaultLoad = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultLoad"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultLoad = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceLoadMetricDescription(name, Optional.ToNullable(weight), Optional.ToNullable(primaryDefaultLoad), Optional.ToNullable(secondaryDefaultLoad), Optional.ToNullable(defaultLoad), serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("{");

            if (Optional.IsDefined(Name))
            {
                builder.Append("  name:");
                builder.AppendLine($" '{Name}'");
            }

            if (Optional.IsDefined(Weight))
            {
                builder.Append("  weight:");
                builder.AppendLine($" '{Weight.ToString()}'");
            }

            if (Optional.IsDefined(PrimaryDefaultLoad))
            {
                builder.Append("  primaryDefaultLoad:");
                builder.AppendLine($" {PrimaryDefaultLoad.Value}");
            }

            if (Optional.IsDefined(SecondaryDefaultLoad))
            {
                builder.Append("  secondaryDefaultLoad:");
                builder.AppendLine($" {SecondaryDefaultLoad.Value}");
            }

            if (Optional.IsDefined(DefaultLoad))
            {
                builder.Append("  defaultLoad:");
                builder.AppendLine($" {DefaultLoad.Value}");
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

        BinaryData IPersistableModel<ServiceLoadMetricDescription>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadMetricDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "B":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServiceLoadMetricDescription)} does not support '{options.Format}' format.");
            }
        }

        ServiceLoadMetricDescription IPersistableModel<ServiceLoadMetricDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceLoadMetricDescription>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceLoadMetricDescription(document.RootElement, options);
                    }
                case "B":
                    throw new InvalidOperationException("Bicep deserialization is not supported for this type.");
                default:
                    throw new FormatException($"The model {nameof(ServiceLoadMetricDescription)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceLoadMetricDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
