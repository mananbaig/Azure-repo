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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecurityAggregatedRecommendationData : IUtf8JsonSerializable, IModelJsonSerializable<IotSecurityAggregatedRecommendationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotSecurityAggregatedRecommendationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotSecurityAggregatedRecommendationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedRecommendationData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RecommendationName))
            {
                writer.WritePropertyName("recommendationName"u8);
                writer.WriteStringValue(RecommendationName);
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

        internal static IotSecurityAggregatedRecommendationData DeserializeIotSecurityAggregatedRecommendationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> recommendationName = default;
            Optional<string> recommendationDisplayName = default;
            Optional<string> description = default;
            Optional<string> recommendationTypeId = default;
            Optional<string> detectedBy = default;
            Optional<string> remediationSteps = default;
            Optional<ReportedSeverity> reportedSeverity = default;
            Optional<long> healthyDevices = default;
            Optional<long> unhealthyDeviceCount = default;
            Optional<string> logAnalyticsQuery = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("recommendationName"u8))
                        {
                            recommendationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendationDisplayName"u8))
                        {
                            recommendationDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("recommendationTypeId"u8))
                        {
                            recommendationTypeId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("detectedBy"u8))
                        {
                            detectedBy = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("remediationSteps"u8))
                        {
                            remediationSteps = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("reportedSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reportedSeverity = new ReportedSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthyDevices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthyDevices = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("unhealthyDeviceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyDeviceCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsQuery"u8))
                        {
                            logAnalyticsQuery = property0.Value.GetString();
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
            return new IotSecurityAggregatedRecommendationData(id, name, type, systemData.Value, recommendationName.Value, recommendationDisplayName.Value, description.Value, recommendationTypeId.Value, detectedBy.Value, remediationSteps.Value, Optional.ToNullable(reportedSeverity), Optional.ToNullable(healthyDevices), Optional.ToNullable(unhealthyDeviceCount), logAnalyticsQuery.Value, Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        IotSecurityAggregatedRecommendationData IModelJsonSerializable<IotSecurityAggregatedRecommendationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedRecommendationData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedRecommendationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotSecurityAggregatedRecommendationData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedRecommendationData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotSecurityAggregatedRecommendationData IModelSerializable<IotSecurityAggregatedRecommendationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedRecommendationData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotSecurityAggregatedRecommendationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotSecurityAggregatedRecommendationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotSecurityAggregatedRecommendationData"/> to convert. </param>
        public static implicit operator RequestContent(IotSecurityAggregatedRecommendationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotSecurityAggregatedRecommendationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotSecurityAggregatedRecommendationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotSecurityAggregatedRecommendationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
