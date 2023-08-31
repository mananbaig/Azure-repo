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
    public partial class PostgreSqlMigrationSecretParameters : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlMigrationSecretParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlMigrationSecretParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlMigrationSecretParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("adminCredentials"u8);
            if (AdminCredentials is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<PostgreSqlMigrationAdminCredentials>)AdminCredentials).Serialize(writer, options);
            }
            if (Optional.IsDefined(SourceServerUsername))
            {
                writer.WritePropertyName("sourceServerUsername"u8);
                writer.WriteStringValue(SourceServerUsername);
            }
            if (Optional.IsDefined(TargetServerUsername))
            {
                writer.WritePropertyName("targetServerUsername"u8);
                writer.WriteStringValue(TargetServerUsername);
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

        internal static PostgreSqlMigrationSecretParameters DeserializePostgreSqlMigrationSecretParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlMigrationAdminCredentials adminCredentials = default;
            Optional<string> sourceServerUsername = default;
            Optional<string> targetServerUsername = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("adminCredentials"u8))
                {
                    adminCredentials = PostgreSqlMigrationAdminCredentials.DeserializePostgreSqlMigrationAdminCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceServerUsername"u8))
                {
                    sourceServerUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerUsername"u8))
                {
                    targetServerUsername = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlMigrationSecretParameters(adminCredentials, sourceServerUsername.Value, targetServerUsername.Value, rawData);
        }

        PostgreSqlMigrationSecretParameters IModelJsonSerializable<PostgreSqlMigrationSecretParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlMigrationSecretParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlMigrationSecretParameters>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlMigrationSecretParameters IModelSerializable<PostgreSqlMigrationSecretParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlMigrationSecretParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PostgreSqlMigrationSecretParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PostgreSqlMigrationSecretParameters"/> to convert. </param>
        public static implicit operator RequestContent(PostgreSqlMigrationSecretParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PostgreSqlMigrationSecretParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PostgreSqlMigrationSecretParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlMigrationSecretParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
