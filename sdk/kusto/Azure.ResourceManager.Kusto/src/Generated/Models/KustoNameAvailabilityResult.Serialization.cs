// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoNameAvailabilityResult
    {
        internal static KustoNameAvailabilityResult DeserializeKustoNameAvailabilityResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<bool> nameAvailable = default;
            Core.Optional<string> name = default;
            Core.Optional<string> message = default;
            Core.Optional<KustoNameUnavailableReason> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = new KustoNameUnavailableReason(property.Value.GetString());
                    continue;
                }
            }
            return new KustoNameAvailabilityResult(Core.Optional.ToNullable(nameAvailable), name.Value, message.Value, Core.Optional.ToNullable(reason));
        }
    }
}
