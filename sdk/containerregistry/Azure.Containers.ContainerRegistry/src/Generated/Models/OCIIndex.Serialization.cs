// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    internal partial class OCIIndex
    {
        internal static OCIIndex DeserializeOCIIndex(JsonElement element)
        {
            Optional<IReadOnlyList<ManifestListAttributes>> manifests = default;
            Optional<Annotations> annotations = default;
            Optional<int> schemaVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("manifests"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ManifestListAttributes> array = new List<ManifestListAttributes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManifestListAttributes.DeserializeManifestListAttributes(item));
                    }
                    manifests = array;
                    continue;
                }
                if (property.NameEquals("annotations"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        annotations = null;
                        continue;
                    }
                    annotations = Annotations.DeserializeAnnotations(property.Value);
                    continue;
                }
                if (property.NameEquals("schemaVersion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    schemaVersion = property.Value.GetInt32();
                    continue;
                }
            }
            return new OCIIndex(Optional.ToNullable(schemaVersion), Optional.ToList(manifests), annotations.Value);
        }
    }
}
