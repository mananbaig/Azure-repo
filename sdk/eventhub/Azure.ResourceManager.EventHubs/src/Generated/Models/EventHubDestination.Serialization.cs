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

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubDestination : IUtf8JsonSerializable, IModelJsonSerializable<EventHubDestination>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubDestination>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubDestination>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubDestination>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountResourceId))
            {
                writer.WritePropertyName("storageAccountResourceId"u8);
                writer.WriteStringValue(StorageAccountResourceId);
            }
            if (Optional.IsDefined(BlobContainer))
            {
                writer.WritePropertyName("blobContainer"u8);
                writer.WriteStringValue(BlobContainer);
            }
            if (Optional.IsDefined(ArchiveNameFormat))
            {
                writer.WritePropertyName("archiveNameFormat"u8);
                writer.WriteStringValue(ArchiveNameFormat);
            }
            if (Optional.IsDefined(DataLakeSubscriptionId))
            {
                writer.WritePropertyName("dataLakeSubscriptionId"u8);
                writer.WriteStringValue(DataLakeSubscriptionId.Value);
            }
            if (Optional.IsDefined(DataLakeAccountName))
            {
                writer.WritePropertyName("dataLakeAccountName"u8);
                writer.WriteStringValue(DataLakeAccountName);
            }
            if (Optional.IsDefined(DataLakeFolderPath))
            {
                writer.WritePropertyName("dataLakeFolderPath"u8);
                writer.WriteStringValue(DataLakeFolderPath);
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

        internal static EventHubDestination DeserializeEventHubDestination(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<ResourceIdentifier> storageAccountResourceId = default;
            Optional<string> blobContainer = default;
            Optional<string> archiveNameFormat = default;
            Optional<Guid> dataLakeSubscriptionId = default;
            Optional<string> dataLakeAccountName = default;
            Optional<string> dataLakeFolderPath = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("storageAccountResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("blobContainer"u8))
                        {
                            blobContainer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("archiveNameFormat"u8))
                        {
                            archiveNameFormat = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeSubscriptionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataLakeSubscriptionId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeAccountName"u8))
                        {
                            dataLakeAccountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataLakeFolderPath"u8))
                        {
                            dataLakeFolderPath = property0.Value.GetString();
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
            return new EventHubDestination(name.Value, storageAccountResourceId.Value, blobContainer.Value, archiveNameFormat.Value, Optional.ToNullable(dataLakeSubscriptionId), dataLakeAccountName.Value, dataLakeFolderPath.Value, serializedAdditionalRawData);
        }

        EventHubDestination IModelJsonSerializable<EventHubDestination>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubDestination>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubDestination(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubDestination>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubDestination>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubDestination IModelSerializable<EventHubDestination>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubDestination>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubDestination(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubDestination"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubDestination"/> to convert. </param>
        public static implicit operator RequestContent(EventHubDestination model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubDestination"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubDestination(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubDestination(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
