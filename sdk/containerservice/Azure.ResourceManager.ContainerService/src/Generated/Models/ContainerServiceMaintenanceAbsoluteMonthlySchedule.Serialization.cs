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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceMaintenanceAbsoluteMonthlySchedule : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("intervalMonths"u8);
            writer.WriteNumberValue(IntervalMonths);
            writer.WritePropertyName("dayOfMonth"u8);
            writer.WriteNumberValue(DayOfMonth);
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

        internal static ContainerServiceMaintenanceAbsoluteMonthlySchedule DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int intervalMonths = default;
            int dayOfMonth = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intervalMonths"u8))
                {
                    intervalMonths = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dayOfMonth"u8))
                {
                    dayOfMonth = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceMaintenanceAbsoluteMonthlySchedule(intervalMonths, dayOfMonth, rawData);
        }

        ContainerServiceMaintenanceAbsoluteMonthlySchedule IModelJsonSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceMaintenanceAbsoluteMonthlySchedule IModelSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ContainerServiceMaintenanceAbsoluteMonthlySchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ContainerServiceMaintenanceAbsoluteMonthlySchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
