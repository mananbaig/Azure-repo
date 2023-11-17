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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class AttachNewDataDiskDetails : IUtf8JsonSerializable, IJsonModel<AttachNewDataDiskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AttachNewDataDiskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AttachNewDataDiskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AttachNewDataDiskDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AttachNewDataDiskDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DiskSizeGiB))
            {
                writer.WritePropertyName("diskSizeGiB"u8);
                writer.WriteNumberValue(DiskSizeGiB.Value);
            }
            if (Optional.IsDefined(DiskName))
            {
                writer.WritePropertyName("diskName"u8);
                writer.WriteStringValue(DiskName);
            }
            if (Optional.IsDefined(DiskType))
            {
                writer.WritePropertyName("diskType"u8);
                writer.WriteStringValue(DiskType.Value.ToString());
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        AttachNewDataDiskDetails IJsonModel<AttachNewDataDiskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AttachNewDataDiskDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAttachNewDataDiskDetails(document.RootElement, options);
        }

        internal static AttachNewDataDiskDetails DeserializeAttachNewDataDiskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> diskSizeGiB = default;
            Optional<string> diskName = default;
            Optional<DevTestLabStorageType> diskType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSizeGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskSizeGiB = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("diskName"u8))
                {
                    diskName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("diskType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    diskType = new DevTestLabStorageType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AttachNewDataDiskDetails(Optional.ToNullable(diskSizeGiB), diskName.Value, Optional.ToNullable(diskType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AttachNewDataDiskDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AttachNewDataDiskDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AttachNewDataDiskDetails IPersistableModel<AttachNewDataDiskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AttachNewDataDiskDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAttachNewDataDiskDetails(document.RootElement, options);
        }

        string IPersistableModel<AttachNewDataDiskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
