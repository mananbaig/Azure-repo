// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceProvisioningServices;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    internal partial class PrivateLinkResources
    {
        internal static PrivateLinkResources DeserializePrivateLinkResources(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<DeviceProvisioningServicesPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeviceProvisioningServicesPrivateLinkResourceData> array = new List<DeviceProvisioningServicesPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeviceProvisioningServicesPrivateLinkResourceData.DeserializeDeviceProvisioningServicesPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PrivateLinkResources(Core.Optional.ToList(value));
        }
    }
}
