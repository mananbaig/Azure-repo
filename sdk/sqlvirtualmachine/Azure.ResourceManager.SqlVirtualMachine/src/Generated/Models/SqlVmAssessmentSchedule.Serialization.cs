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

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class SqlVmAssessmentSchedule : IUtf8JsonSerializable, IModelJsonSerializable<SqlVmAssessmentSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlVmAssessmentSchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlVmAssessmentSchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlVmAssessmentSchedule>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enable"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(WeeklyInterval))
            {
                writer.WritePropertyName("weeklyInterval"u8);
                writer.WriteNumberValue(WeeklyInterval.Value);
            }
            if (Optional.IsDefined(MonthlyOccurrence))
            {
                writer.WritePropertyName("monthlyOccurrence"u8);
                writer.WriteNumberValue(MonthlyOccurrence.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime);
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

        internal static SqlVmAssessmentSchedule DeserializeSqlVmAssessmentSchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enable = default;
            Optional<int> weeklyInterval = default;
            Optional<int> monthlyOccurrence = default;
            Optional<SqlVmAssessmentDayOfWeek> dayOfWeek = default;
            Optional<string> startTime = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("weeklyInterval"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weeklyInterval = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("monthlyOccurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monthlyOccurrence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToSqlVmAssessmentDayOfWeek();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SqlVmAssessmentSchedule(Optional.ToNullable(enable), Optional.ToNullable(weeklyInterval), Optional.ToNullable(monthlyOccurrence), Optional.ToNullable(dayOfWeek), startTime.Value, serializedAdditionalRawData);
        }

        SqlVmAssessmentSchedule IModelJsonSerializable<SqlVmAssessmentSchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlVmAssessmentSchedule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlVmAssessmentSchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlVmAssessmentSchedule>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlVmAssessmentSchedule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlVmAssessmentSchedule IModelSerializable<SqlVmAssessmentSchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SqlVmAssessmentSchedule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlVmAssessmentSchedule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlVmAssessmentSchedule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlVmAssessmentSchedule"/> to convert. </param>
        public static implicit operator RequestContent(SqlVmAssessmentSchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlVmAssessmentSchedule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlVmAssessmentSchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlVmAssessmentSchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
