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
    public partial class VirtualWanVpnProfileContent : IUtf8JsonSerializable, IModelJsonSerializable<VirtualWanVpnProfileContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VirtualWanVpnProfileContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VirtualWanVpnProfileContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VpnServerConfigurationResourceId))
            {
                writer.WritePropertyName("vpnServerConfigurationResourceId"u8);
                writer.WriteStringValue(VpnServerConfigurationResourceId);
            }
            if (Optional.IsDefined(AuthenticationMethod))
            {
                writer.WritePropertyName("authenticationMethod"u8);
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
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

        internal static VirtualWanVpnProfileContent DeserializeVirtualWanVpnProfileContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> vpnServerConfigurationResourceId = default;
            Optional<NetworkAuthenticationMethod> authenticationMethod = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vpnServerConfigurationResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vpnServerConfigurationResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authenticationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMethod = new NetworkAuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VirtualWanVpnProfileContent(vpnServerConfigurationResourceId.Value, Optional.ToNullable(authenticationMethod), rawData);
        }

        VirtualWanVpnProfileContent IModelJsonSerializable<VirtualWanVpnProfileContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualWanVpnProfileContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VirtualWanVpnProfileContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VirtualWanVpnProfileContent IModelSerializable<VirtualWanVpnProfileContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVirtualWanVpnProfileContent(doc.RootElement, options);
        }

        public static implicit operator RequestContent(VirtualWanVpnProfileContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator VirtualWanVpnProfileContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVirtualWanVpnProfileContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
