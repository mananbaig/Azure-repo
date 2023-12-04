// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class DataCollectionRuleBcdrFailoverConfigurationSpec : IUtf8JsonSerializable, IJsonModel<DataCollectionRuleBcdrFailoverConfigurationSpec>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataCollectionRuleBcdrFailoverConfigurationSpec>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataCollectionRuleBcdrFailoverConfigurationSpec>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataCollectionRuleBcdrFailoverConfigurationSpec)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveLocation))
            {
                writer.WritePropertyName("activeLocation"u8);
                writer.WriteStringValue(ActiveLocation);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        DataCollectionRuleBcdrFailoverConfigurationSpec IJsonModel<DataCollectionRuleBcdrFailoverConfigurationSpec>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(DataCollectionRuleBcdrFailoverConfigurationSpec)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataCollectionRuleBcdrFailoverConfigurationSpec(document.RootElement, options);
        }

        internal static DataCollectionRuleBcdrFailoverConfigurationSpec DeserializeDataCollectionRuleBcdrFailoverConfigurationSpec(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> activeLocation = default;
            Optional<IReadOnlyList<DataCollectionRuleBcdrLocationSpec>> locations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeLocation"u8))
                {
                    activeLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataCollectionRuleBcdrLocationSpec> array = new List<DataCollectionRuleBcdrLocationSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataCollectionRuleBcdrLocationSpec.DeserializeDataCollectionRuleBcdrLocationSpec(item));
                    }
                    locations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataCollectionRuleBcdrFailoverConfigurationSpec(activeLocation.Value, Optional.ToList(locations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(DataCollectionRuleBcdrFailoverConfigurationSpec)} does not support '{options.Format}' format.");
            }
        }

        DataCollectionRuleBcdrFailoverConfigurationSpec IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataCollectionRuleBcdrFailoverConfigurationSpec(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(DataCollectionRuleBcdrFailoverConfigurationSpec)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataCollectionRuleBcdrFailoverConfigurationSpec>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
