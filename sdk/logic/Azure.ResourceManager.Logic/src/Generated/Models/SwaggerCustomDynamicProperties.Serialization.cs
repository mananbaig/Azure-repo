// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class SwaggerCustomDynamicProperties : IUtf8JsonSerializable, IJsonModel<SwaggerCustomDynamicProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SwaggerCustomDynamicProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SwaggerCustomDynamicProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(OperationId))
            {
                writer.WritePropertyName("operationId"u8);
                writer.WriteStringValue(OperationId);
            }
            if (Optional.IsDefined(ValuePath))
            {
                writer.WritePropertyName("valuePath"u8);
                writer.WriteStringValue(ValuePath);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value, options);
                }
                writer.WriteEndObject();
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
        }

        SwaggerCustomDynamicProperties IJsonModel<SwaggerCustomDynamicProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SwaggerCustomDynamicProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSwaggerCustomDynamicProperties(document.RootElement, options);
        }

        internal static SwaggerCustomDynamicProperties DeserializeSwaggerCustomDynamicProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string operationId = default;
            string valuePath = default;
            IDictionary<string, SwaggerCustomDynamicProperties> parameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationId"u8))
                {
                    operationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valuePath"u8))
                {
                    valuePath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, SwaggerCustomDynamicProperties> dictionary = new Dictionary<string, SwaggerCustomDynamicProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DeserializeSwaggerCustomDynamicProperties(property0.Value, options));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SwaggerCustomDynamicProperties(operationId, valuePath, parameters ?? new ChangeTrackingDictionary<string, SwaggerCustomDynamicProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SwaggerCustomDynamicProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicProperties)} does not support writing '{options.Format}' format.");
            }
        }

        SwaggerCustomDynamicProperties IPersistableModel<SwaggerCustomDynamicProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SwaggerCustomDynamicProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSwaggerCustomDynamicProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SwaggerCustomDynamicProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SwaggerCustomDynamicProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
