// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class OperationResultInfoBaseResource
    {
        internal static OperationResultInfoBaseResource DeserializeOperationResultInfoBaseResource(JsonElement element)
        {
            Optional<OperationResultInfoBase> operation = default;
            Optional<HttpStatusCode> statusCode = default;
            Optional<IReadOnlyDictionary<string, IList<string>>> headers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    operation = OperationResultInfoBase.DeserializeOperationResultInfoBase(property.Value);
                    continue;
                }
                if (property.NameEquals("statusCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statusCode = property.Value.GetString().ToHttpStatusCode();
                    continue;
                }
                if (property.NameEquals("headers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        List<string> array = new List<string>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            array.Add(item.GetString());
                        }
                        dictionary.Add(property0.Name, array);
                    }
                    headers = dictionary;
                    continue;
                }
            }
            return new OperationResultInfoBaseResource(Optional.ToNullable(statusCode), Optional.ToDictionary(headers), operation.Value);
        }
    }
}
