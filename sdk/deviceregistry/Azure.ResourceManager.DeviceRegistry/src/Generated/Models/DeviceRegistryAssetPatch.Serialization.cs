// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceRegistry.Models
{
    public partial class DeviceRegistryAssetPatch : IUtf8JsonSerializable, IJsonModel<DeviceRegistryAssetPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceRegistryAssetPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeviceRegistryAssetPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryAssetPatch)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AssetType))
            {
                writer.WritePropertyName("assetType"u8);
                writer.WriteStringValue(AssetType);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Manufacturer))
            {
                writer.WritePropertyName("manufacturer"u8);
                writer.WriteStringValue(Manufacturer);
            }
            if (Optional.IsDefined(ManufacturerUri))
            {
                writer.WritePropertyName("manufacturerUri"u8);
                writer.WriteStringValue(ManufacturerUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Model))
            {
                writer.WritePropertyName("model"u8);
                writer.WriteStringValue(Model);
            }
            if (Optional.IsDefined(ProductCode))
            {
                writer.WritePropertyName("productCode"u8);
                writer.WriteStringValue(ProductCode);
            }
            if (Optional.IsDefined(HardwareRevision))
            {
                writer.WritePropertyName("hardwareRevision"u8);
                writer.WriteStringValue(HardwareRevision);
            }
            if (Optional.IsDefined(SoftwareRevision))
            {
                writer.WritePropertyName("softwareRevision"u8);
                writer.WriteStringValue(SoftwareRevision);
            }
            if (Optional.IsDefined(DocumentationUri))
            {
                writer.WritePropertyName("documentationUri"u8);
                writer.WriteStringValue(DocumentationUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (Optional.IsCollectionDefined(Attributes))
            {
                writer.WritePropertyName("attributes"u8);
                writer.WriteStartObject();
                foreach (var item in Attributes)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(DefaultDataPointsConfiguration))
            {
                writer.WritePropertyName("defaultDataPointsConfiguration"u8);
                writer.WriteStringValue(DefaultDataPointsConfiguration);
            }
            if (Optional.IsDefined(DefaultEventsConfiguration))
            {
                writer.WritePropertyName("defaultEventsConfiguration"u8);
                writer.WriteStringValue(DefaultEventsConfiguration);
            }
            if (Optional.IsCollectionDefined(DataPoints))
            {
                writer.WritePropertyName("dataPoints"u8);
                writer.WriteStartArray();
                foreach (var item in DataPoints)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Events))
            {
                writer.WritePropertyName("events"u8);
                writer.WriteStartArray();
                foreach (var item in Events)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        DeviceRegistryAssetPatch IJsonModel<DeviceRegistryAssetPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceRegistryAssetPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceRegistryAssetPatch(document.RootElement, options);
        }

        internal static DeviceRegistryAssetPatch DeserializeDeviceRegistryAssetPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            string assetType = default;
            bool? enabled = default;
            string displayName = default;
            string description = default;
            string manufacturer = default;
            Uri manufacturerUri = default;
            string model = default;
            string productCode = default;
            string hardwareRevision = default;
            string softwareRevision = default;
            Uri documentationUri = default;
            string serialNumber = default;
            IDictionary<string, BinaryData> attributes = default;
            string defaultDataPointsConfiguration = default;
            string defaultEventsConfiguration = default;
            IList<DataPoint> dataPoints = default;
            IList<AssetEvent> events = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("assetType"u8))
                        {
                            assetType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("manufacturer"u8))
                        {
                            manufacturer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("manufacturerUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            manufacturerUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("model"u8))
                        {
                            model = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("productCode"u8))
                        {
                            productCode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hardwareRevision"u8))
                        {
                            hardwareRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("softwareRevision"u8))
                        {
                            softwareRevision = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("documentationUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            documentationUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("attributes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            attributes = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("defaultDataPointsConfiguration"u8))
                        {
                            defaultDataPointsConfiguration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defaultEventsConfiguration"u8))
                        {
                            defaultEventsConfiguration = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dataPoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataPoint> array = new List<DataPoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataPoint.DeserializeDataPoint(item, options));
                            }
                            dataPoints = array;
                            continue;
                        }
                        if (property0.NameEquals("events"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AssetEvent> array = new List<AssetEvent>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AssetEvent.DeserializeAssetEvent(item, options));
                            }
                            events = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeviceRegistryAssetPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                assetType,
                enabled,
                displayName,
                description,
                manufacturer,
                manufacturerUri,
                model,
                productCode,
                hardwareRevision,
                softwareRevision,
                documentationUri,
                serialNumber,
                attributes ?? new ChangeTrackingDictionary<string, BinaryData>(),
                defaultDataPointsConfiguration,
                defaultEventsConfiguration,
                dataPoints ?? new ChangeTrackingList<DataPoint>(),
                events ?? new ChangeTrackingList<AssetEvent>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceRegistryAssetPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryAssetPatch)} does not support writing '{options.Format}' format.");
            }
        }

        DeviceRegistryAssetPatch IPersistableModel<DeviceRegistryAssetPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceRegistryAssetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceRegistryAssetPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceRegistryAssetPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceRegistryAssetPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
