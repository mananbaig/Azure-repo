// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeDeviceData : IUtf8JsonSerializable, IJsonModel<DataBoxEdgeDeviceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxEdgeDeviceData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxEdgeDeviceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku, options);
            }
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (options.Format != "W" && Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(DataBoxEdgeDeviceStatus))
            {
                writer.WritePropertyName("dataBoxEdgeDeviceStatus"u8);
                writer.WriteStringValue(DataBoxEdgeDeviceStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(SerialNumber))
            {
                writer.WritePropertyName("serialNumber"u8);
                writer.WriteStringValue(SerialNumber);
            }
            if (options.Format != "W" && Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && Optional.IsDefined(ModelDescription))
            {
                writer.WritePropertyName("modelDescription"u8);
                writer.WriteStringValue(ModelDescription);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceType))
            {
                writer.WritePropertyName("deviceType"u8);
                writer.WriteStringValue(DeviceType.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (options.Format != "W" && Optional.IsDefined(Culture))
            {
                writer.WritePropertyName("culture"u8);
                writer.WriteStringValue(Culture);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceModel))
            {
                writer.WritePropertyName("deviceModel"u8);
                writer.WriteStringValue(DeviceModel);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceSoftwareVersion))
            {
                writer.WritePropertyName("deviceSoftwareVersion"u8);
                writer.WriteStringValue(DeviceSoftwareVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceLocalCapacity))
            {
                writer.WritePropertyName("deviceLocalCapacity"u8);
                writer.WriteNumberValue(DeviceLocalCapacity.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(TimeZone))
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (options.Format != "W" && Optional.IsDefined(DeviceHcsVersion))
            {
                writer.WritePropertyName("deviceHcsVersion"u8);
                writer.WriteStringValue(DeviceHcsVersion);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ConfiguredRoleTypes))
            {
                writer.WritePropertyName("configuredRoleTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ConfiguredRoleTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(NodeCount))
            {
                writer.WritePropertyName("nodeCount"u8);
                writer.WriteNumberValue(NodeCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(ResourceMoveDetails))
            {
                writer.WritePropertyName("resourceMoveDetails"u8);
                writer.WriteObjectValue(ResourceMoveDetails, options);
            }
            if (options.Format != "W" && Optional.IsDefined(EdgeProfile))
            {
                writer.WritePropertyName("edgeProfile"u8);
                writer.WriteObjectValue(EdgeProfile, options);
            }
            if (Optional.IsDefined(DataResidency))
            {
                writer.WritePropertyName("dataResidency"u8);
                writer.WriteObjectValue(DataResidency, options);
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

        DataBoxEdgeDeviceData IJsonModel<DataBoxEdgeDeviceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxEdgeDeviceData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeDeviceData(document.RootElement, options);
        }

        internal static DataBoxEdgeDeviceData DeserializeDataBoxEdgeDeviceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeSku sku = default;
            ETag? etag = default;
            ManagedServiceIdentity identity = default;
            DataBoxEdgeDeviceKind? kind = default;
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            DataBoxEdgeDeviceStatus? dataBoxEdgeDeviceStatus = default;
            string serialNumber = default;
            string description = default;
            string modelDescription = default;
            DataBoxEdgeDeviceType? deviceType = default;
            string friendlyName = default;
            string culture = default;
            string deviceModel = default;
            string deviceSoftwareVersion = default;
            long? deviceLocalCapacity = default;
            string timeZone = default;
            string deviceHcsVersion = default;
            IReadOnlyList<DataBoxEdgeRoleType> configuredRoleTypes = default;
            int? nodeCount = default;
            DataBoxEdgeResourceMoveDetails resourceMoveDetails = default;
            EdgeProfile edgeProfile = default;
            DataResidency dataResidency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = DataBoxEdgeSku.DeserializeDataBoxEdgeSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new DataBoxEdgeDeviceKind(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("dataBoxEdgeDeviceStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataBoxEdgeDeviceStatus = new DataBoxEdgeDeviceStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("modelDescription"u8))
                        {
                            modelDescription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deviceType = new DataBoxEdgeDeviceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("culture"u8))
                        {
                            culture = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceModel"u8))
                        {
                            deviceModel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceSoftwareVersion"u8))
                        {
                            deviceSoftwareVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceLocalCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deviceLocalCapacity = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deviceHcsVersion"u8))
                        {
                            deviceHcsVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("configuredRoleTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeRoleType> array = new List<DataBoxEdgeRoleType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DataBoxEdgeRoleType(item.GetString()));
                            }
                            configuredRoleTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("nodeCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            nodeCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("resourceMoveDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceMoveDetails = DataBoxEdgeResourceMoveDetails.DeserializeDataBoxEdgeResourceMoveDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("edgeProfile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            edgeProfile = EdgeProfile.DeserializeEdgeProfile(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dataResidency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataResidency = DataResidency.DeserializeDataResidency(property0.Value, options);
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
            return new DataBoxEdgeDeviceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                sku,
                etag,
                identity,
                kind,
                dataBoxEdgeDeviceStatus,
                serialNumber,
                description,
                modelDescription,
                deviceType,
                friendlyName,
                culture,
                deviceModel,
                deviceSoftwareVersion,
                deviceLocalCapacity,
                timeZone,
                deviceHcsVersion,
                configuredRoleTypes ?? new ChangeTrackingList<DataBoxEdgeRoleType>(),
                nodeCount,
                resourceMoveDetails,
                edgeProfile,
                dataResidency,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxEdgeDeviceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceData)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxEdgeDeviceData IPersistableModel<DataBoxEdgeDeviceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxEdgeDeviceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxEdgeDeviceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxEdgeDeviceData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxEdgeDeviceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
