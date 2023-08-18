// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NpbStaticRouteConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(BfdConfiguration))
            {
                writer.WritePropertyName("bfdConfiguration"u8);
                writer.WriteObjectValue(BfdConfiguration);
            }
            if (Core.Optional.IsCollectionDefined(IPv4Routes))
            {
                writer.WritePropertyName("ipv4Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv4Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(IPv6Routes))
            {
                writer.WritePropertyName("ipv6Routes"u8);
                writer.WriteStartArray();
                foreach (var item in IPv6Routes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NpbStaticRouteConfiguration DeserializeNpbStaticRouteConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<BfdConfiguration> bfdConfiguration = default;
            Core.Optional<IList<StaticRouteProperties>> ipv4Routes = default;
            Core.Optional<IList<StaticRouteProperties>> ipv6Routes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdConfiguration = BfdConfiguration.DeserializeBfdConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("ipv4Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRouteProperties> array = new List<StaticRouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRouteProperties.DeserializeStaticRouteProperties(item));
                    }
                    ipv4Routes = array;
                    continue;
                }
                if (property.NameEquals("ipv6Routes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StaticRouteProperties> array = new List<StaticRouteProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StaticRouteProperties.DeserializeStaticRouteProperties(item));
                    }
                    ipv6Routes = array;
                    continue;
                }
            }
            return new NpbStaticRouteConfiguration(bfdConfiguration.Value, Core.Optional.ToList(ipv4Routes), Core.Optional.ToList(ipv6Routes));
        }
    }
}
