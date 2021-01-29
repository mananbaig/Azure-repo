// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.QA.Models
{
    internal partial class InnerErrorModel
    {
        internal static InnerErrorModel DeserializeInnerErrorModel(JsonElement element)
        {
            Optional<string> code = default;
            Optional<InnerErrorModel> innerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innerError = DeserializeInnerErrorModel(property.Value);
                    continue;
                }
            }
            return new InnerErrorModel(code.Value, innerError.Value);
        }
    }
}
