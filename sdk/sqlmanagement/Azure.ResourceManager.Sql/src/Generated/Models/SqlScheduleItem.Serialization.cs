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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlScheduleItem : IUtf8JsonSerializable, IModelJsonSerializable<SqlScheduleItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlScheduleItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlScheduleItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScheduleItem>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("startDay"u8);
            writer.WriteStringValue(StartDay.ToString());
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime);
            writer.WritePropertyName("stopDay"u8);
            writer.WriteStringValue(StopDay.ToString());
            writer.WritePropertyName("stopTime"u8);
            writer.WriteStringValue(StopTime);
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

        internal static SqlScheduleItem DeserializeSqlScheduleItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SqlDayOfWeek startDay = default;
            string startTime = default;
            SqlDayOfWeek stopDay = default;
            string stopTime = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startDay"u8))
                {
                    startDay = new SqlDayOfWeek(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stopDay"u8))
                {
                    stopDay = new SqlDayOfWeek(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stopTime"u8))
                {
                    stopTime = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlScheduleItem(startDay, startTime, stopDay, stopTime, serializedAdditionalRawData);
        }

        SqlScheduleItem IModelJsonSerializable<SqlScheduleItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScheduleItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlScheduleItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlScheduleItem>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScheduleItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlScheduleItem IModelSerializable<SqlScheduleItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlScheduleItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlScheduleItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlScheduleItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlScheduleItem"/> to convert. </param>
        public static implicit operator RequestContent(SqlScheduleItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlScheduleItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlScheduleItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlScheduleItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
