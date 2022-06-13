// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class GeoJsonFeatureCollection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("features");
            writer.WriteStartArray();
            foreach (var item in Features)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToSerialString());
            writer.WriteEndObject();
        }

        internal static GeoJsonFeatureCollection DeserializeGeoJsonFeatureCollection(JsonElement element)
        {
            IList<GeoJsonFeature> features = default;
            GeoJsonObjectType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("features"))
                {
                    List<GeoJsonFeature> array = new List<GeoJsonFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GeoJsonFeature.DeserializeGeoJsonFeature(item));
                    }
                    features = array;
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString().ToGeoJsonObjectType();
                    continue;
                }
            }
            return new GeoJsonFeatureCollection(type, features);
        }
    }
}
