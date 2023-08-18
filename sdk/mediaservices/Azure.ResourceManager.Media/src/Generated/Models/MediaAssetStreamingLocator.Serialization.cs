// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaAssetStreamingLocator
    {
        internal static MediaAssetStreamingLocator DeserializeMediaAssetStreamingLocator(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> name = default;
            Core.Optional<string> assetName = default;
            Core.Optional<DateTimeOffset> created = default;
            Core.Optional<DateTimeOffset> startTime = default;
            Core.Optional<DateTimeOffset> endTime = default;
            Core.Optional<Guid> streamingLocatorId = default;
            Core.Optional<string> streamingPolicyName = default;
            Core.Optional<string> defaultContentKeyPolicyName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetName"u8))
                {
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("created"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    created = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("streamingLocatorId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    streamingLocatorId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("streamingPolicyName"u8))
                {
                    streamingPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultContentKeyPolicyName"u8))
                {
                    defaultContentKeyPolicyName = property.Value.GetString();
                    continue;
                }
            }
            return new MediaAssetStreamingLocator(name.Value, assetName.Value, Core.Optional.ToNullable(created), Core.Optional.ToNullable(startTime), Core.Optional.ToNullable(endTime), Core.Optional.ToNullable(streamingLocatorId), streamingPolicyName.Value, defaultContentKeyPolicyName.Value);
        }
    }
}
