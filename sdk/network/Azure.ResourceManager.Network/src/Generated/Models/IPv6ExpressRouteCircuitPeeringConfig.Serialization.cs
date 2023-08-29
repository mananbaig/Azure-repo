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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IPv6ExpressRouteCircuitPeeringConfig : IUtf8JsonSerializable, IModelJsonSerializable<IPv6ExpressRouteCircuitPeeringConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IPv6ExpressRouteCircuitPeeringConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IPv6ExpressRouteCircuitPeeringConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrimaryPeerAddressPrefix))
            {
                writer.WritePropertyName("primaryPeerAddressPrefix"u8);
                writer.WriteStringValue(PrimaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(SecondaryPeerAddressPrefix))
            {
                writer.WritePropertyName("secondaryPeerAddressPrefix"u8);
                writer.WriteStringValue(SecondaryPeerAddressPrefix);
            }
            if (Optional.IsDefined(MicrosoftPeeringConfig))
            {
                writer.WritePropertyName("microsoftPeeringConfig"u8);
                writer.WriteObjectValue(MicrosoftPeeringConfig);
            }
            if (Optional.IsDefined(RouteFilter))
            {
                writer.WritePropertyName("routeFilter"u8);
                JsonSerializer.Serialize(writer, RouteFilter);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        internal static IPv6ExpressRouteCircuitPeeringConfig DeserializeIPv6ExpressRouteCircuitPeeringConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryPeerAddressPrefix = default;
            Optional<string> secondaryPeerAddressPrefix = default;
            Optional<ExpressRouteCircuitPeeringConfig> microsoftPeeringConfig = default;
            Optional<WritableSubResource> routeFilter = default;
            Optional<ExpressRouteCircuitPeeringState> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryPeerAddressPrefix"u8))
                {
                    primaryPeerAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryPeerAddressPrefix"u8))
                {
                    secondaryPeerAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("microsoftPeeringConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftPeeringConfig = ExpressRouteCircuitPeeringConfig.DeserializeExpressRouteCircuitPeeringConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("routeFilter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routeFilter = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ExpressRouteCircuitPeeringState(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IPv6ExpressRouteCircuitPeeringConfig(primaryPeerAddressPrefix.Value, secondaryPeerAddressPrefix.Value, microsoftPeeringConfig.Value, routeFilter, Optional.ToNullable(state), rawData);
        }

        IPv6ExpressRouteCircuitPeeringConfig IModelJsonSerializable<IPv6ExpressRouteCircuitPeeringConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIPv6ExpressRouteCircuitPeeringConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IPv6ExpressRouteCircuitPeeringConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IPv6ExpressRouteCircuitPeeringConfig IModelSerializable<IPv6ExpressRouteCircuitPeeringConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIPv6ExpressRouteCircuitPeeringConfig(doc.RootElement, options);
        }

        public static implicit operator RequestContent(IPv6ExpressRouteCircuitPeeringConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator IPv6ExpressRouteCircuitPeeringConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIPv6ExpressRouteCircuitPeeringConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
