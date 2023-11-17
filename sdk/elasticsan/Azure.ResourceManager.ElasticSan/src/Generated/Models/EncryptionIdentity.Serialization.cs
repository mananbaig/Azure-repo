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

namespace Azure.ResourceManager.ElasticSan.Models
{
    internal partial class EncryptionIdentity : IUtf8JsonSerializable, IJsonModel<EncryptionIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EncryptionIdentity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EncryptionIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<EncryptionIdentity>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<EncryptionIdentity>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptionUserAssignedIdentity))
            {
                writer.WritePropertyName("userAssignedIdentity"u8);
                writer.WriteStringValue(EncryptionUserAssignedIdentity);
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

        EncryptionIdentity IJsonModel<EncryptionIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EncryptionIdentity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionIdentity(document.RootElement, options);
        }

        internal static EncryptionIdentity DeserializeEncryptionIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> userAssignedIdentity = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userAssignedIdentity"u8))
                {
                    userAssignedIdentity = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EncryptionIdentity(userAssignedIdentity.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EncryptionIdentity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EncryptionIdentity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        EncryptionIdentity IPersistableModel<EncryptionIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(EncryptionIdentity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeEncryptionIdentity(document.RootElement, options);
        }

        string IPersistableModel<EncryptionIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
