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

namespace Azure.IoT.TimeSeriesInsights
{
    internal partial class UpdateModelSettingsRequest : IUtf8JsonSerializable, IModelJsonSerializable<UpdateModelSettingsRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UpdateModelSettingsRequest>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UpdateModelSettingsRequest>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateModelSettingsRequest>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(DefaultTypeId))
            {
                writer.WritePropertyName("defaultTypeId"u8);
                writer.WriteStringValue(DefaultTypeId);
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

        internal static UpdateModelSettingsRequest DeserializeUpdateModelSettingsRequest(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> defaultTypeId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultTypeId"u8))
                {
                    defaultTypeId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UpdateModelSettingsRequest(name.Value, defaultTypeId.Value, serializedAdditionalRawData);
        }

        UpdateModelSettingsRequest IModelJsonSerializable<UpdateModelSettingsRequest>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateModelSettingsRequest>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateModelSettingsRequest(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UpdateModelSettingsRequest>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateModelSettingsRequest>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UpdateModelSettingsRequest IModelSerializable<UpdateModelSettingsRequest>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UpdateModelSettingsRequest>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUpdateModelSettingsRequest(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UpdateModelSettingsRequest"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UpdateModelSettingsRequest"/> to convert. </param>
        public static implicit operator RequestContent(UpdateModelSettingsRequest model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UpdateModelSettingsRequest"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UpdateModelSettingsRequest(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUpdateModelSettingsRequest(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
