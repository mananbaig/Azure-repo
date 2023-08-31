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
    public partial class ForecastDataset : IUtf8JsonSerializable, IModelJsonSerializable<ForecastDataset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ForecastDataset>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ForecastDataset>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Granularity))
            {
                writer.WritePropertyName("granularity"u8);
                writer.WriteStringValue(Granularity.Value.ToString());
            }
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
                if (Configuration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ForecastDatasetConfiguration>)Configuration).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("aggregation"u8);
            writer.WriteStartObject();
            foreach (var item in Aggregation)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ForecastAggregation>)item.Value).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ForecastFilter>)Filter).Serialize(writer, options);
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

        internal static ForecastDataset DeserializeForecastDataset(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GranularityType> granularity = default;
            Optional<ForecastDatasetConfiguration> configuration = default;
            IDictionary<string, ForecastAggregation> aggregation = default;
            Optional<ForecastFilter> filter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("granularity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    granularity = new GranularityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = ForecastDatasetConfiguration.DeserializeForecastDatasetConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("aggregation"u8))
                {
                    Dictionary<string, ForecastAggregation> dictionary = new Dictionary<string, ForecastAggregation>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ForecastAggregation.DeserializeForecastAggregation(property0.Value));
                    }
                    aggregation = dictionary;
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = ForecastFilter.DeserializeForecastFilter(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ForecastDataset(Optional.ToNullable(granularity), configuration.Value, aggregation, filter.Value, rawData);
        }

        ForecastDataset IModelJsonSerializable<ForecastDataset>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeForecastDataset(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ForecastDataset>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ForecastDataset IModelSerializable<ForecastDataset>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeForecastDataset(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ForecastDataset"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ForecastDataset"/> to convert. </param>
        public static implicit operator RequestContent(ForecastDataset model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ForecastDataset"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ForecastDataset(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeForecastDataset(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
