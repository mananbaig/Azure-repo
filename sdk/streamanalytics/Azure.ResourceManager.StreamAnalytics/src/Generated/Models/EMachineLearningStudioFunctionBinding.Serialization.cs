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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class EMachineLearningStudioFunctionBinding : IUtf8JsonSerializable, IModelJsonSerializable<EMachineLearningStudioFunctionBinding>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EMachineLearningStudioFunctionBinding>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EMachineLearningStudioFunctionBinding>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EMachineLearningStudioFunctionBinding>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(FunctionBindingType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(ApiKey))
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (Optional.IsDefined(Inputs))
            {
                writer.WritePropertyName("inputs"u8);
                if (Inputs is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<MachineLearningStudioInputs>)Inputs).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Outputs))
            {
                writer.WritePropertyName("outputs"u8);
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MachineLearningStudioOutputColumn>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(BatchSize))
            {
                writer.WritePropertyName("batchSize"u8);
                writer.WriteNumberValue(BatchSize.Value);
            }
            writer.WriteEndObject();
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

        internal static EMachineLearningStudioFunctionBinding DeserializeEMachineLearningStudioFunctionBinding(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> endpoint = default;
            Optional<string> apiKey = default;
            Optional<MachineLearningStudioInputs> inputs = default;
            Optional<IList<MachineLearningStudioOutputColumn>> outputs = default;
            Optional<int> batchSize = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("endpoint"u8))
                        {
                            endpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("inputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            inputs = MachineLearningStudioInputs.DeserializeMachineLearningStudioInputs(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("outputs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MachineLearningStudioOutputColumn> array = new List<MachineLearningStudioOutputColumn>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MachineLearningStudioOutputColumn.DeserializeMachineLearningStudioOutputColumn(item));
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("batchSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            batchSize = property0.Value.GetInt32();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EMachineLearningStudioFunctionBinding(type, endpoint.Value, apiKey.Value, inputs.Value, Optional.ToList(outputs), Optional.ToNullable(batchSize), serializedAdditionalRawData);
        }

        EMachineLearningStudioFunctionBinding IModelJsonSerializable<EMachineLearningStudioFunctionBinding>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EMachineLearningStudioFunctionBinding>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEMachineLearningStudioFunctionBinding(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EMachineLearningStudioFunctionBinding>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EMachineLearningStudioFunctionBinding>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EMachineLearningStudioFunctionBinding IModelSerializable<EMachineLearningStudioFunctionBinding>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EMachineLearningStudioFunctionBinding>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEMachineLearningStudioFunctionBinding(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EMachineLearningStudioFunctionBinding"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EMachineLearningStudioFunctionBinding"/> to convert. </param>
        public static implicit operator RequestContent(EMachineLearningStudioFunctionBinding model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EMachineLearningStudioFunctionBinding"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EMachineLearningStudioFunctionBinding(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEMachineLearningStudioFunctionBinding(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
