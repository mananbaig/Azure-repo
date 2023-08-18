// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LabServices.Models
{
    public partial class AvailableLabServicesSkuCapacity
    {
        internal static AvailableLabServicesSkuCapacity DeserializeAvailableLabServicesSkuCapacity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<long> @default = default;
            Core.Optional<long> minimum = default;
            Core.Optional<long> maximum = default;
            Core.Optional<LabServicesSkuCapacityScaleType> scaleType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("default"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @default = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("minimum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("maximum"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximum = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("scaleType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scaleType = new LabServicesSkuCapacityScaleType(property.Value.GetString());
                    continue;
                }
            }
            return new AvailableLabServicesSkuCapacity(Core.Optional.ToNullable(@default), Core.Optional.ToNullable(minimum), Core.Optional.ToNullable(maximum), Core.Optional.ToNullable(scaleType));
        }
    }
}
