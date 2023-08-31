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

namespace Azure.AI.OpenAI
{
    public partial class ContentFilterResults : IUtf8JsonSerializable, IModelJsonSerializable<ContentFilterResults>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContentFilterResults>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContentFilterResults>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sexual))
            {
                writer.WritePropertyName("sexual"u8);
                if (Sexual is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentFilterResult>)Sexual).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Violence))
            {
                writer.WritePropertyName("violence"u8);
                if (Violence is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentFilterResult>)Violence).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Hate))
            {
                writer.WritePropertyName("hate"u8);
                if (Hate is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentFilterResult>)Hate).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SelfHarm))
            {
                writer.WritePropertyName("self_harm"u8);
                if (SelfHarm is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentFilterResult>)SelfHarm).Serialize(writer, options);
                }
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static ContentFilterResults DeserializeContentFilterResults(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContentFilterResult> sexual = default;
            Optional<ContentFilterResult> violence = default;
            Optional<ContentFilterResult> hate = default;
            Optional<ContentFilterResult> selfHarm = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sexual"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sexual = ContentFilterResult.DeserializeContentFilterResult(property.Value);
                    continue;
                }
                if (property.NameEquals("violence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    violence = ContentFilterResult.DeserializeContentFilterResult(property.Value);
                    continue;
                }
                if (property.NameEquals("hate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hate = ContentFilterResult.DeserializeContentFilterResult(property.Value);
                    continue;
                }
                if (property.NameEquals("self_harm"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    selfHarm = ContentFilterResult.DeserializeContentFilterResult(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContentFilterResults(sexual.Value, violence.Value, hate.Value, selfHarm.Value, rawData);
        }

        ContentFilterResults IModelJsonSerializable<ContentFilterResults>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContentFilterResults(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContentFilterResults>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContentFilterResults IModelSerializable<ContentFilterResults>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContentFilterResults(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContentFilterResults"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContentFilterResults"/> to convert. </param>
        public static implicit operator RequestContent(ContentFilterResults model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContentFilterResults"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContentFilterResults(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContentFilterResults(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
