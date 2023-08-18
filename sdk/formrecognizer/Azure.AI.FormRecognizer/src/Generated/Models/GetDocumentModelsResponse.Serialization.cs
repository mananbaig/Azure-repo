// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    internal partial class GetDocumentModelsResponse
    {
        internal static GetDocumentModelsResponse DeserializeGetDocumentModelsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DocumentModelSummary> value = default;
            Core.Optional<Uri> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DocumentModelSummary> array = new List<DocumentModelSummary>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentModelSummary.DeserializeDocumentModelSummary(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nextLink = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new GetDocumentModelsResponse(value, nextLink.Value);
        }
    }
}
