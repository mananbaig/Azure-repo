// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    public partial class ShareSubscriptionSynchronization : IUtf8JsonSerializable, IJsonModel<ShareSubscriptionSynchronization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareSubscriptionSynchronization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShareSubscriptionSynchronization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ShareSubscriptionSynchronization>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ShareSubscriptionSynchronization>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DurationInMilliSeconds))
                {
                    writer.WritePropertyName("durationMs"u8);
                    writer.WriteNumberValue(DurationInMilliSeconds.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(EndOn))
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Message))
                {
                    writer.WritePropertyName("message"u8);
                    writer.WriteStringValue(Message);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StartOn))
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
            }
            writer.WritePropertyName("synchronizationId"u8);
            writer.WriteStringValue(SynchronizationId);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SynchronizationMode))
                {
                    writer.WritePropertyName("synchronizationMode"u8);
                    writer.WriteStringValue(SynchronizationMode.Value.ToString());
                }
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

        ShareSubscriptionSynchronization IJsonModel<ShareSubscriptionSynchronization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareSubscriptionSynchronization(document.RootElement, options);
        }

        internal static ShareSubscriptionSynchronization DeserializeShareSubscriptionSynchronization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> durationMs = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> status = default;
            Guid synchronizationId = default;
            Optional<SynchronizationMode> synchronizationMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("durationMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("synchronizationId"u8))
                {
                    synchronizationId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("synchronizationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    synchronizationMode = new SynchronizationMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ShareSubscriptionSynchronization(Optional.ToNullable(durationMs), Optional.ToNullable(endTime), message.Value, Optional.ToNullable(startTime), status.Value, synchronizationId, Optional.ToNullable(synchronizationMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShareSubscriptionSynchronization>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ShareSubscriptionSynchronization IPersistableModel<ShareSubscriptionSynchronization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ShareSubscriptionSynchronization)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeShareSubscriptionSynchronization(document.RootElement, options);
        }

        string IPersistableModel<ShareSubscriptionSynchronization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
