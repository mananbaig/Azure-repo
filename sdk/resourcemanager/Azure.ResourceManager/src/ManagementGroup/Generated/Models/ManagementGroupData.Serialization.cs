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
using Azure.ResourceManager.ManagementGroups.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagementGroups
{
    public partial class ManagementGroupData : IUtf8JsonSerializable, IModelJsonSerializable<ManagementGroupData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagementGroupData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagementGroupData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                if (Details is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagementGroupInfo>)Details).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(Children))
            {
                if (Children != null)
                {
                    writer.WritePropertyName("children"u8);
                    writer.WriteStartArray();
                    foreach (var item in Children)
                    {
                        if (item is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<ManagementGroupChildInfo>)item).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("children");
                }
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

        internal static ManagementGroupData DeserializeManagementGroupData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<Guid> tenantId = default;
            Optional<string> displayName = default;
            Optional<ManagementGroupInfo> details = default;
            Optional<IReadOnlyList<ManagementGroupChildInfo>> children = default;
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
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            details = ManagementGroupInfo.DeserializeManagementGroupInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("children"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                children = null;
                                continue;
                            }
                            List<ManagementGroupChildInfo> array = new List<ManagementGroupChildInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagementGroupChildInfo.DeserializeManagementGroupChildInfo(item));
                            }
                            children = array;
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
            return new ManagementGroupData(id, name, type, systemData.Value, Optional.ToNullable(tenantId), displayName.Value, details.Value, Optional.ToList(children), serializedAdditionalRawData);
        }

        ManagementGroupData IModelJsonSerializable<ManagementGroupData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementGroupData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagementGroupData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagementGroupData IModelSerializable<ManagementGroupData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagementGroupData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagementGroupData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagementGroupData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagementGroupData"/> to convert. </param>
        public static implicit operator RequestContent(ManagementGroupData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagementGroupData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagementGroupData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagementGroupData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
