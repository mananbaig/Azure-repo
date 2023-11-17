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
    [JsonConverter(typeof(ApiManagementProductUpdatedEventDataConverter))]
    public partial class ApiManagementProductUpdatedEventData : IUtf8JsonSerializable, IJsonModel<ApiManagementProductUpdatedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementProductUpdatedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiManagementProductUpdatedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApiManagementProductUpdatedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApiManagementProductUpdatedEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUri);
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

        ApiManagementProductUpdatedEventData IJsonModel<ApiManagementProductUpdatedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementProductUpdatedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementProductUpdatedEventData(document.RootElement, options);
        }

        internal static ApiManagementProductUpdatedEventData DeserializeApiManagementProductUpdatedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementProductUpdatedEventData(resourceUri.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementProductUpdatedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementProductUpdatedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApiManagementProductUpdatedEventData IPersistableModel<ApiManagementProductUpdatedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementProductUpdatedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApiManagementProductUpdatedEventData(document.RootElement, options);
        }

        string IPersistableModel<ApiManagementProductUpdatedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class ApiManagementProductUpdatedEventDataConverter : JsonConverter<ApiManagementProductUpdatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, ApiManagementProductUpdatedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ApiManagementProductUpdatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeApiManagementProductUpdatedEventData(document.RootElement);
            }
        }
    }
}
