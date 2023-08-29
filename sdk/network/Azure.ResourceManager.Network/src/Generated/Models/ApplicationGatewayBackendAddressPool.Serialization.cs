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
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ApplicationGatewayBackendAddressPool : IUtf8JsonSerializable, IModelJsonSerializable<ApplicationGatewayBackendAddressPool>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ApplicationGatewayBackendAddressPool>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ApplicationGatewayBackendAddressPool>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ApplicationGatewayBackendAddressPool>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(BackendAddresses))
            {
                writer.WritePropertyName("backendAddresses"u8);
                writer.WriteStartArray();
                foreach (var item in BackendAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
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

        internal static ApplicationGatewayBackendAddressPool DeserializeApplicationGatewayBackendAddressPool(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            Optional<IReadOnlyList<NetworkInterfaceIPConfigurationData>> backendIPConfigurations = default;
            Optional<IList<ApplicationGatewayBackendAddress>> backendAddresses = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
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
                        if (property0.NameEquals("backendIPConfigurations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkInterfaceIPConfigurationData> array = new List<NetworkInterfaceIPConfigurationData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkInterfaceIPConfigurationData.DeserializeNetworkInterfaceIPConfigurationData(item));
                            }
                            backendIPConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("backendAddresses"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationGatewayBackendAddress> array = new List<ApplicationGatewayBackendAddress>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayBackendAddress.DeserializeApplicationGatewayBackendAddress(item));
                            }
                            backendAddresses = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ApplicationGatewayBackendAddressPool(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToList(backendIPConfigurations), Optional.ToList(backendAddresses), Optional.ToNullable(provisioningState), rawData);
        }

        ApplicationGatewayBackendAddressPool IModelJsonSerializable<ApplicationGatewayBackendAddressPool>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ApplicationGatewayBackendAddressPool>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationGatewayBackendAddressPool(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ApplicationGatewayBackendAddressPool>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ApplicationGatewayBackendAddressPool>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ApplicationGatewayBackendAddressPool IModelSerializable<ApplicationGatewayBackendAddressPool>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ApplicationGatewayBackendAddressPool>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeApplicationGatewayBackendAddressPool(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ApplicationGatewayBackendAddressPool model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ApplicationGatewayBackendAddressPool(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeApplicationGatewayBackendAddressPool(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
