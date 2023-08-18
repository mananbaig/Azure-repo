// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    internal partial class V2AnalyzeResult
    {
        internal static V2AnalyzeResult DeserializeV2AnalyzeResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string version = default;
            Core.Optional<IReadOnlyList<ReadResult>> readResults = default;
            Core.Optional<IReadOnlyList<PageResult>> pageResults = default;
            Core.Optional<IReadOnlyList<DocumentResult>> documentResults = default;
            Core.Optional<IReadOnlyList<FormRecognizerError>> errors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("version"u8))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("readResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        readResults = null;
                        continue;
                    }
                    List<ReadResult> array = new List<ReadResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReadResult.DeserializeReadResult(item));
                    }
                    readResults = array;
                    continue;
                }
                if (property.NameEquals("pageResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        pageResults = null;
                        continue;
                    }
                    List<PageResult> array = new List<PageResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PageResult.DeserializePageResult(item));
                    }
                    pageResults = array;
                    continue;
                }
                if (property.NameEquals("documentResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        documentResults = null;
                        continue;
                    }
                    List<DocumentResult> array = new List<DocumentResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentResult.DeserializeDocumentResult(item));
                    }
                    documentResults = array;
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FormRecognizerError> array = new List<FormRecognizerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FormRecognizerError.DeserializeFormRecognizerError(item));
                    }
                    errors = array;
                    continue;
                }
            }
            return new V2AnalyzeResult(version, Core.Optional.ToList(readResults), Core.Optional.ToList(pageResults), Core.Optional.ToList(documentResults), Core.Optional.ToList(errors));
        }
    }
}
