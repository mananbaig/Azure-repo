// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Media.VideoAnalyzer.Edge;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class Mpeg4Configuration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GovLength))
            {
                writer.WritePropertyName("govLength"u8);
                writer.WriteNumberValue(GovLength.Value);
            }
            if (Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteStringValue(Profile.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static Mpeg4Configuration DeserializeMpeg4Configuration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            float? govLength = default;
            Mpeg4Profile? profile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("govLength"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    govLength = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = new Mpeg4Profile(property.Value.GetString());
                    continue;
                }
            }
            return new Mpeg4Configuration(govLength, profile);
        }
    }
}
