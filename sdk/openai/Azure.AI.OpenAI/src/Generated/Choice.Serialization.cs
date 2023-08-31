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
    public partial class Choice : IUtf8JsonSerializable, IModelJsonSerializable<Choice>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<Choice>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<Choice>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("index"u8);
            writer.WriteNumberValue(Index);
            if (Optional.IsDefined(ContentFilterResults))
            {
                writer.WritePropertyName("content_filter_results"u8);
                if (ContentFilterResults is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ContentFilterResults>)ContentFilterResults).Serialize(writer, options);
                }
            }
            if (LogProbabilityModel != null)
            {
                writer.WritePropertyName("logprobs"u8);
                if (LogProbabilityModel is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CompletionsLogProbabilityModel>)LogProbabilityModel).Serialize(writer, options);
                }
            }
            else
            {
                writer.WriteNull("logprobs");
            }
            if (FinishReason != null)
            {
                writer.WritePropertyName("finish_reason"u8);
                writer.WriteStringValue(FinishReason.Value.ToString());
            }
            else
            {
                writer.WriteNull("finish_reason");
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

        internal static Choice DeserializeChoice(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            int index = default;
            Optional<ContentFilterResults> contentFilterResults = default;
            CompletionsLogProbabilityModel logprobs = default;
            CompletionsFinishReason? finishReason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = ContentFilterResults.DeserializeContentFilterResults(property.Value);
                    continue;
                }
                if (property.NameEquals("logprobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        logprobs = null;
                        continue;
                    }
                    logprobs = CompletionsLogProbabilityModel.DeserializeCompletionsLogProbabilityModel(property.Value);
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        finishReason = null;
                        continue;
                    }
                    finishReason = new CompletionsFinishReason(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Choice(text, index, contentFilterResults.Value, logprobs, finishReason, rawData);
        }

        Choice IModelJsonSerializable<Choice>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeChoice(doc.RootElement, options);
        }

        BinaryData IModelSerializable<Choice>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        Choice IModelSerializable<Choice>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeChoice(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="Choice"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="Choice"/> to convert. </param>
        public static implicit operator RequestContent(Choice model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="Choice"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator Choice(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeChoice(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
