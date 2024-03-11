// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    internal partial class VirtualMachineInstancePropertiesSecurityProfileUefiSettings : IUtf8JsonSerializable, IJsonModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesSecurityProfileUefiSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SecureBootEnabled))
            {
                writer.WritePropertyName("secureBootEnabled"u8);
                writer.WriteBooleanValue(SecureBootEnabled.Value);
            }
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

        VirtualMachineInstancePropertiesSecurityProfileUefiSettings IJsonModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesSecurityProfileUefiSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineInstancePropertiesSecurityProfileUefiSettings(document.RootElement, options);
        }

        internal static VirtualMachineInstancePropertiesSecurityProfileUefiSettings DeserializeVirtualMachineInstancePropertiesSecurityProfileUefiSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? secureBootEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("secureBootEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secureBootEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VirtualMachineInstancePropertiesSecurityProfileUefiSettings(secureBootEnabled, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesSecurityProfileUefiSettings)} does not support '{options.Format}' format.");
            }
        }

        VirtualMachineInstancePropertiesSecurityProfileUefiSettings IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVirtualMachineInstancePropertiesSecurityProfileUefiSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineInstancePropertiesSecurityProfileUefiSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineInstancePropertiesSecurityProfileUefiSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
