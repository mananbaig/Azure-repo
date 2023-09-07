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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class PolicyProviderSpecificContent : IUtf8JsonSerializable, IModelJsonSerializable<PolicyProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyProviderSpecificContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyProviderSpecificContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificContent>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static PolicyProviderSpecificContent DeserializePolicyProviderSpecificContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2APolicyCreationContent.DeserializeA2APolicyCreationContent(element);
                    case "A2ACrossClusterMigration": return A2ACrossClusterMigrationPolicyCreationContent.DeserializeA2ACrossClusterMigrationPolicyCreationContent(element);
                    case "HyperVReplica2012": return HyperVReplicaPolicyContent.DeserializeHyperVReplicaPolicyContent(element);
                    case "HyperVReplica2012R2": return HyperVReplicaBluePolicyContent.DeserializeHyperVReplicaBluePolicyContent(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzurePolicyContent.DeserializeHyperVReplicaAzurePolicyContent(element);
                    case "InMage": return InMagePolicyContent.DeserializeInMagePolicyContent(element);
                    case "InMageAzureV2": return InMageAzureV2PolicyContent.DeserializeInMageAzureV2PolicyContent(element);
                    case "InMageRcm": return InMageRcmPolicyCreationContent.DeserializeInMageRcmPolicyCreationContent(element);
                    case "InMageRcmFailback": return InMageRcmFailbackPolicyCreationContent.DeserializeInMageRcmFailbackPolicyCreationContent(element);
                    case "VMwareCbt": return VMwareCbtPolicyCreationContent.DeserializeVMwareCbtPolicyCreationContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new Models.PolicyProviderSpecificContent(instanceType, serializedAdditionalRawData);
        }

        PolicyProviderSpecificContent IModelJsonSerializable<PolicyProviderSpecificContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyProviderSpecificContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyProviderSpecificContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyProviderSpecificContent IModelSerializable<PolicyProviderSpecificContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyProviderSpecificContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyProviderSpecificContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyProviderSpecificContent"/> to convert. </param>
        public static implicit operator RequestContent(PolicyProviderSpecificContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyProviderSpecificContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyProviderSpecificContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyProviderSpecificContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
