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

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisForceRebootResult : IUtf8JsonSerializable, IModelJsonSerializable<RedisForceRebootResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedisForceRebootResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedisForceRebootResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisForceRebootResult>(this, options.Format);

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

        internal static RedisForceRebootResult DeserializeRedisForceRebootResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> message = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RedisForceRebootResult(message.Value, serializedAdditionalRawData);
        }

        RedisForceRebootResult IModelJsonSerializable<RedisForceRebootResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisForceRebootResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisForceRebootResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedisForceRebootResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisForceRebootResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedisForceRebootResult IModelSerializable<RedisForceRebootResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisForceRebootResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedisForceRebootResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RedisForceRebootResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RedisForceRebootResult"/> to convert. </param>
        public static implicit operator RequestContent(RedisForceRebootResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RedisForceRebootResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RedisForceRebootResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedisForceRebootResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
