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
    public partial class PostgreSqlFlexibleServerSkuCapability : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerSkuCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerSkuCapability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerSkuCapability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerSkuCapability>(this, options.Format);

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

        internal static PostgreSqlFlexibleServerSkuCapability DeserializePostgreSqlFlexibleServerSkuCapability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> vCores = default;
            Optional<int> supportedIops = default;
            Optional<long> supportedMemoryPerVcoreMb = default;
            Optional<IReadOnlyList<string>> supportedZones = default;
            Optional<IReadOnlyList<PostgreSqlFlexibleServerHAMode>> supportedHaMode = default;
            Optional<PostgreSqlFlexbileServerCapabilityStatus> status = default;
            Optional<string> reason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vCores"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCores = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("supportedIops"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedIops = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("supportedMemoryPerVcoreMb"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    supportedMemoryPerVcoreMb = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("supportedZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedZones = array;
                    continue;
                }
                if (property.NameEquals("supportedHaMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlFlexibleServerHAMode> array = new List<PostgreSqlFlexibleServerHAMode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PostgreSqlFlexibleServerHAMode(item.GetString()));
                    }
                    supportedHaMode = array;
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
            return new PostgreSqlFlexibleServerSkuCapability(Optional.ToNullable(status), reason.Value, name.Value, Optional.ToNullable(vCores), Optional.ToNullable(supportedIops), Optional.ToNullable(supportedMemoryPerVcoreMb), Optional.ToList(supportedZones), Optional.ToList(supportedHaMode), rawData);
        }

        PostgreSqlFlexibleServerSkuCapability IModelJsonSerializable<PostgreSqlFlexibleServerSkuCapability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerSkuCapability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerSkuCapability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerSkuCapability>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerSkuCapability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerSkuCapability IModelSerializable<PostgreSqlFlexibleServerSkuCapability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<PostgreSqlFlexibleServerSkuCapability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerSkuCapability(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlFlexibleServerSkuCapability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlFlexibleServerSkuCapability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerSkuCapability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
