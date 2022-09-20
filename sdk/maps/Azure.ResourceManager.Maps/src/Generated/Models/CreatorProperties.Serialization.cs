// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    public partial class CreatorProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("storageUnits");
            writer.WriteNumberValue(StorageUnits);
            writer.WriteEndObject();
        }

        internal static CreatorProperties DeserializeCreatorProperties(JsonElement element)
        {
            Optional<string> provisioningState = default;
            int storageUnits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("storageUnits"))
                {
                    storageUnits = property.Value.GetInt32();
                    continue;
                }
            }
            return new CreatorProperties(provisioningState.Value, storageUnits);
        }
    }
}
