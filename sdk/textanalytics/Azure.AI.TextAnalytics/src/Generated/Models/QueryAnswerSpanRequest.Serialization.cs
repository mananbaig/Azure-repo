// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    public partial class QueryAnswerSpanRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enable))
            {
                writer.WritePropertyName("enable");
                writer.WriteBooleanValue(Enable.Value);
            }
            if (Optional.IsDefined(ScoreThreshold))
            {
                writer.WritePropertyName("scoreThreshold");
                writer.WriteNumberValue(ScoreThreshold.Value);
            }
            if (Optional.IsDefined(TopAnswersWithSpan))
            {
                writer.WritePropertyName("topAnswersWithSpan");
                writer.WriteNumberValue(TopAnswersWithSpan.Value);
            }
            writer.WriteEndObject();
        }
    }
}
