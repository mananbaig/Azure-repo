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

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    internal partial class RequestDocumentIngress : IUtf8JsonSerializable, IJsonModel<RequestDocumentIngress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestDocumentIngress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequestDocumentIngress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestDocumentIngress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RequestDocumentIngress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("Name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("Url"u8);
                writer.WriteStringValue(Url);
            }
            if (Optional.IsDefined(ResponseCode))
            {
                writer.WritePropertyName("ResponseCode"u8);
                writer.WriteStringValue(ResponseCode);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("Duration"u8);
                writer.WriteStringValue(Duration);
            }
            if (Optional.IsDefined(DocumentType))
            {
                writer.WritePropertyName("DocumentType"u8);
                writer.WriteStringValue(DocumentType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DocumentStreamIds))
            {
                writer.WritePropertyName("DocumentStreamIds"u8);
                writer.WriteStartArray();
                foreach (var item in DocumentStreamIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("Properties"u8);
                writer.WriteStartArray();
                foreach (var item in Properties)
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

        RequestDocumentIngress IJsonModel<RequestDocumentIngress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestDocumentIngress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RequestDocumentIngress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestDocumentIngress(document.RootElement, options);
        }

        internal static RequestDocumentIngress DeserializeRequestDocumentIngress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> url = default;
            Optional<string> responseCode = default;
            Optional<string> duration = default;
            Optional<DocumentIngressDocumentType> documentType = default;
            Optional<IList<string>> documentStreamIds = default;
            Optional<IList<KeyValuePairString>> properties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ResponseCode"u8))
                {
                    responseCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Duration"u8))
                {
                    duration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("DocumentType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    documentType = new DocumentIngressDocumentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("DocumentStreamIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    documentStreamIds = array;
                    continue;
                }
                if (property.NameEquals("Properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KeyValuePairString> array = new List<KeyValuePairString>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KeyValuePairString.DeserializeKeyValuePairString(item));
                    }
                    properties = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestDocumentIngress(Optional.ToNullable(documentType), Optional.ToList(documentStreamIds), Optional.ToList(properties), serializedAdditionalRawData, name.Value, url.Value, responseCode.Value, duration.Value);
        }

        BinaryData IPersistableModel<RequestDocumentIngress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestDocumentIngress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RequestDocumentIngress)} does not support '{options.Format}' format.");
            }
        }

        RequestDocumentIngress IPersistableModel<RequestDocumentIngress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestDocumentIngress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequestDocumentIngress(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RequestDocumentIngress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestDocumentIngress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
