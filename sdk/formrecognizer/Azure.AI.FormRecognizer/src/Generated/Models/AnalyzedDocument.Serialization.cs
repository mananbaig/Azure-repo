// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class AnalyzedDocument
    {
        internal static AnalyzedDocument DeserializeAnalyzedDocument(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string docType = default;
            Core.Optional<IReadOnlyList<BoundingRegion>> boundingRegions = default;
            IReadOnlyList<DocumentSpan> spans = default;
            Core.Optional<IReadOnlyDictionary<string, DocumentField>> fields = default;
            float confidence = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("docType"u8))
                {
                    docType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("boundingRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BoundingRegion> array = new List<BoundingRegion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BoundingRegion.DeserializeBoundingRegion(item));
                    }
                    boundingRegions = array;
                    continue;
                }
                if (property.NameEquals("spans"u8))
                {
                    List<DocumentSpan> array = new List<DocumentSpan>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentSpan.DeserializeDocumentSpan(item));
                    }
                    spans = array;
                    continue;
                }
                if (property.NameEquals("fields"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, DocumentField> dictionary = new Dictionary<string, DocumentField>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, DocumentField.DeserializeDocumentField(property0.Value));
                    }
                    fields = dictionary;
                    continue;
                }
                if (property.NameEquals("confidence"u8))
                {
                    confidence = property.Value.GetSingle();
                    continue;
                }
            }
            return new AnalyzedDocument(docType, Core.Optional.ToList(boundingRegions), spans, Core.Optional.ToDictionary(fields), confidence);
        }
    }
}
