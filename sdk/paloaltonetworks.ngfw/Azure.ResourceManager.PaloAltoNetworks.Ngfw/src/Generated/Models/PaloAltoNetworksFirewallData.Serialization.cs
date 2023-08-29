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
using Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    public partial class PaloAltoNetworksFirewallData : IUtf8JsonSerializable, IModelJsonSerializable<PaloAltoNetworksFirewallData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PaloAltoNetworksFirewallData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PaloAltoNetworksFirewallData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
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
            if (Optional.IsDefined(PanETag))
            {
                writer.WritePropertyName("panEtag"u8);
                writer.WriteStringValue(PanETag.Value.ToString());
            }
            writer.WritePropertyName("networkProfile"u8);
            writer.WriteObjectValue(NetworkProfile);
            if (Optional.IsDefined(IsPanoramaManaged))
            {
                writer.WritePropertyName("isPanoramaManaged"u8);
                writer.WriteStringValue(IsPanoramaManaged.Value.ToString());
            }
            if (Optional.IsDefined(PanoramaConfig))
            {
                writer.WritePropertyName("panoramaConfig"u8);
                writer.WriteObjectValue(PanoramaConfig);
            }
            if (Optional.IsDefined(AssociatedRulestack))
            {
                writer.WritePropertyName("associatedRulestack"u8);
                writer.WriteObjectValue(AssociatedRulestack);
            }
            writer.WritePropertyName("dnsSettings"u8);
            writer.WriteObjectValue(DnsSettings);
            if (Optional.IsCollectionDefined(FrontEndSettings))
            {
                writer.WritePropertyName("frontEndSettings"u8);
                writer.WriteStartArray();
                foreach (var item in FrontEndSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("planData"u8);
            writer.WriteObjectValue(PlanData);
            writer.WritePropertyName("marketplaceDetails"u8);
            writer.WriteObjectValue(MarketplaceDetails);
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

        internal static PaloAltoNetworksFirewallData DeserializePaloAltoNetworksFirewallData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ETag> panETag = default;
            FirewallNetworkProfile networkProfile = default;
            Optional<FirewallBooleanType> isPanoramaManaged = default;
            Optional<FirewallPanoramaConfiguration> panoramaConfig = default;
            Optional<RulestackDetails> associatedRulestack = default;
            FirewallDnsSettings dnsSettings = default;
            Optional<IList<FirewallFrontendSetting>> frontEndSettings = default;
            Optional<FirewallProvisioningState> provisioningState = default;
            FirewallBillingPlanInfo planData = default;
            PanFirewallMarketplaceDetails marketplaceDetails = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText(), serializeOptions);
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
                        if (property0.NameEquals("panEtag"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            panETag = new ETag(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"u8))
                        {
                            networkProfile = FirewallNetworkProfile.DeserializeFirewallNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("isPanoramaManaged"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isPanoramaManaged = new FirewallBooleanType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("panoramaConfig"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            panoramaConfig = FirewallPanoramaConfiguration.DeserializeFirewallPanoramaConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("associatedRulestack"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            associatedRulestack = RulestackDetails.DeserializeRulestackDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dnsSettings"u8))
                        {
                            dnsSettings = FirewallDnsSettings.DeserializeFirewallDnsSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontEndSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<FirewallFrontendSetting> array = new List<FirewallFrontendSetting>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(FirewallFrontendSetting.DeserializeFirewallFrontendSetting(item));
                            }
                            frontEndSettings = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new FirewallProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("planData"u8))
                        {
                            planData = FirewallBillingPlanInfo.DeserializeFirewallBillingPlanInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("marketplaceDetails"u8))
                        {
                            marketplaceDetails = PanFirewallMarketplaceDetails.DeserializePanFirewallMarketplaceDetails(property0.Value);
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
            return new PaloAltoNetworksFirewallData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, identity, Optional.ToNullable(panETag), networkProfile, Optional.ToNullable(isPanoramaManaged), panoramaConfig.Value, associatedRulestack.Value, dnsSettings, Optional.ToList(frontEndSettings), Optional.ToNullable(provisioningState), planData, marketplaceDetails, rawData);
        }

        PaloAltoNetworksFirewallData IModelJsonSerializable<PaloAltoNetworksFirewallData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePaloAltoNetworksFirewallData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PaloAltoNetworksFirewallData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PaloAltoNetworksFirewallData IModelSerializable<PaloAltoNetworksFirewallData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePaloAltoNetworksFirewallData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PaloAltoNetworksFirewallData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PaloAltoNetworksFirewallData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePaloAltoNetworksFirewallData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
