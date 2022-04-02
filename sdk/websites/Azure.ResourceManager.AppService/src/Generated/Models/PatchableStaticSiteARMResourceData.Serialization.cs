// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class PatchableStaticSiteARMResourceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl");
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch");
                writer.WriteStringValue(Branch);
            }
            if (Optional.IsDefined(RepositoryToken))
            {
                writer.WritePropertyName("repositoryToken");
                writer.WriteStringValue(RepositoryToken);
            }
            if (Optional.IsDefined(BuildProperties))
            {
                writer.WritePropertyName("buildProperties");
                writer.WriteObjectValue(BuildProperties);
            }
            if (Optional.IsDefined(StagingEnvironmentPolicy))
            {
                writer.WritePropertyName("stagingEnvironmentPolicy");
                writer.WriteStringValue(StagingEnvironmentPolicy.Value.ToSerialString());
            }
            if (Optional.IsDefined(AllowConfigFileUpdates))
            {
                writer.WritePropertyName("allowConfigFileUpdates");
                writer.WriteBooleanValue(AllowConfigFileUpdates.Value);
            }
            if (Optional.IsDefined(TemplateProperties))
            {
                writer.WritePropertyName("templateProperties");
                writer.WriteObjectValue(TemplateProperties);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PatchableStaticSiteARMResourceData DeserializePatchableStaticSiteARMResourceData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> defaultHostname = default;
            Optional<Uri> repositoryUrl = default;
            Optional<string> branch = default;
            Optional<IReadOnlyList<string>> customDomains = default;
            Optional<string> repositoryToken = default;
            Optional<StaticSiteBuildProperties> buildProperties = default;
            Optional<IReadOnlyList<ResponseMessageEnvelopeRemotePrivateEndpointConnection>> privateEndpointConnections = default;
            Optional<StagingEnvironmentPolicy> stagingEnvironmentPolicy = default;
            Optional<bool> allowConfigFileUpdates = default;
            Optional<StaticSiteTemplateOptions> templateProperties = default;
            Optional<string> contentDistributionEndpoint = default;
            Optional<string> keyVaultReferenceIdentity = default;
            Optional<IReadOnlyList<StaticSiteUserProvidedFunctionApp>> userProvidedFunctionApps = default;
            Optional<string> provider = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
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
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
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
                        if (property0.NameEquals("defaultHostname"))
                        {
                            defaultHostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("repositoryUrl"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                repositoryUrl = null;
                                continue;
                            }
                            repositoryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("branch"))
                        {
                            branch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customDomains"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("repositoryToken"))
                        {
                            repositoryToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("buildProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            buildProperties = StaticSiteBuildProperties.DeserializeStaticSiteBuildProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ResponseMessageEnvelopeRemotePrivateEndpointConnection> array = new List<ResponseMessageEnvelopeRemotePrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResponseMessageEnvelopeRemotePrivateEndpointConnection.DeserializeResponseMessageEnvelopeRemotePrivateEndpointConnection(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("stagingEnvironmentPolicy"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            stagingEnvironmentPolicy = property0.Value.GetString().ToStagingEnvironmentPolicy();
                            continue;
                        }
                        if (property0.NameEquals("allowConfigFileUpdates"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            allowConfigFileUpdates = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("templateProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            templateProperties = StaticSiteTemplateOptions.DeserializeStaticSiteTemplateOptions(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("contentDistributionEndpoint"))
                        {
                            contentDistributionEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userProvidedFunctionApps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<StaticSiteUserProvidedFunctionApp> array = new List<StaticSiteUserProvidedFunctionApp>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StaticSiteUserProvidedFunctionApp.DeserializeStaticSiteUserProvidedFunctionApp(item));
                            }
                            userProvidedFunctionApps = array;
                            continue;
                        }
                        if (property0.NameEquals("provider"))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PatchableStaticSiteARMResourceData(id, name, type, systemData, kind.Value, defaultHostname.Value, repositoryUrl.Value, branch.Value, Optional.ToList(customDomains), repositoryToken.Value, buildProperties.Value, Optional.ToList(privateEndpointConnections), Optional.ToNullable(stagingEnvironmentPolicy), Optional.ToNullable(allowConfigFileUpdates), templateProperties.Value, contentDistributionEndpoint.Value, keyVaultReferenceIdentity.Value, Optional.ToList(userProvidedFunctionApps), provider.Value);
        }
    }
}
