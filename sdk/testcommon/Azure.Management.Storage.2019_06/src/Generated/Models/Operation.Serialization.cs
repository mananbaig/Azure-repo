// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class Operation
    {
        internal static Operation DeserializeOperation(JsonElement element)
        {
            string name = default;
            OperationDisplay display = default;
            string origin = default;
            ServiceSpecification serviceSpecification = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    display = OperationDisplay.DeserializeOperationDisplay(property.Value);
                    continue;
                }
                if (property.NameEquals("origin"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    origin = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceSpecification"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceSpecification = ServiceSpecification.DeserializeServiceSpecification(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new Operation(name, display, origin, serviceSpecification);
        }
    }
}
