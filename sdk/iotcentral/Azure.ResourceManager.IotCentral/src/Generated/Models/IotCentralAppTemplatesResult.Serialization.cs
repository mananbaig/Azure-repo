// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotCentral.Models
{
    internal partial class IotCentralAppTemplatesResult : IUtf8JsonSerializable, IJsonModel<IotCentralAppTemplatesResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotCentralAppTemplatesResult>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotCentralAppTemplatesResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplatesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplatesResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item, options);
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

        IotCentralAppTemplatesResult IJsonModel<IotCentralAppTemplatesResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplatesResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotCentralAppTemplatesResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotCentralAppTemplatesResult(document.RootElement, options);
        }

        internal static IotCentralAppTemplatesResult DeserializeIotCentralAppTemplatesResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string nextLink = default;
            IReadOnlyList<IotCentralAppTemplate> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IotCentralAppTemplate> array = new List<IotCentralAppTemplate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IotCentralAppTemplate.DeserializeIotCentralAppTemplate(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotCentralAppTemplatesResult(nextLink, value ?? new ChangeTrackingList<IotCentralAppTemplate>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotCentralAppTemplatesResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplatesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotCentralAppTemplatesResult)} does not support writing '{options.Format}' format.");
            }
        }

        IotCentralAppTemplatesResult IPersistableModel<IotCentralAppTemplatesResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotCentralAppTemplatesResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotCentralAppTemplatesResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotCentralAppTemplatesResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotCentralAppTemplatesResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
