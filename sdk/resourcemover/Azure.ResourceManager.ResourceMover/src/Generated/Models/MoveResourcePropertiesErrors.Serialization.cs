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

namespace Azure.ResourceManager.ResourceMover.Models
{
    internal partial class MoveResourcePropertiesErrors : IUtf8JsonSerializable, IModelJsonSerializable<MoveResourcePropertiesErrors>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MoveResourcePropertiesErrors>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MoveResourcePropertiesErrors>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoveResourcePropertiesErrors>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties);
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

        internal static MoveResourcePropertiesErrors DeserializeMoveResourcePropertiesErrors(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResponseError> properties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MoveResourcePropertiesErrors(properties.Value, serializedAdditionalRawData);
        }

        MoveResourcePropertiesErrors IModelJsonSerializable<MoveResourcePropertiesErrors>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoveResourcePropertiesErrors>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMoveResourcePropertiesErrors(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MoveResourcePropertiesErrors>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoveResourcePropertiesErrors>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MoveResourcePropertiesErrors IModelSerializable<MoveResourcePropertiesErrors>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoveResourcePropertiesErrors>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMoveResourcePropertiesErrors(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MoveResourcePropertiesErrors"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MoveResourcePropertiesErrors"/> to convert. </param>
        public static implicit operator RequestContent(MoveResourcePropertiesErrors model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MoveResourcePropertiesErrors"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MoveResourcePropertiesErrors(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMoveResourcePropertiesErrors(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
