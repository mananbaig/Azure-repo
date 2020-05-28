// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class Disallowed : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (DiskTypes != null)
            {
                writer.WritePropertyName("diskTypes");
                writer.WriteStartArray();
                foreach (var item in DiskTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static Disallowed DeserializeDisallowed(JsonElement element)
        {
            IList<string> diskTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskTypes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    diskTypes = array;
                    continue;
                }
            }
            return new Disallowed(diskTypes);
        }
    }
}
