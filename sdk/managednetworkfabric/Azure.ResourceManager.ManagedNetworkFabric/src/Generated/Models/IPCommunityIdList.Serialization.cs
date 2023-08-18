// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPCommunityIdList : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(IPCommunityIds))
            {
                writer.WritePropertyName("ipCommunityIds"u8);
                writer.WriteStartArray();
                foreach (var item in IPCommunityIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IPCommunityIdList DeserializeIPCommunityIdList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<ResourceIdentifier>> ipCommunityIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipCommunityIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    ipCommunityIds = array;
                    continue;
                }
            }
            return new IPCommunityIdList(Core.Optional.ToList(ipCommunityIds));
        }
    }
}
