// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ResourceNotificationsResourceDeletedEventData : IUtf8JsonSerializable, IJsonModel<ResourceNotificationsResourceDeletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceNotificationsResourceDeletedEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceNotificationsResourceDeletedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsResourceDeletedEventData)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("resourceInfo"u8);
            writer.WriteObjectValue(ResourceDetails, options);
            writer.WritePropertyName("operationalInfo"u8);
            writer.WriteObjectValue(OperationalDetails, options);
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

        ResourceNotificationsResourceDeletedEventData IJsonModel<ResourceNotificationsResourceDeletedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsResourceDeletedEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceNotificationsResourceDeletedEventData(document.RootElement, options);
        }

        internal static ResourceNotificationsResourceDeletedEventData DeserializeResourceNotificationsResourceDeletedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceNotificationsResourceDeletedDetails resourceInfo = default;
            ResourceNotificationsOperationalDetails operationalInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceInfo"u8))
                {
                    resourceInfo = ResourceNotificationsResourceDeletedDetails.DeserializeResourceNotificationsResourceDeletedDetails(property.Value, options);
                    continue;
                }
                if (property.NameEquals("operationalInfo"u8))
                {
                    operationalInfo = ResourceNotificationsOperationalDetails.DeserializeResourceNotificationsOperationalDetails(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceNotificationsResourceDeletedEventData(resourceInfo, operationalInfo, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceNotificationsResourceDeletedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ResourceNotificationsResourceDeletedEventData)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceNotificationsResourceDeletedEventData IPersistableModel<ResourceNotificationsResourceDeletedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceDeletedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceNotificationsResourceDeletedEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceNotificationsResourceDeletedEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceNotificationsResourceDeletedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static ResourceNotificationsResourceDeletedEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeResourceNotificationsResourceDeletedEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
