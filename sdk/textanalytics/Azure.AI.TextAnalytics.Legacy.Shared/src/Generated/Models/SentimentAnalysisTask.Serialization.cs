// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Legacy
{
    internal partial class SentimentAnalysisTask : IUtf8JsonSerializable, IModelJsonSerializable<SentimentAnalysisTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SentimentAnalysisTask>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SentimentAnalysisTask>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTask>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                if (Parameters is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SentimentAnalysisTaskParameters>)Parameters).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
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

        internal static SentimentAnalysisTask DeserializeSentimentAnalysisTask(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SentimentAnalysisTaskParameters> parameters = default;
            Optional<string> taskName = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    parameters = SentimentAnalysisTaskParameters.DeserializeSentimentAnalysisTaskParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SentimentAnalysisTask(parameters.Value, taskName.Value, serializedAdditionalRawData);
        }

        SentimentAnalysisTask IModelJsonSerializable<SentimentAnalysisTask>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTask>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSentimentAnalysisTask(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SentimentAnalysisTask>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTask>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SentimentAnalysisTask IModelSerializable<SentimentAnalysisTask>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SentimentAnalysisTask>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSentimentAnalysisTask(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SentimentAnalysisTask"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SentimentAnalysisTask"/> to convert. </param>
        public static implicit operator RequestContent(SentimentAnalysisTask model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SentimentAnalysisTask"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SentimentAnalysisTask(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSentimentAnalysisTask(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
