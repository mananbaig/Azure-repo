// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class NCrossValidations : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("mode"u8);
            writer.WriteStringValue(Mode.ToString());
            writer.WriteEndObject();
        }

        internal static NCrossValidations DeserializeNCrossValidations(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("mode", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Auto": return AutoNCrossValidations.DeserializeAutoNCrossValidations(element);
                    case "Custom": return CustomNCrossValidations.DeserializeCustomNCrossValidations(element);
                }
            }
            return UnknownNCrossValidations.DeserializeUnknownNCrossValidations(element);
        }
    }
}
