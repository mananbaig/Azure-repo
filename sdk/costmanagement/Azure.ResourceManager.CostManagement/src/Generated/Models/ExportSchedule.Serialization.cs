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

namespace Azure.ResourceManager.CostManagement.Models
{
    public partial class ExportSchedule : IUtf8JsonSerializable, IModelJsonSerializable<ExportSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExportSchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExportSchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Recurrence))
            {
                writer.WritePropertyName("recurrence"u8);
                writer.WriteStringValue(Recurrence.Value.ToString());
            }
            if (Optional.IsDefined(RecurrencePeriod))
            {
                writer.WritePropertyName("recurrencePeriod"u8);
                writer.WriteObjectValue(RecurrencePeriod);
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

        internal static ExportSchedule DeserializeExportSchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExportScheduleStatusType> status = default;
            Optional<ExportScheduleRecurrenceType> recurrence = default;
            Optional<ExportRecurrencePeriod> recurrencePeriod = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ExportScheduleStatusType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recurrence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrence = new ExportScheduleRecurrenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recurrencePeriod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recurrencePeriod = ExportRecurrencePeriod.DeserializeExportRecurrencePeriod(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ExportSchedule(Optional.ToNullable(status), Optional.ToNullable(recurrence), recurrencePeriod.Value, rawData);
        }

        ExportSchedule IModelJsonSerializable<ExportSchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExportSchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExportSchedule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExportSchedule IModelSerializable<ExportSchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExportSchedule(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ExportSchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ExportSchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExportSchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
