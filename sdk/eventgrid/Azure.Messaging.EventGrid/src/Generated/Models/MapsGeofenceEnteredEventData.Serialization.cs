// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MapsGeofenceEnteredEventDataConverter))]
    public partial class MapsGeofenceEnteredEventData
    {
        internal static MapsGeofenceEnteredEventData DeserializeMapsGeofenceEnteredEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> expiredGeofenceGeometryId = default;
            IReadOnlyList<MapsGeofenceGeometry> geometries = default;
            IReadOnlyList<string> invalidPeriodGeofenceGeometryId = default;
            bool? isEventPublished = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("expiredGeofenceGeometryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    expiredGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("geometries"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsGeofenceGeometry> array = new List<MapsGeofenceGeometry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsGeofenceGeometry.DeserializeMapsGeofenceGeometry(item));
                    }
                    geometries = array;
                    continue;
                }
                if (property.NameEquals("invalidPeriodGeofenceGeometryId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    invalidPeriodGeofenceGeometryId = array;
                    continue;
                }
                if (property.NameEquals("isEventPublished"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isEventPublished = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MapsGeofenceEnteredEventData(expiredGeofenceGeometryId ?? new ChangeTrackingList<string>(), geometries ?? new ChangeTrackingList<MapsGeofenceGeometry>(), invalidPeriodGeofenceGeometryId ?? new ChangeTrackingList<string>(), isEventPublished);
        }

        internal partial class MapsGeofenceEnteredEventDataConverter : JsonConverter<MapsGeofenceEnteredEventData>
        {
            public override void Write(Utf8JsonWriter writer, MapsGeofenceEnteredEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override MapsGeofenceEnteredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMapsGeofenceEnteredEventData(document.RootElement);
            }
        }
    }
}
