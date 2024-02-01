// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Fleet.Models
{
    public partial class LinuxPatchSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PatchMode))
            {
                writer.WritePropertyName("patchMode"u8);
                writer.WriteStringValue(PatchMode.Value.ToString());
            }
            if (Optional.IsDefined(AssessmentMode))
            {
                writer.WritePropertyName("assessmentMode"u8);
                writer.WriteStringValue(AssessmentMode.Value.ToString());
            }
            if (Optional.IsDefined(AutomaticByPlatformSettings))
            {
                writer.WritePropertyName("automaticByPlatformSettings"u8);
                writer.WriteObjectValue(AutomaticByPlatformSettings);
            }
            writer.WriteEndObject();
        }

        internal static LinuxPatchSettings DeserializeLinuxPatchSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LinuxVmGuestPatchMode> patchMode = default;
            Optional<LinuxPatchAssessmentMode> assessmentMode = default;
            Optional<LinuxVmGuestPatchAutomaticByPlatformSettings> automaticByPlatformSettings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("patchMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    patchMode = new LinuxVmGuestPatchMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("assessmentMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    assessmentMode = new LinuxPatchAssessmentMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("automaticByPlatformSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    automaticByPlatformSettings = LinuxVmGuestPatchAutomaticByPlatformSettings.DeserializeLinuxVmGuestPatchAutomaticByPlatformSettings(property.Value);
                    continue;
                }
            }
            return new LinuxPatchSettings(Optional.ToNullable(patchMode), Optional.ToNullable(assessmentMode), automaticByPlatformSettings.Value);
        }
    }
}
