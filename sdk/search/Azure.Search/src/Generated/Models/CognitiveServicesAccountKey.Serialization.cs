// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Models
{
    public partial class CognitiveServicesAccountKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("key");
            writer.WriteStringValue(Key);
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            if (Description != null)
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static CognitiveServicesAccountKey DeserializeCognitiveServicesAccountKey(JsonElement element)
        {
            CognitiveServicesAccountKey result = new CognitiveServicesAccountKey();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"))
                {
                    result.Key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    result.ODataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Description = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}
