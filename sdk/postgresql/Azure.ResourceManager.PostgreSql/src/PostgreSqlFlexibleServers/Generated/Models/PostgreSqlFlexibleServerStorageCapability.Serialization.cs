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
    public partial class PostgreSqlFlexibleServerStorageCapability : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerStorageCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerStorageCapability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerStorageCapability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerStorageCapability>(this, options.Format);

            writer.WriteStartObject();
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

        internal static PostgreSqlFlexibleServerStorageCapability DeserializePostgreSqlFlexibleServerStorageCapability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<long> supportedIops = default;
            Optional<long> storageSizeMb = default;
            Optional<string> defaultIopsTier = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerStorageTierCapability>> supportedIopsTiers = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("supportedIops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedIops = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("storageSizeMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageSizeMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("defaultIopsTier"u8))
                {
                    defaultIopsTier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedIopsTiers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerStorageTierCapability> array = new List<PostgreSqlFlexibleServerStorageTierCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlFlexibleServerStorageTierCapability.DeserializePostgreSqlFlexibleServerStorageTierCapability(item));
                    }
                    supportedIopsTiers = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToPostgreSqlFlexbileServerCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerStorageCapability(Optional.ToNullable(status), reason.Value, Optional.ToNullable(supportedIops), Optional.ToNullable(storageSizeMb), defaultIopsTier.Value, Optional.ToList(supportedIopsTiers), rawData);
        }

        PostgreSqlFlexibleServerStorageCapability IModelJsonSerializable<PostgreSqlFlexibleServerStorageCapability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerStorageCapability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerStorageCapability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerStorageCapability>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerStorageCapability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerStorageCapability IModelSerializable<PostgreSqlFlexibleServerStorageCapability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerStorageCapability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerStorageCapability(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlFlexibleServerStorageCapability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlFlexibleServerStorageCapability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerStorageCapability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
