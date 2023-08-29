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
    internal partial class PeriodFeedbackValue : IUtf8JsonSerializable, IModelJsonSerializable<PeriodFeedbackValue>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PeriodFeedbackValue>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PeriodFeedbackValue>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("periodType"u8);
            writer.WriteStringValue(PeriodType.ToString());
            writer.WritePropertyName("periodValue"u8);
            writer.WriteNumberValue(PeriodValue);
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

        internal static PeriodFeedbackValue DeserializePeriodFeedbackValue(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MetricPeriodType periodType = default;
            int periodValue = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("periodType"u8))
                {
                    periodType = new MetricPeriodType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("periodValue"u8))
                {
                    periodValue = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PeriodFeedbackValue(periodType, periodValue, rawData);
        }

        PeriodFeedbackValue IModelJsonSerializable<PeriodFeedbackValue>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePeriodFeedbackValue(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PeriodFeedbackValue>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PeriodFeedbackValue IModelSerializable<PeriodFeedbackValue>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePeriodFeedbackValue(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PeriodFeedbackValue model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PeriodFeedbackValue(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePeriodFeedbackValue(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
