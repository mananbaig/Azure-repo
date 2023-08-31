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

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraReaperStatus : IUtf8JsonSerializable, IModelJsonSerializable<CassandraReaperStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CassandraReaperStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CassandraReaperStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsHealthy))
            {
                writer.WritePropertyName("healthy"u8);
                writer.WriteBooleanValue(IsHealthy.Value);
            }
            if (Optional.IsCollectionDefined(RepairRunIds))
            {
                writer.WritePropertyName("repairRunIds"u8);
                writer.WriteStartObject();
                foreach (var item in RepairRunIds)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(RepairSchedules))
            {
                writer.WritePropertyName("repairSchedules"u8);
                writer.WriteStartObject();
                foreach (var item in RepairSchedules)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static CassandraReaperStatus DeserializeCassandraReaperStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> healthy = default;
            Optional<IReadOnlyDictionary<string, string>> repairRunIds = default;
            Optional<IReadOnlyDictionary<string, string>> repairSchedules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("healthy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("repairRunIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    repairRunIds = dictionary;
                    continue;
                }
                if (property.NameEquals("repairSchedules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    repairSchedules = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CassandraReaperStatus(Optional.ToNullable(healthy), Optional.ToDictionary(repairRunIds), Optional.ToDictionary(repairSchedules), rawData);
        }

        CassandraReaperStatus IModelJsonSerializable<CassandraReaperStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCassandraReaperStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CassandraReaperStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CassandraReaperStatus IModelSerializable<CassandraReaperStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCassandraReaperStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CassandraReaperStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CassandraReaperStatus"/> to convert. </param>
        public static implicit operator RequestContent(CassandraReaperStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CassandraReaperStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CassandraReaperStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCassandraReaperStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
