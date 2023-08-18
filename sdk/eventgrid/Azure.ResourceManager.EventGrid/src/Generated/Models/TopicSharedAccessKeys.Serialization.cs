// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class TopicSharedAccessKeys
    {
        internal static TopicSharedAccessKeys DeserializeTopicSharedAccessKeys(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> key1 = default;
            Core.Optional<string> key2 = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key1"u8))
                {
                    key1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key2"u8))
                {
                    key2 = property.Value.GetString();
                    continue;
                }
            }
            return new TopicSharedAccessKeys(key1.Value, key2.Value);
        }
    }
}
