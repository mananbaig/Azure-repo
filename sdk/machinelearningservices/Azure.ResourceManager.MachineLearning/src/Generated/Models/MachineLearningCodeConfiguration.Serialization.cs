// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningCodeConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(CodeId))
            {
                if (CodeId != null)
                {
                    writer.WritePropertyName("codeId"u8);
                    writer.WriteStringValue(CodeId);
                }
                else
                {
                    writer.WriteNull("codeId");
                }
            }
            writer.WritePropertyName("scoringScript"u8);
            writer.WriteStringValue(ScoringScript);
            writer.WriteEndObject();
        }

        internal static MachineLearningCodeConfiguration DeserializeMachineLearningCodeConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ResourceIdentifier> codeId = default;
            string scoringScript = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        codeId = null;
                        continue;
                    }
                    codeId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("scoringScript"u8))
                {
                    scoringScript = property.Value.GetString();
                    continue;
                }
            }
            return new MachineLearningCodeConfiguration(codeId.Value, scoringScript);
        }
    }
}
