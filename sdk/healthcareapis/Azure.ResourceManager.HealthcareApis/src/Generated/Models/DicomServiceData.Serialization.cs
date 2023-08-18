// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    public partial class DicomServiceData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                var serializeOptions = new JsonSerializerOptions { Converters = { new ManagedServiceIdentityTypeV3Converter() } };
                JsonSerializer.Serialize(writer, Identity, serializeOptions);
            }
            if (Core.Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Core.Optional.IsCollectionDefined(Tags))
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
            if (Core.Optional.IsDefined(AuthenticationConfiguration))
            {
                writer.WritePropertyName("authenticationConfiguration"u8);
                writer.WriteObjectValue(AuthenticationConfiguration);
            }
            if (Core.Optional.IsDefined(CorsConfiguration))
            {
                writer.WritePropertyName("corsConfiguration"u8);
                writer.WriteObjectValue(CorsConfiguration);
            }
            if (Core.Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static DicomServiceData DeserializeDicomServiceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<ManagedServiceIdentity> identity = default;
            Core.Optional<ETag> etag = default;
            Core.Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<HealthcareApisProvisioningState> provisioningState = default;
            Core.Optional<DicomServiceAuthenticationConfiguration> authenticationConfiguration = default;
            Core.Optional<DicomServiceCorsConfiguration> corsConfiguration = default;
            Core.Optional<Uri> serviceUrl = default;
            Core.Optional<IReadOnlyList<HealthcareApisPrivateEndpointConnectionData>> privateEndpointConnections = default;
            Core.Optional<HealthcareApisPublicNetworkAccess> publicNetworkAccess = default;
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
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HealthcareApisProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authenticationConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationConfiguration = DicomServiceAuthenticationConfiguration.DeserializeDicomServiceAuthenticationConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("corsConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            corsConfiguration = DicomServiceCorsConfiguration.DeserializeDicomServiceCorsConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HealthcareApisPrivateEndpointConnectionData> array = new List<HealthcareApisPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HealthcareApisPrivateEndpointConnectionData.DeserializeHealthcareApisPrivateEndpointConnectionData(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new HealthcareApisPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new DicomServiceData(id, name, type, systemData.Value, Core.Optional.ToDictionary(tags), location, Core.Optional.ToNullable(provisioningState), authenticationConfiguration.Value, corsConfiguration.Value, serviceUrl.Value, Core.Optional.ToList(privateEndpointConnections), Core.Optional.ToNullable(publicNetworkAccess), identity, Core.Optional.ToNullable(etag));
        }
    }
}
