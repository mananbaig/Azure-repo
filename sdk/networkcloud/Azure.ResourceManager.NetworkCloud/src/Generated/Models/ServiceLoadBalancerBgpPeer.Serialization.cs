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
    public partial class ServiceLoadBalancerBgpPeer : IUtf8JsonSerializable, IModelJsonSerializable<ServiceLoadBalancerBgpPeer>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceLoadBalancerBgpPeer>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceLoadBalancerBgpPeer>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(BfdEnabled))
            {
                writer.WritePropertyName("bfdEnabled"u8);
                writer.WriteStringValue(BfdEnabled.Value.ToString());
            }
            if (Optional.IsDefined(BgpMultiHop))
            {
                writer.WritePropertyName("bgpMultiHop"u8);
                writer.WriteStringValue(BgpMultiHop.Value.ToString());
            }
            if (Optional.IsDefined(HoldTime))
            {
                writer.WritePropertyName("holdTime"u8);
                writer.WriteStringValue(HoldTime);
            }
            if (Optional.IsDefined(KeepAliveTime))
            {
                writer.WritePropertyName("keepAliveTime"u8);
                writer.WriteStringValue(KeepAliveTime);
            }
            if (Optional.IsDefined(MyAsn))
            {
                writer.WritePropertyName("myAsn"u8);
                writer.WriteNumberValue(MyAsn.Value);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Password))
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            writer.WritePropertyName("peerAddress"u8);
            writer.WriteStringValue(PeerAddress);
            writer.WritePropertyName("peerAsn"u8);
            writer.WriteNumberValue(PeerAsn);
            if (Optional.IsDefined(PeerPort))
            {
                writer.WritePropertyName("peerPort"u8);
                writer.WriteNumberValue(PeerPort.Value);
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

        internal static ServiceLoadBalancerBgpPeer DeserializeServiceLoadBalancerBgpPeer(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BfdEnabled> bfdEnabled = default;
            Optional<BgpMultiHop> bgpMultiHop = default;
            Optional<string> holdTime = default;
            Optional<string> keepAliveTime = default;
            Optional<long> myAsn = default;
            string name = default;
            Optional<string> password = default;
            string peerAddress = default;
            long peerAsn = default;
            Optional<long> peerPort = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bfdEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bfdEnabled = new BfdEnabled(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("bgpMultiHop"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bgpMultiHop = new BgpMultiHop(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("holdTime"u8))
                {
                    holdTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keepAliveTime"u8))
                {
                    keepAliveTime = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("myAsn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    myAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerAddress"u8))
                {
                    peerAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peerAsn"u8))
                {
                    peerAsn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("peerPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peerPort = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceLoadBalancerBgpPeer(Optional.ToNullable(bfdEnabled), Optional.ToNullable(bgpMultiHop), holdTime.Value, keepAliveTime.Value, Optional.ToNullable(myAsn), name, password.Value, peerAddress, peerAsn, Optional.ToNullable(peerPort), rawData);
        }

        ServiceLoadBalancerBgpPeer IModelJsonSerializable<ServiceLoadBalancerBgpPeer>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceLoadBalancerBgpPeer(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceLoadBalancerBgpPeer>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceLoadBalancerBgpPeer IModelSerializable<ServiceLoadBalancerBgpPeer>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceLoadBalancerBgpPeer(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ServiceLoadBalancerBgpPeer model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ServiceLoadBalancerBgpPeer(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceLoadBalancerBgpPeer(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
