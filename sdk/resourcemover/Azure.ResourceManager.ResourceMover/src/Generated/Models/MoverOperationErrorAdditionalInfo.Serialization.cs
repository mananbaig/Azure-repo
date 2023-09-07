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
    public partial class MoverOperationErrorAdditionalInfo : IUtf8JsonSerializable, IModelJsonSerializable<MoverOperationErrorAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MoverOperationErrorAdditionalInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MoverOperationErrorAdditionalInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverOperationErrorAdditionalInfo>(this, options.Format);

            writer.WriteStartObject();
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

        internal static MoverOperationErrorAdditionalInfo DeserializeMoverOperationErrorAdditionalInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<MoveErrorInfo> info = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("info"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    info = MoveErrorInfo.DeserializeMoveErrorInfo(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MoverOperationErrorAdditionalInfo(type.Value, info.Value, serializedAdditionalRawData);
        }

        MoverOperationErrorAdditionalInfo IModelJsonSerializable<MoverOperationErrorAdditionalInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverOperationErrorAdditionalInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverOperationErrorAdditionalInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MoverOperationErrorAdditionalInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverOperationErrorAdditionalInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MoverOperationErrorAdditionalInfo IModelSerializable<MoverOperationErrorAdditionalInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MoverOperationErrorAdditionalInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMoverOperationErrorAdditionalInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MoverOperationErrorAdditionalInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MoverOperationErrorAdditionalInfo"/> to convert. </param>
        public static implicit operator RequestContent(MoverOperationErrorAdditionalInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MoverOperationErrorAdditionalInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MoverOperationErrorAdditionalInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMoverOperationErrorAdditionalInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
