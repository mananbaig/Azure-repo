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

namespace Azure.ResourceManager.PostgreSql.Models
{
    public partial class PostgreSqlServerPropertiesForGeoRestore : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlServerPropertiesForGeoRestore>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlServerPropertiesForGeoRestore>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlServerPropertiesForGeoRestore>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlServerPropertiesForGeoRestore>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceServerId"u8);
            writer.WriteStringValue(SourceServerId);
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            if (Optional.IsDefined(SslEnforcement))
            {
                writer.WritePropertyName("sslEnforcement"u8);
                writer.WriteStringValue(SslEnforcement.Value.ToSerialString());
            }
            if (Optional.IsDefined(MinimalTlsVersion))
            {
                writer.WritePropertyName("minimalTlsVersion"u8);
                writer.WriteStringValue(MinimalTlsVersion.Value.ToString());
            }
            if (Optional.IsDefined(InfrastructureEncryption))
            {
                writer.WritePropertyName("infrastructureEncryption"u8);
                writer.WriteStringValue(InfrastructureEncryption.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile"u8);
                writer.WriteObjectValue(StorageProfile);
            }
            writer.WritePropertyName("createMode"u8);
            writer.WriteStringValue(CreateMode.ToString());
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

        internal static PostgreSqlServerPropertiesForGeoRestore DeserializePostgreSqlServerPropertiesForGeoRestore(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sourceServerId = default;
            Optional<PostgreSqlServerVersion> version = default;
            Optional<PostgreSqlSslEnforcementEnum> sslEnforcement = default;
            Optional<PostgreSqlMinimalTlsVersionEnum> minimalTlsVersion = default;
            Optional<PostgreSqlInfrastructureEncryption> infrastructureEncryption = default;
            Optional<PostgreSqlPublicNetworkAccessEnum> publicNetworkAccess = default;
            Optional<PostgreSqlStorageProfile> storageProfile = default;
            PostgreSqlCreateMode createMode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceServerId"u8))
                {
                    sourceServerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("version"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = new PostgreSqlServerVersion(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sslEnforcement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sslEnforcement = property.Value.GetString().ToPostgreSqlSslEnforcementEnum();
                    continue;
                }
                if (property.NameEquals("minimalTlsVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimalTlsVersion = new PostgreSqlMinimalTlsVersionEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("infrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    infrastructureEncryption = new PostgreSqlInfrastructureEncryption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PostgreSqlPublicNetworkAccessEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageProfile = PostgreSqlStorageProfile.DeserializePostgreSqlStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    createMode = new PostgreSqlCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlServerPropertiesForGeoRestore(Optional.ToNullable(version), Optional.ToNullable(sslEnforcement), Optional.ToNullable(minimalTlsVersion), Optional.ToNullable(infrastructureEncryption), Optional.ToNullable(publicNetworkAccess), storageProfile.Value, createMode, sourceServerId, rawData);
        }

        PostgreSqlServerPropertiesForGeoRestore IModelJsonSerializable<PostgreSqlServerPropertiesForGeoRestore>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlServerPropertiesForGeoRestore>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlServerPropertiesForGeoRestore(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlServerPropertiesForGeoRestore>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlServerPropertiesForGeoRestore>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlServerPropertiesForGeoRestore IModelSerializable<PostgreSqlServerPropertiesForGeoRestore>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlServerPropertiesForGeoRestore>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlServerPropertiesForGeoRestore(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlServerPropertiesForGeoRestore model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlServerPropertiesForGeoRestore(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlServerPropertiesForGeoRestore(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
