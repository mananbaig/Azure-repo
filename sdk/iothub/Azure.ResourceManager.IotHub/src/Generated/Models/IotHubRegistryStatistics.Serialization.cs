// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class IotHubRegistryStatistics
    {
        internal static IotHubRegistryStatistics DeserializeIotHubRegistryStatistics(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<long> totalDeviceCount = default;
            Core.Optional<long> enabledDeviceCount = default;
            Core.Optional<long> disabledDeviceCount = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("enabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("disabledDeviceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disabledDeviceCount = property.Value.GetInt64();
                    continue;
                }
            }
            return new IotHubRegistryStatistics(Core.Optional.ToNullable(totalDeviceCount), Core.Optional.ToNullable(enabledDeviceCount), Core.Optional.ToNullable(disabledDeviceCount));
        }
    }
}
