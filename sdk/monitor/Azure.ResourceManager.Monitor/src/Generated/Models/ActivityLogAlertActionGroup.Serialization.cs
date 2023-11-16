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
    public partial class ActivityLogAlertActionGroup : IUtf8JsonSerializable, IJsonModel<ActivityLogAlertActionGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ActivityLogAlertActionGroup>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ActivityLogAlertActionGroup>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ActivityLogAlertActionGroup>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ActivityLogAlertActionGroup>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("actionGroupId"u8);
            writer.WriteStringValue(ActionGroupId);
            if (Optional.IsCollectionDefined(WebhookProperties))
            {
                writer.WritePropertyName("webhookProperties"u8);
                writer.WriteStartObject();
                foreach (var item in WebhookProperties)
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

        ActivityLogAlertActionGroup IJsonModel<ActivityLogAlertActionGroup>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ActivityLogAlertActionGroup)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeActivityLogAlertActionGroup(document.RootElement, options);
        }

        internal static ActivityLogAlertActionGroup DeserializeActivityLogAlertActionGroup(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier actionGroupId = default;
            Optional<IDictionary<string, string>> webhookProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("actionGroupId"u8))
                {
                    actionGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("webhookProperties"u8))
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
                    webhookProperties = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ActivityLogAlertActionGroup(actionGroupId, Optional.ToDictionary(webhookProperties), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ActivityLogAlertActionGroup>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ActivityLogAlertActionGroup)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ActivityLogAlertActionGroup IPersistableModel<ActivityLogAlertActionGroup>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ActivityLogAlertActionGroup)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeActivityLogAlertActionGroup(document.RootElement, options);
        }

        string IPersistableModel<ActivityLogAlertActionGroup>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
