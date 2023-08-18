// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class ActionIPExtendedCommunityProperties : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete"u8);
                writer.WriteObjectValue(Delete);
            }
            if (Core.Optional.IsDefined(Set))
            {
                writer.WritePropertyName("set"u8);
                writer.WriteObjectValue(Set);
            }
            if (Core.Optional.IsDefined(Add))
            {
                writer.WritePropertyName("add"u8);
                writer.WriteObjectValue(Add);
            }
            writer.WriteEndObject();
        }

        internal static ActionIPExtendedCommunityProperties DeserializeActionIPExtendedCommunityProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IPExtendedCommunityIdList> delete = default;
            Core.Optional<IPExtendedCommunityIdList> @set = default;
            Core.Optional<IPExtendedCommunityIdList> @add = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delete"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    delete = IPExtendedCommunityIdList.DeserializeIPExtendedCommunityIdList(property.Value);
                    continue;
                }
                if (property.NameEquals("set"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @set = IPExtendedCommunityIdList.DeserializeIPExtendedCommunityIdList(property.Value);
                    continue;
                }
                if (property.NameEquals("add"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    @add = IPExtendedCommunityIdList.DeserializeIPExtendedCommunityIdList(property.Value);
                    continue;
                }
            }
            return new ActionIPExtendedCommunityProperties(@add.Value, delete.Value, @set.Value);
        }
    }
}
