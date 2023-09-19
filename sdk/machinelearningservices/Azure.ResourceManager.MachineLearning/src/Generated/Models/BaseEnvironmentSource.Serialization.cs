// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class BaseEnvironmentSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("baseEnvironmentSourceType"u8);
            writer.WriteStringValue(BaseEnvironmentSourceType.ToString());
            writer.WriteEndObject();
        }

        internal static BaseEnvironmentSource DeserializeBaseEnvironmentSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("baseEnvironmentSourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "EnvironmentAsset": return BaseEnvironmentId.DeserializeBaseEnvironmentId(element);
                }
            }
            return UnknownBaseEnvironmentSource.DeserializeUnknownBaseEnvironmentSource(element);
        }
    }
}
