// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceNodePoolRollingStartedEventDataConverter))]
    public partial class ContainerServiceNodePoolRollingStartedEventData : IUtf8JsonSerializable, IJsonModel<ContainerServiceNodePoolRollingStartedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceNodePoolRollingStartedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerServiceNodePoolRollingStartedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerServiceNodePoolRollingStartedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(NodePoolName))
            {
                writer.WritePropertyName("nodePoolName"u8);
                writer.WriteStringValue(NodePoolName);
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

        ContainerServiceNodePoolRollingStartedEventData IJsonModel<ContainerServiceNodePoolRollingStartedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ContainerServiceNodePoolRollingStartedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceNodePoolRollingStartedEventData(document.RootElement, options);
        }

        internal static ContainerServiceNodePoolRollingStartedEventData DeserializeContainerServiceNodePoolRollingStartedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nodePoolName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodePoolName"u8))
                {
                    nodePoolName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerServiceNodePoolRollingStartedEventData(nodePoolName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerServiceNodePoolRollingStartedEventData)} does not support '{options.Format}' format.");
            }
        }

        ContainerServiceNodePoolRollingStartedEventData IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerServiceNodePoolRollingStartedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ContainerServiceNodePoolRollingStartedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceNodePoolRollingStartedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class ContainerServiceNodePoolRollingStartedEventDataConverter : JsonConverter<ContainerServiceNodePoolRollingStartedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceNodePoolRollingStartedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ContainerServiceNodePoolRollingStartedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceNodePoolRollingStartedEventData(document.RootElement);
            }
        }
    }
}
