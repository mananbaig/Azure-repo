// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.IoT.Hub.Service.Models
{
    public partial class PurgeMessageQueueResult
    {
        internal static PurgeMessageQueueResult DeserializePurgeMessageQueueResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? totalMessagesPurged = default;
            string deviceId = default;
            string moduleId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("totalMessagesPurged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalMessagesPurged = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("deviceId"u8))
                {
                    deviceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("moduleId"u8))
                {
                    moduleId = property.Value.GetString();
                    continue;
                }
            }
            return new PurgeMessageQueueResult(totalMessagesPurged, deviceId, moduleId);
        }
    }
}
