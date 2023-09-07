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
    public partial class PolicyProviderSpecificDetails : IUtf8JsonSerializable, IModelJsonSerializable<PolicyProviderSpecificDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyProviderSpecificDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyProviderSpecificDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificDetails>(this, options.Format);

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

        internal static PolicyProviderSpecificDetails DeserializePolicyProviderSpecificDetails(JsonElement element, ModelSerializerOptions options = default)
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
                    case "A2A": return A2APolicyDetails.DeserializeA2APolicyDetails(element);
                    case "HyperVReplica2012": return HyperVReplicaPolicyDetails.DeserializeHyperVReplicaPolicyDetails(element);
                    case "HyperVReplica2012R2": return HyperVReplicaBluePolicyDetails.DeserializeHyperVReplicaBluePolicyDetails(element);
                    case "HyperVReplicaAzure": return HyperVReplicaAzurePolicyDetails.DeserializeHyperVReplicaAzurePolicyDetails(element);
                    case "HyperVReplicaBasePolicyDetails": return HyperVReplicaBasePolicyDetails.DeserializeHyperVReplicaBasePolicyDetails(element);
                    case "InMage": return InMagePolicyDetails.DeserializeInMagePolicyDetails(element);
                    case "InMageAzureV2": return InMageAzureV2PolicyDetails.DeserializeInMageAzureV2PolicyDetails(element);
                    case "InMageBasePolicyDetails": return InMageBasePolicyDetails.DeserializeInMageBasePolicyDetails(element);
                    case "InMageRcm": return InMageRcmPolicyDetails.DeserializeInMageRcmPolicyDetails(element);
                    case "InMageRcmFailback": return InMageRcmFailbackPolicyDetails.DeserializeInMageRcmFailbackPolicyDetails(element);
                    case "VMwareCbt": return VMwareCbtPolicyDetails.DeserializeVMwareCbtPolicyDetails(element);
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
            return new UnknownPolicyProviderSpecificDetails(instanceType, serializedAdditionalRawData);
        }

        PolicyProviderSpecificDetails IModelJsonSerializable<PolicyProviderSpecificDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyProviderSpecificDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyProviderSpecificDetails>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyProviderSpecificDetails IModelSerializable<PolicyProviderSpecificDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PolicyProviderSpecificDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyProviderSpecificDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PolicyProviderSpecificDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PolicyProviderSpecificDetails"/> to convert. </param>
        public static implicit operator RequestContent(PolicyProviderSpecificDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PolicyProviderSpecificDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PolicyProviderSpecificDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyProviderSpecificDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
