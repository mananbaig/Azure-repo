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

namespace Azure.ResourceManager.EventGrid.Models
{
    internal partial class UnknownStaticRoutingEnrichment : IUtf8JsonSerializable, IJsonModel<StaticRoutingEnrichment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticRoutingEnrichment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StaticRoutingEnrichment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticRoutingEnrichment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticRoutingEnrichment)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        StaticRoutingEnrichment IJsonModel<StaticRoutingEnrichment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticRoutingEnrichment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticRoutingEnrichment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticRoutingEnrichment(document.RootElement, options);
        }

        internal static UnknownStaticRoutingEnrichment DeserializeUnknownStaticRoutingEnrichment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string key = default;
            StaticRoutingEnrichmentType valueType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueType"u8))
                {
                    valueType = new StaticRoutingEnrichmentType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UnknownStaticRoutingEnrichment(key, valueType, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Key), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  key: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Key))
                {
                    builder.Append("  key: ");
                    if (Key.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Key}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Key}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ValueType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  valueType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  valueType: ");
                builder.AppendLine($"'{ValueType.ToString()}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StaticRoutingEnrichment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticRoutingEnrichment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StaticRoutingEnrichment)} does not support writing '{options.Format}' format.");
            }
        }

        StaticRoutingEnrichment IPersistableModel<StaticRoutingEnrichment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticRoutingEnrichment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticRoutingEnrichment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticRoutingEnrichment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticRoutingEnrichment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
