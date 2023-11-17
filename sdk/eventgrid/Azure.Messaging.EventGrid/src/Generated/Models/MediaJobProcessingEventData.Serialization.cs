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
    [JsonConverter(typeof(MediaJobProcessingEventDataConverter))]
    public partial class MediaJobProcessingEventData : IUtf8JsonSerializable, IJsonModel<MediaJobProcessingEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaJobProcessingEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaJobProcessingEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MediaJobProcessingEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MediaJobProcessingEventData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PreviousState))
                {
                    writer.WritePropertyName("previousState"u8);
                    writer.WriteStringValue(PreviousState.Value.ToSerialString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(State))
                {
                    writer.WritePropertyName("state"u8);
                    writer.WriteStringValue(State.Value.ToSerialString());
                }
            }
            if (Optional.IsCollectionDefined(CorrelationData))
            {
                writer.WritePropertyName("correlationData"u8);
                writer.WriteStartObject();
                foreach (var item in CorrelationData)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        MediaJobProcessingEventData IJsonModel<MediaJobProcessingEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaJobProcessingEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaJobProcessingEventData(document.RootElement, options);
        }

        internal static MediaJobProcessingEventData DeserializeMediaJobProcessingEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobState> state = default;
            Optional<IReadOnlyDictionary<string, string>> correlationData = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("previousState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("correlationData"u8))
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
                    correlationData = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaJobProcessingEventData(Optional.ToNullable(previousState), Optional.ToNullable(state), Optional.ToDictionary(correlationData), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaJobProcessingEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaJobProcessingEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MediaJobProcessingEventData IPersistableModel<MediaJobProcessingEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MediaJobProcessingEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMediaJobProcessingEventData(document.RootElement, options);
        }

        string IPersistableModel<MediaJobProcessingEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class MediaJobProcessingEventDataConverter : JsonConverter<MediaJobProcessingEventData>
        {
            public override void Write(Utf8JsonWriter writer, MediaJobProcessingEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MediaJobProcessingEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMediaJobProcessingEventData(document.RootElement);
            }
        }
    }
}
