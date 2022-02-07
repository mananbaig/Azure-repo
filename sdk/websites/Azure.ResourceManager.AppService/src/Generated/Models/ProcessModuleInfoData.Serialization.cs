// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class ProcessModuleInfoData : IUtf8JsonSerializable
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
            if (Optional.IsDefined(BaseAddress))
            {
                writer.WritePropertyName("base_address");
                writer.WriteStringValue(BaseAddress);
            }
            if (Optional.IsDefined(FileName))
            {
                writer.WritePropertyName("file_name");
                writer.WriteStringValue(FileName);
            }
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href");
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(FilePath))
            {
                writer.WritePropertyName("file_path");
                writer.WriteStringValue(FilePath);
            }
            if (Optional.IsDefined(ModuleMemorySize))
            {
                writer.WritePropertyName("module_memory_size");
                writer.WriteNumberValue(ModuleMemorySize.Value);
            }
            if (Optional.IsDefined(FileVersion))
            {
                writer.WritePropertyName("file_version");
                writer.WriteStringValue(FileVersion);
            }
            if (Optional.IsDefined(FileDescription))
            {
                writer.WritePropertyName("file_description");
                writer.WriteStringValue(FileDescription);
            }
            if (Optional.IsDefined(Product))
            {
                writer.WritePropertyName("product");
                writer.WriteStringValue(Product);
            }
            if (Optional.IsDefined(ProductVersion))
            {
                writer.WritePropertyName("product_version");
                writer.WriteStringValue(ProductVersion);
            }
            if (Optional.IsDefined(IsDebug))
            {
                writer.WritePropertyName("is_debug");
                writer.WriteBooleanValue(IsDebug.Value);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ProcessModuleInfoData DeserializeProcessModuleInfoData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> baseAddress = default;
            Optional<string> fileName = default;
            Optional<string> href = default;
            Optional<string> filePath = default;
            Optional<int> moduleMemorySize = default;
            Optional<string> fileVersion = default;
            Optional<string> fileDescription = default;
            Optional<string> product = default;
            Optional<string> productVersion = default;
            Optional<bool> isDebug = default;
            Optional<string> language = default;
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
                        if (property0.NameEquals("base_address"))
                        {
                            baseAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_name"))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("href"))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_path"))
                        {
                            filePath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("module_memory_size"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            moduleMemorySize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("file_version"))
                        {
                            fileVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("file_description"))
                        {
                            fileDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product"))
                        {
                            product = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("product_version"))
                        {
                            productVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("is_debug"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDebug = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("language"))
                        {
                            language = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ProcessModuleInfoData(id, name, type, systemData, kind.Value, baseAddress.Value, fileName.Value, href.Value, filePath.Value, Optional.ToNullable(moduleMemorySize), fileVersion.Value, fileDescription.Value, product.Value, productVersion.Value, Optional.ToNullable(isDebug), language.Value);
        }
    }
}
