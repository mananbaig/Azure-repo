// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ContainerRegistry;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    public partial class ContainerRegistryBaseImageTriggerUpdateContent : IUtf8JsonSerializable, IJsonModel<ContainerRegistryBaseImageTriggerUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerRegistryBaseImageTriggerUpdateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerRegistryBaseImageTriggerUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryBaseImageTriggerUpdateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(BaseImageTriggerType))
            {
                writer.WritePropertyName("baseImageTriggerType"u8);
                writer.WriteStringValue(BaseImageTriggerType.Value.ToString());
            }
            if (Optional.IsDefined(UpdateTriggerEndpoint))
            {
                writer.WritePropertyName("updateTriggerEndpoint"u8);
                writer.WriteStringValue(UpdateTriggerEndpoint);
            }
            if (Optional.IsDefined(UpdateTriggerPayloadType))
            {
                writer.WritePropertyName("updateTriggerPayloadType"u8);
                writer.WriteStringValue(UpdateTriggerPayloadType.Value.ToString());
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        ContainerRegistryBaseImageTriggerUpdateContent IJsonModel<ContainerRegistryBaseImageTriggerUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerRegistryBaseImageTriggerUpdateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerRegistryBaseImageTriggerUpdateContent(document.RootElement, options);
        }

        internal static ContainerRegistryBaseImageTriggerUpdateContent DeserializeContainerRegistryBaseImageTriggerUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ContainerRegistryBaseImageTriggerType? baseImageTriggerType = default;
            string updateTriggerEndpoint = default;
            ContainerRegistryUpdateTriggerPayloadType? updateTriggerPayloadType = default;
            ContainerRegistryTriggerStatus? status = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseImageTriggerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    baseImageTriggerType = new ContainerRegistryBaseImageTriggerType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("updateTriggerEndpoint"u8))
                {
                    updateTriggerEndpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("updateTriggerPayloadType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    updateTriggerPayloadType = new ContainerRegistryUpdateTriggerPayloadType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ContainerRegistryTriggerStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerRegistryBaseImageTriggerUpdateContent(
                baseImageTriggerType,
                updateTriggerEndpoint,
                updateTriggerPayloadType,
                status,
                name,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryBaseImageTriggerUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        ContainerRegistryBaseImageTriggerUpdateContent IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerRegistryBaseImageTriggerUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerRegistryBaseImageTriggerUpdateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerRegistryBaseImageTriggerUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
