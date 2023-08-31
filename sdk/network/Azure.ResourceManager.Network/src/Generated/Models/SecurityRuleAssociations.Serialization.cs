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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class SecurityRuleAssociations : IUtf8JsonSerializable, IModelJsonSerializable<SecurityRuleAssociations>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityRuleAssociations>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityRuleAssociations>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkInterfaceAssociation))
            {
                writer.WritePropertyName("networkInterfaceAssociation"u8);
                if (NetworkInterfaceAssociation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetworkInterfaceAssociation>)NetworkInterfaceAssociation).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SubnetAssociation))
            {
                writer.WritePropertyName("subnetAssociation"u8);
                if (SubnetAssociation is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SubnetAssociation>)SubnetAssociation).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(DefaultSecurityRules))
            {
                writer.WritePropertyName("defaultSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in DefaultSecurityRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SecurityRuleData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EffectiveSecurityRules))
            {
                writer.WritePropertyName("effectiveSecurityRules"u8);
                writer.WriteStartArray();
                foreach (var item in EffectiveSecurityRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EffectiveNetworkSecurityRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
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

        internal static SecurityRuleAssociations DeserializeSecurityRuleAssociations(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkInterfaceAssociation> networkInterfaceAssociation = default;
            Optional<SubnetAssociation> subnetAssociation = default;
            Optional<IReadOnlyList<SecurityRuleData>> defaultSecurityRules = default;
            Optional<IReadOnlyList<EffectiveNetworkSecurityRule>> effectiveSecurityRules = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaceAssociation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkInterfaceAssociation = NetworkInterfaceAssociation.DeserializeNetworkInterfaceAssociation(property.Value);
                    continue;
                }
                if (property.NameEquals("subnetAssociation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subnetAssociation = SubnetAssociation.DeserializeSubnetAssociation(property.Value);
                    continue;
                }
                if (property.NameEquals("defaultSecurityRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityRuleData> array = new List<SecurityRuleData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityRuleData.DeserializeSecurityRuleData(item));
                    }
                    defaultSecurityRules = array;
                    continue;
                }
                if (property.NameEquals("effectiveSecurityRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EffectiveNetworkSecurityRule> array = new List<EffectiveNetworkSecurityRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EffectiveNetworkSecurityRule.DeserializeEffectiveNetworkSecurityRule(item));
                    }
                    effectiveSecurityRules = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityRuleAssociations(networkInterfaceAssociation.Value, subnetAssociation.Value, Optional.ToList(defaultSecurityRules), Optional.ToList(effectiveSecurityRules), rawData);
        }

        SecurityRuleAssociations IModelJsonSerializable<SecurityRuleAssociations>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityRuleAssociations(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityRuleAssociations>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityRuleAssociations IModelSerializable<SecurityRuleAssociations>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityRuleAssociations(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityRuleAssociations"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityRuleAssociations"/> to convert. </param>
        public static implicit operator RequestContent(SecurityRuleAssociations model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityRuleAssociations"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityRuleAssociations(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityRuleAssociations(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
