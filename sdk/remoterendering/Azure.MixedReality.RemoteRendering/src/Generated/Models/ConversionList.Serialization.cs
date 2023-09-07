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

namespace Azure.MixedReality.RemoteRendering
{
    internal partial class ConversionList : IUtf8JsonSerializable, IModelJsonSerializable<ConversionList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ConversionList>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ConversionList>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConversionList>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("conversions"u8);
            writer.WriteStartArray();
            foreach (var item in Conversions)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AssetConversion>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static ConversionList DeserializeConversionList(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AssetConversion> conversions = default;
            Optional<string> nextLink = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("conversions"u8))
                {
                    List<AssetConversion> array = new List<AssetConversion>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssetConversion.DeserializeAssetConversion(item));
                    }
                    conversions = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ConversionList(conversions, nextLink.Value, serializedAdditionalRawData);
        }

        ConversionList IModelJsonSerializable<ConversionList>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConversionList>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeConversionList(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ConversionList>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConversionList>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ConversionList IModelSerializable<ConversionList>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ConversionList>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeConversionList(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ConversionList"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ConversionList"/> to convert. </param>
        public static implicit operator RequestContent(ConversionList model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ConversionList"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ConversionList(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeConversionList(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
