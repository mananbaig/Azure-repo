// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(KeyVaultAccessPolicyChangedEventDataConverter))]
    public partial class KeyVaultAccessPolicyChangedEventData : IUtf8JsonSerializable, IJsonModel<KeyVaultAccessPolicyChangedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KeyVaultAccessPolicyChangedEventData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KeyVaultAccessPolicyChangedEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<KeyVaultAccessPolicyChangedEventData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<KeyVaultAccessPolicyChangedEventData>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("Id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(VaultName))
            {
                writer.WritePropertyName("VaultName"u8);
                writer.WriteStringValue(VaultName);
            }
            if (Optional.IsDefined(ObjectType))
            {
                writer.WritePropertyName("ObjectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            if (Optional.IsDefined(ObjectName))
            {
                writer.WritePropertyName("ObjectName"u8);
                writer.WriteStringValue(ObjectName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("Version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(Nbf))
            {
                writer.WritePropertyName("NBF"u8);
                writer.WriteNumberValue(Nbf.Value);
            }
            if (Optional.IsDefined(Exp))
            {
                writer.WritePropertyName("EXP"u8);
                writer.WriteNumberValue(Exp.Value);
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

        KeyVaultAccessPolicyChangedEventData IJsonModel<KeyVaultAccessPolicyChangedEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KeyVaultAccessPolicyChangedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultAccessPolicyChangedEventData(document.RootElement, options);
        }

        internal static KeyVaultAccessPolicyChangedEventData DeserializeKeyVaultAccessPolicyChangedEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> vaultName = default;
            Optional<string> objectType = default;
            Optional<string> objectName = default;
            Optional<string> version = default;
            Optional<float> nbf = default;
            Optional<float> exp = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"u8))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"u8))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nbf = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exp = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KeyVaultAccessPolicyChangedEventData(id.Value, vaultName.Value, objectType.Value, objectName.Value, version.Value, Optional.ToNullable(nbf), Optional.ToNullable(exp), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KeyVaultAccessPolicyChangedEventData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KeyVaultAccessPolicyChangedEventData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        KeyVaultAccessPolicyChangedEventData IPersistableModel<KeyVaultAccessPolicyChangedEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(KeyVaultAccessPolicyChangedEventData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeKeyVaultAccessPolicyChangedEventData(document.RootElement, options);
        }

        string IPersistableModel<KeyVaultAccessPolicyChangedEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal partial class KeyVaultAccessPolicyChangedEventDataConverter : JsonConverter<KeyVaultAccessPolicyChangedEventData>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultAccessPolicyChangedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override KeyVaultAccessPolicyChangedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultAccessPolicyChangedEventData(document.RootElement);
            }
        }
    }
}
