// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Temp.Batch.Models
{
    public partial class NodeCounts
    {
        internal static NodeCounts DeserializeNodeCounts(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int creating = default;
            int idle = default;
            int offline = default;
            int preempted = default;
            int rebooting = default;
            int reimaging = default;
            int running = default;
            int starting = default;
            int startTaskFailed = default;
            int leavingPool = default;
            int unknown = default;
            int unusable = default;
            int waitingForStartTask = default;
            int total = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("creating"u8))
                {
                    creating = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("idle"u8))
                {
                    idle = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("offline"u8))
                {
                    offline = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preempted"u8))
                {
                    preempted = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rebooting"u8))
                {
                    rebooting = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reimaging"u8))
                {
                    reimaging = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("running"u8))
                {
                    running = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("starting"u8))
                {
                    starting = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("startTaskFailed"u8))
                {
                    startTaskFailed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("leavingPool"u8))
                {
                    leavingPool = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unknown"u8))
                {
                    unknown = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("unusable"u8))
                {
                    unusable = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("waitingForStartTask"u8))
                {
                    waitingForStartTask = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"u8))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
            }
            return new NodeCounts(creating, idle, offline, preempted, rebooting, reimaging, running, starting, startTaskFailed, leavingPool, unknown, unusable, waitingForStartTask, total);
        }
    }
}
