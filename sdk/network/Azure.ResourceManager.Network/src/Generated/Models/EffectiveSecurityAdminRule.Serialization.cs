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

namespace Azure.ResourceManager.Network.Models
{
    public partial class EffectiveSecurityAdminRule : IUtf8JsonSerializable, IModelJsonSerializable<EffectiveSecurityAdminRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EffectiveSecurityAdminRule>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EffectiveSecurityAdminRule>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EffectiveSecurityAdminRule>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ConfigurationDescription))
            {
                writer.WritePropertyName("configurationDescription"u8);
                writer.WriteStringValue(ConfigurationDescription);
            }
            if (Optional.IsDefined(RuleCollectionDescription))
            {
                writer.WritePropertyName("ruleCollectionDescription"u8);
                writer.WriteStringValue(RuleCollectionDescription);
            }
            if (Optional.IsCollectionDefined(RuleCollectionAppliesToGroups))
            {
                writer.WritePropertyName("ruleCollectionAppliesToGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleCollectionAppliesToGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RuleGroups))
            {
                writer.WritePropertyName("ruleGroups"u8);
                writer.WriteStartArray();
                foreach (var item in RuleGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Sources))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Destinations))
            {
                writer.WritePropertyName("destinations"u8);
                writer.WriteStartArray();
                foreach (var item in Destinations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SourcePortRanges))
            {
                writer.WritePropertyName("sourcePortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in SourcePortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(DestinationPortRanges))
            {
                writer.WritePropertyName("destinationPortRanges"u8);
                writer.WriteStartArray();
                foreach (var item in DestinationPortRanges)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Access))
            {
                writer.WritePropertyName("access"u8);
                writer.WriteStringValue(Access.Value.ToString());
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority"u8);
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Direction))
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteStringValue(Direction.Value.ToString());
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

        internal static EffectiveSecurityAdminRule DeserializeEffectiveSecurityAdminRule(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> configurationDescription = default;
            Optional<string> ruleCollectionDescription = default;
            Optional<IReadOnlyList<NetworkManagerSecurityGroupItem>> ruleCollectionAppliesToGroups = default;
            Optional<IReadOnlyList<NetworkConfigurationGroup>> ruleGroups = default;
            EffectiveAdminRuleKind kind = default;
            Optional<string> description = default;
            Optional<SecurityConfigurationRuleProtocol> protocol = default;
            Optional<IReadOnlyList<AddressPrefixItem>> sources = default;
            Optional<IReadOnlyList<AddressPrefixItem>> destinations = default;
            Optional<IReadOnlyList<string>> sourcePortRanges = default;
            Optional<IReadOnlyList<string>> destinationPortRanges = default;
            Optional<SecurityConfigurationRuleAccess> access = default;
            Optional<int> priority = default;
            Optional<SecurityConfigurationRuleDirection> direction = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<Guid> resourceGuid = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurationDescription"u8))
                {
                    configurationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionDescription"u8))
                {
                    ruleCollectionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionAppliesToGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkManagerSecurityGroupItem> array = new List<NetworkManagerSecurityGroupItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkManagerSecurityGroupItem.DeserializeNetworkManagerSecurityGroupItem(item));
                    }
                    ruleCollectionAppliesToGroups = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EffectiveAdminRuleKind(property.Value.GetString());
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new SecurityConfigurationRuleProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AddressPrefixItem> array = new List<AddressPrefixItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AddressPrefixItem.DeserializeAddressPrefixItem(item));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("destinations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AddressPrefixItem> array = new List<AddressPrefixItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AddressPrefixItem.DeserializeAddressPrefixItem(item));
                            }
                            destinations = array;
                            continue;
                        }
                        if (property0.NameEquals("sourcePortRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            sourcePortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("destinationPortRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            destinationPortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("access"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            access = new SecurityConfigurationRuleAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("direction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            direction = new SecurityConfigurationRuleDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("resourceGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceGuid = property0.Value.GetGuid();
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
            return new EffectiveSecurityAdminRule(id.Value, configurationDescription.Value, ruleCollectionDescription.Value, Optional.ToList(ruleCollectionAppliesToGroups), Optional.ToList(ruleGroups), kind, description.Value, Optional.ToNullable(protocol), Optional.ToList(sources), Optional.ToList(destinations), Optional.ToList(sourcePortRanges), Optional.ToList(destinationPortRanges), Optional.ToNullable(access), Optional.ToNullable(priority), Optional.ToNullable(direction), Optional.ToNullable(provisioningState), Optional.ToNullable(resourceGuid), rawData);
        }

        EffectiveSecurityAdminRule IModelJsonSerializable<EffectiveSecurityAdminRule>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EffectiveSecurityAdminRule>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEffectiveSecurityAdminRule(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EffectiveSecurityAdminRule>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EffectiveSecurityAdminRule>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EffectiveSecurityAdminRule IModelSerializable<EffectiveSecurityAdminRule>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EffectiveSecurityAdminRule>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEffectiveSecurityAdminRule(doc.RootElement, options);
        }

        public static implicit operator RequestContent(EffectiveSecurityAdminRule model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator EffectiveSecurityAdminRule(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEffectiveSecurityAdminRule(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
