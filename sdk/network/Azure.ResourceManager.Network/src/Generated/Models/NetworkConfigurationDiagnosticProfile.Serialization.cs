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
    public partial class NetworkConfigurationDiagnosticProfile : IUtf8JsonSerializable, IModelJsonSerializable<NetworkConfigurationDiagnosticProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetworkConfigurationDiagnosticProfile>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetworkConfigurationDiagnosticProfile>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol"u8);
            writer.WriteStringValue(Protocol);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source);
            writer.WritePropertyName("destination"u8);
            writer.WriteStringValue(Destination);
            writer.WritePropertyName("destinationPort"u8);
            writer.WriteStringValue(DestinationPort);
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

        internal static NetworkConfigurationDiagnosticProfile DeserializeNetworkConfigurationDiagnosticProfile(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            NetworkTrafficDirection direction = default;
            string protocol = default;
            string source = default;
            string destination = default;
            string destinationPort = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("direction"u8))
                {
                    direction = new NetworkTrafficDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    protocol = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"u8))
                {
                    destinationPort = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetworkConfigurationDiagnosticProfile(direction, protocol, source, destination, destinationPort, rawData);
        }

        NetworkConfigurationDiagnosticProfile IModelJsonSerializable<NetworkConfigurationDiagnosticProfile>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkConfigurationDiagnosticProfile(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetworkConfigurationDiagnosticProfile>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetworkConfigurationDiagnosticProfile IModelSerializable<NetworkConfigurationDiagnosticProfile>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetworkConfigurationDiagnosticProfile(doc.RootElement, options);
        }

        public static implicit operator RequestContent(NetworkConfigurationDiagnosticProfile model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator NetworkConfigurationDiagnosticProfile(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetworkConfigurationDiagnosticProfile(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
