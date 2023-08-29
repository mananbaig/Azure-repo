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

namespace Azure.ResourceManager.MySql.Models
{
    public partial class MySqlTopQueryStatisticsInput : IUtf8JsonSerializable, IModelJsonSerializable<MySqlTopQueryStatisticsInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MySqlTopQueryStatisticsInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MySqlTopQueryStatisticsInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("numberOfTopQueries"u8);
            writer.WriteNumberValue(NumberOfTopQueries);
            writer.WritePropertyName("aggregationFunction"u8);
            writer.WriteStringValue(AggregationFunction);
            writer.WritePropertyName("observedMetric"u8);
            writer.WriteStringValue(ObservedMetric);
            writer.WritePropertyName("observationStartTime"u8);
            writer.WriteStringValue(ObservationStartOn, "O");
            writer.WritePropertyName("observationEndTime"u8);
            writer.WriteStringValue(ObservationEndOn, "O");
            writer.WritePropertyName("aggregationWindow"u8);
            writer.WriteStringValue(AggregationWindow);
            writer.WriteEndObject();
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

        internal static MySqlTopQueryStatisticsInput DeserializeMySqlTopQueryStatisticsInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int numberOfTopQueries = default;
            string aggregationFunction = default;
            string observedMetric = default;
            DateTimeOffset observationStartTime = default;
            DateTimeOffset observationEndTime = default;
            string aggregationWindow = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("numberOfTopQueries"u8))
                        {
                            numberOfTopQueries = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("aggregationFunction"u8))
                        {
                            aggregationFunction = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("observedMetric"u8))
                        {
                            observedMetric = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("observationStartTime"u8))
                        {
                            observationStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("observationEndTime"u8))
                        {
                            observationEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("aggregationWindow"u8))
                        {
                            aggregationWindow = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MySqlTopQueryStatisticsInput(numberOfTopQueries, aggregationFunction, observedMetric, observationStartTime, observationEndTime, aggregationWindow, rawData);
        }

        MySqlTopQueryStatisticsInput IModelJsonSerializable<MySqlTopQueryStatisticsInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlTopQueryStatisticsInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MySqlTopQueryStatisticsInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MySqlTopQueryStatisticsInput IModelSerializable<MySqlTopQueryStatisticsInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMySqlTopQueryStatisticsInput(doc.RootElement, options);
        }

        public static implicit operator RequestContent(MySqlTopQueryStatisticsInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator MySqlTopQueryStatisticsInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMySqlTopQueryStatisticsInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
