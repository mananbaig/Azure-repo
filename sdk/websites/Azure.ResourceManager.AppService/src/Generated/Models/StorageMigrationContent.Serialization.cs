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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StorageMigrationContent : IUtf8JsonSerializable, IModelJsonSerializable<StorageMigrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StorageMigrationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StorageMigrationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageMigrationContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AzurefilesConnectionString))
            {
                writer.WritePropertyName("azurefilesConnectionString"u8);
                writer.WriteStringValue(AzurefilesConnectionString);
            }
            if (Optional.IsDefined(AzurefilesShare))
            {
                writer.WritePropertyName("azurefilesShare"u8);
                writer.WriteStringValue(AzurefilesShare);
            }
            if (Optional.IsDefined(SwitchSiteAfterMigration))
            {
                writer.WritePropertyName("switchSiteAfterMigration"u8);
                writer.WriteBooleanValue(SwitchSiteAfterMigration.Value);
            }
            if (Optional.IsDefined(BlockWriteAccessToSite))
            {
                writer.WritePropertyName("blockWriteAccessToSite"u8);
                writer.WriteBooleanValue(BlockWriteAccessToSite.Value);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static StorageMigrationContent DeserializeStorageMigrationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> azurefilesConnectionString = default;
            Optional<string> azurefilesShare = default;
            Optional<bool> switchSiteAfterMigration = default;
            Optional<bool> blockWriteAccessToSite = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("azurefilesConnectionString"u8))
                        {
                            azurefilesConnectionString = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("azurefilesShare"u8))
                        {
                            azurefilesShare = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("switchSiteAfterMigration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            switchSiteAfterMigration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("blockWriteAccessToSite"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blockWriteAccessToSite = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StorageMigrationContent(id, name, type, systemData.Value, azurefilesConnectionString.Value, azurefilesShare.Value, Optional.ToNullable(switchSiteAfterMigration), Optional.ToNullable(blockWriteAccessToSite), kind.Value, serializedAdditionalRawData);
        }

        StorageMigrationContent IModelJsonSerializable<StorageMigrationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageMigrationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageMigrationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StorageMigrationContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageMigrationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StorageMigrationContent IModelSerializable<StorageMigrationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<StorageMigrationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStorageMigrationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="StorageMigrationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="StorageMigrationContent"/> to convert. </param>
        public static implicit operator RequestContent(StorageMigrationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="StorageMigrationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator StorageMigrationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStorageMigrationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
