// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsNameResult
    {
        internal static DigitalTwinsNameResult DeserializeDigitalTwinsNameResult(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<string> message = default;
            Optional<DigitalTwinsNameUnavailableReason?> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        message = null;
                        continue;
                    }
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        reason = null;
                        continue;
                    }
                    reason = new DigitalTwinsNameUnavailableReason(property.Value.GetString());
                    continue;
                }
            }
            return new DigitalTwinsNameResult(Optional.ToNullable(nameAvailable), message.Value, Optional.ToNullable(reason));
        }
    }
}
