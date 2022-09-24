// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class TargetComputeSizeProperties
    {
        internal static TargetComputeSizeProperties DeserializeTargetComputeSizeProperties(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> friendlyName = default;
            Optional<int> cpuCoresCount = default;
            Optional<int> vcpUsAvailable = default;
            Optional<double> memoryInGB = default;
            Optional<int> maxDataDiskCount = default;
            Optional<int> maxNicsCount = default;
            Optional<IReadOnlyList<ComputeSizeErrorDetails>> errors = default;
            Optional<string> highIopsSupported = default;
            Optional<IReadOnlyList<string>> hyperVGenerations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cpuCoresCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    cpuCoresCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("vCPUsAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    vcpUsAvailable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("memoryInGB"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    memoryInGB = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("maxDataDiskCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxDataDiskCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNicsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    maxNicsCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ComputeSizeErrorDetails> array = new List<ComputeSizeErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeSizeErrorDetails.DeserializeComputeSizeErrorDetails(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("highIopsSupported"))
                {
                    highIopsSupported = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("hyperVGenerations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    hyperVGenerations = array;
                    continue;
                }
            }
            return new TargetComputeSizeProperties(name.Value, friendlyName.Value, Optional.ToNullable(cpuCoresCount), Optional.ToNullable(vcpUsAvailable), Optional.ToNullable(memoryInGB), Optional.ToNullable(maxDataDiskCount), Optional.ToNullable(maxNicsCount), Optional.ToList(errors), highIopsSupported.Value, Optional.ToList(hyperVGenerations));
        }
    }
}
