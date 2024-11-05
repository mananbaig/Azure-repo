// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerGroupInstanceView : IUtf8JsonSerializable, IJsonModel<ContainerGroupInstanceView>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerGroupInstanceView>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerGroupInstanceView>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupInstanceView)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
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

        ContainerGroupInstanceView IJsonModel<ContainerGroupInstanceView>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerGroupInstanceView)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerGroupInstanceView(document.RootElement, options);
        }

        internal static ContainerGroupInstanceView DeserializeContainerGroupInstanceView(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerEvent> events = default;
            string state = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("events"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContainerEvent> array = new List<ContainerEvent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerEvent.DeserializeContainerEvent(item, options));
                    }
                    events = array;
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerGroupInstanceView(events ?? new ChangeTrackingList<ContainerEvent>(), state, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerGroupInstanceView>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupInstanceView)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerGroupInstanceView IPersistableModel<ContainerGroupInstanceView>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerGroupInstanceView>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerGroupInstanceView(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerGroupInstanceView)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerGroupInstanceView>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
