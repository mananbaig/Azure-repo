// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSitePatch : IUtf8JsonSerializable, IJsonModel<StaticSitePatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSitePatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StaticSitePatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSitePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSitePatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DefaultHostname))
            {
                writer.WritePropertyName("defaultHostname"u8);
                writer.WriteStringValue(DefaultHostname);
            }
            if (Optional.IsDefined(RepositoryUri))
            {
                writer.WritePropertyName("repositoryUrl"u8);
                writer.WriteStringValue(RepositoryUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Branch))
            {
                writer.WritePropertyName("branch"u8);
                writer.WriteStringValue(Branch);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CustomDomains))
            {
                writer.WritePropertyName("customDomains"u8);
                writer.WriteStartArray();
                foreach (var item in CustomDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RepositoryToken))
            {
                writer.WritePropertyName("repositoryToken"u8);
                writer.WriteStringValue(RepositoryToken);
            }
            if (Optional.IsDefined(BuildProperties))
            {
                writer.WritePropertyName("buildProperties"u8);
                writer.WriteObjectValue(BuildProperties);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(StagingEnvironmentPolicy))
            {
                writer.WritePropertyName("stagingEnvironmentPolicy"u8);
                writer.WriteStringValue(StagingEnvironmentPolicy.Value.ToSerialString());
            }
            if (Optional.IsDefined(AllowConfigFileUpdates))
            {
                writer.WritePropertyName("allowConfigFileUpdates"u8);
                writer.WriteBooleanValue(AllowConfigFileUpdates.Value);
            }
            if (Optional.IsDefined(TemplateProperties))
            {
                writer.WritePropertyName("templateProperties"u8);
                writer.WriteObjectValue(TemplateProperties);
            }
            if (options.Format != "W" && Optional.IsDefined(ContentDistributionEndpoint))
            {
                writer.WritePropertyName("contentDistributionEndpoint"u8);
                writer.WriteStringValue(ContentDistributionEndpoint);
            }
            if (options.Format != "W" && Optional.IsDefined(KeyVaultReferenceIdentity))
            {
                writer.WritePropertyName("keyVaultReferenceIdentity"u8);
                writer.WriteStringValue(KeyVaultReferenceIdentity);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(UserProvidedFunctionApps))
            {
                writer.WritePropertyName("userProvidedFunctionApps"u8);
                writer.WriteStartArray();
                foreach (var item in UserProvidedFunctionApps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        StaticSitePatch IJsonModel<StaticSitePatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSitePatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSitePatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSitePatch(document.RootElement, options);
        }

        internal static StaticSitePatch DeserializeStaticSitePatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string defaultHostname = default;
            Uri repositoryUrl = default;
            string branch = default;
            IReadOnlyList<string> customDomains = default;
            string repositoryToken = default;
            StaticSiteBuildProperties buildProperties = default;
            IReadOnlyList<ResponseMessageEnvelopeRemotePrivateEndpointConnection> privateEndpointConnections = default;
            StagingEnvironmentPolicy? stagingEnvironmentPolicy = default;
            bool? allowConfigFileUpdates = default;
            StaticSiteTemplate templateProperties = default;
            string contentDistributionEndpoint = default;
            string keyVaultReferenceIdentity = default;
            IReadOnlyList<StaticSiteUserProvidedFunctionAppData> userProvidedFunctionApps = default;
            string provider = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("defaultHostname"u8))
                        {
                            defaultHostname = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("repositoryUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repositoryUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("branch"u8))
                        {
                            branch = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customDomains"u8))
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
                            customDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("repositoryToken"u8))
                        {
                            repositoryToken = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("buildProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            buildProperties = StaticSiteBuildProperties.DeserializeStaticSiteBuildProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResponseMessageEnvelopeRemotePrivateEndpointConnection> array = new List<ResponseMessageEnvelopeRemotePrivateEndpointConnection>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResponseMessageEnvelopeRemotePrivateEndpointConnection.DeserializeResponseMessageEnvelopeRemotePrivateEndpointConnection(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("stagingEnvironmentPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            stagingEnvironmentPolicy = property0.Value.GetString().ToStagingEnvironmentPolicy();
                            continue;
                        }
                        if (property0.NameEquals("allowConfigFileUpdates"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            allowConfigFileUpdates = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("templateProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            templateProperties = StaticSiteTemplate.DeserializeStaticSiteTemplate(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("contentDistributionEndpoint"u8))
                        {
                            contentDistributionEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyVaultReferenceIdentity"u8))
                        {
                            keyVaultReferenceIdentity = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userProvidedFunctionApps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<StaticSiteUserProvidedFunctionAppData> array = new List<StaticSiteUserProvidedFunctionAppData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(StaticSiteUserProvidedFunctionAppData.DeserializeStaticSiteUserProvidedFunctionAppData(item, options));
                            }
                            userProvidedFunctionApps = array;
                            continue;
                        }
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StaticSitePatch(
                id,
                name,
                type,
                systemData,
                defaultHostname,
                repositoryUrl,
                branch,
                customDomains ?? new ChangeTrackingList<string>(),
                repositoryToken,
                buildProperties,
                privateEndpointConnections ?? new ChangeTrackingList<ResponseMessageEnvelopeRemotePrivateEndpointConnection>(),
                stagingEnvironmentPolicy,
                allowConfigFileUpdates,
                templateProperties,
                contentDistributionEndpoint,
                keyVaultReferenceIdentity,
                userProvidedFunctionApps ?? new ChangeTrackingList<StaticSiteUserProvidedFunctionAppData>(),
                provider,
                kind,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StaticSitePatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSitePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StaticSitePatch)} does not support writing '{options.Format}' format.");
            }
        }

        StaticSitePatch IPersistableModel<StaticSitePatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSitePatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticSitePatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSitePatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSitePatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
