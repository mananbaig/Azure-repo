// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Communication.MediaComposition.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.MediaComposition
{
    public partial class SrtInput : IUtf8JsonSerializable, IModelJsonSerializable<SrtInput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SrtInput>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SrtInput>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SrtInput>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resolution"u8);
            if (Resolution is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<LayoutResolution>)Resolution).Serialize(writer, options);
            }
            writer.WritePropertyName("streamUrl"u8);
            writer.WriteStringValue(StreamUrl);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(PlaceholderImageUri))
            {
                writer.WritePropertyName("placeholderImageUri"u8);
                writer.WriteStringValue(PlaceholderImageUri);
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

        internal static SrtInput DeserializeSrtInput(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            LayoutResolution resolution = default;
            string streamUrl = default;
            MediaInputType kind = default;
            Optional<string> placeholderImageUri = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resolution"u8))
                {
                    resolution = LayoutResolution.DeserializeLayoutResolution(property.Value);
                    continue;
                }
                if (property.NameEquals("streamUrl"u8))
                {
                    streamUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new MediaInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("placeholderImageUri"u8))
                {
                    placeholderImageUri = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SrtInput(kind, placeholderImageUri.Value, resolution, streamUrl, rawData);
        }

        SrtInput IModelJsonSerializable<SrtInput>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SrtInput>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSrtInput(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SrtInput>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SrtInput>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SrtInput IModelSerializable<SrtInput>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SrtInput>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSrtInput(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SrtInput"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SrtInput"/> to convert. </param>
        public static implicit operator RequestContent(SrtInput model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SrtInput"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SrtInput(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSrtInput(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
