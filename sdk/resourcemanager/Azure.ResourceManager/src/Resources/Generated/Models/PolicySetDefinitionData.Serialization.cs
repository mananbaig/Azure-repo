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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class PolicySetDefinitionData : IUtf8JsonSerializable, IModelJsonSerializable<PolicySetDefinitionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicySetDefinitionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicySetDefinitionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicySetDefinitionData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyType))
            {
                writer.WritePropertyName("policyType"u8);
                writer.WriteStringValue(PolicyType.Value.ToString());
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Metadata);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Metadata.ToString()).RootElement);
#endif
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ArmPolicyParameter>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(PolicyDefinitions))
            {
                writer.WritePropertyName("policyDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PolicyDefinitionReference>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PolicyDefinitionGroups))
            {
                writer.WritePropertyName("policyDefinitionGroups"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyDefinitionGroups)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<PolicyDefinitionGroup>)item).Serialize(writer, options);
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

        internal static PolicySetDefinitionData DeserializePolicySetDefinitionData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<PolicyType> policyType = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<BinaryData> metadata = default;
            Optional<IDictionary<string, ArmPolicyParameter>> parameters = default;
            Optional<IList<PolicyDefinitionReference>> policyDefinitions = default;
            Optional<IList<PolicyDefinitionGroup>> policyDefinitionGroups = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("policyType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            policyType = new PolicyType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("metadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metadata = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ArmPolicyParameter> dictionary = new Dictionary<string, ArmPolicyParameter>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ArmPolicyParameter.DeserializeArmPolicyParameter(property1.Value));
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PolicyDefinitionReference> array = new List<PolicyDefinitionReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PolicyDefinitionReference.DeserializePolicyDefinitionReference(item));
                            }
                            policyDefinitions = array;
                            continue;
                        }
                        if (property0.NameEquals("policyDefinitionGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PolicyDefinitionGroup> array = new List<PolicyDefinitionGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PolicyDefinitionGroup.DeserializePolicyDefinitionGroup(item));
                            }
                            policyDefinitionGroups = array;
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
            return new PolicySetDefinitionData(id, name, type, systemData.Value, Optional.ToNullable(policyType), displayName.Value, description.Value, metadata.Value, Optional.ToDictionary(parameters), Optional.ToList(policyDefinitions), Optional.ToList(policyDefinitionGroups), serializedAdditionalRawData);
        }

        PolicySetDefinitionData IModelJsonSerializable<PolicySetDefinitionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicySetDefinitionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicySetDefinitionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicySetDefinitionData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicySetDefinitionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicySetDefinitionData IModelSerializable<PolicySetDefinitionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicySetDefinitionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicySetDefinitionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicySetDefinitionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicySetDefinitionData"/> to convert. </param>
        public static implicit operator RequestContent(PolicySetDefinitionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicySetDefinitionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicySetDefinitionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicySetDefinitionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
