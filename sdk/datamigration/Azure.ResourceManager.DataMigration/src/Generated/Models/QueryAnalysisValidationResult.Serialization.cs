// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class QueryAnalysisValidationResult
    {
        internal static QueryAnalysisValidationResult DeserializeQueryAnalysisValidationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<QueryExecutionResult> queryResults = default;
            Core.Optional<ValidationError> validationErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryResults = QueryExecutionResult.DeserializeQueryExecutionResult(property.Value);
                    continue;
                }
                if (property.NameEquals("validationErrors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validationErrors = ValidationError.DeserializeValidationError(property.Value);
                    continue;
                }
            }
            return new QueryAnalysisValidationResult(queryResults.Value, validationErrors.Value);
        }
    }
}
