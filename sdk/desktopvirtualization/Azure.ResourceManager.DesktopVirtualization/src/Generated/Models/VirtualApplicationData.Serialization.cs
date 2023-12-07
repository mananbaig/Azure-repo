// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class VirtualApplicationData : IUtf8JsonSerializable, IJsonModel<VirtualApplicationData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualApplicationData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualApplicationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplicationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualApplicationData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && Optional.IsDefined(ObjectId))
            {
                writer.WritePropertyName("objectId"u8);
                writer.WriteStringValue(ObjectId);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("filePath"u8);
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(MsixPackageFamilyName))
            {
                if (MsixPackageFamilyName != null)
                {
                    writer.WritePropertyName("msixPackageFamilyName"u8);
                    writer.WriteStringValue(MsixPackageFamilyName);
                }
                else
                {
                    writer.WriteNull("msixPackageFamilyName");
                }
            }
            if (Optional.IsDefined(MsixPackageApplicationId))
            {
                if (MsixPackageApplicationId != null)
                {
                    writer.WritePropertyName("msixPackageApplicationId"u8);
                    writer.WriteStringValue(MsixPackageApplicationId);
                }
                else
                {
                    writer.WriteNull("msixPackageApplicationId");
                }
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            writer.WritePropertyName("commandLineSetting"u8);
            writer.WriteStringValue(CommandLineSetting.ToString());
            if (Optional.IsDefined(CommandLineArguments))
            {
                writer.WritePropertyName("commandLineArguments"u8);
                writer.WriteStringValue(CommandLineArguments);
            }
            if (Optional.IsDefined(ShowInPortal))
            {
                writer.WritePropertyName("showInPortal"u8);
                writer.WriteBooleanValue(ShowInPortal.Value);
            }
            if (Optional.IsDefined(IconPath))
            {
                writer.WritePropertyName("iconPath"u8);
                writer.WriteStringValue(IconPath);
            }
            if (Optional.IsDefined(IconIndex))
            {
                writer.WritePropertyName("iconIndex"u8);
                writer.WriteNumberValue(IconIndex.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(IconHash))
            {
                writer.WritePropertyName("iconHash"u8);
                writer.WriteStringValue(IconHash);
            }
            if (options.Format != "W" && Optional.IsDefined(IconContent))
            {
                writer.WritePropertyName("iconContent"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(IconContent);
#else
                using (JsonDocument document = JsonDocument.Parse(IconContent))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        VirtualApplicationData IJsonModel<VirtualApplicationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplicationData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VirtualApplicationData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualApplicationData(document.RootElement, options);
        }

        internal static VirtualApplicationData DeserializeVirtualApplicationData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> objectId = default;
            Optional<string> description = default;
            Optional<string> friendlyName = default;
            Optional<string> filePath = default;
            Optional<string> msixPackageFamilyName = default;
            Optional<string> msixPackageApplicationId = default;
            Optional<RemoteApplicationType> applicationType = default;
            VirtualApplicationCommandLineSetting commandLineSetting = default;
            Optional<string> commandLineArguments = default;
            Optional<bool> showInPortal = default;
            Optional<string> iconPath = default;
            Optional<int> iconIndex = default;
            Optional<string> iconHash = default;
            Optional<BinaryData> iconContent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("filePath"u8))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("msixPackageFamilyName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                msixPackageFamilyName = null;
                                continue;
                            }
                            msixPackageFamilyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("msixPackageApplicationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                msixPackageApplicationId = null;
                                continue;
                            }
                            msixPackageApplicationId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationType = new RemoteApplicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("commandLineSetting"u8))
                        {
                            commandLineSetting = new VirtualApplicationCommandLineSetting(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("commandLineArguments"u8))
                        {
                            commandLineArguments = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("showInPortal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            showInPortal = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("iconPath"u8))
                        {
                            iconPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconIndex"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iconIndex = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("iconHash"u8))
                        {
                            iconHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iconContent"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iconContent = BinaryData.FromString(property0.Value.GetRawText());
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
            return new VirtualApplicationData(id, name, type, systemData.Value, objectId.Value, description.Value, friendlyName.Value, filePath.Value, msixPackageFamilyName.Value, msixPackageApplicationId.Value, Optional.ToNullable(applicationType), commandLineSetting, commandLineArguments.Value, Optional.ToNullable(showInPortal), iconPath.Value, Optional.ToNullable(iconIndex), iconHash.Value, iconContent.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualApplicationData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplicationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualApplicationData)} does not support '{options.Format}' format.");
            }
        }

        VirtualApplicationData IPersistableModel<VirtualApplicationData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualApplicationData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualApplicationData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VirtualApplicationData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualApplicationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
