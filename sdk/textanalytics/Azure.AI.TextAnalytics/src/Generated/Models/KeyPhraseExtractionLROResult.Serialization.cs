// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.AI.TextAnalytics;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class KeyPhraseExtractionLROResult : IUtf8JsonSerializable, IModelJsonSerializable<KeyPhraseExtractionLROResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<KeyPhraseExtractionLROResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<KeyPhraseExtractionLROResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyPhraseExtractionLROResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("results"u8);
            if (Results is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<KeyPhraseResult>)Results).Serialize(writer, options);
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(TaskName))
            {
                writer.WritePropertyName("taskName"u8);
                writer.WriteStringValue(TaskName);
            }
            writer.WritePropertyName("lastUpdateDateTime"u8);
            writer.WriteStringValue(LastUpdateDateTime, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
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

        internal static KeyPhraseExtractionLROResult DeserializeKeyPhraseExtractionLROResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            KeyPhraseResult results = default;
            AnalyzeTextLROResultsKind kind = default;
            Optional<string> taskName = default;
            DateTimeOffset lastUpdateDateTime = default;
            TextAnalyticsOperationStatus status = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"u8))
                {
                    results = KeyPhraseResult.DeserializeKeyPhraseResult(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new AnalyzeTextLROResultsKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskName"u8))
                {
                    taskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"u8))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new TextAnalyticsOperationStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new KeyPhraseExtractionLROResult(lastUpdateDateTime, status, kind, taskName.Value, results, serializedAdditionalRawData);
        }

        KeyPhraseExtractionLROResult IModelJsonSerializable<KeyPhraseExtractionLROResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyPhraseExtractionLROResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeKeyPhraseExtractionLROResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<KeyPhraseExtractionLROResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyPhraseExtractionLROResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        KeyPhraseExtractionLROResult IModelSerializable<KeyPhraseExtractionLROResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<KeyPhraseExtractionLROResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeKeyPhraseExtractionLROResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="KeyPhraseExtractionLROResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="KeyPhraseExtractionLROResult"/> to convert. </param>
        public static implicit operator RequestContent(KeyPhraseExtractionLROResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="KeyPhraseExtractionLROResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator KeyPhraseExtractionLROResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeKeyPhraseExtractionLROResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
