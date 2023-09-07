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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabEvaluatePolicy : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabEvaluatePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabEvaluatePolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabEvaluatePolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePolicy>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FactName))
            {
                writer.WritePropertyName("factName"u8);
                writer.WriteStringValue(FactName);
            }
            if (Optional.IsDefined(FactData))
            {
                writer.WritePropertyName("factData"u8);
                writer.WriteStringValue(FactData);
            }
            if (Optional.IsDefined(ValueOffset))
            {
                writer.WritePropertyName("valueOffset"u8);
                writer.WriteStringValue(ValueOffset);
            }
            if (Optional.IsDefined(UserObjectId))
            {
                writer.WritePropertyName("userObjectId"u8);
                writer.WriteStringValue(UserObjectId);
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

        internal static DevTestLabEvaluatePolicy DeserializeDevTestLabEvaluatePolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> factName = default;
            Optional<string> factData = default;
            Optional<string> valueOffset = default;
            Optional<string> userObjectId = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("factName"u8))
                {
                    factName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("factData"u8))
                {
                    factData = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("valueOffset"u8))
                {
                    valueOffset = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userObjectId"u8))
                {
                    userObjectId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabEvaluatePolicy(factName.Value, factData.Value, valueOffset.Value, userObjectId.Value, serializedAdditionalRawData);
        }

        DevTestLabEvaluatePolicy IModelJsonSerializable<DevTestLabEvaluatePolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePolicy>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabEvaluatePolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabEvaluatePolicy>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePolicy>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabEvaluatePolicy IModelSerializable<DevTestLabEvaluatePolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabEvaluatePolicy>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabEvaluatePolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabEvaluatePolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabEvaluatePolicy"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabEvaluatePolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabEvaluatePolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabEvaluatePolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabEvaluatePolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
