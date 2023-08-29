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
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    public partial class AvsPrivateCloudData : IUtf8JsonSerializable, IModelJsonSerializable<AvsPrivateCloudData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvsPrivateCloudData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvsPrivateCloudData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sku"u8);
            writer.WriteObjectValue(Sku);
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
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
            if (Optional.IsDefined(ManagementCluster))
            {
                writer.WritePropertyName("managementCluster"u8);
                writer.WriteObjectValue(ManagementCluster);
            }
            if (Optional.IsDefined(Internet))
            {
                writer.WritePropertyName("internet"u8);
                writer.WriteStringValue(Internet.Value.ToString());
            }
            if (Optional.IsCollectionDefined(IdentitySources))
            {
                writer.WritePropertyName("identitySources"u8);
                writer.WriteStartArray();
                foreach (var item in IdentitySources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Availability))
            {
                writer.WritePropertyName("availability"u8);
                writer.WriteObjectValue(Availability);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption"u8);
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(Circuit))
            {
                writer.WritePropertyName("circuit"u8);
                writer.WriteObjectValue(Circuit);
            }
            if (Optional.IsDefined(NetworkBlock))
            {
                writer.WritePropertyName("networkBlock"u8);
                writer.WriteStringValue(NetworkBlock);
            }
            if (Optional.IsDefined(VCenterPassword))
            {
                writer.WritePropertyName("vcenterPassword"u8);
                writer.WriteStringValue(VCenterPassword);
            }
            if (Optional.IsDefined(NsxtPassword))
            {
                writer.WritePropertyName("nsxtPassword"u8);
                writer.WriteStringValue(NsxtPassword);
            }
            if (Optional.IsDefined(SecondaryCircuit))
            {
                writer.WritePropertyName("secondaryCircuit"u8);
                writer.WriteObjectValue(SecondaryCircuit);
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

        internal static AvsPrivateCloudData DeserializeAvsPrivateCloudData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvsSku sku = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AvsManagementCluster> managementCluster = default;
            Optional<InternetConnectivityState> internet = default;
            Optional<IList<SingleSignOnIdentitySource>> identitySources = default;
            Optional<PrivateCloudAvailabilityProperties> availability = default;
            Optional<CustomerManagedEncryption> encryption = default;
            Optional<AvsPrivateCloudProvisioningState> provisioningState = default;
            Optional<ExpressRouteCircuit> circuit = default;
            Optional<AvsPrivateCloudEndpoints> endpoints = default;
            Optional<string> networkBlock = default;
            Optional<string> managementNetwork = default;
            Optional<string> provisioningNetwork = default;
            Optional<string> vmotionNetwork = default;
            Optional<string> vcenterPassword = default;
            Optional<string> nsxtPassword = default;
            Optional<string> vcenterCertificateThumbprint = default;
            Optional<string> nsxtCertificateThumbprint = default;
            Optional<IReadOnlyList<ResourceIdentifier>> externalCloudLinks = default;
            Optional<ExpressRouteCircuit> secondaryCircuit = default;
            Optional<NsxPublicIPQuotaRaisedEnum> nsxPublicIPQuotaRaised = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    sku = AvsSku.DeserializeAvsSku(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("managementCluster"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            managementCluster = AvsManagementCluster.DeserializeAvsManagementCluster(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("internet"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            internet = new InternetConnectivityState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("identitySources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SingleSignOnIdentitySource> array = new List<SingleSignOnIdentitySource>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SingleSignOnIdentitySource.DeserializeSingleSignOnIdentitySource(item));
                            }
                            identitySources = array;
                            continue;
                        }
                        if (property0.NameEquals("availability"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            availability = PrivateCloudAvailabilityProperties.DeserializePrivateCloudAvailabilityProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("encryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryption = CustomerManagedEncryption.DeserializeCustomerManagedEncryption(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new AvsPrivateCloudProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("circuit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuit = ExpressRouteCircuit.DeserializeExpressRouteCircuit(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("endpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpoints = AvsPrivateCloudEndpoints.DeserializeAvsPrivateCloudEndpoints(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkBlock"u8))
                        {
                            networkBlock = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("managementNetwork"u8))
                        {
                            managementNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningNetwork"u8))
                        {
                            provisioningNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmotionNetwork"u8))
                        {
                            vmotionNetwork = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vcenterPassword"u8))
                        {
                            vcenterPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nsxtPassword"u8))
                        {
                            nsxtPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vcenterCertificateThumbprint"u8))
                        {
                            vcenterCertificateThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("nsxtCertificateThumbprint"u8))
                        {
                            nsxtCertificateThumbprint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("externalCloudLinks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(new ResourceIdentifier(item.GetString()));
                                }
                            }
                            externalCloudLinks = array;
                            continue;
                        }
                        if (property0.NameEquals("secondaryCircuit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryCircuit = ExpressRouteCircuit.DeserializeExpressRouteCircuit(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("nsxPublicIpQuotaRaised"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nsxPublicIPQuotaRaised = new NsxPublicIPQuotaRaisedEnum(property0.Value.GetString());
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
            return new AvsPrivateCloudData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, sku, identity, managementCluster.Value, Optional.ToNullable(internet), Optional.ToList(identitySources), availability.Value, encryption.Value, Optional.ToNullable(provisioningState), circuit.Value, endpoints.Value, networkBlock.Value, managementNetwork.Value, provisioningNetwork.Value, vmotionNetwork.Value, vcenterPassword.Value, nsxtPassword.Value, vcenterCertificateThumbprint.Value, nsxtCertificateThumbprint.Value, Optional.ToList(externalCloudLinks), secondaryCircuit.Value, Optional.ToNullable(nsxPublicIPQuotaRaised), rawData);
        }

        AvsPrivateCloudData IModelJsonSerializable<AvsPrivateCloudData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsPrivateCloudData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvsPrivateCloudData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvsPrivateCloudData IModelSerializable<AvsPrivateCloudData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvsPrivateCloudData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AvsPrivateCloudData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AvsPrivateCloudData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvsPrivateCloudData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
