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

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleNotification : IUtf8JsonSerializable, IJsonModel<AutoscaleNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleNotification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoscaleNotification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AutoscaleNotification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("operation"u8);
            writer.WriteStringValue(Operation.ToString());
            if (Optional.IsDefined(Email))
            {
                writer.WritePropertyName("email"u8);
                writer.WriteObjectValue(Email);
            }
            if (Optional.IsCollectionDefined(Webhooks))
            {
                writer.WritePropertyName("webhooks"u8);
                writer.WriteStartArray();
                foreach (var item in Webhooks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AutoscaleNotification IJsonModel<AutoscaleNotification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleNotification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AutoscaleNotification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleNotification(document.RootElement, options);
        }

        internal static AutoscaleNotification DeserializeAutoscaleNotification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MonitorOperationType operation = default;
            Optional<EmailNotification> email = default;
            Optional<IList<WebhookNotification>> webhooks = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operation"u8))
                {
                    operation = new MonitorOperationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("email"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    email = EmailNotification.DeserializeEmailNotification(property.Value);
                    continue;
                }
                if (property.NameEquals("webhooks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebhookNotification> array = new List<WebhookNotification>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebhookNotification.DeserializeWebhookNotification(item));
                    }
                    webhooks = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoscaleNotification(operation, email.Value, Optional.ToList(webhooks), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleNotification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AutoscaleNotification)} does not support '{options.Format}' format.");
            }
        }

        AutoscaleNotification IPersistableModel<AutoscaleNotification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoscaleNotification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoscaleNotification(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AutoscaleNotification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoscaleNotification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
