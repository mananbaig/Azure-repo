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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class MonthlyRetentionSchedule : IUtf8JsonSerializable, IModelJsonSerializable<MonthlyRetentionSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MonthlyRetentionSchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MonthlyRetentionSchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonthlyRetentionSchedule>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RetentionScheduleFormatType))
            {
                writer.WritePropertyName("retentionScheduleFormatType"u8);
                writer.WriteStringValue(RetentionScheduleFormatType.Value.ToString());
            }
            if (Optional.IsDefined(RetentionScheduleDaily))
            {
                writer.WritePropertyName("retentionScheduleDaily"u8);
                if (RetentionScheduleDaily is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DailyRetentionFormat>)RetentionScheduleDaily).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RetentionScheduleWeekly))
            {
                writer.WritePropertyName("retentionScheduleWeekly"u8);
                if (RetentionScheduleWeekly is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<WeeklyRetentionFormat>)RetentionScheduleWeekly).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(RetentionTimes))
            {
                writer.WritePropertyName("retentionTimes"u8);
                writer.WriteStartArray();
                foreach (var item in RetentionTimes)
                {
                    writer.WriteStringValue(item, "O");
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RetentionDuration))
            {
                writer.WritePropertyName("retentionDuration"u8);
                if (RetentionDuration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RetentionDuration>)RetentionDuration).Serialize(writer, options);
                }
            }
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

        internal static MonthlyRetentionSchedule DeserializeMonthlyRetentionSchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<RetentionScheduleFormat> retentionScheduleFormatType = default;
            Optional<DailyRetentionFormat> retentionScheduleDaily = default;
            Optional<WeeklyRetentionFormat> retentionScheduleWeekly = default;
            Optional<IList<DateTimeOffset>> retentionTimes = default;
            Optional<RetentionDuration> retentionDuration = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("retentionScheduleFormatType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleFormatType = new RetentionScheduleFormat(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("retentionScheduleDaily"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleDaily = DailyRetentionFormat.DeserializeDailyRetentionFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionScheduleWeekly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionScheduleWeekly = WeeklyRetentionFormat.DeserializeWeeklyRetentionFormat(property.Value);
                    continue;
                }
                if (property.NameEquals("retentionTimes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DateTimeOffset> array = new List<DateTimeOffset>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDateTimeOffset("O"));
                    }
                    retentionTimes = array;
                    continue;
                }
                if (property.NameEquals("retentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    retentionDuration = RetentionDuration.DeserializeRetentionDuration(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MonthlyRetentionSchedule(Optional.ToNullable(retentionScheduleFormatType), retentionScheduleDaily.Value, retentionScheduleWeekly.Value, Optional.ToList(retentionTimes), retentionDuration.Value, serializedAdditionalRawData);
        }

        MonthlyRetentionSchedule IModelJsonSerializable<MonthlyRetentionSchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonthlyRetentionSchedule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMonthlyRetentionSchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MonthlyRetentionSchedule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonthlyRetentionSchedule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MonthlyRetentionSchedule IModelSerializable<MonthlyRetentionSchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MonthlyRetentionSchedule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMonthlyRetentionSchedule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MonthlyRetentionSchedule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MonthlyRetentionSchedule"/> to convert. </param>
        public static implicit operator RequestContent(MonthlyRetentionSchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MonthlyRetentionSchedule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MonthlyRetentionSchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMonthlyRetentionSchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
