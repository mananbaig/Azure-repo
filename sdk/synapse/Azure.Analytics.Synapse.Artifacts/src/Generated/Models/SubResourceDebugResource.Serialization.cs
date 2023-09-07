// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SubResourceDebugResourceConverter))]
    public partial class SubResourceDebugResource : IUtf8JsonSerializable, IModelJsonSerializable<SubResourceDebugResource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubResourceDebugResource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubResourceDebugResource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubResourceDebugResource>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
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

        internal static SubResourceDebugResource DeserializeSubResourceDebugResource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new SubResourceDebugResource(name.Value, serializedAdditionalRawData);
        }

        SubResourceDebugResource IModelJsonSerializable<SubResourceDebugResource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubResourceDebugResource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubResourceDebugResource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubResourceDebugResource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubResourceDebugResource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubResourceDebugResource IModelSerializable<SubResourceDebugResource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SubResourceDebugResource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubResourceDebugResource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SubResourceDebugResource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SubResourceDebugResource"/> to convert. </param>
        public static implicit operator RequestContent(SubResourceDebugResource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SubResourceDebugResource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SubResourceDebugResource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubResourceDebugResource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class SubResourceDebugResourceConverter : JsonConverter<SubResourceDebugResource>
        {
            public override void Write(Utf8JsonWriter writer, SubResourceDebugResource model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SubResourceDebugResource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSubResourceDebugResource(document.RootElement);
            }
        }
    }
}
