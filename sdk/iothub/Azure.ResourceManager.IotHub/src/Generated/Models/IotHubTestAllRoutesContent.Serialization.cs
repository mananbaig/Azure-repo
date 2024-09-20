// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubTestAllRoutesContent : IUtf8JsonSerializable, IJsonModel<IotHubTestAllRoutesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotHubTestAllRoutesContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<IotHubTestAllRoutesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestAllRoutesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubTestAllRoutesContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RoutingSource))
            {
                writer.WritePropertyName("routingSource"u8);
                writer.WriteStringValue(RoutingSource.Value.ToString());
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteObjectValue(Message, options);
            }
            if (Optional.IsDefined(Twin))
            {
                writer.WritePropertyName("twin"u8);
                writer.WriteObjectValue(Twin, options);
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

        IotHubTestAllRoutesContent IJsonModel<IotHubTestAllRoutesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestAllRoutesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(IotHubTestAllRoutesContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotHubTestAllRoutesContent(document.RootElement, options);
        }

        internal static IotHubTestAllRoutesContent DeserializeIotHubTestAllRoutesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IotHubRoutingSource? routingSource = default;
            RoutingMessage message = default;
            RoutingTwin twin = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("routingSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routingSource = new IotHubRoutingSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    message = RoutingMessage.DeserializeRoutingMessage(property.Value, options);
                    continue;
                }
                if (property.NameEquals("twin"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    twin = RoutingTwin.DeserializeRoutingTwin(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new IotHubTestAllRoutesContent(routingSource, message, twin, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<IotHubTestAllRoutesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestAllRoutesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(IotHubTestAllRoutesContent)} does not support writing '{options.Format}' format.");
            }
        }

        IotHubTestAllRoutesContent IPersistableModel<IotHubTestAllRoutesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<IotHubTestAllRoutesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeIotHubTestAllRoutesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(IotHubTestAllRoutesContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<IotHubTestAllRoutesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
