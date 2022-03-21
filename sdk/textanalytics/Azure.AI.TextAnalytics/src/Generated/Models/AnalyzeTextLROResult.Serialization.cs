// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class AnalyzeTextLROResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName");
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime");
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status");
            writer.WriteStringValue(Status.ToString());
            writer.WriteEndObject();
        }

        internal static AnalyzeTextLROResult DeserializeAnalyzeTextLROResult(JsonElement element)
        {
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "CustomEntityRecognitionLROResults": return CustomEntityRecognitionLROResult.DeserializeCustomEntityRecognitionLROResult(element);
                    case "CustomMultiClassificationLROResults": return CustomMultiClassificationLROResult.DeserializeCustomMultiClassificationLROResult(element);
                    case "CustomSingleClassificationLROResults": return CustomSingleClassificationLROResult.DeserializeCustomSingleClassificationLROResult(element);
                    case "EntityLinkingLROResults": return EntityLinkingLROResult.DeserializeEntityLinkingLROResult(element);
                    case "EntityRecognitionLROResults": return EntityRecognitionLROResult.DeserializeEntityRecognitionLROResult(element);
                    case "ExtractiveSummarizationLROResults": return ExtractiveSummarizationLROResult.DeserializeExtractiveSummarizationLROResult(element);
                    case "HealthcareLROResults": return HealthcareLROResult.DeserializeHealthcareLROResult(element);
                    case "KeyPhraseExtractionLROResults": return KeyPhraseExtractionLROResult.DeserializeKeyPhraseExtractionLROResult(element);
                    case "PiiEntityRecognitionLROResults": return PiiEntityRecognitionLROResult.DeserializePiiEntityRecognitionLROResult(element);
                    case "SentimentAnalysisLROResults": return SentimentLROResult.DeserializeSentimentLROResult(element);
                }
            }
            AnalyzeTextLROResultsKind kind = default;
            Optional<string> taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
            }
            return new AnalyzeTextLROResult(lastUpdateDateTime, status, kind, taskName.Value);
        }
    }
}
