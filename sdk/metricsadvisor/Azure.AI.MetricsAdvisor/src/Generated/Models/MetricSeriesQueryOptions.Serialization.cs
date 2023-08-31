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
    internal partial class MetricSeriesQueryOptions : IUtf8JsonSerializable, IModelJsonSerializable<MetricSeriesQueryOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MetricSeriesQueryOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MetricSeriesQueryOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("activeSince"u8);
            writer.WriteStringValue(ActiveSince, "O");
            if (Optional.IsCollectionDefined(DimensionFilter))
            {
                writer.WritePropertyName("dimensionFilter"u8);
                writer.WriteStartObject();
                foreach (var item in DimensionFilter)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStartArray();
                    foreach (var item0 in item.Value)
                    {
                        writer.WriteStringValue(item0);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndObject();
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

        internal static MetricSeriesQueryOptions DeserializeMetricSeriesQueryOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset activeSince = default;
            Optional<IDictionary<string, IList<string>>> dimensionFilter = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activeSince"u8))
                {
                    activeSince = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("dimensionFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dictionary.Add(property0.Name, array);
                        }
                    }
                    dimensionFilter = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MetricSeriesQueryOptions(activeSince, Optional.ToDictionary(dimensionFilter), rawData);
        }

        MetricSeriesQueryOptions IModelJsonSerializable<MetricSeriesQueryOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMetricSeriesQueryOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MetricSeriesQueryOptions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MetricSeriesQueryOptions IModelSerializable<MetricSeriesQueryOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMetricSeriesQueryOptions(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MetricSeriesQueryOptions"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MetricSeriesQueryOptions"/> to convert. </param>
        public static implicit operator RequestContent(MetricSeriesQueryOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MetricSeriesQueryOptions"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MetricSeriesQueryOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMetricSeriesQueryOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
