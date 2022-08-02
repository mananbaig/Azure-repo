// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerInstanceCapabilities
    {
        internal static ContainerInstanceCapabilities DeserializeContainerInstanceCapabilities(JsonElement element)
        {
            Optional<string> resourceType = default;
            Optional<string> osType = default;
            Optional<AzureLocation> location = default;
            Optional<string> ipAddressType = default;
            Optional<string> gpu = default;
            Optional<ContainerInstanceSupportedCapabilities> capabilities = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osType"))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipAddressType"))
                {
                    ipAddressType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("gpu"))
                {
                    gpu = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capabilities"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    capabilities = ContainerInstanceSupportedCapabilities.DeserializeContainerInstanceSupportedCapabilities(property.Value);
                    continue;
                }
            }
            return new ContainerInstanceCapabilities(resourceType.Value, osType.Value, Optional.ToNullable(location), ipAddressType.Value, gpu.Value, capabilities.Value);
        }
    }
}
