// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class ResourceInstanceViewStatus : IUtf8JsonSerializable, IJsonModel<ResourceInstanceViewStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceInstanceViewStatus>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceInstanceViewStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceInstanceViewStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceInstanceViewStatus)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Code != null)
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (options.Format != "W" && DisplayStatus != null)
            {
                writer.WritePropertyName("displayStatus"u8);
                writer.WriteStringValue(DisplayStatus);
            }
            if (options.Format != "W" && Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && Time.HasValue)
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            if (Level.HasValue)
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
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

        ResourceInstanceViewStatus IJsonModel<ResourceInstanceViewStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceInstanceViewStatus>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceInstanceViewStatus)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceInstanceViewStatus(document.RootElement, options);
        }

        internal static ResourceInstanceViewStatus DeserializeResourceInstanceViewStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> displayStatus = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> time = default;
            Optional<ComputeStatusLevelType> level = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayStatus"u8))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = property.Value.GetString().ToComputeStatusLevelType();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceInstanceViewStatus(code.Value, displayStatus.Value, message.Value, Optional.ToNullable(time), Optional.ToNullable(level), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceInstanceViewStatus>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceInstanceViewStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceInstanceViewStatus)} does not support '{options.Format}' format.");
            }
        }

        ResourceInstanceViewStatus IPersistableModel<ResourceInstanceViewStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceInstanceViewStatus>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceInstanceViewStatus(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceInstanceViewStatus)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceInstanceViewStatus>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
