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
    [JsonConverter(typeof(AcsRouterWorkerOfferAcceptedEventDataConverter))]
    public partial class AcsRouterWorkerOfferAcceptedEventData : IUtf8JsonSerializable, IJsonModel<AcsRouterWorkerOfferAcceptedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterWorkerOfferAcceptedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcsRouterWorkerOfferAcceptedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsRouterWorkerOfferAcceptedEventData)} does not support '{format}' format.");
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
            if (Optional.IsDefined(AssignmentId))
            {
                writer.WritePropertyName("assignmentId"u8);
                writer.WriteStringValue(AssignmentId);
            }
            if (Optional.IsDefined(JobPriority))
            {
                writer.WritePropertyName("jobPriority"u8);
                writer.WriteNumberValue(JobPriority.Value);
            }
            if (Optional.IsCollectionDefined(WorkerLabels))
            {
                writer.WritePropertyName("workerLabels"u8);
                writer.WriteStartObject();
                foreach (var item in WorkerLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(WorkerTags))
            {
                writer.WritePropertyName("workerTags"u8);
                writer.WriteStartObject();
                foreach (var item in WorkerTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(JobLabels))
            {
                writer.WritePropertyName("jobLabels"u8);
                writer.WriteStartObject();
                foreach (var item in JobLabels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(JobTags))
            {
                writer.WritePropertyName("jobTags"u8);
                writer.WriteStartObject();
                foreach (var item in JobTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        AcsRouterWorkerOfferAcceptedEventData IJsonModel<AcsRouterWorkerOfferAcceptedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsRouterWorkerOfferAcceptedEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterWorkerOfferAcceptedEventData(document.RootElement, options);
        }

        internal static AcsRouterWorkerOfferAcceptedEventData DeserializeAcsRouterWorkerOfferAcceptedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queueId = default;
            Optional<string> offerId = default;
            Optional<string> assignmentId = default;
            Optional<int> jobPriority = default;
            Optional<IReadOnlyDictionary<string, string>> workerLabels = default;
            Optional<IReadOnlyDictionary<string, string>> workerTags = default;
            Optional<IReadOnlyDictionary<string, string>> jobLabels = default;
            Optional<IReadOnlyDictionary<string, string>> jobTags = default;
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
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobPriority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    workerLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("workerTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    workerTags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("jobTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobTags = dictionary;
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AcsRouterWorkerOfferAcceptedEventData(jobId.Value, channelReference.Value, channelId.Value, serializedAdditionalRawData, workerId.Value, queueId.Value, offerId.Value, assignmentId.Value, Optional.ToNullable(jobPriority), Optional.ToDictionary(workerLabels), Optional.ToDictionary(workerTags), Optional.ToDictionary(jobLabels), Optional.ToDictionary(jobTags));
        }

        BinaryData IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsRouterWorkerOfferAcceptedEventData)} does not support '{options.Format}' format.");
            }
        }

        AcsRouterWorkerOfferAcceptedEventData IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsRouterWorkerOfferAcceptedEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsRouterWorkerOfferAcceptedEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsRouterWorkerOfferAcceptedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class AcsRouterWorkerOfferAcceptedEventDataConverter : JsonConverter<AcsRouterWorkerOfferAcceptedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterWorkerOfferAcceptedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsRouterWorkerOfferAcceptedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterWorkerOfferAcceptedEventData(document.RootElement);
            }
        }
    }
}
