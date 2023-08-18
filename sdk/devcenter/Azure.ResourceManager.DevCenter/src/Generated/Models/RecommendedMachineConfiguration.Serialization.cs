// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class RecommendedMachineConfiguration
    {
        internal static RecommendedMachineConfiguration DeserializeRecommendedMachineConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DevCenterResourceRange> memory = default;
            Core.Optional<DevCenterResourceRange> vCpus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("memory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memory = DevCenterResourceRange.DeserializeDevCenterResourceRange(property.Value);
                    continue;
                }
                if (property.NameEquals("vCPUs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vCpus = DevCenterResourceRange.DeserializeDevCenterResourceRange(property.Value);
                    continue;
                }
            }
            return new RecommendedMachineConfiguration(memory.Value, vCpus.Value);
        }
    }
}
