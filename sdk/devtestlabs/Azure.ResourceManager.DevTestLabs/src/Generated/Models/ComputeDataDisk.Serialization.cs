// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class ComputeDataDisk
    {
        internal static ComputeDataDisk DeserializeComputeDataDisk(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<Uri> diskUri = default;
            Core.Optional<string> managedDiskId = default;
            Core.Optional<int> diskSizeGiB = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedDiskId"u8))
                {
                    managedDiskId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskSizeGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGiB = property.Value.GetInt32();
                    continue;
                }
            }
            return new ComputeDataDisk(name.Value, diskUri.Value, managedDiskId.Value, Core.Optional.ToNullable(diskSizeGiB));
        }
    }
}
