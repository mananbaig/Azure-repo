// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AacAudio : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Profile))
            {
                writer.WritePropertyName("profile"u8);
                writer.WriteStringValue(Profile.Value.ToString());
            }
            if (Core.Optional.IsDefined(Channels))
            {
                writer.WritePropertyName("channels"u8);
                writer.WriteNumberValue(Channels.Value);
            }
            if (Core.Optional.IsDefined(SamplingRate))
            {
                writer.WritePropertyName("samplingRate"u8);
                writer.WriteNumberValue(SamplingRate.Value);
            }
            if (Core.Optional.IsDefined(Bitrate))
            {
                writer.WritePropertyName("bitrate"u8);
                writer.WriteNumberValue(Bitrate.Value);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Core.Optional.IsDefined(Label))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Label);
            }
            writer.WriteEndObject();
        }

        internal static AacAudio DeserializeAacAudio(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<AacAudioProfile> profile = default;
            Core.Optional<int> channels = default;
            Core.Optional<int> samplingRate = default;
            Core.Optional<int> bitrate = default;
            string odataType = default;
            Core.Optional<string> label = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("profile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    profile = new AacAudioProfile(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("channels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    channels = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("samplingRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    samplingRate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bitrate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bitrate = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
            }
            return new AacAudio(odataType, label.Value, Core.Optional.ToNullable(channels), Core.Optional.ToNullable(samplingRate), Core.Optional.ToNullable(bitrate), Core.Optional.ToNullable(profile));
        }
    }
}
