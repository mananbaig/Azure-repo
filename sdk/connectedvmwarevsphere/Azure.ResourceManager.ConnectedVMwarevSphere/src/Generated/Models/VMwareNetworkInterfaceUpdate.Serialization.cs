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

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class VMwareNetworkInterfaceUpdate : IUtf8JsonSerializable, IJsonModel<VMwareNetworkInterfaceUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareNetworkInterfaceUpdate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareNetworkInterfaceUpdate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareNetworkInterfaceUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VMwareNetworkInterfaceUpdate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(NetworkId))
            {
                writer.WritePropertyName("networkId"u8);
                writer.WriteStringValue(NetworkId);
            }
            if (Optional.IsDefined(NicType))
            {
                writer.WritePropertyName("nicType"u8);
                writer.WriteStringValue(NicType.Value.ToString());
            }
            if (Optional.IsDefined(PowerOnBoot))
            {
                writer.WritePropertyName("powerOnBoot"u8);
                writer.WriteStringValue(PowerOnBoot.Value.ToString());
            }
            if (Optional.IsDefined(DeviceKey))
            {
                writer.WritePropertyName("deviceKey"u8);
                writer.WriteNumberValue(DeviceKey.Value);
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

        VMwareNetworkInterfaceUpdate IJsonModel<VMwareNetworkInterfaceUpdate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareNetworkInterfaceUpdate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(VMwareNetworkInterfaceUpdate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareNetworkInterfaceUpdate(document.RootElement, options);
        }

        internal static VMwareNetworkInterfaceUpdate DeserializeVMwareNetworkInterfaceUpdate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> networkId = default;
            Optional<VMwareNicType> nicType = default;
            Optional<PowerOnBootOption> powerOnBoot = default;
            Optional<int> deviceKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nicType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nicType = new VMwareNicType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("powerOnBoot"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    powerOnBoot = new PowerOnBootOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deviceKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deviceKey = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareNetworkInterfaceUpdate(name.Value, networkId.Value, Optional.ToNullable(nicType), Optional.ToNullable(powerOnBoot), Optional.ToNullable(deviceKey), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VMwareNetworkInterfaceUpdate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareNetworkInterfaceUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(VMwareNetworkInterfaceUpdate)} does not support '{options.Format}' format.");
            }
        }

        VMwareNetworkInterfaceUpdate IPersistableModel<VMwareNetworkInterfaceUpdate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VMwareNetworkInterfaceUpdate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVMwareNetworkInterfaceUpdate(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(VMwareNetworkInterfaceUpdate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VMwareNetworkInterfaceUpdate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
