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
    public partial class DataFeedMetric : IUtf8JsonSerializable, IModelJsonSerializable<DataFeedMetric>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataFeedMetric>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataFeedMetric>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("metricName"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("metricDisplayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("metricDescription"u8);
                writer.WriteStringValue(Description);
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

        internal static DataFeedMetric DeserializeDataFeedMetric(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> metricId = default;
            string metricName = default;
            Optional<string> metricDisplayName = default;
            Optional<string> metricDescription = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("metricId"u8))
                {
                    metricId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricName"u8))
                {
                    metricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricDisplayName"u8))
                {
                    metricDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metricDescription"u8))
                {
                    metricDescription = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataFeedMetric(metricId.Value, metricName, metricDisplayName.Value, metricDescription.Value, rawData);
        }

        DataFeedMetric IModelJsonSerializable<DataFeedMetric>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFeedMetric(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataFeedMetric>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataFeedMetric IModelSerializable<DataFeedMetric>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataFeedMetric(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataFeedMetric model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataFeedMetric(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataFeedMetric(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
