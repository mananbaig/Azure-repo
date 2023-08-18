// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthBot.Models
{
    public partial class HealthBotSku : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name.ToSerialString());
            writer.WriteEndObject();
        }

        internal static HealthBotSku DeserializeHealthBotSku(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HealthBotSkuName name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString().ToHealthBotSkuName();
                    continue;
                }
            }
            return new HealthBotSku(name);
        }
    }
}
