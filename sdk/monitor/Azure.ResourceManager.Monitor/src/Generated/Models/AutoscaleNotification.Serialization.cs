// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class AutoscaleNotification : IUtf8JsonSerializable, IJsonModel<AutoscaleNotification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoscaleNotification>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AutoscaleNotification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AutoscaleNotification>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AutoscaleNotification>)} interface");
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

        AutoscaleNotification IJsonModel<AutoscaleNotification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AutoscaleNotification)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoscaleNotification(document.RootElement, options);
        }

        internal static AutoscaleNotification DeserializeAutoscaleNotification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoscaleNotification(operation, email.Value, Optional.ToList(webhooks), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoscaleNotification>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AutoscaleNotification)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AutoscaleNotification IPersistableModel<AutoscaleNotification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AutoscaleNotification)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAutoscaleNotification(document.RootElement, options);
        }

        string IPersistableModel<AutoscaleNotification>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
