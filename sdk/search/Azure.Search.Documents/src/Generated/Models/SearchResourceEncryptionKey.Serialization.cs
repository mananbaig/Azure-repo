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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchResourceEncryptionKey : IUtf8JsonSerializable, IModelJsonSerializable<SearchResourceEncryptionKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SearchResourceEncryptionKey>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SearchResourceEncryptionKey>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchResourceEncryptionKey>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultKeyName"u8);
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVaultKeyVersion"u8);
            writer.WriteStringValue(KeyVersion);
            writer.WritePropertyName("keyVaultUri"u8);
            writer.WriteStringValue(_vaultUri);
            if (Optional.IsDefined(AccessCredentialsInternal))
            {
                writer.WritePropertyName("accessCredentials"u8);
                if (AccessCredentialsInternal is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AzureActiveDirectoryApplicationCredentials>)AccessCredentialsInternal).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    if (Identity is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SearchIndexerDataIdentity>)Identity).Serialize(writer, options);
                    }
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
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

        internal static SearchResourceEncryptionKey DeserializeSearchResourceEncryptionKey(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyVaultKeyName = default;
            string keyVaultKeyVersion = default;
            string keyVaultUri = default;
            Optional<AzureActiveDirectoryApplicationCredentials> accessCredentials = default;
            Optional<SearchIndexerDataIdentity> identity = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultKeyName"u8))
                {
                    keyVaultKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultKeyVersion"u8))
                {
                    keyVaultKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    keyVaultUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessCredentials = AzureActiveDirectoryApplicationCredentials.DeserializeAzureActiveDirectoryApplicationCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SearchResourceEncryptionKey(keyVaultKeyName, keyVaultKeyVersion, keyVaultUri, accessCredentials.Value, identity.Value, serializedAdditionalRawData);
        }

        SearchResourceEncryptionKey IModelJsonSerializable<SearchResourceEncryptionKey>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchResourceEncryptionKey>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSearchResourceEncryptionKey(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SearchResourceEncryptionKey>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchResourceEncryptionKey>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SearchResourceEncryptionKey IModelSerializable<SearchResourceEncryptionKey>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SearchResourceEncryptionKey>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSearchResourceEncryptionKey(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SearchResourceEncryptionKey"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SearchResourceEncryptionKey"/> to convert. </param>
        public static implicit operator RequestContent(SearchResourceEncryptionKey model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SearchResourceEncryptionKey"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SearchResourceEncryptionKey(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSearchResourceEncryptionKey(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
