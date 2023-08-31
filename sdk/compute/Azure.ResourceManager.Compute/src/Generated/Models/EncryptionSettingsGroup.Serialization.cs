// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class EncryptionSettingsGroup : IUtf8JsonSerializable, IModelJsonSerializable<EncryptionSettingsGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EncryptionSettingsGroup>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EncryptionSettingsGroup>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(Enabled);
            if (Optional.IsCollectionDefined(EncryptionSettings))
            {
                writer.WritePropertyName("encryptionSettings"u8);
                writer.WriteStartArray();
                foreach (var item in EncryptionSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EncryptionSettingsVersion))
            {
                writer.WritePropertyName("encryptionSettingsVersion"u8);
                writer.WriteStringValue(EncryptionSettingsVersion);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static EncryptionSettingsGroup DeserializeEncryptionSettingsGroup(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            Optional<IList<EncryptionSettingsElement>> encryptionSettings = default;
            Optional<string> encryptionSettingsVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encryptionSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EncryptionSettingsElement> array = new List<EncryptionSettingsElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EncryptionSettingsElement.DeserializeEncryptionSettingsElement(item));
                    }
                    encryptionSettings = array;
                    continue;
                }
                if (property.NameEquals("encryptionSettingsVersion"u8))
                {
                    encryptionSettingsVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EncryptionSettingsGroup(enabled, Optional.ToList(encryptionSettings), encryptionSettingsVersion.Value, rawData);
        }

        EncryptionSettingsGroup IModelJsonSerializable<EncryptionSettingsGroup>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEncryptionSettingsGroup(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EncryptionSettingsGroup>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EncryptionSettingsGroup IModelSerializable<EncryptionSettingsGroup>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEncryptionSettingsGroup(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EncryptionSettingsGroup model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EncryptionSettingsGroup(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEncryptionSettingsGroup(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
