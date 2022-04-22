// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations
{
    public partial class QuestionAnsweringTargetIntentResult
    {
        internal static QuestionAnsweringTargetIntentResult DeserializeQuestionAnsweringTargetIntentResult(JsonElement element)
        {
            Optional<KnowledgeBaseAnswers> result = default;
            TargetKind targetKind = default;
            Optional<string> apiVersion = default;
            double confidenceScore = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("result"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        result = null;
                        continue;
                    }
                    result = KnowledgeBaseAnswers.DeserializeKnowledgeBaseAnswers(property.Value);
                    continue;
                }
                if (property.NameEquals("targetKind"))
                {
                    targetKind = new TargetKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiVersion"))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScore"))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
            }
            return new QuestionAnsweringTargetIntentResult(targetKind, apiVersion.Value, confidenceScore, result.Value);
        }
    }
}
