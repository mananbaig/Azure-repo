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

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceNetworkProfileKubeProxyIPVSConfig : IUtf8JsonSerializable, IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyIPVSConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyIPVSConfig>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Scheduler))
            {
                writer.WritePropertyName("scheduler"u8);
                writer.WriteStringValue(Scheduler.Value.ToString());
            }
            if (Optional.IsDefined(TcpTimeoutSeconds))
            {
                writer.WritePropertyName("tcpTimeoutSeconds"u8);
                writer.WriteNumberValue(TcpTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(TcpFinTimeoutSeconds))
            {
                writer.WritePropertyName("tcpFinTimeoutSeconds"u8);
                writer.WriteNumberValue(TcpFinTimeoutSeconds.Value);
            }
            if (Optional.IsDefined(UdpTimeoutSeconds))
            {
                writer.WritePropertyName("udpTimeoutSeconds"u8);
                writer.WriteNumberValue(UdpTimeoutSeconds.Value);
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

        internal static ContainerServiceNetworkProfileKubeProxyIPVSConfig DeserializeContainerServiceNetworkProfileKubeProxyIPVSConfig(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ContainerServiceNetworkProfileKubeProxyIPVSScheduler> scheduler = default;
            Optional<int> tcpTimeoutSeconds = default;
            Optional<int> tcpFinTimeoutSeconds = default;
            Optional<int> udpTimeoutSeconds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheduler"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduler = new ContainerServiceNetworkProfileKubeProxyIPVSScheduler(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tcpTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcpTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("tcpFinTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tcpFinTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("udpTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    udpTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ContainerServiceNetworkProfileKubeProxyIPVSConfig(Optional.ToNullable(scheduler), Optional.ToNullable(tcpTimeoutSeconds), Optional.ToNullable(tcpFinTimeoutSeconds), Optional.ToNullable(udpTimeoutSeconds), rawData);
        }

        ContainerServiceNetworkProfileKubeProxyIPVSConfig IModelJsonSerializable<ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceNetworkProfileKubeProxyIPVSConfig(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ContainerServiceNetworkProfileKubeProxyIPVSConfig IModelSerializable<ContainerServiceNetworkProfileKubeProxyIPVSConfig>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeContainerServiceNetworkProfileKubeProxyIPVSConfig(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ContainerServiceNetworkProfileKubeProxyIPVSConfig"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ContainerServiceNetworkProfileKubeProxyIPVSConfig"/> to convert. </param>
        public static implicit operator RequestContent(ContainerServiceNetworkProfileKubeProxyIPVSConfig model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ContainerServiceNetworkProfileKubeProxyIPVSConfig"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ContainerServiceNetworkProfileKubeProxyIPVSConfig(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeContainerServiceNetworkProfileKubeProxyIPVSConfig(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
