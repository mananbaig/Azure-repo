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

namespace Azure.ResourceManager.ResourceHealth.Models
{
    public partial class ResourceHealthEventArticle : IUtf8JsonSerializable, IModelJsonSerializable<ResourceHealthEventArticle>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceHealthEventArticle>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceHealthEventArticle>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventArticle>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ArticleContent))
            {
                writer.WritePropertyName("articleContent"u8);
                writer.WriteStringValue(ArticleContent);
            }
            if (Optional.IsDefined(ArticleId))
            {
                writer.WritePropertyName("articleId"u8);
                writer.WriteStringValue(ArticleId);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Parameters.ToString()).RootElement);
#endif
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

        internal static ResourceHealthEventArticle DeserializeResourceHealthEventArticle(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> articleContent = default;
            Optional<string> articleId = default;
            Optional<BinaryData> parameters = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("articleContent"u8))
                {
                    articleContent = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("articleId"u8))
                {
                    articleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceHealthEventArticle(articleContent.Value, articleId.Value, parameters.Value, serializedAdditionalRawData);
        }

        ResourceHealthEventArticle IModelJsonSerializable<ResourceHealthEventArticle>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventArticle>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthEventArticle(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceHealthEventArticle>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventArticle>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceHealthEventArticle IModelSerializable<ResourceHealthEventArticle>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthEventArticle>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceHealthEventArticle(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceHealthEventArticle"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceHealthEventArticle"/> to convert. </param>
        public static implicit operator RequestContent(ResourceHealthEventArticle model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceHealthEventArticle"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceHealthEventArticle(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceHealthEventArticle(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
