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
    [JsonConverter(typeof(AcsRouterWorkerOfferExpiredEventDataConverter))]
    public partial class AcsRouterWorkerOfferExpiredEventData : IUtf8JsonSerializable, IJsonModel<AcsRouterWorkerOfferExpiredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterWorkerOfferExpiredEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcsRouterWorkerOfferExpiredEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AcsRouterWorkerOfferExpiredEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AcsRouterWorkerOfferExpiredEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsDefined(OfferId))
            {
                writer.WritePropertyName("offerId"u8);
                writer.WriteStringValue(OfferId);
            }
            if (Optional.IsDefined(WorkerId))
            {
                writer.WritePropertyName("workerId"u8);
                writer.WriteStringValue(WorkerId);
            }
            if (Optional.IsDefined(JobId))
            {
                writer.WritePropertyName("jobId"u8);
                writer.WriteStringValue(JobId);
            }
            if (Optional.IsDefined(ChannelReference))
            {
                writer.WritePropertyName("channelReference"u8);
                writer.WriteStringValue(ChannelReference);
            }
            if (Optional.IsDefined(ChannelId))
            {
                writer.WritePropertyName("channelId"u8);
                writer.WriteStringValue(ChannelId);
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

        AcsRouterWorkerOfferExpiredEventData IJsonModel<AcsRouterWorkerOfferExpiredEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerOfferExpiredEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterWorkerOfferExpiredEventData(document.RootElement, options);
        }

        internal static AcsRouterWorkerOfferExpiredEventData DeserializeAcsRouterWorkerOfferExpiredEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queueId = default;
            Optional<string> offerId = default;
            Optional<string> workerId = default;
            Optional<string> jobId = default;
            Optional<string> channelReference = default;
            Optional<string> channelId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AcsRouterWorkerOfferExpiredEventData(jobId.Value, channelReference.Value, channelId.Value, serializedAdditionalRawData, workerId.Value, queueId.Value, offerId.Value);
        }

        BinaryData IPersistableModel<AcsRouterWorkerOfferExpiredEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerOfferExpiredEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AcsRouterWorkerOfferExpiredEventData IPersistableModel<AcsRouterWorkerOfferExpiredEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AcsRouterWorkerOfferExpiredEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAcsRouterWorkerOfferExpiredEventData(document.RootElement, options);
        }

        string IPersistableModel<AcsRouterWorkerOfferExpiredEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class AcsRouterWorkerOfferExpiredEventDataConverter : JsonConverter<AcsRouterWorkerOfferExpiredEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterWorkerOfferExpiredEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsRouterWorkerOfferExpiredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterWorkerOfferExpiredEventData(document.RootElement);
            }
        }
    }
}
