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

namespace Azure.ResourceManager.Resources.Models
{
    public partial class PolicyDefinitionReference : IUtf8JsonSerializable, IModelJsonSerializable<PolicyDefinitionReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyDefinitionReference>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyDefinitionReference>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyDefinitionReference>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("policyDefinitionId"u8);
            writer.WriteStringValue(PolicyDefinitionId);
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
                        ((IModelJsonSerializable<ArmPolicyParameterValue>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(PolicyDefinitionReferenceId))
            {
                writer.WritePropertyName("policyDefinitionReferenceId"u8);
                writer.WriteStringValue(PolicyDefinitionReferenceId);
            }
            if (Optional.IsCollectionDefined(GroupNames))
            {
                writer.WritePropertyName("groupNames"u8);
                writer.WriteStartArray();
                foreach (var item in GroupNames)
                {
                    writer.WriteStringValue(item);
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

        internal static PolicyDefinitionReference DeserializePolicyDefinitionReference(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string policyDefinitionId = default;
            Optional<IDictionary<string, ArmPolicyParameterValue>> parameters = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<IList<string>> groupNames = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    policyDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ArmPolicyParameterValue> dictionary = new Dictionary<string, ArmPolicyParameterValue>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ArmPolicyParameterValue.DeserializeArmPolicyParameterValue(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("groupNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    groupNames = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolicyDefinitionReference(policyDefinitionId, Optional.ToDictionary(parameters), policyDefinitionReferenceId.Value, Optional.ToList(groupNames), serializedAdditionalRawData);
        }

        PolicyDefinitionReference IModelJsonSerializable<PolicyDefinitionReference>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyDefinitionReference>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyDefinitionReference(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyDefinitionReference>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyDefinitionReference>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyDefinitionReference IModelSerializable<PolicyDefinitionReference>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyDefinitionReference>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyDefinitionReference(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyDefinitionReference"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyDefinitionReference"/> to convert. </param>
        public static implicit operator RequestContent(PolicyDefinitionReference model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyDefinitionReference"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyDefinitionReference(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyDefinitionReference(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
