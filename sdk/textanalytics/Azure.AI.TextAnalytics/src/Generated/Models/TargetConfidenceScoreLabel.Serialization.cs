// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class TargetConfidenceScoreLabel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("positive");
            writer.WriteNumberValue(Positive);
            writer.WritePropertyName("negative");
            writer.WriteNumberValue(Negative);
            writer.WriteEndObject();
        }

        internal static TargetConfidenceScoreLabel DeserializeTargetConfidenceScoreLabel(JsonElement element)
        {
            double positive = default;
            double negative = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("positive"))
                {
                    positive = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("negative"))
                {
                    negative = property.Value.GetDouble();
                    continue;
                }
            }
            return new TargetConfidenceScoreLabel(positive, negative);
        }
    }
}
