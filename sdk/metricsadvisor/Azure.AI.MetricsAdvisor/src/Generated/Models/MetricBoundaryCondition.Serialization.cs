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

namespace Azure.AI.MetricsAdvisor.Models
{
    public partial class MetricBoundaryCondition : IUtf8JsonSerializable, IModelJsonSerializable<MetricBoundaryCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricBoundaryCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricBoundaryCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(LowerBound))
            {
                writer.WritePropertyName("lower"u8);
                writer.WriteNumberValue(LowerBound.Value);
            }
            if (Optional.IsDefined(UpperBound))
            {
                writer.WritePropertyName("upper"u8);
                writer.WriteNumberValue(UpperBound.Value);
            }
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            if (Optional.IsDefined(MeasureType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(MeasureType.Value.ToString());
            }
            if (Optional.IsDefined(CompanionMetricId))
            {
                writer.WritePropertyName("metricId"u8);
                writer.WriteStringValue(CompanionMetricId);
            }
            if (Optional.IsDefined(ShouldAlertIfDataPointMissing))
            {
                writer.WritePropertyName("triggerForMissing"u8);
                writer.WriteBooleanValue(ShouldAlertIfDataPointMissing.Value);
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

        internal static MetricBoundaryCondition DeserializeMetricBoundaryCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<double> lower = default;
            Optional<double> upper = default;
            BoundaryDirection direction = default;
            Optional<BoundaryMeasureType> type = default;
            Optional<string> metricId = default;
            Optional<bool> triggerForMissing = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lower"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lower = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("upper"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upper = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new BoundaryDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new BoundaryMeasureType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("metricId"u8))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("triggerForMissing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    triggerForMissing = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetricBoundaryCondition(Optional.ToNullable(lower), Optional.ToNullable(upper), direction, Optional.ToNullable(type), metricId.Value, Optional.ToNullable(triggerForMissing), rawData);
        }

        MetricBoundaryCondition IModelJsonSerializable<MetricBoundaryCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricBoundaryCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricBoundaryCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricBoundaryCondition IModelSerializable<MetricBoundaryCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricBoundaryCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MetricBoundaryCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MetricBoundaryCondition"/> to convert. </param>
        public static implicit operator RequestContent(MetricBoundaryCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MetricBoundaryCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MetricBoundaryCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricBoundaryCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
