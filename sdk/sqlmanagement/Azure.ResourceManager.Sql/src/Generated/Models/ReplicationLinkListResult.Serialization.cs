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
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class ReplicationLinkListResult : IUtf8JsonSerializable, IModelJsonSerializable<ReplicationLinkListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReplicationLinkListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReplicationLinkListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationLinkListResult>(this, options.Format);

            writer.WriteStartObject();
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

        internal static ReplicationLinkListResult DeserializeReplicationLinkListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SqlServerDatabaseReplicationLinkData>> value = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlServerDatabaseReplicationLinkData> array = new List<SqlServerDatabaseReplicationLinkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlServerDatabaseReplicationLinkData.DeserializeSqlServerDatabaseReplicationLinkData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReplicationLinkListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        ReplicationLinkListResult IModelJsonSerializable<ReplicationLinkListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationLinkListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationLinkListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReplicationLinkListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationLinkListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReplicationLinkListResult IModelSerializable<ReplicationLinkListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ReplicationLinkListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReplicationLinkListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReplicationLinkListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReplicationLinkListResult"/> to convert. </param>
        public static implicit operator RequestContent(ReplicationLinkListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReplicationLinkListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReplicationLinkListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReplicationLinkListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
