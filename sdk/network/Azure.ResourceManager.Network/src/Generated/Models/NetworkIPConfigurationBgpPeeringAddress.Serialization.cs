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

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkIPConfigurationBgpPeeringAddress : IUtf8JsonSerializable, IModelJsonSerializable<NetworkIPConfigurationBgpPeeringAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkIPConfigurationBgpPeeringAddress>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkIPConfigurationBgpPeeringAddress>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(IPConfigurationId))
            {
                writer.WritePropertyName("ipconfigurationId"u8);
                writer.WriteStringValue(IPConfigurationId);
            }
            if (Optional.IsCollectionDefined(CustomBgpIPAddresses))
            {
                writer.WritePropertyName("customBgpIpAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in CustomBgpIPAddresses)
                {
                    writer.WriteStringValue(item);
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

        internal static NetworkIPConfigurationBgpPeeringAddress DeserializeNetworkIPConfigurationBgpPeeringAddress(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ipconfigurationId = default;
            Optional<IReadOnlyList<string>> defaultBgpIPAddresses = default;
            Optional<IList<string>> customBgpIPAddresses = default;
            Optional<IReadOnlyList<string>> tunnelIPAddresses = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipconfigurationId"u8))
                {
                    ipconfigurationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("defaultBgpIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    defaultBgpIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("customBgpIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    customBgpIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("tunnelIpAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    tunnelIPAddresses = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkIPConfigurationBgpPeeringAddress(ipconfigurationId.Value, Optional.ToList(defaultBgpIPAddresses), Optional.ToList(customBgpIPAddresses), Optional.ToList(tunnelIPAddresses), rawData);
        }

        NetworkIPConfigurationBgpPeeringAddress IModelJsonSerializable<NetworkIPConfigurationBgpPeeringAddress>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkIPConfigurationBgpPeeringAddress(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkIPConfigurationBgpPeeringAddress>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkIPConfigurationBgpPeeringAddress IModelSerializable<NetworkIPConfigurationBgpPeeringAddress>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkIPConfigurationBgpPeeringAddress(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkIPConfigurationBgpPeeringAddress model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkIPConfigurationBgpPeeringAddress(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkIPConfigurationBgpPeeringAddress(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
