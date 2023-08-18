// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    internal partial class SearchInsideGeometryRequest : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Geometry))
            {
                writer.WritePropertyName("geometry"u8);
                writer.WriteObjectValue(Geometry);
            }
            writer.WriteEndObject();
        }
    }
}
