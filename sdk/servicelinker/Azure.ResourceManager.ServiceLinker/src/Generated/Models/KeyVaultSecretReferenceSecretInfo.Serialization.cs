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

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class KeyVaultSecretReferenceSecretInfo : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultSecretReferenceSecretInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultSecretReferenceSecretInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultSecretReferenceSecretInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSecretReferenceSecretInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Version))
            {
                if (Version != null)
                {
                    writer.WritePropertyName("version"u8);
                    writer.WriteStringValue(Version);
                }
                else
                {
                    writer.WriteNull("version");
                }
            }
            writer.WritePropertyName("secretType"u8);
            writer.WriteStringValue(SecretType.ToString());
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static KeyVaultSecretReferenceSecretInfo DeserializeKeyVaultSecretReferenceSecretInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> version = default;
            LinkerSecretType secretType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        version = null;
                        continue;
                    }
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secretType"u8))
                {
                    secretType = new LinkerSecretType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultSecretReferenceSecretInfo(secretType, name.Value, version.Value, serializedAdditionalRawData);
        }

        KeyVaultSecretReferenceSecretInfo IModelJsonSerializable<KeyVaultSecretReferenceSecretInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSecretReferenceSecretInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultSecretReferenceSecretInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultSecretReferenceSecretInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSecretReferenceSecretInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultSecretReferenceSecretInfo IModelSerializable<KeyVaultSecretReferenceSecretInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyVaultSecretReferenceSecretInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultSecretReferenceSecretInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyVaultSecretReferenceSecretInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyVaultSecretReferenceSecretInfo"/> to convert. </param>
        public static implicit operator RequestContent(KeyVaultSecretReferenceSecretInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyVaultSecretReferenceSecretInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyVaultSecretReferenceSecretInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultSecretReferenceSecretInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
