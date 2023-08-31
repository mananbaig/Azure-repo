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

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    public partial class PostgreSqlFlexibleServerDataEncryption : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerDataEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerDataEncryption>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerDataEncryption>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryKeyUri))
            {
                writer.WritePropertyName("primaryKeyURI"u8);
                writer.WriteStringValue(PrimaryKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(PrimaryUserAssignedIdentityId))
            {
                writer.WritePropertyName("primaryUserAssignedIdentityId"u8);
                writer.WriteStringValue(PrimaryUserAssignedIdentityId);
            }
            if (Optional.IsDefined(GeoBackupKeyUri))
            {
                writer.WritePropertyName("geoBackupKeyURI"u8);
                writer.WriteStringValue(GeoBackupKeyUri.AbsoluteUri);
            }
            if (Optional.IsDefined(GeoBackupUserAssignedIdentityId))
            {
                writer.WritePropertyName("geoBackupUserAssignedIdentityId"u8);
                writer.WriteStringValue(GeoBackupUserAssignedIdentityId);
            }
            if (Optional.IsDefined(KeyType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            if (Optional.IsDefined(PrimaryEncryptionKeyStatus))
            {
                writer.WritePropertyName("primaryEncryptionKeyStatus"u8);
                writer.WriteStringValue(PrimaryEncryptionKeyStatus.Value.ToString());
            }
            if (Optional.IsDefined(GeoBackupEncryptionKeyStatus))
            {
                writer.WritePropertyName("geoBackupEncryptionKeyStatus"u8);
                writer.WriteStringValue(GeoBackupEncryptionKeyStatus.Value.ToString());
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

        internal static PostgreSqlFlexibleServerDataEncryption DeserializePostgreSqlFlexibleServerDataEncryption(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> primaryKeyUri = default;
            Optional<ResourceIdentifier> primaryUserAssignedIdentityId = default;
            Optional<Uri> geoBackupKeyUri = default;
            Optional<string> geoBackupUserAssignedIdentityId = default;
            Optional<PostgreSqlFlexibleServerKeyType> type = default;
            Optional<PostgreSqlKeyStatus> primaryEncryptionKeyStatus = default;
            Optional<PostgreSqlKeyStatus> geoBackupEncryptionKeyStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryUserAssignedIdentityId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryUserAssignedIdentityId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupKeyURI"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupKeyUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupUserAssignedIdentityId"u8))
                {
                    geoBackupUserAssignedIdentityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new PostgreSqlFlexibleServerKeyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("geoBackupEncryptionKeyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    geoBackupEncryptionKeyStatus = new PostgreSqlKeyStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerDataEncryption(primaryKeyUri.Value, primaryUserAssignedIdentityId.Value, geoBackupKeyUri.Value, geoBackupUserAssignedIdentityId.Value, Optional.ToNullable(type), Optional.ToNullable(primaryEncryptionKeyStatus), Optional.ToNullable(geoBackupEncryptionKeyStatus), rawData);
        }

        PostgreSqlFlexibleServerDataEncryption IModelJsonSerializable<PostgreSqlFlexibleServerDataEncryption>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerDataEncryption(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerDataEncryption>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerDataEncryption IModelSerializable<PostgreSqlFlexibleServerDataEncryption>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerDataEncryption(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlFlexibleServerDataEncryption"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlFlexibleServerDataEncryption"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlFlexibleServerDataEncryption model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlFlexibleServerDataEncryption"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlFlexibleServerDataEncryption(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerDataEncryption(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
