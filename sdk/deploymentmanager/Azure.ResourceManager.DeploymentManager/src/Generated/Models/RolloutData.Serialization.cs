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
using Azure.ResourceManager.DeploymentManager.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeploymentManager
{
    public partial class RolloutData : IUtf8JsonSerializable, IModelJsonSerializable<RolloutData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RolloutData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RolloutData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                if (Identity is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<Identity>)Identity).Serialize(writer, options);
                }
            }
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(BuildVersion))
            {
                writer.WritePropertyName("buildVersion"u8);
                writer.WriteStringValue(BuildVersion);
            }
            if (Optional.IsDefined(ArtifactSourceId))
            {
                writer.WritePropertyName("artifactSourceId"u8);
                writer.WriteStringValue(ArtifactSourceId);
            }
            if (Optional.IsDefined(TargetServiceTopologyId))
            {
                writer.WritePropertyName("targetServiceTopologyId"u8);
                writer.WriteStringValue(TargetServiceTopologyId);
            }
            if (Optional.IsCollectionDefined(StepGroups))
            {
                writer.WritePropertyName("stepGroups"u8);
                writer.WriteStartArray();
                foreach (var item in StepGroups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<StepGroup>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static RolloutData DeserializeRolloutData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Identity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> buildVersion = default;
            Optional<string> artifactSourceId = default;
            Optional<string> targetServiceTopologyId = default;
            Optional<IList<StepGroup>> stepGroups = default;
            Optional<string> status = default;
            Optional<int> totalRetryAttempts = default;
            Optional<RolloutOperationInfo> operationInfo = default;
            Optional<IReadOnlyList<Service>> services = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = Identity.DeserializeIdentity(property.Value);
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("buildVersion"u8))
                        {
                            buildVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactSourceId"u8))
                        {
                            artifactSourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("targetServiceTopologyId"u8))
                        {
                            targetServiceTopologyId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("stepGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StepGroup> array = new List<StepGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StepGroup.DeserializeStepGroup(item));
                            }
                            stepGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("totalRetryAttempts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalRetryAttempts = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("operationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationInfo = RolloutOperationInfo.DeserializeRolloutOperationInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("services"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Service> array = new List<Service>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Service.DeserializeService(item));
                            }
                            services = array;
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
            return new RolloutData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity.Value, buildVersion.Value, artifactSourceId.Value, targetServiceTopologyId.Value, Optional.ToList(stepGroups), status.Value, Optional.ToNullable(totalRetryAttempts), operationInfo.Value, Optional.ToList(services), serializedAdditionalRawData);
        }

        RolloutData IModelJsonSerializable<RolloutData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRolloutData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RolloutData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RolloutData IModelSerializable<RolloutData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<RolloutData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRolloutData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RolloutData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RolloutData"/> to convert. </param>
        public static implicit operator RequestContent(RolloutData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RolloutData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RolloutData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRolloutData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
