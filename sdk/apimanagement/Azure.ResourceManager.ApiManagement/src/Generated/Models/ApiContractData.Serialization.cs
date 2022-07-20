// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiContractData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(AuthenticationSettings))
            {
                writer.WritePropertyName("authenticationSettings");
                writer.WriteObjectValue(AuthenticationSettings);
            }
            if (Optional.IsDefined(SubscriptionKeyParameterNames))
            {
                writer.WritePropertyName("subscriptionKeyParameterNames");
                writer.WriteObjectValue(SubscriptionKeyParameterNames);
            }
            if (Optional.IsDefined(ApiType))
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(ApiType.Value.ToString());
            }
            if (Optional.IsDefined(ApiRevision))
            {
                writer.WritePropertyName("apiRevision");
                writer.WriteStringValue(ApiRevision);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion");
                writer.WriteStringValue(ApiVersion);
            }
            if (Optional.IsDefined(IsCurrent))
            {
                writer.WritePropertyName("isCurrent");
                writer.WriteBooleanValue(IsCurrent.Value);
            }
            if (Optional.IsDefined(ApiRevisionDescription))
            {
                writer.WritePropertyName("apiRevisionDescription");
                writer.WriteStringValue(ApiRevisionDescription);
            }
            if (Optional.IsDefined(ApiVersionDescription))
            {
                writer.WritePropertyName("apiVersionDescription");
                writer.WriteStringValue(ApiVersionDescription);
            }
            if (Optional.IsDefined(ApiVersionSetId))
            {
                writer.WritePropertyName("apiVersionSetId");
                writer.WriteStringValue(ApiVersionSetId);
            }
            if (Optional.IsDefined(SubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired");
                writer.WriteBooleanValue(SubscriptionRequired.Value);
            }
            if (Optional.IsDefined(TermsOfServiceUri))
            {
                writer.WritePropertyName("termsOfServiceUrl");
                writer.WriteStringValue(TermsOfServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Contact))
            {
                writer.WritePropertyName("contact");
                writer.WriteObjectValue(Contact);
            }
            if (Optional.IsDefined(License))
            {
                writer.WritePropertyName("license");
                writer.WriteObjectValue(License);
            }
            if (Optional.IsDefined(SourceApiId))
            {
                writer.WritePropertyName("sourceApiId");
                writer.WriteStringValue(SourceApiId);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName");
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUrl");
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            if (Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols");
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ApiVersionSet))
            {
                writer.WritePropertyName("apiVersionSet");
                writer.WriteObjectValue(ApiVersionSet);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApiContractData DeserializeApiContractData(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> description = default;
            Optional<AuthenticationSettingsContract> authenticationSettings = default;
            Optional<SubscriptionKeyParameterNamesContract> subscriptionKeyParameterNames = default;
            Optional<ApiType> type0 = default;
            Optional<string> apiRevision = default;
            Optional<string> apiVersion = default;
            Optional<bool> isCurrent = default;
            Optional<bool> isOnline = default;
            Optional<string> apiRevisionDescription = default;
            Optional<string> apiVersionDescription = default;
            Optional<string> apiVersionSetId = default;
            Optional<bool> subscriptionRequired = default;
            Optional<Uri> termsOfServiceUrl = default;
            Optional<ApiContactInformation> contact = default;
            Optional<ApiLicenseInformation> license = default;
            Optional<string> sourceApiId = default;
            Optional<string> displayName = default;
            Optional<Uri> serviceUrl = default;
            Optional<string> path = default;
            Optional<IList<Protocol>> protocols = default;
            Optional<ApiVersionSetContractDetails> apiVersionSet = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationSettings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            authenticationSettings = AuthenticationSettingsContract.DeserializeAuthenticationSettingsContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("subscriptionKeyParameterNames"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            subscriptionKeyParameterNames = SubscriptionKeyParameterNamesContract.DeserializeSubscriptionKeyParameterNamesContract(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("type"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            type0 = new ApiType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiRevision"))
                        {
                            apiRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersion"))
                        {
                            apiVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isCurrent"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isCurrent = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isOnline"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isOnline = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("apiRevisionDescription"))
                        {
                            apiRevisionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionDescription"))
                        {
                            apiVersionDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSetId"))
                        {
                            apiVersionSetId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subscriptionRequired"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            subscriptionRequired = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("termsOfServiceUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                termsOfServiceUrl = null;
                                continue;
                            }
                            termsOfServiceUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("contact"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            contact = ApiContactInformation.DeserializeApiContactInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("license"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            license = ApiLicenseInformation.DeserializeApiLicenseInformation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("sourceApiId"))
                        {
                            sourceApiId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                serviceUrl = null;
                                continue;
                            }
                            serviceUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("path"))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocols"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<Protocol> array = new List<Protocol>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new Protocol(item.GetString()));
                            }
                            protocols = array;
                            continue;
                        }
                        if (property0.NameEquals("apiVersionSet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            apiVersionSet = ApiVersionSetContractDetails.DeserializeApiVersionSetContractDetails(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApiContractData(id, name, type, systemData.Value, description.Value, authenticationSettings.Value, subscriptionKeyParameterNames.Value, Optional.ToNullable(type0), apiRevision.Value, apiVersion.Value, Optional.ToNullable(isCurrent), Optional.ToNullable(isOnline), apiRevisionDescription.Value, apiVersionDescription.Value, apiVersionSetId.Value, Optional.ToNullable(subscriptionRequired), termsOfServiceUrl.Value, contact.Value, license.Value, sourceApiId.Value, displayName.Value, serviceUrl.Value, path.Value, Optional.ToList(protocols), apiVersionSet.Value);
        }
    }
}
