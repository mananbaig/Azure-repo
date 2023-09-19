// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.SchemaRegistry.Models
{
    public partial class SchemaGroup
    {
        internal static SchemaGroup DeserializeSchemaGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string groupName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupName"u8))
                {
                    groupName = property.Value.GetString();
                    continue;
                }
            }
            return new SchemaGroup(groupName);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SchemaGroup FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSchemaGroup(document.RootElement);
        }
    }
}
