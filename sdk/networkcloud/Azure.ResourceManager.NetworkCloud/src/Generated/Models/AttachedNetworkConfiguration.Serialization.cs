// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class AttachedNetworkConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(L2Networks))
            {
                writer.WritePropertyName("l2Networks"u8);
                writer.WriteStartArray();
                foreach (var item in L2Networks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(L3Networks))
            {
                writer.WritePropertyName("l3Networks"u8);
                writer.WriteStartArray();
                foreach (var item in L3Networks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TrunkedNetworks))
            {
                writer.WritePropertyName("trunkedNetworks"u8);
                writer.WriteStartArray();
                foreach (var item in TrunkedNetworks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static AttachedNetworkConfiguration DeserializeAttachedNetworkConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<L2NetworkAttachmentConfiguration>> l2Networks = default;
            Optional<IList<L3NetworkAttachmentConfiguration>> l3Networks = default;
            Optional<IList<TrunkedNetworkAttachmentConfiguration>> trunkedNetworks = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("l2Networks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<L2NetworkAttachmentConfiguration> array = new List<L2NetworkAttachmentConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(L2NetworkAttachmentConfiguration.DeserializeL2NetworkAttachmentConfiguration(item));
                    }
                    l2Networks = array;
                    continue;
                }
                if (property.NameEquals("l3Networks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<L3NetworkAttachmentConfiguration> array = new List<L3NetworkAttachmentConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(L3NetworkAttachmentConfiguration.DeserializeL3NetworkAttachmentConfiguration(item));
                    }
                    l3Networks = array;
                    continue;
                }
                if (property.NameEquals("trunkedNetworks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TrunkedNetworkAttachmentConfiguration> array = new List<TrunkedNetworkAttachmentConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TrunkedNetworkAttachmentConfiguration.DeserializeTrunkedNetworkAttachmentConfiguration(item));
                    }
                    trunkedNetworks = array;
                    continue;
                }
            }
            return new AttachedNetworkConfiguration(Optional.ToList(l2Networks), Optional.ToList(l3Networks), Optional.ToList(trunkedNetworks));
        }
    }
}
