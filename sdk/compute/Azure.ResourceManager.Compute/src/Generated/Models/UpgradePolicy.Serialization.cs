// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class UpgradePolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode");
                writer.WriteStringValue(Mode.Value.ToSerialString());
            }
            if (Optional.IsDefined(RollingUpgradePolicy))
            {
                writer.WritePropertyName("rollingUpgradePolicy");
                writer.WriteObjectValue(RollingUpgradePolicy);
            }
            if (Optional.IsDefined(AutomaticOSUpgradePolicy))
            {
                writer.WritePropertyName("automaticOSUpgradePolicy");
                writer.WriteObjectValue(AutomaticOSUpgradePolicy);
            }
            writer.WriteEndObject();
        }

        internal static UpgradePolicy DeserializeUpgradePolicy(JsonElement element)
        {
            Optional<UpgradeMode> mode = default;
            Optional<RollingUpgradePolicy> rollingUpgradePolicy = default;
            Optional<AutomaticOSUpgradePolicy> automaticOSUpgradePolicy = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mode"))
                {
                    mode = property.Value.GetString().ToUpgradeMode();
                    continue;
                }
                if (property.NameEquals("rollingUpgradePolicy"))
                {
                    rollingUpgradePolicy = RollingUpgradePolicy.DeserializeRollingUpgradePolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("automaticOSUpgradePolicy"))
                {
                    automaticOSUpgradePolicy = AutomaticOSUpgradePolicy.DeserializeAutomaticOSUpgradePolicy(property.Value);
                    continue;
                }
            }
            return new UpgradePolicy(Optional.ToNullable(mode), rollingUpgradePolicy.Value, automaticOSUpgradePolicy.Value);
        }
    }
}
