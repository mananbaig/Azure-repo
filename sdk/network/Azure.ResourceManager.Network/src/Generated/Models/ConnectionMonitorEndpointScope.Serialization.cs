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

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorEndpointScope : IUtf8JsonSerializable, IJsonModel<ConnectionMonitorEndpointScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConnectionMonitorEndpointScope>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConnectionMonitorEndpointScope>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpointScope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Include))
            {
                writer.WritePropertyName("include"u8);
                writer.WriteStartArray();
                foreach (var item in Include)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Exclude))
            {
                writer.WritePropertyName("exclude"u8);
                writer.WriteStartArray();
                foreach (var item in Exclude)
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

        ConnectionMonitorEndpointScope IJsonModel<ConnectionMonitorEndpointScope>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpointScope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConnectionMonitorEndpointScope(document.RootElement, options);
        }

        internal static ConnectionMonitorEndpointScope DeserializeConnectionMonitorEndpointScope(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ConnectionMonitorEndpointScopeItem>> include = default;
            Optional<IList<ConnectionMonitorEndpointScopeItem>> exclude = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("include"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionMonitorEndpointScopeItem> array = new List<ConnectionMonitorEndpointScopeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorEndpointScopeItem.DeserializeConnectionMonitorEndpointScopeItem(item));
                    }
                    include = array;
                    continue;
                }
                if (property.NameEquals("exclude"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConnectionMonitorEndpointScopeItem> array = new List<ConnectionMonitorEndpointScopeItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorEndpointScopeItem.DeserializeConnectionMonitorEndpointScopeItem(item));
                    }
                    exclude = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConnectionMonitorEndpointScope(Optional.ToList(include), Optional.ToList(exclude), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConnectionMonitorEndpointScope>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpointScope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{options.Format}' format.");
            }
        }

        ConnectionMonitorEndpointScope IPersistableModel<ConnectionMonitorEndpointScope>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConnectionMonitorEndpointScope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConnectionMonitorEndpointScope(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ConnectionMonitorEndpointScope)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConnectionMonitorEndpointScope>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
