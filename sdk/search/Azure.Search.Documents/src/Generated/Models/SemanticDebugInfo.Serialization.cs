// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Models
{
    public partial class SemanticDebugInfo
    {
        internal static SemanticDebugInfo DeserializeSemanticDebugInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            QueryResultDocumentSemanticField titleField = default;
            IReadOnlyList<QueryResultDocumentSemanticField> contentFields = default;
            IReadOnlyList<QueryResultDocumentSemanticField> keywordFields = default;
            QueryResultDocumentRerankerInput rerankerInput = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("titleField"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    titleField = QueryResultDocumentSemanticField.DeserializeQueryResultDocumentSemanticField(property.Value);
                    continue;
                }
                if (property.NameEquals("contentFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryResultDocumentSemanticField> array = new List<QueryResultDocumentSemanticField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryResultDocumentSemanticField.DeserializeQueryResultDocumentSemanticField(item));
                    }
                    contentFields = array;
                    continue;
                }
                if (property.NameEquals("keywordFields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<QueryResultDocumentSemanticField> array = new List<QueryResultDocumentSemanticField>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryResultDocumentSemanticField.DeserializeQueryResultDocumentSemanticField(item));
                    }
                    keywordFields = array;
                    continue;
                }
                if (property.NameEquals("rerankerInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rerankerInput = QueryResultDocumentRerankerInput.DeserializeQueryResultDocumentRerankerInput(property.Value);
                    continue;
                }
            }
            return new SemanticDebugInfo(titleField, contentFields ?? new ChangeTrackingList<QueryResultDocumentSemanticField>(), keywordFields ?? new ChangeTrackingList<QueryResultDocumentSemanticField>(), rerankerInput);
        }
    }
}
