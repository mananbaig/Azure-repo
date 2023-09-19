// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MLAssistConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("mlAssist"u8);
            writer.WriteStringValue(MlAssist.ToString());
            writer.WriteEndObject();
        }

        internal static MLAssistConfiguration DeserializeMLAssistConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mlAssist", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Disabled": return MLAssistConfigurationDisabled.DeserializeMLAssistConfigurationDisabled(element);
                    case "Enabled": return MLAssistConfigurationEnabled.DeserializeMLAssistConfigurationEnabled(element);
                }
            }
            return UnknownMLAssistConfiguration.DeserializeUnknownMLAssistConfiguration(element);
        }
    }
}
