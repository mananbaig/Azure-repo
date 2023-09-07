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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class NamedLineString : IUtf8JsonSerializable, IModelJsonSerializable<NamedLineString>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NamedLineString>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NamedLineString>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineString>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("line"u8);
            writer.WriteStringValue(Line);
            writer.WritePropertyName("@type"u8);
            writer.WriteStringValue(Type);
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

        internal static NamedLineString DeserializeNamedLineString(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string line = default;
            string type = default;
            string name = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("line"u8))
                {
                    line = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NamedLineString(type, name, line, serializedAdditionalRawData);
        }

        NamedLineString IModelJsonSerializable<NamedLineString>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineString>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNamedLineString(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NamedLineString>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineString>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NamedLineString IModelSerializable<NamedLineString>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<NamedLineString>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNamedLineString(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NamedLineString"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NamedLineString"/> to convert. </param>
        public static implicit operator RequestContent(NamedLineString model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NamedLineString"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NamedLineString(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNamedLineString(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
