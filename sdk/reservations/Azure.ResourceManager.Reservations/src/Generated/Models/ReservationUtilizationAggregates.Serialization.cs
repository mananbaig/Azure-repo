// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationUtilizationAggregates
    {
        internal static ReservationUtilizationAggregates DeserializeReservationUtilizationAggregates(JsonElement element)
        {
            Optional<float> grain = default;
            Optional<string> grainUnit = default;
            Optional<float> value = default;
            Optional<string> valueUnit = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("grain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    grain = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("grainUnit"))
                {
                    grainUnit = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    value = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("valueUnit"))
                {
                    valueUnit = property.Value.GetString();
                    continue;
                }
            }
            return new ReservationUtilizationAggregates(Optional.ToNullable(grain), grainUnit.Value, Optional.ToNullable(value), valueUnit.Value);
        }
    }
}
