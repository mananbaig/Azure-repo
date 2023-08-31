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
    public partial class SshPublicKeyGenerateKeyPairResult : IUtf8JsonSerializable, IModelJsonSerializable<SshPublicKeyGenerateKeyPairResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SshPublicKeyGenerateKeyPairResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SshPublicKeyGenerateKeyPairResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("privateKey"u8);
            writer.WriteStringValue(PrivateKey);
            writer.WritePropertyName("publicKey"u8);
            writer.WriteStringValue(PublicKey);
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
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

        internal static SshPublicKeyGenerateKeyPairResult DeserializeSshPublicKeyGenerateKeyPairResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string privateKey = default;
            string publicKey = default;
            ResourceIdentifier id = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateKey"u8))
                {
                    privateKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicKey"u8))
                {
                    publicKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SshPublicKeyGenerateKeyPairResult(privateKey, publicKey, id, rawData);
        }

        SshPublicKeyGenerateKeyPairResult IModelJsonSerializable<SshPublicKeyGenerateKeyPairResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSshPublicKeyGenerateKeyPairResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SshPublicKeyGenerateKeyPairResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SshPublicKeyGenerateKeyPairResult IModelSerializable<SshPublicKeyGenerateKeyPairResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSshPublicKeyGenerateKeyPairResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SshPublicKeyGenerateKeyPairResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SshPublicKeyGenerateKeyPairResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSshPublicKeyGenerateKeyPairResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
