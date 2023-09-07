// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    internal partial class UnknownCharFilter : IUtf8JsonSerializable, IModelJsonSerializable<CharFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CharFilter>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CharFilter>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CharFilter>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static CharFilter DeserializeUnknownCharFilter(JsonElement element, ModelSerializerOptions options = default) => DeserializeCharFilter(element, options);

        CharFilter IModelJsonSerializable<CharFilter>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CharFilter>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownCharFilter(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CharFilter>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CharFilter>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CharFilter IModelSerializable<CharFilter>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<CharFilter>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCharFilter(doc.RootElement, options);
        }
    }
}
