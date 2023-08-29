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
    public partial class PostgreSqlFlexibleServerLtrBackupContent : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerLtrBackupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerLtrBackupContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerLtrBackupContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerLtrBackupContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("targetDetails"u8);
            writer.WriteObjectValue(TargetDetails);
            writer.WritePropertyName("backupSettings"u8);
            writer.WriteObjectValue(BackupSettings);
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

        internal static PostgreSqlFlexibleServerLtrBackupContent DeserializePostgreSqlFlexibleServerLtrBackupContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PostgreSqlFlexibleServerBackupStoreDetails targetDetails = default;
            PostgreSqlFlexibleServerBackupSettings backupSettings = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetDetails"u8))
                {
                    targetDetails = PostgreSqlFlexibleServerBackupStoreDetails.DeserializePostgreSqlFlexibleServerBackupStoreDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("backupSettings"u8))
                {
                    backupSettings = PostgreSqlFlexibleServerBackupSettings.DeserializePostgreSqlFlexibleServerBackupSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerLtrBackupContent(backupSettings, targetDetails, rawData);
        }

        PostgreSqlFlexibleServerLtrBackupContent IModelJsonSerializable<PostgreSqlFlexibleServerLtrBackupContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerLtrBackupContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerLtrBackupContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerLtrBackupContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerLtrBackupContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerLtrBackupContent IModelSerializable<PostgreSqlFlexibleServerLtrBackupContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerLtrBackupContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerLtrBackupContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlFlexibleServerLtrBackupContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlFlexibleServerLtrBackupContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerLtrBackupContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
