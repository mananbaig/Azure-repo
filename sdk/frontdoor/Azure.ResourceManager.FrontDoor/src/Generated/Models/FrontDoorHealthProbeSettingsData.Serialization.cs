// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class FrontDoorHealthProbeSettingsData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Core.Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Core.Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Core.Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Core.Optional.IsDefined(HealthProbeMethod))
            {
                writer.WritePropertyName("healthProbeMethod"u8);
                writer.WriteStringValue(HealthProbeMethod.Value.ToString());
            }
            if (Core.Optional.IsDefined(EnabledState))
            {
                writer.WritePropertyName("enabledState"u8);
                writer.WriteStringValue(EnabledState.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FrontDoorHealthProbeSettingsData DeserializeFrontDoorHealthProbeSettingsData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> id = default;
            Core.Optional<string> name = default;
            Core.Optional<ResourceType> type = default;
            Core.Optional<string> path = default;
            Core.Optional<FrontDoorProtocol> protocol = default;
            Core.Optional<int> intervalInSeconds = default;
            Core.Optional<FrontDoorHealthProbeMethod> healthProbeMethod = default;
            Core.Optional<HealthProbeEnabled> enabledState = default;
            Core.Optional<FrontDoorResourceState> resourceState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new FrontDoorProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("intervalInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            intervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("healthProbeMethod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthProbeMethod = new FrontDoorHealthProbeMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("enabledState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabledState = new HealthProbeEnabled(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceState = new FrontDoorResourceState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FrontDoorHealthProbeSettingsData(id.Value, name.Value, Core.Optional.ToNullable(type), path.Value, Core.Optional.ToNullable(protocol), Core.Optional.ToNullable(intervalInSeconds), Core.Optional.ToNullable(healthProbeMethod), Core.Optional.ToNullable(enabledState), Core.Optional.ToNullable(resourceState));
        }
    }
}
