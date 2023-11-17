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
    [JsonConverter(typeof(WebBackupOperationCompletedEventDataConverter))]
    public partial class WebBackupOperationCompletedEventData : IUtf8JsonSerializable, IJsonModel<WebBackupOperationCompletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<WebBackupOperationCompletedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<WebBackupOperationCompletedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<WebBackupOperationCompletedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<WebBackupOperationCompletedEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AppEventTypeDetail))
            {
                writer.WritePropertyName("appEventTypeDetail"u8);
                writer.WriteObjectValue(AppEventTypeDetail);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(ClientRequestId))
            {
                writer.WritePropertyName("clientRequestId"u8);
                writer.WriteStringValue(ClientRequestId);
            }
            if (Optional.IsDefined(CorrelationRequestId))
            {
                writer.WritePropertyName("correlationRequestId"u8);
                writer.WriteStringValue(CorrelationRequestId);
            }
            if (Optional.IsDefined(RequestId))
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (Optional.IsDefined(Address))
            {
                writer.WritePropertyName("address"u8);
                writer.WriteStringValue(Address);
            }
            if (Optional.IsDefined(Verb))
            {
                writer.WritePropertyName("verb"u8);
                writer.WriteStringValue(Verb);
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

        WebBackupOperationCompletedEventData IJsonModel<WebBackupOperationCompletedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebBackupOperationCompletedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeWebBackupOperationCompletedEventData(document.RootElement, options);
        }

        internal static WebBackupOperationCompletedEventData DeserializeWebBackupOperationCompletedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppEventTypeDetail> appEventTypeDetail = default;
            Optional<string> name = default;
            Optional<string> clientRequestId = default;
            Optional<string> correlationRequestId = default;
            Optional<string> requestId = default;
            Optional<string> address = default;
            Optional<string> verb = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appEventTypeDetail"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appEventTypeDetail = AppEventTypeDetail.DeserializeAppEventTypeDetail(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRequestId"u8))
                {
                    clientRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("correlationRequestId"u8))
                {
                    correlationRequestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("address"u8))
                {
                    address = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verb"u8))
                {
                    verb = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new WebBackupOperationCompletedEventData(appEventTypeDetail.Value, name.Value, clientRequestId.Value, correlationRequestId.Value, requestId.Value, address.Value, verb.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<WebBackupOperationCompletedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebBackupOperationCompletedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        WebBackupOperationCompletedEventData IPersistableModel<WebBackupOperationCompletedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(WebBackupOperationCompletedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeWebBackupOperationCompletedEventData(document.RootElement, options);
        }

        string IPersistableModel<WebBackupOperationCompletedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class WebBackupOperationCompletedEventDataConverter : JsonConverter<WebBackupOperationCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, WebBackupOperationCompletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override WebBackupOperationCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeWebBackupOperationCompletedEventData(document.RootElement);
            }
        }
    }
}
