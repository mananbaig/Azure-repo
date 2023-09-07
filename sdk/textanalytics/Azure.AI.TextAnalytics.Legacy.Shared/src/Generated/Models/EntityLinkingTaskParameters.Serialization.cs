// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics.Legacy;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Legacy.Models
{
    internal partial class EntityLinkingTaskParameters : IUtf8JsonSerializable, IModelJsonSerializable<EntityLinkingTaskParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EntityLinkingTaskParameters>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EntityLinkingTaskParameters>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EntityLinkingTaskParameters>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("model-version"u8);
                writer.WriteStringValue(ModelVersion);
            }
            if (Optional.IsDefined(LoggingOptOut))
            {
                writer.WritePropertyName("loggingOptOut"u8);
                writer.WriteBooleanValue(LoggingOptOut.Value);
            }
            if (Optional.IsDefined(StringIndexType))
            {
                writer.WritePropertyName("stringIndexType"u8);
                writer.WriteStringValue(StringIndexType.Value.ToString());
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

        internal static EntityLinkingTaskParameters DeserializeEntityLinkingTaskParameters(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> modelVersion = default;
            Optional<bool> loggingOptOut = default;
            Optional<StringIndexType> stringIndexType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("model-version"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("loggingOptOut"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    loggingOptOut = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("stringIndexType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stringIndexType = new StringIndexType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EntityLinkingTaskParameters(modelVersion.Value, Optional.ToNullable(loggingOptOut), Optional.ToNullable(stringIndexType), serializedAdditionalRawData);
        }

        EntityLinkingTaskParameters IModelJsonSerializable<EntityLinkingTaskParameters>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EntityLinkingTaskParameters>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityLinkingTaskParameters(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EntityLinkingTaskParameters>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EntityLinkingTaskParameters>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EntityLinkingTaskParameters IModelSerializable<EntityLinkingTaskParameters>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EntityLinkingTaskParameters>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEntityLinkingTaskParameters(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EntityLinkingTaskParameters"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EntityLinkingTaskParameters"/> to convert. </param>
        public static implicit operator RequestContent(EntityLinkingTaskParameters model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EntityLinkingTaskParameters"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EntityLinkingTaskParameters(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEntityLinkingTaskParameters(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
