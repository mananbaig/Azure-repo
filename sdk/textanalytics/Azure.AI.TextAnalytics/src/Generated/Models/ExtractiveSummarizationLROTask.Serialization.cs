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

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class ExtractiveSummarizationLROTask : IUtf8JsonSerializable, IModelJsonSerializable<ExtractiveSummarizationLROTask>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ExtractiveSummarizationLROTask>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ExtractiveSummarizationLROTask>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtractiveSummarizationLROTask>(this, options.Format);

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
                    ((IModelJsonSerializable<ExtractiveSummarizationTaskParameters>)Parameters).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        internal static ExtractiveSummarizationLROTask DeserializeExtractiveSummarizationLROTask(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ExtractiveSummarizationTaskParameters> parameters = default;
            AnalyzeTextLROTaskKind kind = default;
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
                    parameters = ExtractiveSummarizationTaskParameters.DeserializeExtractiveSummarizationTaskParameters(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROTaskKind(property.Value.GetString());
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
            return new ExtractiveSummarizationLROTask(taskName.Value, kind, parameters.Value, serializedAdditionalRawData);
        }

        ExtractiveSummarizationLROTask IModelJsonSerializable<ExtractiveSummarizationLROTask>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtractiveSummarizationLROTask>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeExtractiveSummarizationLROTask(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ExtractiveSummarizationLROTask>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtractiveSummarizationLROTask>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ExtractiveSummarizationLROTask IModelSerializable<ExtractiveSummarizationLROTask>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ExtractiveSummarizationLROTask>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeExtractiveSummarizationLROTask(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ExtractiveSummarizationLROTask"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ExtractiveSummarizationLROTask"/> to convert. </param>
        public static implicit operator RequestContent(ExtractiveSummarizationLROTask model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ExtractiveSummarizationLROTask"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ExtractiveSummarizationLROTask(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeExtractiveSummarizationLROTask(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
