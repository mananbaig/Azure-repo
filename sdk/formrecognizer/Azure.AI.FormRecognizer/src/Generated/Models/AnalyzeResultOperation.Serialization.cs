// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    internal partial class AnalyzeResultOperation
    {
        internal static AnalyzeResultOperation DeserializeAnalyzeResultOperation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AnalyzeResultOperationStatus status = default;
            DateTimeOffset createdDateTime = default;
            DateTimeOffset lastUpdatedDateTime = default;
            Core.Optional<JsonElement> error = default;
            Core.Optional<AnalyzeResult> analyzeResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToAnalyzeResultOperationStatus();
                    continue;
                }
                if (property.NameEquals("createdDateTime"u8))
                {
                    createdDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastUpdatedDateTime"u8))
                {
                    lastUpdatedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    error = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("analyzeResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analyzeResult = AnalyzeResult.DeserializeAnalyzeResult(property.Value);
                    continue;
                }
            }
            return new AnalyzeResultOperation(status, createdDateTime, lastUpdatedDateTime, error, analyzeResult.Value);
        }
    }
}
