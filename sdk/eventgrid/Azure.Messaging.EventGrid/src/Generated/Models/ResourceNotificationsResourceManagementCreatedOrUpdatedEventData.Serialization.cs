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
    [JsonConverter(typeof(ResourceNotificationsResourceManagementCreatedOrUpdatedEventDataConverter))]
    public partial class ResourceNotificationsResourceManagementCreatedOrUpdatedEventData : IUtf8JsonSerializable, IJsonModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ResourceNotificationsResourceManagementCreatedOrUpdatedEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceDetails))
            {
                writer.WritePropertyName("resourceInfo"u8);
                writer.WriteObjectValue(ResourceDetails);
            }
            if (Optional.IsDefined(OperationalDetails))
            {
                writer.WritePropertyName("operationalInfo"u8);
                writer.WriteObjectValue(OperationalDetails);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
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

        ResourceNotificationsResourceManagementCreatedOrUpdatedEventData IJsonModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ResourceNotificationsResourceManagementCreatedOrUpdatedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceNotificationsResourceManagementCreatedOrUpdatedEventData(document.RootElement, options);
        }

        internal static ResourceNotificationsResourceManagementCreatedOrUpdatedEventData DeserializeResourceNotificationsResourceManagementCreatedOrUpdatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceNotificationsResourceUpdatedDetails> resourceInfo = default;
            Optional<ResourceNotificationsOperationalDetails> operationalInfo = default;
            Optional<string> apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceInfo = ResourceNotificationsResourceUpdatedDetails.DeserializeResourceNotificationsResourceUpdatedDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("operationalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operationalInfo = ResourceNotificationsOperationalDetails.DeserializeResourceNotificationsOperationalDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceNotificationsResourceManagementCreatedOrUpdatedEventData(resourceInfo.Value, operationalInfo.Value, apiVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ResourceNotificationsResourceManagementCreatedOrUpdatedEventData)} does not support '{options.Format}' format.");
            }
        }

        ResourceNotificationsResourceManagementCreatedOrUpdatedEventData IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeResourceNotificationsResourceManagementCreatedOrUpdatedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ResourceNotificationsResourceManagementCreatedOrUpdatedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class ResourceNotificationsResourceManagementCreatedOrUpdatedEventDataConverter : JsonConverter<ResourceNotificationsResourceManagementCreatedOrUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceNotificationsResourceManagementCreatedOrUpdatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ResourceNotificationsResourceManagementCreatedOrUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceNotificationsResourceManagementCreatedOrUpdatedEventData(document.RootElement);
            }
        }
    }
}
