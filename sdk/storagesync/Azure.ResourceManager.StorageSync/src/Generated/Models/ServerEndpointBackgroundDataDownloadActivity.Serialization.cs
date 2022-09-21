// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointBackgroundDataDownloadActivity
    {
        internal static ServerEndpointBackgroundDataDownloadActivity DeserializeServerEndpointBackgroundDataDownloadActivity(JsonElement element)
        {
            Optional<DateTimeOffset> timestamp = default;
            Optional<DateTimeOffset> startedTimestamp = default;
            Optional<int> percentProgress = default;
            Optional<long> downloadedBytes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startedTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("percentProgress"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    percentProgress = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("downloadedBytes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    downloadedBytes = property.Value.GetInt64();
                    continue;
                }
            }
            return new ServerEndpointBackgroundDataDownloadActivity(Optional.ToNullable(timestamp), Optional.ToNullable(startedTimestamp), Optional.ToNullable(percentProgress), Optional.ToNullable(downloadedBytes));
        }
    }
}
