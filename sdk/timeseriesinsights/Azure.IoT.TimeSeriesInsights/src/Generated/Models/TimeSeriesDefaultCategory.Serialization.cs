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
    public partial class TimeSeriesDefaultCategory : IUtf8JsonSerializable, IModelJsonSerializable<TimeSeriesDefaultCategory>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TimeSeriesDefaultCategory>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TimeSeriesDefaultCategory>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDefaultCategory>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("label"u8);
            writer.WriteStringValue(Label);
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

        internal static TimeSeriesDefaultCategory DeserializeTimeSeriesDefaultCategory(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string label = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TimeSeriesDefaultCategory(label, serializedAdditionalRawData);
        }

        TimeSeriesDefaultCategory IModelJsonSerializable<TimeSeriesDefaultCategory>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDefaultCategory>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTimeSeriesDefaultCategory(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TimeSeriesDefaultCategory>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDefaultCategory>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TimeSeriesDefaultCategory IModelSerializable<TimeSeriesDefaultCategory>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<TimeSeriesDefaultCategory>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTimeSeriesDefaultCategory(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TimeSeriesDefaultCategory"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TimeSeriesDefaultCategory"/> to convert. </param>
        public static implicit operator RequestContent(TimeSeriesDefaultCategory model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TimeSeriesDefaultCategory"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TimeSeriesDefaultCategory(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTimeSeriesDefaultCategory(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
