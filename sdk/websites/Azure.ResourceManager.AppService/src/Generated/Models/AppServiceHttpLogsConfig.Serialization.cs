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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceHttpLogsConfig : IUtf8JsonSerializable, IModelJsonSerializable<AppServiceHttpLogsConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AppServiceHttpLogsConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AppServiceHttpLogsConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceHttpLogsConfig>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FileSystem))
            {
                writer.WritePropertyName("fileSystem"u8);
                if (FileSystem is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<FileSystemHttpLogsConfig>)FileSystem).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(AzureBlobStorage))
            {
                writer.WritePropertyName("azureBlobStorage"u8);
                if (AzureBlobStorage is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceBlobStorageHttpLogsConfig>)AzureBlobStorage).Serialize(writer, options);
                }
            }
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

        internal static AppServiceHttpLogsConfig DeserializeAppServiceHttpLogsConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FileSystemHttpLogsConfig> fileSystem = default;
            Optional<AppServiceBlobStorageHttpLogsConfig> azureBlobStorage = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fileSystem"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSystem = FileSystemHttpLogsConfig.DeserializeFileSystemHttpLogsConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("azureBlobStorage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureBlobStorage = AppServiceBlobStorageHttpLogsConfig.DeserializeAppServiceBlobStorageHttpLogsConfig(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AppServiceHttpLogsConfig(fileSystem.Value, azureBlobStorage.Value, serializedAdditionalRawData);
        }

        AppServiceHttpLogsConfig IModelJsonSerializable<AppServiceHttpLogsConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceHttpLogsConfig>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceHttpLogsConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AppServiceHttpLogsConfig>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceHttpLogsConfig>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AppServiceHttpLogsConfig IModelSerializable<AppServiceHttpLogsConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<AppServiceHttpLogsConfig>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAppServiceHttpLogsConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AppServiceHttpLogsConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AppServiceHttpLogsConfig"/> to convert. </param>
        public static implicit operator RequestContent(AppServiceHttpLogsConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AppServiceHttpLogsConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AppServiceHttpLogsConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAppServiceHttpLogsConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
