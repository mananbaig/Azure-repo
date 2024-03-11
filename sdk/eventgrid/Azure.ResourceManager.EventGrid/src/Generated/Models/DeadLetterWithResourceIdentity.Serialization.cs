// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class DeadLetterWithResourceIdentity : IUtf8JsonSerializable, IJsonModel<DeadLetterWithResourceIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeadLetterWithResourceIdentity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeadLetterWithResourceIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterWithResourceIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeadLetterWithResourceIdentity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(DeadLetterDestination))
            {
                writer.WritePropertyName("deadLetterDestination"u8);
                writer.WriteObjectValue(DeadLetterDestination);
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

        DeadLetterWithResourceIdentity IJsonModel<DeadLetterWithResourceIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterWithResourceIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeadLetterWithResourceIdentity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeadLetterWithResourceIdentity(document.RootElement, options);
        }

        internal static DeadLetterWithResourceIdentity DeserializeDeadLetterWithResourceIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EventSubscriptionIdentity identity = default;
            DeadLetterDestination deadLetterDestination = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = EventSubscriptionIdentity.DeserializeEventSubscriptionIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deadLetterDestination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deadLetterDestination = DeadLetterDestination.DeserializeDeadLetterDestination(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeadLetterWithResourceIdentity(identity, deadLetterDestination, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeadLetterWithResourceIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterWithResourceIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeadLetterWithResourceIdentity)} does not support '{options.Format}' format.");
            }
        }

        DeadLetterWithResourceIdentity IPersistableModel<DeadLetterWithResourceIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeadLetterWithResourceIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeadLetterWithResourceIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeadLetterWithResourceIdentity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeadLetterWithResourceIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
