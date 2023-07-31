// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class ComputeNodeInformation
    {
        internal static ComputeNodeInformation DeserializeComputeNodeInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> affinityId = default;
            Optional<string> nodeUrl = default;
            Optional<string> poolId = default;
            Optional<string> nodeId = default;
            Optional<string> taskRootDirectory = default;
            Optional<string> taskRootDirectoryUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("affinityId"u8))
                {
                    affinityId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeUrl"u8))
                {
                    nodeUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("poolId"u8))
                {
                    poolId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskRootDirectory"u8))
                {
                    taskRootDirectory = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("taskRootDirectoryUrl"u8))
                {
                    taskRootDirectoryUrl = property.Value.GetString();
                    continue;
                }
            }
            return new ComputeNodeInformation(affinityId.Value, nodeUrl.Value, poolId.Value, nodeId.Value, taskRootDirectory.Value, taskRootDirectoryUrl.Value);
        }
    }
}
