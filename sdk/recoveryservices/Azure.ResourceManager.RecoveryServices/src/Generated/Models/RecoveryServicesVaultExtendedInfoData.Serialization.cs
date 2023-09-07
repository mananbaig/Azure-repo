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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.RecoveryServices
{
    public partial class RecoveryServicesVaultExtendedInfoData : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryServicesVaultExtendedInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryServicesVaultExtendedInfoData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryServicesVaultExtendedInfoData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryServicesVaultExtendedInfoData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IntegrityKey))
            {
                writer.WritePropertyName("integrityKey"u8);
                writer.WriteStringValue(IntegrityKey);
            }
            if (Optional.IsDefined(EncryptionKey))
            {
                writer.WritePropertyName("encryptionKey"u8);
                writer.WriteStringValue(EncryptionKey);
            }
            if (Optional.IsDefined(EncryptionKeyThumbprint))
            {
                writer.WritePropertyName("encryptionKeyThumbprint"u8);
                writer.WriteStringValue(EncryptionKeyThumbprint);
            }
            if (Optional.IsDefined(Algorithm))
            {
                writer.WritePropertyName("algorithm"u8);
                writer.WriteStringValue(Algorithm);
            }
            writer.WriteEndObject();
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

        internal static RecoveryServicesVaultExtendedInfoData DeserializeRecoveryServicesVaultExtendedInfoData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> integrityKey = default;
            Optional<string> encryptionKey = default;
            Optional<string> encryptionKeyThumbprint = default;
            Optional<string> algorithm = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("integrityKey"u8))
                        {
                            integrityKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKey"u8))
                        {
                            encryptionKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("encryptionKeyThumbprint"u8))
                        {
                            encryptionKeyThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("algorithm"u8))
                        {
                            algorithm = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RecoveryServicesVaultExtendedInfoData(id, name, type, systemData.Value, integrityKey.Value, encryptionKey.Value, encryptionKeyThumbprint.Value, algorithm.Value, Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        RecoveryServicesVaultExtendedInfoData IModelJsonSerializable<RecoveryServicesVaultExtendedInfoData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryServicesVaultExtendedInfoData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryServicesVaultExtendedInfoData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryServicesVaultExtendedInfoData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryServicesVaultExtendedInfoData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryServicesVaultExtendedInfoData IModelSerializable<RecoveryServicesVaultExtendedInfoData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RecoveryServicesVaultExtendedInfoData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryServicesVaultExtendedInfoData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryServicesVaultExtendedInfoData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryServicesVaultExtendedInfoData"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryServicesVaultExtendedInfoData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryServicesVaultExtendedInfoData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryServicesVaultExtendedInfoData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryServicesVaultExtendedInfoData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
