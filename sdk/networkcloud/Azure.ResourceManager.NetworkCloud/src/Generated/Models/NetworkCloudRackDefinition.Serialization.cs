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

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudRackDefinition : IUtf8JsonSerializable, IModelJsonSerializable<NetworkCloudRackDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkCloudRackDefinition>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkCloudRackDefinition>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AvailabilityZone))
            {
                writer.WritePropertyName("availabilityZone"u8);
                writer.WriteStringValue(AvailabilityZone);
            }
            if (Optional.IsCollectionDefined(BareMetalMachineConfigurationData))
            {
                writer.WritePropertyName("bareMetalMachineConfigurationData"u8);
                writer.WriteStartArray();
                foreach (var item in BareMetalMachineConfigurationData)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("networkRackId"u8);
            writer.WriteStringValue(NetworkRackId);
            if (Optional.IsDefined(RackLocation))
            {
                writer.WritePropertyName("rackLocation"u8);
                writer.WriteStringValue(RackLocation);
            }
            writer.WritePropertyName("rackSerialNumber"u8);
            writer.WriteStringValue(RackSerialNumber);
            writer.WritePropertyName("rackSkuId"u8);
            writer.WriteStringValue(RackSkuId);
            if (Optional.IsCollectionDefined(StorageApplianceConfigurationData))
            {
                writer.WritePropertyName("storageApplianceConfigurationData"u8);
                writer.WriteStartArray();
                foreach (var item in StorageApplianceConfigurationData)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static NetworkCloudRackDefinition DeserializeNetworkCloudRackDefinition(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> availabilityZone = default;
            Optional<IList<BareMetalMachineConfiguration>> bareMetalMachineConfigurationData = default;
            ResourceIdentifier networkRackId = default;
            Optional<string> rackLocation = default;
            string rackSerialNumber = default;
            ResourceIdentifier rackSkuId = default;
            Optional<IList<StorageApplianceConfiguration>> storageApplianceConfigurationData = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("availabilityZone"u8))
                {
                    availabilityZone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bareMetalMachineConfigurationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BareMetalMachineConfiguration> array = new List<BareMetalMachineConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BareMetalMachineConfiguration.DeserializeBareMetalMachineConfiguration(item));
                    }
                    bareMetalMachineConfigurationData = array;
                    continue;
                }
                if (property.NameEquals("networkRackId"u8))
                {
                    networkRackId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rackLocation"u8))
                {
                    rackLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rackSerialNumber"u8))
                {
                    rackSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rackSkuId"u8))
                {
                    rackSkuId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageApplianceConfigurationData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StorageApplianceConfiguration> array = new List<StorageApplianceConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StorageApplianceConfiguration.DeserializeStorageApplianceConfiguration(item));
                    }
                    storageApplianceConfigurationData = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkCloudRackDefinition(availabilityZone.Value, Optional.ToList(bareMetalMachineConfigurationData), networkRackId, rackLocation.Value, rackSerialNumber, rackSkuId, Optional.ToList(storageApplianceConfigurationData), rawData);
        }

        NetworkCloudRackDefinition IModelJsonSerializable<NetworkCloudRackDefinition>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudRackDefinition(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkCloudRackDefinition>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkCloudRackDefinition IModelSerializable<NetworkCloudRackDefinition>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkCloudRackDefinition(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkCloudRackDefinition model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkCloudRackDefinition(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkCloudRackDefinition(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
