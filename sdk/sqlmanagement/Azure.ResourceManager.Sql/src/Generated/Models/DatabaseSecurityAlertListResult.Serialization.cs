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
    internal partial class DatabaseSecurityAlertListResult : IUtf8JsonSerializable, IModelJsonSerializable<DatabaseSecurityAlertListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DatabaseSecurityAlertListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DatabaseSecurityAlertListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseSecurityAlertListResult>(this, options.Format);

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

        internal static DatabaseSecurityAlertListResult DeserializeDatabaseSecurityAlertListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SqlDatabaseSecurityAlertPolicyData>> value = default;
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
                    List<SqlDatabaseSecurityAlertPolicyData> array = new List<SqlDatabaseSecurityAlertPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDatabaseSecurityAlertPolicyData.DeserializeSqlDatabaseSecurityAlertPolicyData(item));
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
            return new DatabaseSecurityAlertListResult(Optional.ToList(value), nextLink.Value, serializedAdditionalRawData);
        }

        DatabaseSecurityAlertListResult IModelJsonSerializable<DatabaseSecurityAlertListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseSecurityAlertListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseSecurityAlertListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DatabaseSecurityAlertListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseSecurityAlertListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DatabaseSecurityAlertListResult IModelSerializable<DatabaseSecurityAlertListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DatabaseSecurityAlertListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDatabaseSecurityAlertListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DatabaseSecurityAlertListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DatabaseSecurityAlertListResult"/> to convert. </param>
        public static implicit operator RequestContent(DatabaseSecurityAlertListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DatabaseSecurityAlertListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DatabaseSecurityAlertListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDatabaseSecurityAlertListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
