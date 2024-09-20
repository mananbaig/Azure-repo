// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    public partial class ConnectorMappingFormat : IUtf8JsonSerializable, IJsonModel<ConnectorMappingFormat>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectorMappingFormat>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConnectorMappingFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorMappingFormat)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("formatType"u8);
            writer.WriteStringValue(FormatType.ToString());
            if (Optional.IsDefined(ColumnDelimiter))
            {
                writer.WritePropertyName("columnDelimiter"u8);
                writer.WriteStringValue(ColumnDelimiter);
            }
            if (Optional.IsDefined(AcceptLanguage))
            {
                writer.WritePropertyName("acceptLanguage"u8);
                writer.WriteStringValue(AcceptLanguage);
            }
            if (Optional.IsDefined(QuoteCharacter))
            {
                writer.WritePropertyName("quoteCharacter"u8);
                writer.WriteStringValue(QuoteCharacter);
            }
            if (Optional.IsDefined(QuoteEscapeCharacter))
            {
                writer.WritePropertyName("quoteEscapeCharacter"u8);
                writer.WriteStringValue(QuoteEscapeCharacter);
            }
            if (Optional.IsDefined(ArraySeparator))
            {
                writer.WritePropertyName("arraySeparator"u8);
                writer.WriteStringValue(ArraySeparator);
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

        ConnectorMappingFormat IJsonModel<ConnectorMappingFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConnectorMappingFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectorMappingFormat(document.RootElement, options);
        }

        internal static ConnectorMappingFormat DeserializeConnectorMappingFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FormatType formatType = default;
            string columnDelimiter = default;
            string acceptLanguage = default;
            string quoteCharacter = default;
            string quoteEscapeCharacter = default;
            string arraySeparator = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("formatType"u8))
                {
                    formatType = new FormatType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("columnDelimiter"u8))
                {
                    columnDelimiter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("acceptLanguage"u8))
                {
                    acceptLanguage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quoteCharacter"u8))
                {
                    quoteCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("quoteEscapeCharacter"u8))
                {
                    quoteEscapeCharacter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("arraySeparator"u8))
                {
                    arraySeparator = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConnectorMappingFormat(
                formatType,
                columnDelimiter,
                acceptLanguage,
                quoteCharacter,
                quoteEscapeCharacter,
                arraySeparator,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectorMappingFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConnectorMappingFormat)} does not support writing '{options.Format}' format.");
            }
        }

        ConnectorMappingFormat IPersistableModel<ConnectorMappingFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectorMappingFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectorMappingFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConnectorMappingFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectorMappingFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
