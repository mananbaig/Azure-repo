// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            ErrorCodeType code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<Error>> details = default;
            Optional<InnerErrorModel> innerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = new ErrorCodeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Error> array = new List<Error>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    innerError = InnerErrorModel.DeserializeInnerErrorModel(property.Value);
                    continue;
                }
            }
            return new Error(code, message.Value, target.Value, Optional.ToList(details), innerError.Value);
        }
    }
}
