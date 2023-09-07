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

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class AggregateVariable : IUtf8JsonSerializable, IModelJsonSerializable<AggregateVariable>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AggregateVariable>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AggregateVariable>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateVariable>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("aggregation"u8);
            if (Aggregation is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<TimeSeriesExpression>)Aggregation).Serialize(writer, options);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TimeSeriesExpression>)Filter).Serialize(writer, options);
                }
            }
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static AggregateVariable DeserializeAggregateVariable(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSeriesExpression aggregation = default;
            string kind = default;
            Optional<TimeSeriesExpression> filter = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("aggregation"u8))
                {
                    aggregation = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AggregateVariable(kind, filter.Value, aggregation, serializedAdditionalRawData);
        }

        AggregateVariable IModelJsonSerializable<AggregateVariable>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateVariable>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAggregateVariable(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AggregateVariable>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateVariable>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AggregateVariable IModelSerializable<AggregateVariable>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AggregateVariable>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAggregateVariable(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AggregateVariable"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AggregateVariable"/> to convert. </param>
        public static implicit operator RequestContent(AggregateVariable model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AggregateVariable"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AggregateVariable(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAggregateVariable(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
