// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedServices.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedServices
{
    public partial class ManagedServicesRegistrationData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
            }
            if (Core.Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                writer.WriteObjectValue(Plan);
            }
            writer.WriteEndObject();
        }

        internal static ManagedServicesRegistrationData DeserializeManagedServicesRegistrationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ManagedServicesRegistrationProperties> properties = default;
            Core.Optional<ManagedServicesPlan> plan = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ManagedServicesRegistrationProperties.DeserializeManagedServicesRegistrationProperties(property.Value);
                    continue;
                }
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = ManagedServicesPlan.DeserializeManagedServicesPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
            }
            return new ManagedServicesRegistrationData(id, name, type, systemData.Value, properties.Value, plan.Value);
        }
    }
}
