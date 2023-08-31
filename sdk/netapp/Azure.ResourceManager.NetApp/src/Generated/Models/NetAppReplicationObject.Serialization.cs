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

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppReplicationObject : IUtf8JsonSerializable, IModelJsonSerializable<NetAppReplicationObject>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NetAppReplicationObject>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NetAppReplicationObject>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ReplicationId))
            {
                writer.WritePropertyName("replicationId"u8);
                writer.WriteStringValue(ReplicationId);
            }
            if (Optional.IsDefined(EndpointType))
            {
                writer.WritePropertyName("endpointType"u8);
                writer.WriteStringValue(EndpointType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationSchedule))
            {
                writer.WritePropertyName("replicationSchedule"u8);
                writer.WriteStringValue(ReplicationSchedule.Value.ToString());
            }
            writer.WritePropertyName("remoteVolumeResourceId"u8);
            writer.WriteStringValue(RemoteVolumeResourceId);
            if (Optional.IsDefined(RemoteVolumeRegion))
            {
                writer.WritePropertyName("remoteVolumeRegion"u8);
                writer.WriteStringValue(RemoteVolumeRegion);
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

        internal static NetAppReplicationObject DeserializeNetAppReplicationObject(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> replicationId = default;
            Optional<NetAppEndpointType> endpointType = default;
            Optional<NetAppReplicationSchedule> replicationSchedule = default;
            ResourceIdentifier remoteVolumeResourceId = default;
            Optional<string> remoteVolumeRegion = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("replicationId"u8))
                {
                    replicationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endpointType = new NetAppEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationSchedule"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationSchedule = new NetAppReplicationSchedule(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeResourceId"u8))
                {
                    remoteVolumeResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("remoteVolumeRegion"u8))
                {
                    remoteVolumeRegion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new NetAppReplicationObject(replicationId.Value, Optional.ToNullable(endpointType), Optional.ToNullable(replicationSchedule), remoteVolumeResourceId, remoteVolumeRegion.Value, rawData);
        }

        NetAppReplicationObject IModelJsonSerializable<NetAppReplicationObject>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppReplicationObject(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NetAppReplicationObject>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NetAppReplicationObject IModelSerializable<NetAppReplicationObject>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNetAppReplicationObject(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NetAppReplicationObject"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NetAppReplicationObject"/> to convert. </param>
        public static implicit operator RequestContent(NetAppReplicationObject model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NetAppReplicationObject"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NetAppReplicationObject(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNetAppReplicationObject(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
