// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Routing.Models
{
    internal partial class GeoJsonFeatureData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("geometry");
            writer.WriteObjectValue(Geometry);
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteObjectValue(Properties);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(FeatureType))
            {
                writer.WritePropertyName("featureType");
                writer.WriteStringValue(FeatureType);
            }
            writer.WriteEndObject();
        }
    }
}
