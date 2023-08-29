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
    public partial class PostgreSqlFlexibleServerMaintenanceWindow : IUtf8JsonSerializable, IModelJsonSerializable<PostgreSqlFlexibleServerMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PostgreSqlFlexibleServerMaintenanceWindow>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PostgreSqlFlexibleServerMaintenanceWindow>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CustomWindow))
            {
                writer.WritePropertyName("customWindow"u8);
                writer.WriteStringValue(CustomWindow);
            }
            if (Optional.IsDefined(StartHour))
            {
                writer.WritePropertyName("startHour"u8);
                writer.WriteNumberValue(StartHour.Value);
            }
            if (Optional.IsDefined(StartMinute))
            {
                writer.WritePropertyName("startMinute"u8);
                writer.WriteNumberValue(StartMinute.Value);
            }
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteNumberValue(DayOfWeek.Value);
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

        internal static PostgreSqlFlexibleServerMaintenanceWindow DeserializePostgreSqlFlexibleServerMaintenanceWindow(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> customWindow = default;
            Optional<int> startHour = default;
            Optional<int> startMinute = default;
            Optional<int> dayOfWeek = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customWindow"u8))
                {
                    customWindow = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startHour"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startHour = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startMinute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startMinute = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PostgreSqlFlexibleServerMaintenanceWindow(customWindow.Value, Optional.ToNullable(startHour), Optional.ToNullable(startMinute), Optional.ToNullable(dayOfWeek), rawData);
        }

        PostgreSqlFlexibleServerMaintenanceWindow IModelJsonSerializable<PostgreSqlFlexibleServerMaintenanceWindow>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePostgreSqlFlexibleServerMaintenanceWindow(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PostgreSqlFlexibleServerMaintenanceWindow>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PostgreSqlFlexibleServerMaintenanceWindow IModelSerializable<PostgreSqlFlexibleServerMaintenanceWindow>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePostgreSqlFlexibleServerMaintenanceWindow(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PostgreSqlFlexibleServerMaintenanceWindow model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PostgreSqlFlexibleServerMaintenanceWindow(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePostgreSqlFlexibleServerMaintenanceWindow(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
