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
    public partial class PartnerAuthorization : IUtf8JsonSerializable, IJsonModel<PartnerAuthorization>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerAuthorization>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerAuthorization>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PartnerAuthorization>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PartnerAuthorization>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultMaximumExpirationTimeInDays))
            {
                writer.WritePropertyName("defaultMaximumExpirationTimeInDays"u8);
                writer.WriteNumberValue(DefaultMaximumExpirationTimeInDays.Value);
            }
            if (Optional.IsCollectionDefined(AuthorizedPartnersList))
            {
                writer.WritePropertyName("authorizedPartnersList"u8);
                writer.WriteStartArray();
                foreach (var item in AuthorizedPartnersList)
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

        PartnerAuthorization IJsonModel<PartnerAuthorization>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerAuthorization(document.RootElement, options);
        }

        internal static PartnerAuthorization DeserializePartnerAuthorization(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> defaultMaximumExpirationTimeInDays = default;
            Optional<IList<EventGridPartnerContent>> authorizedPartnersList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultMaximumExpirationTimeInDays"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultMaximumExpirationTimeInDays = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("authorizedPartnersList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventGridPartnerContent> array = new List<EventGridPartnerContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventGridPartnerContent.DeserializeEventGridPartnerContent(item));
                    }
                    authorizedPartnersList = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerAuthorization(Optional.ToNullable(defaultMaximumExpirationTimeInDays), Optional.ToList(authorizedPartnersList), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerAuthorization>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PartnerAuthorization IPersistableModel<PartnerAuthorization>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PartnerAuthorization)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePartnerAuthorization(document.RootElement, options);
        }

        string IPersistableModel<PartnerAuthorization>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
