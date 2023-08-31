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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class CloudServiceVaultSecretGroup : IUtf8JsonSerializable, IModelJsonSerializable<CloudServiceVaultSecretGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CloudServiceVaultSecretGroup>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CloudServiceVaultSecretGroup>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVault))
            {
                writer.WritePropertyName("sourceVault"u8);
                JsonSerializer.Serialize(writer, SourceVault);
            }
            if (Optional.IsCollectionDefined(VaultCertificates))
            {
                writer.WritePropertyName("vaultCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in VaultCertificates)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<CloudServiceVaultCertificate>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static CloudServiceVaultSecretGroup DeserializeCloudServiceVaultSecretGroup(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> sourceVault = default;
            Optional<IList<CloudServiceVaultCertificate>> vaultCertificates = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVault"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVault = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("vaultCertificates"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CloudServiceVaultCertificate> array = new List<CloudServiceVaultCertificate>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CloudServiceVaultCertificate.DeserializeCloudServiceVaultCertificate(item));
                    }
                    vaultCertificates = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CloudServiceVaultSecretGroup(sourceVault, Optional.ToList(vaultCertificates), rawData);
        }

        CloudServiceVaultSecretGroup IModelJsonSerializable<CloudServiceVaultSecretGroup>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudServiceVaultSecretGroup(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CloudServiceVaultSecretGroup>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CloudServiceVaultSecretGroup IModelSerializable<CloudServiceVaultSecretGroup>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCloudServiceVaultSecretGroup(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CloudServiceVaultSecretGroup"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CloudServiceVaultSecretGroup"/> to convert. </param>
        public static implicit operator RequestContent(CloudServiceVaultSecretGroup model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CloudServiceVaultSecretGroup"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CloudServiceVaultSecretGroup(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCloudServiceVaultSecretGroup(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
