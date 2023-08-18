// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class DeviceConnectionStateEventProperties
    {
        internal static DeviceConnectionStateEventProperties DeserializeDeviceConnectionStateEventProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> deviceId = default;
            Core.Optional<string> moduleId = default;
            Core.Optional<string> hubName = default;
            Core.Optional<DeviceConnectionStateEventInfo> deviceConnectionStateEventInfo = default;
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("hubName"u8))
                {
                    hubName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deviceConnectionStateEventInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceConnectionStateEventInfo = DeviceConnectionStateEventInfo.DeserializeDeviceConnectionStateEventInfo(property.Value);
                    continue;
                }
            }
            return new DeviceConnectionStateEventProperties(deviceId.Value, moduleId.Value, hubName.Value, deviceConnectionStateEventInfo.Value);
        }
    }
}
