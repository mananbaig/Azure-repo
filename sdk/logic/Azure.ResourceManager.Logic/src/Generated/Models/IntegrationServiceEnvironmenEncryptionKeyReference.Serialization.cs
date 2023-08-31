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

namespace Azure.ResourceManager.Logic.Models
{
    public partial class IntegrationServiceEnvironmenEncryptionKeyReference : IUtf8JsonSerializable, IModelJsonSerializable<IntegrationServiceEnvironmenEncryptionKeyReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IntegrationServiceEnvironmenEncryptionKeyReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IntegrationServiceEnvironmenEncryptionKeyReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(KeyVault))
            {
                writer.WritePropertyName("keyVault"u8);
                writer.WriteObjectValue(KeyVault);
            }
            if (Optional.IsDefined(KeyName))
            {
                writer.WritePropertyName("keyName"u8);
                writer.WriteStringValue(KeyName);
            }
            if (Optional.IsDefined(KeyVersion))
            {
                writer.WritePropertyName("keyVersion"u8);
                writer.WriteStringValue(KeyVersion);
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

        internal static IntegrationServiceEnvironmenEncryptionKeyReference DeserializeIntegrationServiceEnvironmenEncryptionKeyReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LogicResourceReference> keyVault = default;
            Optional<string> keyName = default;
            Optional<string> keyVersion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVault = LogicResourceReference.DeserializeLogicResourceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("keyName"u8))
                {
                    keyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVersion"u8))
                {
                    keyVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IntegrationServiceEnvironmenEncryptionKeyReference(keyVault.Value, keyName.Value, keyVersion.Value, rawData);
        }

        IntegrationServiceEnvironmenEncryptionKeyReference IModelJsonSerializable<IntegrationServiceEnvironmenEncryptionKeyReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIntegrationServiceEnvironmenEncryptionKeyReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IntegrationServiceEnvironmenEncryptionKeyReference>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IntegrationServiceEnvironmenEncryptionKeyReference IModelSerializable<IntegrationServiceEnvironmenEncryptionKeyReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIntegrationServiceEnvironmenEncryptionKeyReference(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IntegrationServiceEnvironmenEncryptionKeyReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IntegrationServiceEnvironmenEncryptionKeyReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIntegrationServiceEnvironmenEncryptionKeyReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
