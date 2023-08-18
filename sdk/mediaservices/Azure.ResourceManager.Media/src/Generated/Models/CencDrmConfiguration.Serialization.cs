// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class CencDrmConfiguration : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(PlayReady))
            {
                writer.WritePropertyName("playReady"u8);
                writer.WriteObjectValue(PlayReady);
            }
            if (Core.Optional.IsDefined(Widevine))
            {
                writer.WritePropertyName("widevine"u8);
                writer.WriteObjectValue(Widevine);
            }
            writer.WriteEndObject();
        }

        internal static CencDrmConfiguration DeserializeCencDrmConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<StreamingPolicyPlayReadyConfiguration> playReady = default;
            Core.Optional<StreamingPolicyWidevineConfiguration> widevine = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("playReady"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    playReady = StreamingPolicyPlayReadyConfiguration.DeserializeStreamingPolicyPlayReadyConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("widevine"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    widevine = StreamingPolicyWidevineConfiguration.DeserializeStreamingPolicyWidevineConfiguration(property.Value);
                    continue;
                }
            }
            return new CencDrmConfiguration(playReady.Value, widevine.Value);
        }
    }
}
