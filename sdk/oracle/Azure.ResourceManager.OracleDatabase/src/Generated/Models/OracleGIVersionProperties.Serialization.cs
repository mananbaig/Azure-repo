// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OracleDatabase.Models
{
    internal partial class OracleGIVersionProperties : IUtf8JsonSerializable, IJsonModel<OracleGIVersionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OracleGIVersionProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OracleGIVersionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleGIVersionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OracleGIVersionProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
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

        OracleGIVersionProperties IJsonModel<OracleGIVersionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleGIVersionProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OracleGIVersionProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOracleGIVersionProperties(document.RootElement, options);
        }

        internal static OracleGIVersionProperties DeserializeOracleGIVersionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string version = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OracleGIVersionProperties(version, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<OracleGIVersionProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleGIVersionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OracleGIVersionProperties)} does not support writing '{options.Format}' format.");
            }
        }

        OracleGIVersionProperties IPersistableModel<OracleGIVersionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OracleGIVersionProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOracleGIVersionProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OracleGIVersionProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OracleGIVersionProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
