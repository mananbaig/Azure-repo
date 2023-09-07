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
    public partial class RemoteRenderingServiceError : IUtf8JsonSerializable, IModelJsonSerializable<RemoteRenderingServiceError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RemoteRenderingServiceError>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RemoteRenderingServiceError>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RemoteRenderingServiceError>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code);
            writer.WritePropertyName("message"u8);
            writer.WriteStringValue(Message);
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

        internal static RemoteRenderingServiceError DeserializeRemoteRenderingServiceError(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            Optional<IReadOnlyList<RemoteRenderingServiceError>> details = default;
            Optional<string> target = default;
            Optional<RemoteRenderingServiceError> innerError = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RemoteRenderingServiceError> array = new List<RemoteRenderingServiceError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeRemoteRenderingServiceError(item));
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("innerError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    innerError = DeserializeRemoteRenderingServiceError(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RemoteRenderingServiceError(code, message, Optional.ToList(details), target.Value, innerError.Value, serializedAdditionalRawData);
        }

        RemoteRenderingServiceError IModelJsonSerializable<RemoteRenderingServiceError>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RemoteRenderingServiceError>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRemoteRenderingServiceError(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RemoteRenderingServiceError>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RemoteRenderingServiceError>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RemoteRenderingServiceError IModelSerializable<RemoteRenderingServiceError>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RemoteRenderingServiceError>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRemoteRenderingServiceError(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RemoteRenderingServiceError"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RemoteRenderingServiceError"/> to convert. </param>
        public static implicit operator RequestContent(RemoteRenderingServiceError model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RemoteRenderingServiceError"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RemoteRenderingServiceError(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRemoteRenderingServiceError(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
