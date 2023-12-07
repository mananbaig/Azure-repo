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
    [JsonConverter(typeof(AcsRouterJobExceptionTriggeredEventDataConverter))]
    public partial class AcsRouterJobExceptionTriggeredEventData : IUtf8JsonSerializable, IJsonModel<AcsRouterJobExceptionTriggeredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AcsRouterJobExceptionTriggeredEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AcsRouterJobExceptionTriggeredEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobExceptionTriggeredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsRouterJobExceptionTriggeredEventData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RuleKey))
            {
                writer.WritePropertyName("ruleKey"u8);
                writer.WriteStringValue(RuleKey);
            }
            if (Optional.IsDefined(ExceptionRuleId))
            {
                writer.WritePropertyName("exceptionRuleId"u8);
                writer.WriteStringValue(ExceptionRuleId);
            }
            if (Optional.IsDefined(QueueId))
            {
                writer.WritePropertyName("queueId"u8);
                writer.WriteStringValue(QueueId);
            }
            if (Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartObject();
                foreach (var item in Labels)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        AcsRouterJobExceptionTriggeredEventData IJsonModel<AcsRouterJobExceptionTriggeredEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobExceptionTriggeredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AcsRouterJobExceptionTriggeredEventData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAcsRouterJobExceptionTriggeredEventData(document.RootElement, options);
        }

        internal static AcsRouterJobExceptionTriggeredEventData DeserializeAcsRouterJobExceptionTriggeredEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ruleKey = default;
            Optional<string> exceptionRuleId = default;
            Optional<string> queueId = default;
            Optional<IReadOnlyDictionary<string, string>> labels = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<string> jobId = default;
            Optional<string> channelReference = default;
            Optional<string> channelId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ruleKey"u8))
                {
                    ruleKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exceptionRuleId"u8))
                {
                    exceptionRuleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labels"u8))
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
                    labels = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
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
            return new AcsRouterJobExceptionTriggeredEventData(jobId.Value, channelReference.Value, channelId.Value, serializedAdditionalRawData, queueId.Value, Optional.ToDictionary(labels), Optional.ToDictionary(tags), ruleKey.Value, exceptionRuleId.Value);
        }

        BinaryData IPersistableModel<AcsRouterJobExceptionTriggeredEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobExceptionTriggeredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsRouterJobExceptionTriggeredEventData)} does not support '{options.Format}' format.");
            }
        }

        AcsRouterJobExceptionTriggeredEventData IPersistableModel<AcsRouterJobExceptionTriggeredEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AcsRouterJobExceptionTriggeredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAcsRouterJobExceptionTriggeredEventData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AcsRouterJobExceptionTriggeredEventData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AcsRouterJobExceptionTriggeredEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class AcsRouterJobExceptionTriggeredEventDataConverter : JsonConverter<AcsRouterJobExceptionTriggeredEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterJobExceptionTriggeredEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsRouterJobExceptionTriggeredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterJobExceptionTriggeredEventData(document.RootElement);
            }
        }
    }
}
