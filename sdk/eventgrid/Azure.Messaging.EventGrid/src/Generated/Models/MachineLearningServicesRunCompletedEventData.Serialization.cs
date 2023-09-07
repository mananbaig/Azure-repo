// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(MachineLearningServicesRunCompletedEventDataConverter))]
    public partial class MachineLearningServicesRunCompletedEventData : IUtf8JsonSerializable, IModelJsonSerializable<MachineLearningServicesRunCompletedEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MachineLearningServicesRunCompletedEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MachineLearningServicesRunCompletedEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningServicesRunCompletedEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ExperimentId))
            {
                writer.WritePropertyName("experimentId"u8);
                writer.WriteStringValue(ExperimentId);
            }
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName"u8);
                writer.WriteStringValue(ExperimentName);
            }
            if (Optional.IsDefined(RunId))
            {
                writer.WritePropertyName("runId"u8);
                writer.WriteStringValue(RunId);
            }
            if (Optional.IsDefined(RunType))
            {
                writer.WritePropertyName("runType"u8);
                writer.WriteStringValue(RunType);
            }
            if (Optional.IsDefined(RunTags))
            {
                writer.WritePropertyName("runTags"u8);
                writer.WriteObjectValue(RunTags);
            }
            if (Optional.IsDefined(RunProperties))
            {
                writer.WritePropertyName("runProperties"u8);
                writer.WriteObjectValue(RunProperties);
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

        internal static MachineLearningServicesRunCompletedEventData DeserializeMachineLearningServicesRunCompletedEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> experimentId = default;
            Optional<string> experimentName = default;
            Optional<string> runId = default;
            Optional<string> runType = default;
            Optional<object> runTags = default;
            Optional<object> runProperties = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("experimentId"u8))
                {
                    experimentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("experimentName"u8))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runId"u8))
                {
                    runId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runType"u8))
                {
                    runType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runTags = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("runProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runProperties = property.Value.GetObject();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MachineLearningServicesRunCompletedEventData(experimentId.Value, experimentName.Value, runId.Value, runType.Value, runTags.Value, runProperties.Value, serializedAdditionalRawData);
        }

        MachineLearningServicesRunCompletedEventData IModelJsonSerializable<MachineLearningServicesRunCompletedEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningServicesRunCompletedEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicesRunCompletedEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MachineLearningServicesRunCompletedEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningServicesRunCompletedEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MachineLearningServicesRunCompletedEventData IModelSerializable<MachineLearningServicesRunCompletedEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<MachineLearningServicesRunCompletedEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMachineLearningServicesRunCompletedEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MachineLearningServicesRunCompletedEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MachineLearningServicesRunCompletedEventData"/> to convert. </param>
        public static implicit operator RequestContent(MachineLearningServicesRunCompletedEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MachineLearningServicesRunCompletedEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MachineLearningServicesRunCompletedEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMachineLearningServicesRunCompletedEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class MachineLearningServicesRunCompletedEventDataConverter : JsonConverter<MachineLearningServicesRunCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, MachineLearningServicesRunCompletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override MachineLearningServicesRunCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeMachineLearningServicesRunCompletedEventData(document.RootElement);
            }
        }
    }
}
