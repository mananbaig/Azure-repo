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

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    public partial class MecRole : IUtf8JsonSerializable, IModelJsonSerializable<MecRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MecRole>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MecRole>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MecRole>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                if (ConnectionString is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AsymmetricEncryptedSecret>)ConnectionString).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ControllerEndpoint))
            {
                writer.WritePropertyName("controllerEndpoint"u8);
                writer.WriteStringValue(ControllerEndpoint);
            }
            if (Optional.IsDefined(ResourceUniqueId))
            {
                writer.WritePropertyName("resourceUniqueId"u8);
                writer.WriteStringValue(ResourceUniqueId);
            }
            if (Optional.IsDefined(RoleStatus))
            {
                writer.WritePropertyName("roleStatus"u8);
                writer.WriteStringValue(RoleStatus.Value.ToString());
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

        internal static MecRole DeserializeMecRole(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataBoxEdgeRoleType kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AsymmetricEncryptedSecret> connectionString = default;
            Optional<string> controllerEndpoint = default;
            Optional<string> resourceUniqueId = default;
            Optional<DataBoxEdgeRoleStatus> roleStatus = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new DataBoxEdgeRoleType(property.Value.GetString());
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
                        if (property0.NameEquals("connectionString"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            connectionString = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("controllerEndpoint"u8))
                        {
                            controllerEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceUniqueId"u8))
                        {
                            resourceUniqueId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("roleStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            roleStatus = new DataBoxEdgeRoleStatus(property0.Value.GetString());
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
            return new MecRole(id, name, type, systemData.Value, kind, connectionString.Value, controllerEndpoint.Value, resourceUniqueId.Value, Optional.ToNullable(roleStatus), rawData);
        }

        MecRole IModelJsonSerializable<MecRole>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MecRole>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMecRole(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MecRole>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MecRole>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MecRole IModelSerializable<MecRole>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<MecRole>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMecRole(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MecRole"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MecRole"/> to convert. </param>
        public static implicit operator RequestContent(MecRole model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MecRole"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MecRole(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMecRole(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
