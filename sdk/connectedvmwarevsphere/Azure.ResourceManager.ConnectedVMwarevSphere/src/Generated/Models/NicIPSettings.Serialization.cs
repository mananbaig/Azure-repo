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

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    public partial class NicIPSettings : IUtf8JsonSerializable, IModelJsonSerializable<NicIPSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NicIPSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NicIPSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AllocationMethod))
            {
                writer.WritePropertyName("allocationMethod"u8);
                writer.WriteStringValue(AllocationMethod.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Gateway))
            {
                writer.WritePropertyName("gateway"u8);
                writer.WriteStartArray();
                foreach (var item in Gateway)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IPAddress))
            {
                writer.WritePropertyName("ipAddress"u8);
                writer.WriteStringValue(IPAddress);
            }
            if (Optional.IsDefined(SubnetMask))
            {
                writer.WritePropertyName("subnetMask"u8);
                writer.WriteStringValue(SubnetMask);
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

        internal static NicIPSettings DeserializeNicIPSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IPAddressAllocationMethod> allocationMethod = default;
            Optional<IList<string>> dnsServers = default;
            Optional<IList<string>> gateway = default;
            Optional<string> ipAddress = default;
            Optional<string> subnetMask = default;
            Optional<string> primaryWinsServer = default;
            Optional<string> secondaryWinsServer = default;
            Optional<IReadOnlyList<NicIPAddressSettings>> ipAddressInfo = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allocationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationMethod = new IPAddressAllocationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dnsServers"u8))
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
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("gateway"u8))
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
                    gateway = array;
                    continue;
                }
                if (property.NameEquals("ipAddress"u8))
                {
                    ipAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subnetMask"u8))
                {
                    subnetMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryWinsServer"u8))
                {
                    primaryWinsServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryWinsServer"u8))
                {
                    secondaryWinsServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ipAddressInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NicIPAddressSettings> array = new List<NicIPAddressSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicIPAddressSettings.DeserializeNicIPAddressSettings(item));
                    }
                    ipAddressInfo = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NicIPSettings(Optional.ToNullable(allocationMethod), Optional.ToList(dnsServers), Optional.ToList(gateway), ipAddress.Value, subnetMask.Value, primaryWinsServer.Value, secondaryWinsServer.Value, Optional.ToList(ipAddressInfo), rawData);
        }

        NicIPSettings IModelJsonSerializable<NicIPSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNicIPSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NicIPSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NicIPSettings IModelSerializable<NicIPSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNicIPSettings(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NicIPSettings"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NicIPSettings"/> to convert. </param>
        public static implicit operator RequestContent(NicIPSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NicIPSettings"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NicIPSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNicIPSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
