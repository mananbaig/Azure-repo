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
    public partial class MaintenanceWindowTimeRange : IUtf8JsonSerializable, IModelJsonSerializable<MaintenanceWindowTimeRange>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MaintenanceWindowTimeRange>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MaintenanceWindowTimeRange>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaintenanceWindowTimeRange>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToString());
            }
            if (Optional.IsDefined(StartTime))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartTime);
            }
            if (Optional.IsDefined(Duration))
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteStringValue(Duration.Value, "P");
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

        internal static MaintenanceWindowTimeRange DeserializeMaintenanceWindowTimeRange(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlDayOfWeek> dayOfWeek = default;
            Optional<string> startTime = default;
            Optional<TimeSpan> duration = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = new SqlDayOfWeek(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MaintenanceWindowTimeRange(Optional.ToNullable(dayOfWeek), startTime.Value, Optional.ToNullable(duration), serializedAdditionalRawData);
        }

        MaintenanceWindowTimeRange IModelJsonSerializable<MaintenanceWindowTimeRange>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaintenanceWindowTimeRange>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMaintenanceWindowTimeRange(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MaintenanceWindowTimeRange>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaintenanceWindowTimeRange>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MaintenanceWindowTimeRange IModelSerializable<MaintenanceWindowTimeRange>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MaintenanceWindowTimeRange>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMaintenanceWindowTimeRange(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MaintenanceWindowTimeRange"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MaintenanceWindowTimeRange"/> to convert. </param>
        public static implicit operator RequestContent(MaintenanceWindowTimeRange model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MaintenanceWindowTimeRange"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MaintenanceWindowTimeRange(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMaintenanceWindowTimeRange(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
