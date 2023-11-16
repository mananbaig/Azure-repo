// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppVolumeReplication : IUtf8JsonSerializable, IJsonModel<NetAppVolumeReplication>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetAppVolumeReplication>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<NetAppVolumeReplication>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetAppVolumeReplication>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetAppVolumeReplication>)} interface");
            }

            writer.WriteStartObject();
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
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        NetAppVolumeReplication IJsonModel<NetAppVolumeReplication>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeReplication)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetAppVolumeReplication(document.RootElement, options);
        }

        internal static NetAppVolumeReplication DeserializeNetAppVolumeReplication(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetAppEndpointType> endpointType = default;
            Optional<NetAppReplicationSchedule> replicationSchedule = default;
            ResourceIdentifier remoteVolumeResourceId = default;
            Optional<string> remoteVolumeRegion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetAppVolumeReplication(Optional.ToNullable(endpointType), Optional.ToNullable(replicationSchedule), remoteVolumeResourceId, remoteVolumeRegion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetAppVolumeReplication>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeReplication)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetAppVolumeReplication IPersistableModel<NetAppVolumeReplication>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetAppVolumeReplication)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetAppVolumeReplication(document.RootElement, options);
        }

        string IPersistableModel<NetAppVolumeReplication>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
