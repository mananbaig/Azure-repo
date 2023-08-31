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

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier : IUtf8JsonSerializable, IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>(this, options.Format);

            writer.WriteStartObject();
            if (KeyId != null)
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId.Value);
            }
            else
            {
                writer.WriteNull("keyId");
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        internal static ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid? keyId = default;
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyId = null;
                        continue;
                    }
                    keyId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(odataType, keyId, rawData);
        }

        ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier IModelJsonSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier IModelSerializable<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentKeyPolicyPlayReadyContentEncryptionKeyFromKeyIdentifier(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
