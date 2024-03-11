// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class PowerQuerySink : IUtf8JsonSerializable, IJsonModel<PowerQuerySink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PowerQuerySink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PowerQuerySink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PowerQuerySink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Script))
            {
                writer.WritePropertyName("script"u8);
                writer.WriteStringValue(Script);
            }
            if (Optional.IsDefined(SchemaLinkedService))
            {
                writer.WritePropertyName("schemaLinkedService"u8);
                JsonSerializer.Serialize(writer, SchemaLinkedService);
            }
            if (Optional.IsDefined(RejectedDataLinkedService))
            {
                writer.WritePropertyName("rejectedDataLinkedService"u8);
                JsonSerializer.Serialize(writer, RejectedDataLinkedService);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Dataset))
            {
                writer.WritePropertyName("dataset"u8);
                writer.WriteObjectValue(Dataset);
            }
            if (Optional.IsDefined(LinkedService))
            {
                writer.WritePropertyName("linkedService"u8);
                JsonSerializer.Serialize(writer, LinkedService);
            }
            if (Optional.IsDefined(Flowlet))
            {
                writer.WritePropertyName("flowlet"u8);
                writer.WriteObjectValue(Flowlet);
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

        PowerQuerySink IJsonModel<PowerQuerySink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PowerQuerySink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePowerQuerySink(document.RootElement, options);
        }

        internal static PowerQuerySink DeserializePowerQuerySink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string script = default;
            DataFactoryLinkedServiceReference schemaLinkedService = default;
            DataFactoryLinkedServiceReference rejectedDataLinkedService = default;
            string name = default;
            string description = default;
            DatasetReference dataset = default;
            DataFactoryLinkedServiceReference linkedService = default;
            DataFlowReference flowlet = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("script"u8))
                {
                    script = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    schemaLinkedService = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("rejectedDataLinkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rejectedDataLinkedService = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataset = DatasetReference.DeserializeDatasetReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("linkedService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linkedService = JsonSerializer.Deserialize<DataFactoryLinkedServiceReference>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("flowlet"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    flowlet = DataFlowReference.DeserializeDataFlowReference(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PowerQuerySink(
                name,
                description,
                dataset,
                linkedService,
                flowlet,
                serializedAdditionalRawData,
                schemaLinkedService,
                rejectedDataLinkedService,
                script);
        }

        BinaryData IPersistableModel<PowerQuerySink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PowerQuerySink)} does not support '{options.Format}' format.");
            }
        }

        PowerQuerySink IPersistableModel<PowerQuerySink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PowerQuerySink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePowerQuerySink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PowerQuerySink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PowerQuerySink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
