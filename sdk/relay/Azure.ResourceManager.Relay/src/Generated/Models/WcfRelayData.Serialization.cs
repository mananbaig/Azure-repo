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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Relay.Models;

namespace Azure.ResourceManager.Relay
{
    public partial class WcfRelayData : IUtf8JsonSerializable, IModelJsonSerializable<WcfRelayData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WcfRelayData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WcfRelayData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WcfRelayData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(RelayType))
            {
                writer.WritePropertyName("relayType"u8);
                writer.WriteStringValue(RelayType.Value.ToSerialString());
            }
            if (Optional.IsDefined(IsClientAuthorizationRequired))
            {
                writer.WritePropertyName("requiresClientAuthorization"u8);
                writer.WriteBooleanValue(IsClientAuthorizationRequired.Value);
            }
            if (Optional.IsDefined(IsTransportSecurityRequired))
            {
                writer.WritePropertyName("requiresTransportSecurity"u8);
                writer.WriteBooleanValue(IsTransportSecurityRequired.Value);
            }
            if (Optional.IsDefined(UserMetadata))
            {
                writer.WritePropertyName("userMetadata"u8);
                writer.WriteStringValue(UserMetadata);
            }
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

        internal static WcfRelayData DeserializeWcfRelayData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isDynamic = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<int> listenerCount = default;
            Optional<RelayType> relayType = default;
            Optional<bool> requiresClientAuthorization = default;
            Optional<bool> requiresTransportSecurity = default;
            Optional<string> userMetadata = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("isDynamic"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDynamic = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("listenerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            listenerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("relayType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            relayType = property0.Value.GetString().ToRelayType();
                            continue;
                        }
                        if (property0.NameEquals("requiresClientAuthorization"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requiresClientAuthorization = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("requiresTransportSecurity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requiresTransportSecurity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("userMetadata"u8))
                        {
                            userMetadata = property0.Value.GetString();
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
            return new WcfRelayData(id, name, type, systemData.Value, Optional.ToNullable(isDynamic), Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), Optional.ToNullable(listenerCount), Optional.ToNullable(relayType), Optional.ToNullable(requiresClientAuthorization), Optional.ToNullable(requiresTransportSecurity), userMetadata.Value, Optional.ToNullable(location), serializedAdditionalRawData);
        }

        WcfRelayData IModelJsonSerializable<WcfRelayData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WcfRelayData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWcfRelayData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WcfRelayData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WcfRelayData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WcfRelayData IModelSerializable<WcfRelayData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WcfRelayData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWcfRelayData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WcfRelayData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WcfRelayData"/> to convert. </param>
        public static implicit operator RequestContent(WcfRelayData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WcfRelayData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WcfRelayData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWcfRelayData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
