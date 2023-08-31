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
    public partial class SmartDetectionCondition : IUtf8JsonSerializable, IModelJsonSerializable<SmartDetectionCondition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SmartDetectionCondition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SmartDetectionCondition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sensitivity"u8);
            writer.WriteNumberValue(Sensitivity);
            writer.WritePropertyName("anomalyDetectorDirection"u8);
            writer.WriteStringValue(AnomalyDetectorDirection.ToString());
            writer.WritePropertyName("suppressCondition"u8);
            if (SuppressCondition is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<SuppressCondition>)SuppressCondition).Serialize(writer, options);
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

        internal static SmartDetectionCondition DeserializeSmartDetectionCondition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            double sensitivity = default;
            AnomalyDetectorDirection anomalyDetectorDirection = default;
            SuppressCondition suppressCondition = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sensitivity"u8))
                {
                    sensitivity = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("anomalyDetectorDirection"u8))
                {
                    anomalyDetectorDirection = new AnomalyDetectorDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("suppressCondition"u8))
                {
                    suppressCondition = Models.SuppressCondition.DeserializeSuppressCondition(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SmartDetectionCondition(sensitivity, anomalyDetectorDirection, suppressCondition, rawData);
        }

        SmartDetectionCondition IModelJsonSerializable<SmartDetectionCondition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSmartDetectionCondition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SmartDetectionCondition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SmartDetectionCondition IModelSerializable<SmartDetectionCondition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSmartDetectionCondition(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SmartDetectionCondition"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SmartDetectionCondition"/> to convert. </param>
        public static implicit operator RequestContent(SmartDetectionCondition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SmartDetectionCondition"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SmartDetectionCondition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSmartDetectionCondition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
