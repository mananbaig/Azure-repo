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

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class RunQueryOrderBy : IUtf8JsonSerializable, IJsonModel<RunQueryOrderBy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RunQueryOrderBy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RunQueryOrderBy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RunQueryOrderBy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("orderBy"u8);
            writer.WriteStringValue(OrderBy.ToString());
            writer.WritePropertyName("order"u8);
            writer.WriteStringValue(Order.ToString());
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

        RunQueryOrderBy IJsonModel<RunQueryOrderBy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RunQueryOrderBy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRunQueryOrderBy(document.RootElement, options);
        }

        internal static RunQueryOrderBy DeserializeRunQueryOrderBy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RunQueryOrderByField orderBy = default;
            RunQueryOrder order = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("orderBy"u8))
                {
                    orderBy = new RunQueryOrderByField(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("order"u8))
                {
                    order = new RunQueryOrder(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RunQueryOrderBy(orderBy, order, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RunQueryOrderBy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RunQueryOrderBy)} does not support '{options.Format}' format.");
            }
        }

        RunQueryOrderBy IPersistableModel<RunQueryOrderBy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RunQueryOrderBy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRunQueryOrderBy(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RunQueryOrderBy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RunQueryOrderBy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
