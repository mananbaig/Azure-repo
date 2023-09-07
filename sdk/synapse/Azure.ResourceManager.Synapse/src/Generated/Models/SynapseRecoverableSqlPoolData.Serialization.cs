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

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseRecoverableSqlPoolData : IUtf8JsonSerializable, IModelJsonSerializable<SynapseRecoverableSqlPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SynapseRecoverableSqlPoolData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SynapseRecoverableSqlPoolData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseRecoverableSqlPoolData>(this, options.Format);

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

        internal static SynapseRecoverableSqlPoolData DeserializeSynapseRecoverableSqlPoolData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> edition = default;
            Optional<string> serviceLevelObjective = default;
            Optional<string> elasticPoolName = default;
            Optional<DateTimeOffset> lastAvailableBackupDate = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("edition"u8))
                        {
                            edition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceLevelObjective"u8))
                        {
                            serviceLevelObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("elasticPoolName"u8))
                        {
                            elasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastAvailableBackupDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastAvailableBackupDate = property0.Value.GetDateTimeOffset("O");
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
            return new SynapseRecoverableSqlPoolData(id, name, type, systemData.Value, edition.Value, serviceLevelObjective.Value, elasticPoolName.Value, Optional.ToNullable(lastAvailableBackupDate), serializedAdditionalRawData);
        }

        SynapseRecoverableSqlPoolData IModelJsonSerializable<SynapseRecoverableSqlPoolData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseRecoverableSqlPoolData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSynapseRecoverableSqlPoolData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SynapseRecoverableSqlPoolData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseRecoverableSqlPoolData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SynapseRecoverableSqlPoolData IModelSerializable<SynapseRecoverableSqlPoolData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SynapseRecoverableSqlPoolData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSynapseRecoverableSqlPoolData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SynapseRecoverableSqlPoolData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SynapseRecoverableSqlPoolData"/> to convert. </param>
        public static implicit operator RequestContent(SynapseRecoverableSqlPoolData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SynapseRecoverableSqlPoolData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SynapseRecoverableSqlPoolData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSynapseRecoverableSqlPoolData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
