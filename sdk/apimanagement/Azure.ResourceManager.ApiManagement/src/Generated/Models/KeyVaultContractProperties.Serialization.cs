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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class KeyVaultContractProperties : IUtf8JsonSerializable, IModelJsonSerializable<KeyVaultContractProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyVaultContractProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyVaultContractProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<KeyVaultContractProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LastStatus))
            {
                writer.WritePropertyName("lastStatus"u8);
                writer.WriteObjectValue(LastStatus);
            }
            if (Optional.IsDefined(SecretIdentifier))
            {
                writer.WritePropertyName("secretIdentifier"u8);
                writer.WriteStringValue(SecretIdentifier);
            }
            if (Optional.IsDefined(IdentityClientId))
            {
                writer.WritePropertyName("identityClientId"u8);
                writer.WriteStringValue(IdentityClientId);
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

        internal static KeyVaultContractProperties DeserializeKeyVaultContractProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KeyVaultLastAccessStatusContractProperties> lastStatus = default;
            Optional<string> secretIdentifier = default;
            Optional<string> identityClientId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastStatus = KeyVaultLastAccessStatusContractProperties.DeserializeKeyVaultLastAccessStatusContractProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("secretIdentifier"u8))
                {
                    secretIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityClientId"u8))
                {
                    identityClientId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyVaultContractProperties(secretIdentifier.Value, identityClientId.Value, lastStatus.Value, rawData);
        }

        KeyVaultContractProperties IModelJsonSerializable<KeyVaultContractProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<KeyVaultContractProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyVaultContractProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyVaultContractProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<KeyVaultContractProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyVaultContractProperties IModelSerializable<KeyVaultContractProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<KeyVaultContractProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyVaultContractProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(KeyVaultContractProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator KeyVaultContractProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyVaultContractProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
