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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class PartnerTopicEventTypeInfo : IUtf8JsonSerializable, IJsonModel<PartnerTopicEventTypeInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerTopicEventTypeInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerTopicEventTypeInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PartnerTopicEventTypeInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PartnerTopicEventTypeInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InlineEventTypes))
            {
                writer.WritePropertyName("inlineEventTypes"u8);
                writer.WriteStartObject();
                foreach (var item in InlineEventTypes)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
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

        PartnerTopicEventTypeInfo IJsonModel<PartnerTopicEventTypeInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PartnerTopicEventTypeInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerTopicEventTypeInfo(document.RootElement, options);
        }

        internal static PartnerTopicEventTypeInfo DeserializePartnerTopicEventTypeInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EventDefinitionKind> kind = default;
            Optional<IDictionary<string, InlineEventProperties>> inlineEventTypes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new EventDefinitionKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inlineEventTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, InlineEventProperties> dictionary = new Dictionary<string, InlineEventProperties>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, InlineEventProperties.DeserializeInlineEventProperties(property0.Value));
                    }
                    inlineEventTypes = dictionary;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerTopicEventTypeInfo(Optional.ToNullable(kind), Optional.ToDictionary(inlineEventTypes), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerTopicEventTypeInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PartnerTopicEventTypeInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PartnerTopicEventTypeInfo IPersistableModel<PartnerTopicEventTypeInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PartnerTopicEventTypeInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePartnerTopicEventTypeInfo(document.RootElement, options);
        }

        string IPersistableModel<PartnerTopicEventTypeInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
