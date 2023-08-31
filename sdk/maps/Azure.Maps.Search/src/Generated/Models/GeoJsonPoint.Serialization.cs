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

namespace Azure.Maps.Search.Models
{
    internal partial class GeoJsonPoint : IUtf8JsonSerializable, IModelJsonSerializable<GeoJsonPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<GeoJsonPoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<GeoJsonPoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GeoJsonPoint>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("coordinates"u8);
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToSerialString());
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

        internal static GeoJsonPoint DeserializeGeoJsonPoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<double> coordinates = default;
            GeoJsonObjectType type = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"u8))
                {
                    List<double> array = new List<double>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetDouble());
                    }
                    coordinates = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new GeoJsonPoint(type, coordinates, rawData);
        }

        GeoJsonPoint IModelJsonSerializable<GeoJsonPoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GeoJsonPoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeGeoJsonPoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<GeoJsonPoint>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GeoJsonPoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        GeoJsonPoint IModelSerializable<GeoJsonPoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<GeoJsonPoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeGeoJsonPoint(doc.RootElement, options);
        }

        public static implicit operator RequestContent(GeoJsonPoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator GeoJsonPoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeGeoJsonPoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
