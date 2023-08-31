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

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class NetworkFabricL3IsolationDomainPatch : IUtf8JsonSerializable, IModelJsonSerializable<NetworkFabricL3IsolationDomainPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkFabricL3IsolationDomainPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkFabricL3IsolationDomainPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricL3IsolationDomainPatch>(this, options.Format);

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
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            if (Optional.IsDefined(RedistributeConnectedSubnets))
            {
                writer.WritePropertyName("redistributeConnectedSubnets"u8);
                writer.WriteStringValue(RedistributeConnectedSubnets.Value.ToString());
            }
            if (Optional.IsDefined(RedistributeStaticRoutes))
            {
                writer.WritePropertyName("redistributeStaticRoutes"u8);
                writer.WriteStringValue(RedistributeStaticRoutes.Value.ToString());
            }
            if (Optional.IsDefined(AggregateRouteConfiguration))
            {
                writer.WritePropertyName("aggregateRouteConfiguration"u8);
                writer.WriteObjectValue(AggregateRouteConfiguration);
            }
            if (Optional.IsDefined(ConnectedSubnetRoutePolicy))
            {
                writer.WritePropertyName("connectedSubnetRoutePolicy"u8);
                writer.WriteObjectValue(ConnectedSubnetRoutePolicy);
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

        internal static NetworkFabricL3IsolationDomainPatch DeserializeNetworkFabricL3IsolationDomainPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> annotation = default;
            Optional<RedistributeConnectedSubnet> redistributeConnectedSubnets = default;
            Optional<RedistributeStaticRoute> redistributeStaticRoutes = default;
            Optional<AggregateRouteConfiguration> aggregateRouteConfiguration = default;
            Optional<ConnectedSubnetRoutePolicy> connectedSubnetRoutePolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("redistributeConnectedSubnets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redistributeConnectedSubnets = new RedistributeConnectedSubnet(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("redistributeStaticRoutes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            redistributeStaticRoutes = new RedistributeStaticRoute(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aggregateRouteConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregateRouteConfiguration = AggregateRouteConfiguration.DeserializeAggregateRouteConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("connectedSubnetRoutePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectedSubnetRoutePolicy = ConnectedSubnetRoutePolicy.DeserializeConnectedSubnetRoutePolicy(property0.Value);
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
            return new NetworkFabricL3IsolationDomainPatch(Optional.ToDictionary(tags), annotation.Value, Optional.ToNullable(redistributeConnectedSubnets), Optional.ToNullable(redistributeStaticRoutes), aggregateRouteConfiguration.Value, connectedSubnetRoutePolicy.Value, rawData);
        }

        NetworkFabricL3IsolationDomainPatch IModelJsonSerializable<NetworkFabricL3IsolationDomainPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricL3IsolationDomainPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricL3IsolationDomainPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkFabricL3IsolationDomainPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricL3IsolationDomainPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkFabricL3IsolationDomainPatch IModelSerializable<NetworkFabricL3IsolationDomainPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<NetworkFabricL3IsolationDomainPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkFabricL3IsolationDomainPatch(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkFabricL3IsolationDomainPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkFabricL3IsolationDomainPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkFabricL3IsolationDomainPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
