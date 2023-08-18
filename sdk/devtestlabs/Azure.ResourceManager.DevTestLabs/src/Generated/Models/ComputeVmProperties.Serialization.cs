// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class ComputeVmProperties
    {
        internal static ComputeVmProperties DeserializeComputeVmProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<ComputeVmInstanceViewStatus>> statuses = default;
            Core.Optional<string> osType = default;
            Core.Optional<string> vmSize = default;
            Core.Optional<string> networkInterfaceId = default;
            Core.Optional<string> osDiskId = default;
            Core.Optional<IReadOnlyList<string>> dataDiskIds = default;
            Core.Optional<IReadOnlyList<ComputeDataDisk>> dataDisks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statuses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeVmInstanceViewStatus> array = new List<ComputeVmInstanceViewStatus>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeVmInstanceViewStatus.DeserializeComputeVmInstanceViewStatus(item));
                    }
                    statuses = array;
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkInterfaceId"u8))
                {
                    networkInterfaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDiskId"u8))
                {
                    osDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataDiskIds"u8))
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
                    dataDiskIds = array;
                    continue;
                }
                if (property.NameEquals("dataDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComputeDataDisk> array = new List<ComputeDataDisk>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComputeDataDisk.DeserializeComputeDataDisk(item));
                    }
                    dataDisks = array;
                    continue;
                }
            }
            return new ComputeVmProperties(Core.Optional.ToList(statuses), osType.Value, vmSize.Value, networkInterfaceId.Value, osDiskId.Value, Core.Optional.ToList(dataDiskIds), Core.Optional.ToList(dataDisks));
        }
    }
}
