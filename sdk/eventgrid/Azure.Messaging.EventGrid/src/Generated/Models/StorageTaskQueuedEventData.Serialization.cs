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
    [JsonConverter(typeof(StorageTaskQueuedEventDataConverter))]
    public partial class StorageTaskQueuedEventData : IUtf8JsonSerializable, IJsonModel<StorageTaskQueuedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageTaskQueuedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StorageTaskQueuedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<StorageTaskQueuedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<StorageTaskQueuedEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(QueuedDateTime))
            {
                writer.WritePropertyName("queuedDateTime"u8);
                writer.WriteStringValue(QueuedDateTime.Value, "O");
            }
            if (Optional.IsDefined(TaskExecutionId))
            {
                writer.WritePropertyName("taskExecutionId"u8);
                writer.WriteStringValue(TaskExecutionId);
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

        StorageTaskQueuedEventData IJsonModel<StorageTaskQueuedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageTaskQueuedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageTaskQueuedEventData(document.RootElement, options);
        }

        internal static StorageTaskQueuedEventData DeserializeStorageTaskQueuedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> queuedDateTime = default;
            Optional<string> taskExecutionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queuedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queuedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskExecutionId"u8))
                {
                    taskExecutionId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageTaskQueuedEventData(Optional.ToNullable(queuedDateTime), taskExecutionId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StorageTaskQueuedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageTaskQueuedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageTaskQueuedEventData IPersistableModel<StorageTaskQueuedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageTaskQueuedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageTaskQueuedEventData(document.RootElement, options);
        }

        string IPersistableModel<StorageTaskQueuedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class StorageTaskQueuedEventDataConverter : JsonConverter<StorageTaskQueuedEventData>
        {
            public override void Write(Utf8JsonWriter writer, StorageTaskQueuedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override StorageTaskQueuedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeStorageTaskQueuedEventData(document.RootElement);
            }
        }
    }
}
