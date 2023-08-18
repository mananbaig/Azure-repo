// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class CollectionsToSubscriptionsMappingResult
    {
        internal static CollectionsToSubscriptionsMappingResult DeserializeCollectionsToSubscriptionsMappingResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyDictionary<string, CollectionsSubscriptionsMappingDetails>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, CollectionsSubscriptionsMappingDetails> dictionary = new Dictionary<string, CollectionsSubscriptionsMappingDetails>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, CollectionsSubscriptionsMappingDetails.DeserializeCollectionsSubscriptionsMappingDetails(property0.Value));
                    }
                    details = dictionary;
                    continue;
                }
            }
            return new CollectionsToSubscriptionsMappingResult(Core.Optional.ToDictionary(details));
        }
    }
}
