// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceValidateContent : IUtf8JsonSerializable, IJsonModel<AppServiceValidateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceValidateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceValidateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceValidateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceValidateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ValidateResourceType.ToString());
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServerFarmId))
            {
                writer.WritePropertyName("serverFarmId"u8);
                writer.WriteStringValue(ServerFarmId);
            }
            if (Optional.IsDefined(SkuName))
            {
                writer.WritePropertyName("skuName"u8);
                writer.WriteStringValue(SkuName);
            }
            if (Optional.IsDefined(NeedLinuxWorkers))
            {
                writer.WritePropertyName("needLinuxWorkers"u8);
                writer.WriteBooleanValue(NeedLinuxWorkers.Value);
            }
            if (Optional.IsDefined(IsSpot))
            {
                writer.WritePropertyName("isSpot"u8);
                writer.WriteBooleanValue(IsSpot.Value);
            }
            if (Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteNumberValue(Capacity.Value);
            }
            if (Optional.IsDefined(HostingEnvironment))
            {
                writer.WritePropertyName("hostingEnvironment"u8);
                writer.WriteStringValue(HostingEnvironment);
            }
            if (Optional.IsDefined(IsXenon))
            {
                writer.WritePropertyName("isXenon"u8);
                writer.WriteBooleanValue(IsXenon.Value);
            }
            if (Optional.IsDefined(ContainerRegistryBaseUri))
            {
                writer.WritePropertyName("containerRegistryBaseUrl"u8);
                writer.WriteStringValue(ContainerRegistryBaseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ContainerRegistryUsername))
            {
                writer.WritePropertyName("containerRegistryUsername"u8);
                writer.WriteStringValue(ContainerRegistryUsername);
            }
            if (Optional.IsDefined(ContainerRegistryPassword))
            {
                writer.WritePropertyName("containerRegistryPassword"u8);
                writer.WriteStringValue(ContainerRegistryPassword);
            }
            if (Optional.IsDefined(ContainerImageRepository))
            {
                writer.WritePropertyName("containerImageRepository"u8);
                writer.WriteStringValue(ContainerImageRepository);
            }
            if (Optional.IsDefined(ContainerImageTag))
            {
                writer.WritePropertyName("containerImageTag"u8);
                writer.WriteStringValue(ContainerImageTag);
            }
            if (Optional.IsDefined(ContainerImagePlatform))
            {
                writer.WritePropertyName("containerImagePlatform"u8);
                writer.WriteStringValue(ContainerImagePlatform);
            }
            if (Optional.IsDefined(AppServiceEnvironment))
            {
                writer.WritePropertyName("appServiceEnvironment"u8);
                writer.WriteObjectValue(AppServiceEnvironment);
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

        AppServiceValidateContent IJsonModel<AppServiceValidateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceValidateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceValidateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceValidateContent(document.RootElement, options);
        }

        internal static AppServiceValidateContent DeserializeAppServiceValidateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ValidateResourceType type = default;
            AzureLocation location = default;
            ResourceIdentifier serverFarmId = default;
            string skuName = default;
            bool? needLinuxWorkers = default;
            bool? isSpot = default;
            int? capacity = default;
            string hostingEnvironment = default;
            bool? isXenon = default;
            Uri containerRegistryBaseUrl = default;
            string containerRegistryUsername = default;
            string containerRegistryPassword = default;
            string containerImageRepository = default;
            string containerImageTag = default;
            string containerImagePlatform = default;
            AppServiceEnvironmentProperties appServiceEnvironment = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ValidateResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("serverFarmId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serverFarmId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("skuName"u8))
                        {
                            skuName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("needLinuxWorkers"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            needLinuxWorkers = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isSpot"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isSpot = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("hostingEnvironment"u8))
                        {
                            hostingEnvironment = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isXenon"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isXenon = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("containerRegistryBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            containerRegistryBaseUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("containerRegistryUsername"u8))
                        {
                            containerRegistryUsername = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerRegistryPassword"u8))
                        {
                            containerRegistryPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerImageRepository"u8))
                        {
                            containerImageRepository = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerImageTag"u8))
                        {
                            containerImageTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containerImagePlatform"u8))
                        {
                            containerImagePlatform = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("appServiceEnvironment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appServiceEnvironment = AppServiceEnvironmentProperties.DeserializeAppServiceEnvironmentProperties(property0.Value, options);
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
            return new AppServiceValidateContent(
                name,
                type,
                location,
                serverFarmId,
                skuName,
                needLinuxWorkers,
                isSpot,
                capacity,
                hostingEnvironment,
                isXenon,
                containerRegistryBaseUrl,
                containerRegistryUsername,
                containerRegistryPassword,
                containerImageRepository,
                containerImageTag,
                containerImagePlatform,
                appServiceEnvironment,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceValidateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceValidateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceValidateContent)} does not support '{options.Format}' format.");
            }
        }

        AppServiceValidateContent IPersistableModel<AppServiceValidateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceValidateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceValidateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceValidateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceValidateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
