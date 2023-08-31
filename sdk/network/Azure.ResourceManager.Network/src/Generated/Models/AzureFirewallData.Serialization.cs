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
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    public partial class AzureFirewallData : IUtf8JsonSerializable, IModelJsonSerializable<AzureFirewallData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AzureFirewallData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AzureFirewallData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureFirewallData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
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
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ApplicationRuleCollections))
            {
                writer.WritePropertyName("applicationRuleCollections"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationRuleCollections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AzureFirewallApplicationRuleCollectionData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NatRuleCollections))
            {
                writer.WritePropertyName("natRuleCollections"u8);
                writer.WriteStartArray();
                foreach (var item in NatRuleCollections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AzureFirewallNatRuleCollectionData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(NetworkRuleCollections))
            {
                writer.WritePropertyName("networkRuleCollections"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkRuleCollections)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AzureFirewallNetworkRuleCollectionData>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<AzureFirewallIPConfiguration>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ManagementIPConfiguration))
            {
                writer.WritePropertyName("managementIpConfiguration"u8);
                if (ManagementIPConfiguration is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AzureFirewallIPConfiguration>)ManagementIPConfiguration).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ThreatIntelMode))
            {
                writer.WritePropertyName("threatIntelMode"u8);
                writer.WriteStringValue(ThreatIntelMode.Value.ToString());
            }
            if (Optional.IsDefined(VirtualHub))
            {
                writer.WritePropertyName("virtualHub"u8);
                JsonSerializer.Serialize(writer, VirtualHub);
            }
            if (Optional.IsDefined(FirewallPolicy))
            {
                writer.WritePropertyName("firewallPolicy"u8);
                JsonSerializer.Serialize(writer, FirewallPolicy);
            }
            if (Optional.IsDefined(HubIPAddresses))
            {
                writer.WritePropertyName("hubIPAddresses"u8);
                if (HubIPAddresses is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<HubIPAddresses>)HubIPAddresses).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AzureFirewallSku>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(AdditionalProperties))
            {
                writer.WritePropertyName("additionalProperties"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
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

        internal static AzureFirewallData DeserializeAzureFirewallData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> zones = default;
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<AzureLocation> location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<AzureFirewallApplicationRuleCollectionData>> applicationRuleCollections = default;
            Optional<IList<AzureFirewallNatRuleCollectionData>> natRuleCollections = default;
            Optional<IList<AzureFirewallNetworkRuleCollectionData>> networkRuleCollections = default;
            Optional<IList<AzureFirewallIPConfiguration>> ipConfigurations = default;
            Optional<AzureFirewallIPConfiguration> managementIPConfiguration = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<AzureFirewallThreatIntelMode> threatIntelMode = default;
            Optional<WritableSubResource> virtualHub = default;
            Optional<WritableSubResource> firewallPolicy = default;
            Optional<HubIPAddresses> hubIPAddresses = default;
            Optional<IReadOnlyList<AzureFirewallIPGroups>> ipGroups = default;
            Optional<AzureFirewallSku> sku = default;
            Optional<IDictionary<string, string>> additionalProperties = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("applicationRuleCollections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallApplicationRuleCollectionData> array = new List<AzureFirewallApplicationRuleCollectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallApplicationRuleCollectionData.DeserializeAzureFirewallApplicationRuleCollectionData(item));
                            }
                            applicationRuleCollections = array;
                            continue;
                        }
                        if (property0.NameEquals("natRuleCollections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallNatRuleCollectionData> array = new List<AzureFirewallNatRuleCollectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallNatRuleCollectionData.DeserializeAzureFirewallNatRuleCollectionData(item));
                            }
                            natRuleCollections = array;
                            continue;
                        }
                        if (property0.NameEquals("networkRuleCollections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallNetworkRuleCollectionData> array = new List<AzureFirewallNetworkRuleCollectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallNetworkRuleCollectionData.DeserializeAzureFirewallNetworkRuleCollectionData(item));
                            }
                            networkRuleCollections = array;
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallIPConfiguration> array = new List<AzureFirewallIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallIPConfiguration.DeserializeAzureFirewallIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("managementIpConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementIPConfiguration = AzureFirewallIPConfiguration.DeserializeAzureFirewallIPConfiguration(property0.Value);
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
                        if (property0.NameEquals("threatIntelMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            threatIntelMode = new AzureFirewallThreatIntelMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualHub"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            virtualHub = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("firewallPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firewallPolicy = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hubIPAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            hubIPAddresses = HubIPAddresses.DeserializeHubIPAddresses(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ipGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallIPGroups> array = new List<AzureFirewallIPGroups>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallIPGroups.DeserializeAzureFirewallIPGroups(item));
                            }
                            ipGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("sku"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sku = AzureFirewallSku.DeserializeAzureFirewallSku(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            additionalProperties = dictionary;
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
            return new AzureFirewallData(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(location), Optional.ToDictionary(tags), Optional.ToList(zones), Optional.ToNullable(etag), Optional.ToList(applicationRuleCollections), Optional.ToList(natRuleCollections), Optional.ToList(networkRuleCollections), Optional.ToList(ipConfigurations), managementIPConfiguration.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(threatIntelMode), virtualHub, firewallPolicy, hubIPAddresses.Value, Optional.ToList(ipGroups), sku.Value, Optional.ToDictionary(additionalProperties), rawData);
        }

        AzureFirewallData IModelJsonSerializable<AzureFirewallData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureFirewallData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureFirewallData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AzureFirewallData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureFirewallData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AzureFirewallData IModelSerializable<AzureFirewallData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AzureFirewallData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAzureFirewallData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AzureFirewallData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AzureFirewallData"/> to convert. </param>
        public static implicit operator RequestContent(AzureFirewallData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AzureFirewallData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AzureFirewallData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAzureFirewallData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
