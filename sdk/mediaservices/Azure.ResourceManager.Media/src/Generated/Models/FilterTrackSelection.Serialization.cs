// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class FilterTrackSelection : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("trackSelections"u8);
            writer.WriteStartArray();
            foreach (var item in TrackSelections)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static FilterTrackSelection DeserializeFilterTrackSelection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<FilterTrackPropertyCondition> trackSelections = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("trackSelections"u8))
                {
                    List<FilterTrackPropertyCondition> array = new List<FilterTrackPropertyCondition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FilterTrackPropertyCondition.DeserializeFilterTrackPropertyCondition(item));
                    }
                    trackSelections = array;
                    continue;
                }
            }
            return new FilterTrackSelection(trackSelections);
        }
    }
}
