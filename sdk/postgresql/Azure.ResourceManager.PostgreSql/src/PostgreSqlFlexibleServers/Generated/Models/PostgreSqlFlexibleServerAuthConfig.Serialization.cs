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
    public partial class PostgreSqlFlexibleServerAuthConfig : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerAuthConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerAuthConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerAuthConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ActiveDirectoryAuth))
            {
                writer.WritePropertyName("activeDirectoryAuth"u8);
                writer.WriteStringValue(ActiveDirectoryAuth.Value.ToString());
            }
            if (Optional.IsDefined(PasswordAuth))
            {
                writer.WritePropertyName("passwordAuth"u8);
                writer.WriteStringValue(PasswordAuth.Value.ToString());
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
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

        internal static PostgreSqlFlexibleServerAuthConfig DeserializePostgreSqlFlexibleServerAuthConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PostgreSqlFlexibleServerActiveDirectoryAuthEnum> activeDirectoryAuth = default;
            Optional<PostgreSqlFlexibleServerPasswordAuthEnum> passwordAuth = default;
            Optional<Guid> tenantId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeDirectoryAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activeDirectoryAuth = new PostgreSqlFlexibleServerActiveDirectoryAuthEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("passwordAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    passwordAuth = new PostgreSqlFlexibleServerPasswordAuthEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerAuthConfig(Optional.ToNullable(activeDirectoryAuth), Optional.ToNullable(passwordAuth), Optional.ToNullable(tenantId), rawData);
        }

        PostgreSqlFlexibleServerAuthConfig IModelJsonSerializable<PostgreSqlFlexibleServerAuthConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerAuthConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerAuthConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerAuthConfig IModelSerializable<PostgreSqlFlexibleServerAuthConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerAuthConfig(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlFlexibleServerAuthConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlFlexibleServerAuthConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerAuthConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
