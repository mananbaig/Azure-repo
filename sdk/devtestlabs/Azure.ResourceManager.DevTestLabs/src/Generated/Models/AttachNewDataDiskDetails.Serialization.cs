// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class AttachNewDataDiskDetails : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(DiskSizeGiB))
            {
                writer.WritePropertyName("diskSizeGiB"u8);
                writer.WriteNumberValue(DiskSizeGiB.Value);
            }
            if (Core.Optional.IsDefined(DiskName))
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (Core.Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AttachNewDataDiskDetails DeserializeAttachNewDataDiskDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<int> diskSizeGiB = default;
            Core.Optional<string> diskName = default;
            Core.Optional<DevTestLabStorageType> diskType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSizeGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGiB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new DevTestLabStorageType(property.Value.GetString());
                    continue;
                }
            }
            return new AttachNewDataDiskDetails(Core.Optional.ToNullable(diskSizeGiB), diskName.Value, Core.Optional.ToNullable(diskType));
        }
    }
}
