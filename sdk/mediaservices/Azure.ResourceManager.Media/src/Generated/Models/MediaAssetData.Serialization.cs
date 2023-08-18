// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Media
{
    public partial class MediaAssetData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(AlternateId))
            {
                writer.WritePropertyName("alternateId"u8);
                writer.WriteStringValue(AlternateId);
            }
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container"u8);
                writer.WriteStringValue(Container);
            }
            if (Core.Optional.IsDefined(StorageAccountName))
            {
                writer.WritePropertyName("storageAccountName"u8);
                writer.WriteStringValue(StorageAccountName);
            }
            if (Core.Optional.IsDefined(EncryptionScope))
            {
                writer.WritePropertyName("encryptionScope"u8);
                writer.WriteStringValue(EncryptionScope);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MediaAssetData DeserializeMediaAssetData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<Guid> assetId = default;
            Core.Optional<DateTimeOffset> created = default;
            Core.Optional<DateTimeOffset> lastModified = default;
            Core.Optional<string> alternateId = default;
            Core.Optional<string> description = default;
            Core.Optional<string> container = default;
            Core.Optional<string> storageAccountName = default;
            Core.Optional<MediaAssetStorageEncryptionFormat> storageEncryptionFormat = default;
            Core.Optional<string> encryptionScope = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
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
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("assetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            assetId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModified = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("alternateId"u8))
                        {
                            alternateId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("container"u8))
                        {
                            container = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountName"u8))
                        {
                            storageAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageEncryptionFormat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageEncryptionFormat = new MediaAssetStorageEncryptionFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("encryptionScope"u8))
                        {
                            encryptionScope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MediaAssetData(id, name, type, systemData.Value, Core.Optional.ToNullable(assetId), Core.Optional.ToNullable(created), Core.Optional.ToNullable(lastModified), alternateId.Value, description.Value, container.Value, storageAccountName.Value, Core.Optional.ToNullable(storageEncryptionFormat), encryptionScope.Value);
        }
    }
}
