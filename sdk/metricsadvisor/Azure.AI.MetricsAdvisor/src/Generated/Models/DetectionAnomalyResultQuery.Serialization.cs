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
    internal partial class DetectionAnomalyResultQuery : IUtf8JsonSerializable, IModelJsonSerializable<DetectionAnomalyResultQuery>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DetectionAnomalyResultQuery>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DetectionAnomalyResultQuery>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartTime, "O");
            writer.WritePropertyName("endTime"u8);
            writer.WriteStringValue(EndTime, "O");
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DetectionAnomalyFilterCondition>)Filter).Serialize(writer, options);
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

        internal static DetectionAnomalyResultQuery DeserializeDetectionAnomalyResultQuery(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset startTime = default;
            DateTimeOffset endTime = default;
            Optional<DetectionAnomalyFilterCondition> filter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"u8))
                {
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = DetectionAnomalyFilterCondition.DeserializeDetectionAnomalyFilterCondition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DetectionAnomalyResultQuery(startTime, endTime, filter.Value, rawData);
        }

        DetectionAnomalyResultQuery IModelJsonSerializable<DetectionAnomalyResultQuery>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDetectionAnomalyResultQuery(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DetectionAnomalyResultQuery>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DetectionAnomalyResultQuery IModelSerializable<DetectionAnomalyResultQuery>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDetectionAnomalyResultQuery(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DetectionAnomalyResultQuery"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DetectionAnomalyResultQuery"/> to convert. </param>
        public static implicit operator RequestContent(DetectionAnomalyResultQuery model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DetectionAnomalyResultQuery"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DetectionAnomalyResultQuery(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDetectionAnomalyResultQuery(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
