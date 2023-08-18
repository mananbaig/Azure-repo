// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabInboundNatRule : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(TransportProtocol))
            {
                writer.WritePropertyName("transportProtocol"u8);
                writer.WriteStringValue(TransportProtocol.Value.ToString());
            }
            if (Core.Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort"u8);
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (Core.Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort"u8);
                writer.WriteNumberValue(BackendPort.Value);
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabInboundNatRule DeserializeDevTestLabInboundNatRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DevTestLabTransportProtocol> transportProtocol = default;
            Core.Optional<int> frontendPort = default;
            Core.Optional<int> backendPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transportProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportProtocol = new DevTestLabTransportProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPort = property.Value.GetInt32();
                    continue;
                }
            }
            return new DevTestLabInboundNatRule(Core.Optional.ToNullable(transportProtocol), Core.Optional.ToNullable(frontendPort), Core.Optional.ToNullable(backendPort));
        }
    }
}
