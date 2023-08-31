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
    public partial class ContainerServiceMaintenanceSchedule : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceMaintenanceSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceMaintenanceSchedule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceMaintenanceSchedule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Daily))
            {
                writer.WritePropertyName("daily"u8);
                if (Daily is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DailySchedule>)Daily).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Weekly))
            {
                writer.WritePropertyName("weekly"u8);
                if (Weekly is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerServiceMaintenanceWeeklySchedule>)Weekly).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AbsoluteMonthly))
            {
                writer.WritePropertyName("absoluteMonthly"u8);
                if (AbsoluteMonthly is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerServiceMaintenanceAbsoluteMonthlySchedule>)AbsoluteMonthly).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RelativeMonthly))
            {
                writer.WritePropertyName("relativeMonthly"u8);
                if (RelativeMonthly is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContainerServiceMaintenanceRelativeMonthlySchedule>)RelativeMonthly).Serialize(writer, options);
                }
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

        internal static ContainerServiceMaintenanceSchedule DeserializeContainerServiceMaintenanceSchedule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DailySchedule> daily = default;
            Optional<ContainerServiceMaintenanceWeeklySchedule> weekly = default;
            Optional<ContainerServiceMaintenanceAbsoluteMonthlySchedule> absoluteMonthly = default;
            Optional<ContainerServiceMaintenanceRelativeMonthlySchedule> relativeMonthly = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("daily"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    daily = DailySchedule.DeserializeDailySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("weekly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    weekly = ContainerServiceMaintenanceWeeklySchedule.DeserializeContainerServiceMaintenanceWeeklySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("absoluteMonthly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    absoluteMonthly = ContainerServiceMaintenanceAbsoluteMonthlySchedule.DeserializeContainerServiceMaintenanceAbsoluteMonthlySchedule(property.Value);
                    continue;
                }
                if (property.NameEquals("relativeMonthly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relativeMonthly = ContainerServiceMaintenanceRelativeMonthlySchedule.DeserializeContainerServiceMaintenanceRelativeMonthlySchedule(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceMaintenanceSchedule(daily.Value, weekly.Value, absoluteMonthly.Value, relativeMonthly.Value, rawData);
        }

        ContainerServiceMaintenanceSchedule IModelJsonSerializable<ContainerServiceMaintenanceSchedule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceMaintenanceSchedule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceMaintenanceSchedule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceMaintenanceSchedule IModelSerializable<ContainerServiceMaintenanceSchedule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceMaintenanceSchedule(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerServiceMaintenanceSchedule"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerServiceMaintenanceSchedule"/> to convert. </param>
        public static implicit operator RequestContent(ContainerServiceMaintenanceSchedule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerServiceMaintenanceSchedule"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerServiceMaintenanceSchedule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceMaintenanceSchedule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
