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
    public partial class DevTestLabImportVmContent : IUtf8JsonSerializable, IJsonModel<DevTestLabImportVmContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabImportVmContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabImportVmContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DevTestLabImportVmContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DevTestLabImportVmContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceVmResourceId))
            {
                writer.WritePropertyName("sourceVirtualMachineResourceId"u8);
                writer.WriteStringValue(SourceVmResourceId);
            }
            if (Optional.IsDefined(DestinationVmName))
            {
                writer.WritePropertyName("destinationVirtualMachineName"u8);
                writer.WriteStringValue(DestinationVmName);
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

        DevTestLabImportVmContent IJsonModel<DevTestLabImportVmContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DevTestLabImportVmContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabImportVmContent(document.RootElement, options);
        }

        internal static DevTestLabImportVmContent DeserializeDevTestLabImportVmContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> sourceVmResourceId = default;
            Optional<string> destinationVmName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceVirtualMachineResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceVmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("destinationVirtualMachineName"u8))
                {
                    destinationVmName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabImportVmContent(sourceVmResourceId.Value, destinationVmName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabImportVmContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DevTestLabImportVmContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DevTestLabImportVmContent IPersistableModel<DevTestLabImportVmContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DevTestLabImportVmContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDevTestLabImportVmContent(document.RootElement, options);
        }

        string IPersistableModel<DevTestLabImportVmContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
