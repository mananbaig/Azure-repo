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

namespace Azure.ResourceManager.Quota.Models
{
    public partial class QuotaLimitObject : IUtf8JsonSerializable, IModelJsonSerializable<QuotaLimitObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<QuotaLimitObject>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<QuotaLimitObject>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaLimitObject>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            if (Optional.IsDefined(LimitType))
            {
                writer.WritePropertyName("limitType"u8);
                writer.WriteStringValue(LimitType.Value.ToString());
            }
            writer.WritePropertyName("limitObjectType"u8);
            writer.WriteStringValue(LimitObjectType.ToString());
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

        internal static QuotaLimitObject DeserializeQuotaLimitObject(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            Optional<QuotaLimitType> limitType = default;
            LimitType limitObjectType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limitType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limitType = new QuotaLimitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("limitObjectType"u8))
                {
                    limitObjectType = new LimitType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new QuotaLimitObject(limitObjectType, value, Optional.ToNullable(limitType), serializedAdditionalRawData);
        }

        QuotaLimitObject IModelJsonSerializable<QuotaLimitObject>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaLimitObject>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeQuotaLimitObject(doc.RootElement, options);
        }

        BinaryData IModelSerializable<QuotaLimitObject>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaLimitObject>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        QuotaLimitObject IModelSerializable<QuotaLimitObject>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<QuotaLimitObject>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeQuotaLimitObject(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="QuotaLimitObject"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="QuotaLimitObject"/> to convert. </param>
        public static implicit operator RequestContent(QuotaLimitObject model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="QuotaLimitObject"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator QuotaLimitObject(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeQuotaLimitObject(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
