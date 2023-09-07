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
    public partial class IotSecurityAggregatedAlertData : IUtf8JsonSerializable, IModelJsonSerializable<IotSecurityAggregatedAlertData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotSecurityAggregatedAlertData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotSecurityAggregatedAlertData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertData>(this, options.Format);

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

        internal static IotSecurityAggregatedAlertData DeserializeIotSecurityAggregatedAlertData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> alertType = default;
            Optional<string> alertDisplayName = default;
            Optional<DateTimeOffset> aggregatedDateUtc = default;
            Optional<string> vendorName = default;
            Optional<ReportedSeverity> reportedSeverity = default;
            Optional<string> remediationSteps = default;
            Optional<string> description = default;
            Optional<long> count = default;
            Optional<string> effectedResourceType = default;
            Optional<string> systemSource = default;
            Optional<string> actionTaken = default;
            Optional<string> logAnalyticsQuery = default;
            Optional<IReadOnlyList<IotSecurityAggregatedAlertTopDevice>> topDevicesList = default;
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
                        if (property0.NameEquals("alertType"u8))
                        {
                            alertType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("alertDisplayName"u8))
                        {
                            alertDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aggregatedDateUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregatedDateUtc = property0.Value.GetDateTimeOffset("D");
                            continue;
                        }
                        if (property0.NameEquals("vendorName"u8))
                        {
                            vendorName = property0.Value.GetString();
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
                        if (property0.NameEquals("remediationSteps"u8))
                        {
                            remediationSteps = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            count = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("effectedResourceType"u8))
                        {
                            effectedResourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("systemSource"u8))
                        {
                            systemSource = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("actionTaken"u8))
                        {
                            actionTaken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("logAnalyticsQuery"u8))
                        {
                            logAnalyticsQuery = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("topDevicesList"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityAggregatedAlertTopDevice> array = new List<IotSecurityAggregatedAlertTopDevice>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityAggregatedAlertTopDevice.DeserializeIotSecurityAggregatedAlertTopDevice(item));
                            }
                            topDevicesList = array;
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
            return new IotSecurityAggregatedAlertData(id, name, type, systemData.Value, alertType.Value, alertDisplayName.Value, Optional.ToNullable(aggregatedDateUtc), vendorName.Value, Optional.ToNullable(reportedSeverity), remediationSteps.Value, description.Value, Optional.ToNullable(count), effectedResourceType.Value, systemSource.Value, actionTaken.Value, logAnalyticsQuery.Value, Optional.ToList(topDevicesList), Optional.ToDictionary(tags), serializedAdditionalRawData);
        }

        IotSecurityAggregatedAlertData IModelJsonSerializable<IotSecurityAggregatedAlertData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecurityAggregatedAlertData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotSecurityAggregatedAlertData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotSecurityAggregatedAlertData IModelSerializable<IotSecurityAggregatedAlertData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<IotSecurityAggregatedAlertData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotSecurityAggregatedAlertData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotSecurityAggregatedAlertData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotSecurityAggregatedAlertData"/> to convert. </param>
        public static implicit operator RequestContent(IotSecurityAggregatedAlertData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotSecurityAggregatedAlertData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotSecurityAggregatedAlertData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotSecurityAggregatedAlertData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
