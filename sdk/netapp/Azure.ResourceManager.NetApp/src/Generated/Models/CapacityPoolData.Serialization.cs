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
using Azure.ResourceManager.NetApp.Models;

namespace Azure.ResourceManager.NetApp
{
    public partial class CapacityPoolData : IUtf8JsonSerializable, IModelJsonSerializable<CapacityPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CapacityPoolData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CapacityPoolData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("size"u8);
            writer.WriteNumberValue(Size);
            writer.WritePropertyName("serviceLevel"u8);
            writer.WriteStringValue(ServiceLevel.ToString());
            if (Optional.IsDefined(QosType))
            {
                writer.WritePropertyName("qosType"u8);
                writer.WriteStringValue(QosType.Value.ToString());
            }
            if (Optional.IsDefined(IsCoolAccessEnabled))
            {
                writer.WritePropertyName("coolAccess"u8);
                writer.WriteBooleanValue(IsCoolAccessEnabled.Value);
            }
            if (Optional.IsDefined(EncryptionType))
            {
                if (EncryptionType != null)
                {
                    writer.WritePropertyName("encryptionType"u8);
                    writer.WriteStringValue(EncryptionType.Value.ToString());
                }
                else
                {
                    writer.WriteNull("encryptionType");
                }
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

        internal static CapacityPoolData DeserializeCapacityPoolData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> poolId = default;
            long size = default;
            NetAppFileServiceLevel serviceLevel = default;
            Optional<string> provisioningState = default;
            Optional<float> totalThroughputMibps = default;
            Optional<float> utilizedThroughputMibps = default;
            Optional<CapacityPoolQosType> qosType = default;
            Optional<bool> coolAccess = default;
            Optional<CapacityPoolEncryptionType?> encryptionType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                if (property.NameEquals("location"u8))
                {
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
                        if (property0.NameEquals("poolId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            poolId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevel"u8))
                        {
                            serviceLevel = new NetAppFileServiceLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("totalThroughputMibps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            totalThroughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("utilizedThroughputMibps"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            utilizedThroughputMibps = property0.Value.GetSingle();
                            continue;
                        }
                        if (property0.NameEquals("qosType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            qosType = new CapacityPoolQosType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("coolAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            coolAccess = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("encryptionType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                encryptionType = null;
                                continue;
                            }
                            encryptionType = new CapacityPoolEncryptionType(property0.Value.GetString());
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
            return new CapacityPoolData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(etag), Optional.ToNullable(poolId), size, serviceLevel, provisioningState.Value, Optional.ToNullable(totalThroughputMibps), Optional.ToNullable(utilizedThroughputMibps), Optional.ToNullable(qosType), Optional.ToNullable(coolAccess), Optional.ToNullable(encryptionType), rawData);
        }

        CapacityPoolData IModelJsonSerializable<CapacityPoolData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCapacityPoolData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CapacityPoolData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CapacityPoolData IModelSerializable<CapacityPoolData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCapacityPoolData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(CapacityPoolData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator CapacityPoolData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCapacityPoolData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
