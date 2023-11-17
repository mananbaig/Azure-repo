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

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ResourceHttpRequest : IUtf8JsonSerializable, IJsonModel<ResourceHttpRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceHttpRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceHttpRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ResourceHttpRequest>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ResourceHttpRequest>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ClientRequestId))
            {
                writer.WritePropertyName("clientRequestId"u8);
                writer.WriteStringValue(ClientRequestId);
            }
            if (Optional.IsDefined(ClientIpAddress))
            {
                writer.WritePropertyName("clientIpAddress"u8);
                writer.WriteStringValue(ClientIpAddress);
            }
            if (Optional.IsDefined(MethodString))
            {
                writer.WritePropertyName("method"u8);
                writer.WriteStringValue(MethodString);
            }
            if (Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        ResourceHttpRequest IJsonModel<ResourceHttpRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceHttpRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHttpRequest(document.RootElement, options);
        }

        internal static ResourceHttpRequest DeserializeResourceHttpRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clientRequestId = default;
            Optional<string> clientIpAddress = default;
            Optional<string> method = default;
            Optional<string> url = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientIpAddress"u8))
                {
                    clientIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("method"u8))
                {
                    method = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceHttpRequest(clientRequestId.Value, clientIpAddress.Value, method.Value, url.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceHttpRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceHttpRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ResourceHttpRequest IPersistableModel<ResourceHttpRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceHttpRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeResourceHttpRequest(document.RootElement, options);
        }

        string IPersistableModel<ResourceHttpRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
