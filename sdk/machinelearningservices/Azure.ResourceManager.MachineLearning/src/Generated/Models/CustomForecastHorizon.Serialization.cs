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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class CustomForecastHorizon : IUtf8JsonSerializable, IModelJsonSerializable<CustomForecastHorizon>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomForecastHorizon>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomForecastHorizon>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomForecastHorizon>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
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

        internal static CustomForecastHorizon DeserializeCustomForecastHorizon(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            ForecastHorizonMode mode = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    mode = new ForecastHorizonMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomForecastHorizon(mode, value, rawData);
        }

        CustomForecastHorizon IModelJsonSerializable<CustomForecastHorizon>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomForecastHorizon>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomForecastHorizon(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomForecastHorizon>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomForecastHorizon>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomForecastHorizon IModelSerializable<CustomForecastHorizon>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CustomForecastHorizon>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomForecastHorizon(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CustomForecastHorizon model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CustomForecastHorizon(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomForecastHorizon(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
