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

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseCapability : IUtf8JsonSerializable, IModelJsonSerializable<RedisEnterpriseCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RedisEnterpriseCapability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RedisEnterpriseCapability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisEnterpriseCapability>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteBooleanValue(Value.Value);
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

        internal static RedisEnterpriseCapability DeserializeRedisEnterpriseCapability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<bool> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RedisEnterpriseCapability(name.Value, Optional.ToNullable(value), serializedAdditionalRawData);
        }

        RedisEnterpriseCapability IModelJsonSerializable<RedisEnterpriseCapability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisEnterpriseCapability>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRedisEnterpriseCapability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RedisEnterpriseCapability>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisEnterpriseCapability>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RedisEnterpriseCapability IModelSerializable<RedisEnterpriseCapability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RedisEnterpriseCapability>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRedisEnterpriseCapability(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RedisEnterpriseCapability"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RedisEnterpriseCapability"/> to convert. </param>
        public static implicit operator RequestContent(RedisEnterpriseCapability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RedisEnterpriseCapability"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RedisEnterpriseCapability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRedisEnterpriseCapability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
