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
using Azure.ResourceManager.PolicyInsights.Models;

namespace Azure.ResourceManager.PolicyInsights
{
    public partial class PolicyRemediationData : IUtf8JsonSerializable, IModelJsonSerializable<PolicyRemediationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyRemediationData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyRemediationData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyAssignmentId))
            {
                writer.WritePropertyName("policyAssignmentId"u8);
                writer.WriteStringValue(PolicyAssignmentId);
            }
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsDefined(ResourceDiscoveryMode))
            {
                writer.WritePropertyName("resourceDiscoveryMode"u8);
                writer.WriteStringValue(ResourceDiscoveryMode.Value.ToString());
            }
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filters"u8);
                if (Filter is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RemediationFilters>)Filter).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ResourceCount))
            {
                writer.WritePropertyName("resourceCount"u8);
                writer.WriteNumberValue(ResourceCount.Value);
            }
            if (Optional.IsDefined(ParallelDeployments))
            {
                writer.WritePropertyName("parallelDeployments"u8);
                writer.WriteNumberValue(ParallelDeployments.Value);
            }
            if (Optional.IsDefined(FailureThreshold))
            {
                writer.WritePropertyName("failureThreshold"u8);
                if (FailureThreshold is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RemediationPropertiesFailureThreshold>)FailureThreshold).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static PolicyRemediationData DeserializePolicyRemediationData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> policyAssignmentId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<ResourceDiscoveryMode> resourceDiscoveryMode = default;
            Optional<string> provisioningState = default;
            Optional<DateTimeOffset> createdOn = default;
            Optional<DateTimeOffset> lastUpdatedOn = default;
            Optional<RemediationFilters> filters = default;
            Optional<RemediationDeploymentSummary> deploymentStatus = default;
            Optional<string> statusMessage = default;
            Optional<string> correlationId = default;
            Optional<int> resourceCount = default;
            Optional<int> parallelDeployments = default;
            Optional<RemediationPropertiesFailureThreshold> failureThreshold = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("policyAssignmentId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyAssignmentId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionReferenceId"u8))
                        {
                            policyDefinitionReferenceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceDiscoveryMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceDiscoveryMode = new ResourceDiscoveryMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedOn = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filters = RemediationFilters.DeserializeRemediationFilters(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("deploymentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentStatus = RemediationDeploymentSummary.DeserializeRemediationDeploymentSummary(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("statusMessage"u8))
                        {
                            statusMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlationId"u8))
                        {
                            correlationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("parallelDeployments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            parallelDeployments = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("failureThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            failureThreshold = RemediationPropertiesFailureThreshold.DeserializeRemediationPropertiesFailureThreshold(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolicyRemediationData(id, name, type, systemData.Value, policyAssignmentId.Value, policyDefinitionReferenceId.Value, Optional.ToNullable(resourceDiscoveryMode), provisioningState.Value, Optional.ToNullable(createdOn), Optional.ToNullable(lastUpdatedOn), filters.Value, deploymentStatus.Value, statusMessage.Value, correlationId.Value, Optional.ToNullable(resourceCount), Optional.ToNullable(parallelDeployments), failureThreshold.Value, rawData);
        }

        PolicyRemediationData IModelJsonSerializable<PolicyRemediationData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyRemediationData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyRemediationData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyRemediationData IModelSerializable<PolicyRemediationData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyRemediationData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyRemediationData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyRemediationData"/> to convert. </param>
        public static implicit operator RequestContent(PolicyRemediationData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyRemediationData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyRemediationData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyRemediationData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
