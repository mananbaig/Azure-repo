// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class NetworkMappingFabricSpecificSettings
    {
        internal static NetworkMappingFabricSpecificSettings DeserializeNetworkMappingFabricSpecificSettings(JsonElement element)
        {
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureToAzure": return AzureToAzureNetworkMappingSettings.DeserializeAzureToAzureNetworkMappingSettings(element);
                    case "VmmToAzure": return VmmToAzureNetworkMappingSettings.DeserializeVmmToAzureNetworkMappingSettings(element);
                    case "VmmToVmm": return VmmToVmmNetworkMappingSettings.DeserializeVmmToVmmNetworkMappingSettings(element);
                }
            }
            string instanceType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
            }
            return new UnknownNetworkMappingFabricSpecificSettings(instanceType);
        }
    }
}
