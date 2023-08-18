// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabCustomImageVhd : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ImageName))
            {
                writer.WritePropertyName("imageName"u8);
                writer.WriteStringValue(ImageName);
            }
            if (Core.Optional.IsDefined(IsSysPrepEnabled))
            {
                writer.WritePropertyName("sysPrep"u8);
                writer.WriteBooleanValue(IsSysPrepEnabled.Value);
            }
            writer.WritePropertyName("osType"u8);
            writer.WriteStringValue(OSType.ToString());
            writer.WriteEndObject();
        }

        internal static DevTestLabCustomImageVhd DeserializeDevTestLabCustomImageVhd(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> imageName = default;
            Core.Optional<bool> sysPrep = default;
            DevTestLabCustomImageOSType osType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageName"u8))
                {
                    imageName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sysPrep"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sysPrep = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = new DevTestLabCustomImageOSType(property.Value.GetString());
                    continue;
                }
            }
            return new DevTestLabCustomImageVhd(imageName.Value, Core.Optional.ToNullable(sysPrep), osType);
        }
    }
}
