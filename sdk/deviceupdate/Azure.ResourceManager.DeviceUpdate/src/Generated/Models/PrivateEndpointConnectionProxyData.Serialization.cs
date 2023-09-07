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
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    public partial class PrivateEndpointConnectionProxyData : IUtf8JsonSerializable, IModelJsonSerializable<PrivateEndpointConnectionProxyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PrivateEndpointConnectionProxyData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PrivateEndpointConnectionProxyData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpointConnectionProxyData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RemotePrivateEndpoint))
            {
                writer.WritePropertyName("remotePrivateEndpoint"u8);
                if (RemotePrivateEndpoint is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RemotePrivateEndpoint>)RemotePrivateEndpoint).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
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

        internal static PrivateEndpointConnectionProxyData DeserializePrivateEndpointConnectionProxyData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> eTag = default;
            Optional<RemotePrivateEndpoint> remotePrivateEndpoint = default;
            Optional<string> status = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<PrivateEndpointConnectionProxyProvisioningState> provisioningState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    eTag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remotePrivateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    remotePrivateEndpoint = RemotePrivateEndpoint.DeserializeRemotePrivateEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PrivateEndpointConnectionProxyProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PrivateEndpointConnectionProxyData(id, name, type, systemData.Value, Optional.ToNullable(provisioningState), eTag.Value, remotePrivateEndpoint.Value, status.Value, serializedAdditionalRawData);
        }

        PrivateEndpointConnectionProxyData IModelJsonSerializable<PrivateEndpointConnectionProxyData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpointConnectionProxyData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePrivateEndpointConnectionProxyData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PrivateEndpointConnectionProxyData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpointConnectionProxyData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PrivateEndpointConnectionProxyData IModelSerializable<PrivateEndpointConnectionProxyData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PrivateEndpointConnectionProxyData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePrivateEndpointConnectionProxyData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PrivateEndpointConnectionProxyData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PrivateEndpointConnectionProxyData"/> to convert. </param>
        public static implicit operator RequestContent(PrivateEndpointConnectionProxyData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PrivateEndpointConnectionProxyData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PrivateEndpointConnectionProxyData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePrivateEndpointConnectionProxyData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
