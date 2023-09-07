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

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseDataConnectionValidationListResult : IUtf8JsonSerializable, IModelJsonSerializable<SynapseDataConnectionValidationListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseDataConnectionValidationListResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseDataConnectionValidationListResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataConnectionValidationListResult>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SynapseDataConnectionValidationResult>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static SynapseDataConnectionValidationListResult DeserializeSynapseDataConnectionValidationListResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseDataConnectionValidationResult>> value = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseDataConnectionValidationResult> array = new List<SynapseDataConnectionValidationResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseDataConnectionValidationResult.DeserializeSynapseDataConnectionValidationResult(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SynapseDataConnectionValidationListResult(Optional.ToList(value), serializedAdditionalRawData);
        }

        SynapseDataConnectionValidationListResult IModelJsonSerializable<SynapseDataConnectionValidationListResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataConnectionValidationListResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseDataConnectionValidationListResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseDataConnectionValidationListResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataConnectionValidationListResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseDataConnectionValidationListResult IModelSerializable<SynapseDataConnectionValidationListResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseDataConnectionValidationListResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseDataConnectionValidationListResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseDataConnectionValidationListResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseDataConnectionValidationListResult"/> to convert. </param>
        public static implicit operator RequestContent(SynapseDataConnectionValidationListResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseDataConnectionValidationListResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseDataConnectionValidationListResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseDataConnectionValidationListResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
