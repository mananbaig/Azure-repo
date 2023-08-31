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
    public partial class SelectAudioTrackByAttribute : IUtf8JsonSerializable, IModelJsonSerializable<SelectAudioTrackByAttribute>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SelectAudioTrackByAttribute>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SelectAudioTrackByAttribute>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelectAudioTrackByAttribute>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("attribute"u8);
            writer.WriteStringValue(Attribute.ToString());
            writer.WritePropertyName("filter"u8);
            writer.WriteStringValue(Filter.ToString());
            if (Optional.IsDefined(FilterValue))
            {
                writer.WritePropertyName("filterValue"u8);
                writer.WriteStringValue(FilterValue);
            }
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

        internal static SelectAudioTrackByAttribute DeserializeSelectAudioTrackByAttribute(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TrackAttribute attribute = default;
            TrackAttributeFilter filter = default;
            Optional<string> filterValue = default;
            Optional<ChannelMapping> channelMapping = default;
            string odataType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("attribute"u8))
                {
                    attribute = new TrackAttribute(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = new TrackAttributeFilter(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filterValue"u8))
                {
                    filterValue = property.Value.GetString();
                    continue;
                }
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
            return new SelectAudioTrackByAttribute(odataType, Optional.ToNullable(channelMapping), attribute, filter, filterValue.Value, rawData);
        }

        SelectAudioTrackByAttribute IModelJsonSerializable<SelectAudioTrackByAttribute>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelectAudioTrackByAttribute>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSelectAudioTrackByAttribute(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SelectAudioTrackByAttribute>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelectAudioTrackByAttribute>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SelectAudioTrackByAttribute IModelSerializable<SelectAudioTrackByAttribute>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SelectAudioTrackByAttribute>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSelectAudioTrackByAttribute(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SelectAudioTrackByAttribute model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SelectAudioTrackByAttribute(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSelectAudioTrackByAttribute(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
