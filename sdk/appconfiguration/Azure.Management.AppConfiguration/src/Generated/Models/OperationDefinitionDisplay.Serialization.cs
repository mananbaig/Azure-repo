// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.AppConfiguration.Models
{
    public partial class OperationDefinitionDisplay
    {
        internal static OperationDefinitionDisplay DeserializeOperationDefinitionDisplay(JsonElement element)
        {
            string provider = default;
            string resource = default;
            string operation = default;
            string description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provider"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resource"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    operation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new OperationDefinitionDisplay(provider, resource, operation, description);
        }
    }
}
