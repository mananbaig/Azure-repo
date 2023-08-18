// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricPortCondition : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PortType))
            {
                writer.WritePropertyName("portType"u8);
                writer.WriteStringValue(PortType.Value.ToString());
            }
            writer.WritePropertyName("layer4Protocol"u8);
            writer.WriteStringValue(Layer4Protocol.ToString());
            if (Core.Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(PortGroupNames))
            {
                writer.WritePropertyName("portGroupNames"u8);
                writer.WriteStartArray();
                foreach (var item in PortGroupNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NetworkFabricPortCondition DeserializeNetworkFabricPortCondition(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<NetworkFabricPortType> portType = default;
            Layer4Protocol layer4Protocol = default;
            Core.Optional<IList<string>> ports = default;
            Core.Optional<IList<string>> portGroupNames = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("portType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portType = new NetworkFabricPortType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("layer4Protocol"u8))
                {
                    layer4Protocol = new Layer4Protocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
                if (property.NameEquals("portGroupNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    portGroupNames = array;
                    continue;
                }
            }
            return new NetworkFabricPortCondition(Core.Optional.ToNullable(portType), layer4Protocol, Core.Optional.ToList(ports), Core.Optional.ToList(portGroupNames));
        }
    }
}
