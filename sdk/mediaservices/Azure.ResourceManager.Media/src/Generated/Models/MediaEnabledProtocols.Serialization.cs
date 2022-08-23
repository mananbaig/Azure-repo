// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaEnabledProtocols : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("download");
            writer.WriteBooleanValue(IsDownloadEnabled);
            writer.WritePropertyName("dash");
            writer.WriteBooleanValue(IsDashEnabled);
            writer.WritePropertyName("hls");
            writer.WriteBooleanValue(IsHttpLiveStreamingEnabled);
            writer.WritePropertyName("smoothStreaming");
            writer.WriteBooleanValue(IsSmoothStreamingEnabled);
            writer.WriteEndObject();
        }

        internal static MediaEnabledProtocols DeserializeMediaEnabledProtocols(JsonElement element)
        {
            bool download = default;
            bool dash = default;
            bool hls = default;
            bool smoothStreaming = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("download"))
                {
                    download = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dash"))
                {
                    dash = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hls"))
                {
                    hls = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("smoothStreaming"))
                {
                    smoothStreaming = property.Value.GetBoolean();
                    continue;
                }
            }
            return new MediaEnabledProtocols(download, dash, hls, smoothStreaming);
        }
    }
}
