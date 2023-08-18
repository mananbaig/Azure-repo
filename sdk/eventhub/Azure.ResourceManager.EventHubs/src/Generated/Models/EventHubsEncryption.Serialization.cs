// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsEncryption : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsCollectionDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteStartArray();
                foreach (var item in KeyVaultProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(KeySource))
            {
                writer.WritePropertyName("keySource"u8);
                writer.WriteStringValue(KeySource.Value.ToString());
            }
            if (Core.Optional.IsDefined(RequireInfrastructureEncryption))
            {
                writer.WritePropertyName("requireInfrastructureEncryption"u8);
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
            }
            writer.WriteEndObject();
        }

        internal static EventHubsEncryption DeserializeEventHubsEncryption(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IList<EventHubsKeyVaultProperties>> keyVaultProperties = default;
            Core.Optional<EventHubsKeySource> keySource = default;
            Core.Optional<bool> requireInfrastructureEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsKeyVaultProperties> array = new List<EventHubsKeyVaultProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsKeyVaultProperties.DeserializeEventHubsKeyVaultProperties(item));
                    }
                    keyVaultProperties = array;
                    continue;
                }
                if (property.NameEquals("keySource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keySource = new EventHubsKeySource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("requireInfrastructureEncryption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requireInfrastructureEncryption = property.Value.GetBoolean();
                    continue;
                }
            }
            return new EventHubsEncryption(Core.Optional.ToList(keyVaultProperties), Core.Optional.ToNullable(keySource), Core.Optional.ToNullable(requireInfrastructureEncryption));
        }
    }
}
