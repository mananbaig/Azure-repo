// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class Pav2MeterDetails
    {
        internal static Pav2MeterDetails DeserializePav2MeterDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<Guid> meterGuid = default;
            BillingType billingType = default;
            Core.Optional<double> multiplier = default;
            Core.Optional<EdgeOrderProductChargingType> chargingType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("meterGuid"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    meterGuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("billingType"u8))
                {
                    billingType = new BillingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("multiplier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multiplier = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("chargingType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    chargingType = new EdgeOrderProductChargingType(property.Value.GetString());
                    continue;
                }
            }
            return new Pav2MeterDetails(billingType, Core.Optional.ToNullable(multiplier), Core.Optional.ToNullable(chargingType), Core.Optional.ToNullable(meterGuid));
        }
    }
}
