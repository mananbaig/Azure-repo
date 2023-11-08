// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecurityAggregatedRecommendationData : IUtf8JsonSerializable, IJsonModel<IotSecurityAggregatedRecommendationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<IotSecurityAggregatedRecommendationData>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<IotSecurityAggregatedRecommendationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
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
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RecommendationName))
            {
                writer.WritePropertyName("recommendationName"u8);
                writer.WriteStringValue(RecommendationName);
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RecommendationDisplayName))
                {
                    writer.WritePropertyName("recommendationDisplayName"u8);
                    writer.WriteStringValue(RecommendationDisplayName);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(Description))
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RecommendationTypeId))
                {
                    writer.WritePropertyName("recommendationTypeId"u8);
                    writer.WriteStringValue(RecommendationTypeId);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DetectedBy))
                {
                    writer.WritePropertyName("detectedBy"u8);
                    writer.WriteStringValue(DetectedBy);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(RemediationSteps))
                {
                    writer.WritePropertyName("remediationSteps"u8);
                    writer.WriteStringValue(RemediationSteps);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(ReportedSeverity))
                {
                    writer.WritePropertyName("reportedSeverity"u8);
                    writer.WriteStringValue(ReportedSeverity.Value.ToString());
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(HealthyDevices))
                {
                    writer.WritePropertyName("healthyDevices"u8);
                    writer.WriteNumberValue(HealthyDevices.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(UnhealthyDeviceCount))
                {
                    writer.WritePropertyName("unhealthyDeviceCount"u8);
                    writer.WriteNumberValue(UnhealthyDeviceCount.Value);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LogAnalyticsQuery))
                {
                    writer.WritePropertyName("logAnalyticsQuery"u8);
                    writer.WriteStringValue(LogAnalyticsQuery);
                }
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        IotSecurityAggregatedRecommendationData IJsonModel<IotSecurityAggregatedRecommendationData>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedRecommendationData(document.RootElement, options);
        }

        internal static IotSecurityAggregatedRecommendationData DeserializeIotSecurityAggregatedRecommendationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

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
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new IotSecurityAggregatedRecommendationData(id, name, type, systemData.Value, recommendationName.Value, recommendationDisplayName.Value, description.Value, recommendationTypeId.Value, detectedBy.Value, remediationSteps.Value, Optional.ToNullable(reportedSeverity), Optional.ToNullable(healthyDevices), Optional.ToNullable(unhealthyDeviceCount), logAnalyticsQuery.Value, Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        BinaryData IModel<IotSecurityAggregatedRecommendationData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        IotSecurityAggregatedRecommendationData IModel<IotSecurityAggregatedRecommendationData>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(IotSecurityAggregatedRecommendationData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeIotSecurityAggregatedRecommendationData(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<IotSecurityAggregatedRecommendationData>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
