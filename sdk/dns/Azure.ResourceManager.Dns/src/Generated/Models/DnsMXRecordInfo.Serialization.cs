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

namespace Azure.ResourceManager.Dns.Models
{
    public partial class DnsMXRecordInfo : IUtf8JsonSerializable, IJsonModel<DnsMXRecordInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DnsMXRecordInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DnsMXRecordInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DnsMXRecordInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DnsMXRecordInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Preference))
            {
                writer.WritePropertyName("preference"u8);
                writer.WriteNumberValue(Preference.Value);
            }
            if (Optional.IsDefined(Exchange))
            {
                writer.WritePropertyName("exchange"u8);
                writer.WriteStringValue(Exchange);
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

        DnsMXRecordInfo IJsonModel<DnsMXRecordInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DnsMXRecordInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDnsMXRecordInfo(document.RootElement, options);
        }

        internal static DnsMXRecordInfo DeserializeDnsMXRecordInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> preference = default;
            Optional<string> exchange = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("preference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preference = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("exchange"u8))
                {
                    exchange = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DnsMXRecordInfo(Optional.ToNullable(preference), exchange.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DnsMXRecordInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DnsMXRecordInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DnsMXRecordInfo IPersistableModel<DnsMXRecordInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DnsMXRecordInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDnsMXRecordInfo(document.RootElement, options);
        }

        string IPersistableModel<DnsMXRecordInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
