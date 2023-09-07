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
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseReplicationLinkData : IUtf8JsonSerializable, IModelJsonSerializable<SynapseReplicationLinkData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseReplicationLinkData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseReplicationLinkData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseReplicationLinkData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
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

        internal static SynapseReplicationLinkData DeserializeSynapseReplicationLinkData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<bool> isTerminationAllowed = default;
            Optional<string> replicationMode = default;
            Optional<string> partnerServer = default;
            Optional<string> partnerDatabase = default;
            Optional<AzureLocation> partnerLocation = default;
            Optional<SynapseReplicationRole> role = default;
            Optional<SynapseReplicationRole> partnerRole = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<int> percentComplete = default;
            Optional<SynapseReplicationState> replicationState = default;
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
                        if (property0.NameEquals("isTerminationAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isTerminationAllowed = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("replicationMode"u8))
                        {
                            replicationMode = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerServer"u8))
                        {
                            partnerServer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerDatabase"u8))
                        {
                            partnerDatabase = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partnerLocation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerLocation = new AzureLocation(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = property0.Value.GetString().ToSynapseReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("partnerRole"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRole = property0.Value.GetString().ToSynapseReplicationRole();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("replicationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            replicationState = new SynapseReplicationState(property0.Value.GetString());
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
            return new SynapseReplicationLinkData(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(isTerminationAllowed), replicationMode.Value, partnerServer.Value, partnerDatabase.Value, Optional.ToNullable(partnerLocation), Optional.ToNullable(role), Optional.ToNullable(partnerRole), Optional.ToNullable(startTime), Optional.ToNullable(percentComplete), Optional.ToNullable(replicationState), serializedAdditionalRawData);
        }

        SynapseReplicationLinkData IModelJsonSerializable<SynapseReplicationLinkData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseReplicationLinkData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseReplicationLinkData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseReplicationLinkData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseReplicationLinkData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseReplicationLinkData IModelSerializable<SynapseReplicationLinkData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseReplicationLinkData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseReplicationLinkData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseReplicationLinkData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseReplicationLinkData"/> to convert. </param>
        public static implicit operator RequestContent(SynapseReplicationLinkData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseReplicationLinkData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseReplicationLinkData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseReplicationLinkData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
