// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class SessionHostHealthCheckFailureDetails
    {
        internal static SessionHostHealthCheckFailureDetails DeserializeSessionHostHealthCheckFailureDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> message = default;
            Core.Optional<int> errorCode = default;
            Core.Optional<DateTimeOffset> lastHealthCheckDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    errorCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("lastHealthCheckDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastHealthCheckDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new SessionHostHealthCheckFailureDetails(message.Value, Core.Optional.ToNullable(errorCode), Core.Optional.ToNullable(lastHealthCheckDateTime));
        }
    }
}
