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
    public partial class NetworkPrivateLinkServiceConnection : IUtf8JsonSerializable, IModelJsonSerializable<NetworkPrivateLinkServiceConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkPrivateLinkServiceConnection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkPrivateLinkServiceConnection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkPrivateLinkServiceConnection>(this, options.Format);

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
            if (Optional.IsDefined(PrivateLinkServiceId))
            {
                writer.WritePropertyName("privateLinkServiceId"u8);
                writer.WriteStringValue(PrivateLinkServiceId);
            }
            if (Optional.IsCollectionDefined(GroupIds))
            {
                writer.WritePropertyName("groupIds"u8);
                writer.WriteStartArray();
                foreach (var item in GroupIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RequestMessage))
            {
                writer.WritePropertyName("requestMessage"u8);
                writer.WriteStringValue(RequestMessage);
            }
            if (Optional.IsDefined(ConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                if (ConnectionState is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NetworkPrivateLinkServiceConnectionState>)ConnectionState).Serialize(writer, options);
                }
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

        internal static NetworkPrivateLinkServiceConnection DeserializeNetworkPrivateLinkServiceConnection(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<NetworkProvisioningState> provisioningState = default;
            Optional<ResourceIdentifier> privateLinkServiceId = default;
            Optional<IList<string>> groupIds = default;
            Optional<string> requestMessage = default;
            Optional<NetworkPrivateLinkServiceConnectionState> privateLinkServiceConnectionState = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("groupIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            groupIds = array;
                            continue;
                        }
                        if (property0.NameEquals("requestMessage"u8))
                        {
                            requestMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateLinkServiceConnectionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            privateLinkServiceConnectionState = NetworkPrivateLinkServiceConnectionState.DeserializeNetworkPrivateLinkServiceConnectionState(property0.Value);
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
            return new NetworkPrivateLinkServiceConnection(id.Value, name.Value, Optional.ToNullable(type), Optional.ToNullable(etag), Optional.ToNullable(provisioningState), privateLinkServiceId.Value, Optional.ToList(groupIds), requestMessage.Value, privateLinkServiceConnectionState.Value, rawData);
        }

        NetworkPrivateLinkServiceConnection IModelJsonSerializable<NetworkPrivateLinkServiceConnection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkPrivateLinkServiceConnection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkPrivateLinkServiceConnection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkPrivateLinkServiceConnection>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkPrivateLinkServiceConnection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkPrivateLinkServiceConnection IModelSerializable<NetworkPrivateLinkServiceConnection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkPrivateLinkServiceConnection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkPrivateLinkServiceConnection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetworkPrivateLinkServiceConnection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetworkPrivateLinkServiceConnection"/> to convert. </param>
        public static implicit operator RequestContent(NetworkPrivateLinkServiceConnection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetworkPrivateLinkServiceConnection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetworkPrivateLinkServiceConnection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkPrivateLinkServiceConnection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
