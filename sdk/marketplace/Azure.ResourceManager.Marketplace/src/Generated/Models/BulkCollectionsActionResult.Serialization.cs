// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class BulkCollectionsActionResult
    {
        internal static BulkCollectionsActionResult DeserializeBulkCollectionsActionResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<PrivateStoreCollectionDetails>> succeeded = default;
            Core.Optional<IReadOnlyList<PrivateStoreCollectionDetails>> failed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeeded"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item));
                    }
                    succeeded = array;
                    continue;
                }
                if (property.NameEquals("failed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PrivateStoreCollectionDetails> array = new List<PrivateStoreCollectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PrivateStoreCollectionDetails.DeserializePrivateStoreCollectionDetails(item));
                    }
                    failed = array;
                    continue;
                }
            }
            return new BulkCollectionsActionResult(Core.Optional.ToList(succeeded), Core.Optional.ToList(failed));
        }
    }
}
