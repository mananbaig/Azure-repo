// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AmlComputeNodeInformation
    {
        internal static AmlComputeNodeInformation DeserializeAmlComputeNodeInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nodeId = default;
            Core.Optional<IPAddress> privateIPAddress = default;
            Core.Optional<IPAddress> publicIPAddress = default;
            Core.Optional<int> port = default;
            Core.Optional<MachineLearningNodeState> nodeState = default;
            Core.Optional<string> runId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nodeId"u8))
                {
                    nodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        privateIPAddress = null;
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicIpAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        publicIPAddress = null;
                        continue;
                    }
                    publicIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeState = new MachineLearningNodeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runId = null;
                        continue;
                    }
                    runId = property.Value.GetString();
                    continue;
                }
            }
            return new AmlComputeNodeInformation(nodeId.Value, privateIPAddress.Value, publicIPAddress.Value, Core.Optional.ToNullable(port), Core.Optional.ToNullable(nodeState), runId.Value);
        }
    }
}
