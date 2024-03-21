// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StoragePermissionScope : IUtf8JsonSerializable, IJsonModel<StoragePermissionScope>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StoragePermissionScope>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<StoragePermissionScope>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePermissionScope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoragePermissionScope)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("permissions"u8);
            writer.WriteStringValue(Permissions);
            writer.WritePropertyName("service"u8);
            writer.WriteStringValue(Service);
            writer.WritePropertyName("resourceName"u8);
            writer.WriteStringValue(ResourceName);
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

        StoragePermissionScope IJsonModel<StoragePermissionScope>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePermissionScope>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StoragePermissionScope)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStoragePermissionScope(document.RootElement, options);
        }

        internal static StoragePermissionScope DeserializeStoragePermissionScope(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string permissions = default;
            string service = default;
            string resourceName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("permissions"u8))
                {
                    permissions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("service"u8))
                {
                    service = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StoragePermissionScope(permissions, service, resourceName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<StoragePermissionScope>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePermissionScope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(StoragePermissionScope)} does not support writing '{options.Format}' format.");
            }
        }

        StoragePermissionScope IPersistableModel<StoragePermissionScope>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StoragePermissionScope>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStoragePermissionScope(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StoragePermissionScope)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StoragePermissionScope>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
