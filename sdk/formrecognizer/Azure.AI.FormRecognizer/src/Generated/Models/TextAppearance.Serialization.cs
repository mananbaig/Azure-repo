// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    public partial class TextAppearance
    {
        internal static TextAppearance DeserializeTextAppearance(JsonElement element)
        {
            Style style = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("style"))
                {
                    style = FormRecognizer.Models.Style.DeserializeStyle(property.Value);
                    continue;
                }
            }
            return new TextAppearance(style);
        }
    }
}
