// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridNetwork;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    internal partial class ArtifactStoreListResult
    {
        internal static ArtifactStoreListResult DeserializeArtifactStoreListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ArtifactStoreData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ArtifactStoreData> array = new List<ArtifactStoreData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ArtifactStoreData.DeserializeArtifactStoreData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ArtifactStoreListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
