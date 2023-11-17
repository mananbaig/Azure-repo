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
    [JsonConverter(typeof(ResourceNotificationsResourceManagementDeletedEventDataConverter))]
    public partial class ResourceNotificationsResourceManagementDeletedEventData : IUtf8JsonSerializable, IJsonModel<ResourceNotificationsResourceManagementDeletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceNotificationsResourceManagementDeletedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceNotificationsResourceManagementDeletedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ResourceNotificationsResourceManagementDeletedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ResourceNotificationsResourceManagementDeletedEventData>)} interface");
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

        ResourceNotificationsResourceManagementDeletedEventData IJsonModel<ResourceNotificationsResourceManagementDeletedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsResourceManagementDeletedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceNotificationsResourceManagementDeletedEventData(document.RootElement, options);
        }

        internal static ResourceNotificationsResourceManagementDeletedEventData DeserializeResourceNotificationsResourceManagementDeletedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceNotificationsResourceDeletedDetails> resourceInfo = default;
            Optional<ResourceNotificationsOperationalDetails> operationalInfo = default;
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
                    resourceInfo = ResourceNotificationsResourceDeletedDetails.DeserializeResourceNotificationsResourceDeletedDetails(property.Value);
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceNotificationsResourceManagementDeletedEventData(resourceInfo.Value, operationalInfo.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceNotificationsResourceManagementDeletedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsResourceManagementDeletedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ResourceNotificationsResourceManagementDeletedEventData IPersistableModel<ResourceNotificationsResourceManagementDeletedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceNotificationsResourceManagementDeletedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeResourceNotificationsResourceManagementDeletedEventData(document.RootElement, options);
        }

        string IPersistableModel<ResourceNotificationsResourceManagementDeletedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class ResourceNotificationsResourceManagementDeletedEventDataConverter : JsonConverter<ResourceNotificationsResourceManagementDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceNotificationsResourceManagementDeletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ResourceNotificationsResourceManagementDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceNotificationsResourceManagementDeletedEventData(document.RootElement);
            }
        }
    }
}
