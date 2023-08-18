// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaTransformPreset : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static MediaTransformPreset DeserializeMediaTransformPreset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.AudioAnalyzerPreset": return AudioAnalyzerPreset.DeserializeAudioAnalyzerPreset(element);
                    case "#Microsoft.Media.BuiltInStandardEncoderPreset": return BuiltInStandardEncoderPreset.DeserializeBuiltInStandardEncoderPreset(element);
                    case "#Microsoft.Media.StandardEncoderPreset": return StandardEncoderPreset.DeserializeStandardEncoderPreset(element);
                    case "#Microsoft.Media.VideoAnalyzerPreset": return VideoAnalyzerPreset.DeserializeVideoAnalyzerPreset(element);
                }
            }
            return UnknownPreset.DeserializeUnknownPreset(element);
        }
    }
}
