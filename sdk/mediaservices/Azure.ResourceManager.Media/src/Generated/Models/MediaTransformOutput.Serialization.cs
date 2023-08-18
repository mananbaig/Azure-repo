// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class MediaTransformOutput : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(OnError))
            {
                writer.WritePropertyName("onError"u8);
                writer.WriteStringValue(OnError.Value.ToString());
            }
            if (Core.Optional.IsDefined(RelativePriority))
            {
                writer.WritePropertyName("relativePriority"u8);
                writer.WriteStringValue(RelativePriority.Value.ToString());
            }
            writer.WritePropertyName("preset"u8);
            writer.WriteObjectValue(Preset);
            writer.WriteEndObject();
        }

        internal static MediaTransformOutput DeserializeMediaTransformOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<MediaTransformOnErrorType> onError = default;
            Core.Optional<MediaJobPriority> relativePriority = default;
            MediaTransformPreset preset = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("onError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onError = new MediaTransformOnErrorType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("relativePriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    relativePriority = new MediaJobPriority(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preset"u8))
                {
                    preset = MediaTransformPreset.DeserializeMediaTransformPreset(property.Value);
                    continue;
                }
            }
            return new MediaTransformOutput(Core.Optional.ToNullable(onError), Core.Optional.ToNullable(relativePriority), preset);
        }
    }
}
