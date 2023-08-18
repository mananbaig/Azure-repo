// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    public partial class DocumentTableCell
    {
        internal static DocumentTableCell DeserializeDocumentTableCell(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<DocumentTableCellKind> kind = default;
            int rowIndex = default;
            int columnIndex = default;
            Core.Optional<int> rowSpan = default;
            Core.Optional<int> columnSpan = default;
            string content = default;
            Core.Optional<IReadOnlyList<BoundingRegion>> boundingRegions = default;
            IReadOnlyList<DocumentSpan> spans = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new DocumentTableCellKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rowIndex"u8))
                {
                    rowIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnIndex"u8))
                {
                    columnIndex = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("rowSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rowSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("columnSpan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    columnSpan = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
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
            }
            return new DocumentTableCell(Core.Optional.ToNullable(kind), rowIndex, columnIndex, Core.Optional.ToNullable(rowSpan), Core.Optional.ToNullable(columnSpan), content, Core.Optional.ToList(boundingRegions), spans);
        }
    }
}
