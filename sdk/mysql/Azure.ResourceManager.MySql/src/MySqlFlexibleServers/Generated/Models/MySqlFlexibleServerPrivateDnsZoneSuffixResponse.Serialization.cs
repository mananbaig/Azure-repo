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

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerPrivateDnsZoneSuffixResponse : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateDnsZoneSuffix))
            {
                writer.WritePropertyName("privateDnsZoneSuffix"u8);
                writer.WriteStringValue(PrivateDnsZoneSuffix);
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

        MySqlFlexibleServerPrivateDnsZoneSuffixResponse IJsonModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(document.RootElement, options);
        }

        internal static MySqlFlexibleServerPrivateDnsZoneSuffixResponse DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> privateDnsZoneSuffix = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateDnsZoneSuffix"u8))
                {
                    privateDnsZoneSuffix = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerPrivateDnsZoneSuffixResponse(privateDnsZoneSuffix.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MySqlFlexibleServerPrivateDnsZoneSuffixResponse IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MySqlFlexibleServerPrivateDnsZoneSuffixResponse)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMySqlFlexibleServerPrivateDnsZoneSuffixResponse(document.RootElement, options);
        }

        string IPersistableModel<MySqlFlexibleServerPrivateDnsZoneSuffixResponse>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
