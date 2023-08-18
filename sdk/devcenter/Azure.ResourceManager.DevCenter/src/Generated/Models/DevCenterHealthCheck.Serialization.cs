// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterHealthCheck
    {
        internal static DevCenterHealthCheck DeserializeDevCenterHealthCheck(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DevCenterHealthCheckStatus> status = default;
            Core.Optional<string> displayName = default;
            Core.Optional<DateTimeOffset> startDateTime = default;
            Core.Optional<DateTimeOffset> endDateTime = default;
            Core.Optional<string> errorType = default;
            Core.Optional<string> recommendedAction = default;
            Core.Optional<string> additionalDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new DevCenterHealthCheckStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errorType"u8))
                {
                    errorType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recommendedAction"u8))
                {
                    recommendedAction = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("additionalDetails"u8))
                {
                    additionalDetails = property.Value.GetString();
                    continue;
                }
            }
            return new DevCenterHealthCheck(Core.Optional.ToNullable(status), displayName.Value, Core.Optional.ToNullable(startDateTime), Core.Optional.ToNullable(endDateTime), errorType.Value, recommendedAction.Value, additionalDetails.Value);
        }
    }
}
