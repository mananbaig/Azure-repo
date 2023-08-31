// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AudioTrackDescriptor : IUtf8JsonSerializable, IModelJsonSerializable<AudioTrackDescriptor>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AudioTrackDescriptor>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AudioTrackDescriptor>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AudioTrackDescriptor>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ChannelMapping))
            {
                writer.WritePropertyName("channelMapping"u8);
                writer.WriteStringValue(ChannelMapping.Value.ToString());
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static AudioTrackDescriptor DeserializeAudioTrackDescriptor(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.SelectAudioTrackByAttribute": return SelectAudioTrackByAttribute.DeserializeSelectAudioTrackByAttribute(element);
                    case "#Microsoft.Media.SelectAudioTrackById": return SelectAudioTrackById.DeserializeSelectAudioTrackById(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<ChannelMapping> channelMapping = default;
            string odataType = "#Microsoft.Media.AudioTrackDescriptor";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channelMapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    channelMapping = new ChannelMapping(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AudioTrackDescriptor(odataType, Optional.ToNullable(channelMapping), rawData);
        }

        AudioTrackDescriptor IModelJsonSerializable<AudioTrackDescriptor>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AudioTrackDescriptor>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAudioTrackDescriptor(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AudioTrackDescriptor>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AudioTrackDescriptor>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AudioTrackDescriptor IModelSerializable<AudioTrackDescriptor>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AudioTrackDescriptor>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAudioTrackDescriptor(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AudioTrackDescriptor model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AudioTrackDescriptor(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAudioTrackDescriptor(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
