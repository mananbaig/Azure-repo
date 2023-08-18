// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class StorageSpacesPropertiesHciStorageProfile : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(MocGroup))
            {
                writer.WritePropertyName("mocGroup"u8);
                writer.WriteStringValue(MocGroup);
            }
            if (Core.Optional.IsDefined(MocLocation))
            {
                writer.WritePropertyName("mocLocation"u8);
                writer.WriteStringValue(MocLocation);
            }
            if (Core.Optional.IsDefined(MocStorageContainer))
            {
                writer.WritePropertyName("mocStorageContainer"u8);
                writer.WriteStringValue(MocStorageContainer);
            }
            writer.WriteEndObject();
        }

        internal static StorageSpacesPropertiesHciStorageProfile DeserializeStorageSpacesPropertiesHciStorageProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> mocGroup = default;
            Core.Optional<string> mocLocation = default;
            Core.Optional<string> mocStorageContainer = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mocGroup"u8))
                {
                    mocGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocLocation"u8))
                {
                    mocLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mocStorageContainer"u8))
                {
                    mocStorageContainer = property.Value.GetString();
                    continue;
                }
            }
            return new StorageSpacesPropertiesHciStorageProfile(mocGroup.Value, mocLocation.Value, mocStorageContainer.Value);
        }
    }
}
