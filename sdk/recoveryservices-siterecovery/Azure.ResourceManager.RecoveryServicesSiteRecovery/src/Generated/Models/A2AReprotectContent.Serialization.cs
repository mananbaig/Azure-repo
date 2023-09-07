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
    public partial class A2AReprotectContent : IUtf8JsonSerializable, IModelJsonSerializable<A2AReprotectContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<A2AReprotectContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<A2AReprotectContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AReprotectContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryContainerId))
            {
                writer.WritePropertyName("recoveryContainerId"u8);
                writer.WriteStringValue(RecoveryContainerId);
            }
            if (Optional.IsCollectionDefined(VmDisks))
            {
                writer.WritePropertyName("vmDisks"u8);
                writer.WriteStartArray();
                foreach (var item in VmDisks)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<A2AVmDiskDetails>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryResourceGroupId))
            {
                writer.WritePropertyName("recoveryResourceGroupId"u8);
                writer.WriteStringValue(RecoveryResourceGroupId);
            }
            if (Optional.IsDefined(RecoveryCloudServiceId))
            {
                writer.WritePropertyName("recoveryCloudServiceId"u8);
                writer.WriteStringValue(RecoveryCloudServiceId);
            }
            if (Optional.IsDefined(RecoveryAvailabilitySetId))
            {
                writer.WritePropertyName("recoveryAvailabilitySetId"u8);
                writer.WriteStringValue(RecoveryAvailabilitySetId);
            }
            if (Optional.IsDefined(PolicyId))
            {
                writer.WritePropertyName("policyId"u8);
                writer.WriteStringValue(PolicyId);
            }
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

        internal static A2AReprotectContent DeserializeA2AReprotectContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> recoveryContainerId = default;
            Optional<IList<A2AVmDiskDetails>> vmDisks = default;
            Optional<ResourceIdentifier> recoveryResourceGroupId = default;
            Optional<string> recoveryCloudServiceId = default;
            Optional<ResourceIdentifier> recoveryAvailabilitySetId = default;
            Optional<ResourceIdentifier> policyId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryContainerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryContainerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmDisks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<A2AVmDiskDetails> array = new List<A2AVmDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(A2AVmDiskDetails.DeserializeA2AVmDiskDetails(item));
                    }
                    vmDisks = array;
                    continue;
                }
                if (property.NameEquals("recoveryResourceGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryResourceGroupId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryCloudServiceId"u8))
                {
                    recoveryCloudServiceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("recoveryAvailabilitySetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryAvailabilitySetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    policyId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
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
            return new A2AReprotectContent(instanceType, recoveryContainerId.Value, Optional.ToList(vmDisks), recoveryResourceGroupId.Value, recoveryCloudServiceId.Value, recoveryAvailabilitySetId.Value, policyId.Value, serializedAdditionalRawData);
        }

        A2AReprotectContent IModelJsonSerializable<A2AReprotectContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AReprotectContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeA2AReprotectContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<A2AReprotectContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AReprotectContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        A2AReprotectContent IModelSerializable<A2AReprotectContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<A2AReprotectContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeA2AReprotectContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="A2AReprotectContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="A2AReprotectContent"/> to convert. </param>
        public static implicit operator RequestContent(A2AReprotectContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="A2AReprotectContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator A2AReprotectContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeA2AReprotectContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
