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
    public partial class EnvelopeEncryption : IUtf8JsonSerializable, IModelJsonSerializable<EnvelopeEncryption>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EnvelopeEncryption>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EnvelopeEncryption>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnabledProtocols))
            {
                writer.WritePropertyName("enabledProtocols"u8);
                writer.WriteObjectValue(EnabledProtocols);
            }
            if (Optional.IsCollectionDefined(ClearTracks))
            {
                writer.WritePropertyName("clearTracks"u8);
                writer.WriteStartArray();
                foreach (var item in ClearTracks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ContentKeys))
            {
                writer.WritePropertyName("contentKeys"u8);
                writer.WriteObjectValue(ContentKeys);
            }
            if (Optional.IsDefined(CustomKeyAcquisitionUriTemplate))
            {
                writer.WritePropertyName("customKeyAcquisitionUrlTemplate"u8);
                writer.WriteStringValue(CustomKeyAcquisitionUriTemplate);
            }
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

        internal static EnvelopeEncryption DeserializeEnvelopeEncryption(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MediaEnabledProtocols> enabledProtocols = default;
            Optional<IList<MediaTrackSelection>> clearTracks = default;
            Optional<StreamingPolicyContentKeys> contentKeys = default;
            Optional<string> customKeyAcquisitionUriTemplate = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabledProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabledProtocols = MediaEnabledProtocols.DeserializeMediaEnabledProtocols(property.Value);
                    continue;
                }
                if (property.NameEquals("clearTracks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaTrackSelection> array = new List<MediaTrackSelection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaTrackSelection.DeserializeMediaTrackSelection(item));
                    }
                    clearTracks = array;
                    continue;
                }
                if (property.NameEquals("contentKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentKeys = StreamingPolicyContentKeys.DeserializeStreamingPolicyContentKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("customKeyAcquisitionUrlTemplate"u8))
                {
                    customKeyAcquisitionUriTemplate = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EnvelopeEncryption(enabledProtocols.Value, Optional.ToList(clearTracks), contentKeys.Value, customKeyAcquisitionUriTemplate.Value, rawData);
        }

        EnvelopeEncryption IModelJsonSerializable<EnvelopeEncryption>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEnvelopeEncryption(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EnvelopeEncryption>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EnvelopeEncryption IModelSerializable<EnvelopeEncryption>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEnvelopeEncryption(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EnvelopeEncryption model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EnvelopeEncryption(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEnvelopeEncryption(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
