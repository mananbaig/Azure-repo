// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnswerSpanResponse
    {
        internal static AnswerSpanResponse DeserializeAnswerSpanResponse(JsonElement element)
        {
            Optional<string> text = default;
            Optional<double> score = default;
            Optional<int> startIndex = default;
            Optional<int> endIndex = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("score"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    score = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("startIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("endIndex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endIndex = property.Value.GetInt32();
                    continue;
                }
            }
            return new AnswerSpanResponse(text.Value, Optional.ToNullable(score), Optional.ToNullable(startIndex), Optional.ToNullable(endIndex));
        }
    }
}
