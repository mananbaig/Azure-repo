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

namespace Azure.AI.Language.QuestionAnswering
{
    public partial class AnswersOptions : IUtf8JsonSerializable, IModelJsonSerializable<AnswersOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AnswersOptions>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AnswersOptions>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(QnaId))
            {
                writer.WritePropertyName("qnaId"u8);
                writer.WriteNumberValue(QnaId.Value);
            }
            if (Optional.IsDefined(Question))
            {
                writer.WritePropertyName("question"u8);
                writer.WriteStringValue(Question);
            }
            if (Optional.IsDefined(Size))
            {
                writer.WritePropertyName("top"u8);
                writer.WriteNumberValue(Size.Value);
            }
            if (Optional.IsDefined(UserId))
            {
                writer.WritePropertyName("userId"u8);
                writer.WriteStringValue(UserId);
            }
            if (Optional.IsDefined(ConfidenceThreshold))
            {
                writer.WritePropertyName("confidenceScoreThreshold"u8);
                writer.WriteNumberValue(ConfidenceThreshold.Value);
            }
            if (Optional.IsDefined(AnswerContext))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteObjectValue(AnswerContext);
            }
            if (Optional.IsDefined(RankerKind))
            {
                writer.WritePropertyName("rankerType"u8);
                writer.WriteStringValue(RankerKind.Value.ToString());
            }
            if (Optional.IsDefined(Filters))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteObjectValue(Filters);
            }
            if (Optional.IsDefined(ShortAnswerOptions))
            {
                writer.WritePropertyName("answerSpanRequest"u8);
                writer.WriteObjectValue(ShortAnswerOptions);
            }
            if (Optional.IsDefined(IncludeUnstructuredSources))
            {
                writer.WritePropertyName("includeUnstructuredSources"u8);
                writer.WriteBooleanValue(IncludeUnstructuredSources.Value);
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

        internal static AnswersOptions DeserializeAnswersOptions(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> qnaId = default;
            Optional<string> question = default;
            Optional<int> top = default;
            Optional<string> userId = default;
            Optional<double> confidenceScoreThreshold = default;
            Optional<KnowledgeBaseAnswerContext> context = default;
            Optional<RankerKind> rankerType = default;
            Optional<QueryFilters> filters = default;
            Optional<ShortAnswerOptions> answerSpanRequest = default;
            Optional<bool> includeUnstructuredSources = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("qnaId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    qnaId = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("question"u8))
                {
                    question = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("top"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    top = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("confidenceScoreThreshold"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    confidenceScoreThreshold = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    context = KnowledgeBaseAnswerContext.DeserializeKnowledgeBaseAnswerContext(property.Value);
                    continue;
                }
                if (property.NameEquals("rankerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rankerType = new RankerKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("filters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    filters = QueryFilters.DeserializeQueryFilters(property.Value);
                    continue;
                }
                if (property.NameEquals("answerSpanRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    answerSpanRequest = ShortAnswerOptions.DeserializeShortAnswerOptions(property.Value);
                    continue;
                }
                if (property.NameEquals("includeUnstructuredSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeUnstructuredSources = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AnswersOptions(Optional.ToNullable(qnaId), question.Value, Optional.ToNullable(top), userId.Value, Optional.ToNullable(confidenceScoreThreshold), context.Value, Optional.ToNullable(rankerType), filters.Value, answerSpanRequest.Value, Optional.ToNullable(includeUnstructuredSources), rawData);
        }

        AnswersOptions IModelJsonSerializable<AnswersOptions>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAnswersOptions(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AnswersOptions>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AnswersOptions IModelSerializable<AnswersOptions>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAnswersOptions(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AnswersOptions model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AnswersOptions(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAnswersOptions(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
