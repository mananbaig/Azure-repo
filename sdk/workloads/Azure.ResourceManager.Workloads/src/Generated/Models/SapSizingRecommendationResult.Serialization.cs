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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSizingRecommendationResult : IUtf8JsonSerializable, IModelJsonSerializable<SapSizingRecommendationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SapSizingRecommendationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SapSizingRecommendationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSizingRecommendationResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
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

        internal static SapSizingRecommendationResult DeserializeSapSizingRecommendationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("deploymentType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "SingleServer": return SingleServerRecommendationResult.DeserializeSingleServerRecommendationResult(element);
                    case "ThreeTier": return ThreeTierRecommendationResult.DeserializeThreeTierRecommendationResult(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            SapDeploymentType deploymentType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownSapSizingRecommendationResult(deploymentType, serializedAdditionalRawData);
        }

        SapSizingRecommendationResult IModelJsonSerializable<SapSizingRecommendationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSizingRecommendationResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSizingRecommendationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SapSizingRecommendationResult>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSizingRecommendationResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SapSizingRecommendationResult IModelSerializable<SapSizingRecommendationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SapSizingRecommendationResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSapSizingRecommendationResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SapSizingRecommendationResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SapSizingRecommendationResult"/> to convert. </param>
        public static implicit operator RequestContent(SapSizingRecommendationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SapSizingRecommendationResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SapSizingRecommendationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSapSizingRecommendationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
