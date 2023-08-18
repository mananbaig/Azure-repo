// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class FormulaPropertiesFromVm : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(LabVmId))
            {
                writer.WritePropertyName("labVmId"u8);
                writer.WriteStringValue(LabVmId);
            }
            writer.WriteEndObject();
        }

        internal static FormulaPropertiesFromVm DeserializeFormulaPropertiesFromVm(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> labVmId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labVmId"u8))
                {
                    labVmId = property.Value.GetString();
                    continue;
                }
            }
            return new FormulaPropertiesFromVm(labVmId.Value);
        }
    }
}
