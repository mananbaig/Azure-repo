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
    public partial class BgpPeerStatus : IUtf8JsonSerializable, IModelJsonSerializable<BgpPeerStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BgpPeerStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BgpPeerStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static BgpPeerStatus DeserializeBgpPeerStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> localAddress = default;
            Optional<string> neighbor = default;
            Optional<long> asn = default;
            Optional<BgpPeerState> state = default;
            Optional<TimeSpan> connectedDuration = default;
            Optional<long> routesReceived = default;
            Optional<long> messagesSent = default;
            Optional<long> messagesReceived = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("localAddress"u8))
                {
                    localAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("neighbor"u8))
                {
                    neighbor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("asn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    asn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new BgpPeerState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("connectedDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectedDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("routesReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    routesReceived = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesSent"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messagesSent = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("messagesReceived"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messagesReceived = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BgpPeerStatus(localAddress.Value, neighbor.Value, Optional.ToNullable(asn), Optional.ToNullable(state), Optional.ToNullable(connectedDuration), Optional.ToNullable(routesReceived), Optional.ToNullable(messagesSent), Optional.ToNullable(messagesReceived), rawData);
        }

        BgpPeerStatus IModelJsonSerializable<BgpPeerStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBgpPeerStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BgpPeerStatus>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BgpPeerStatus IModelSerializable<BgpPeerStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBgpPeerStatus(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BgpPeerStatus"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BgpPeerStatus"/> to convert. </param>
        public static implicit operator RequestContent(BgpPeerStatus model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BgpPeerStatus"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BgpPeerStatus(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBgpPeerStatus(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
