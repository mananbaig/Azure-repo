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
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    public partial class ResourceHealthMetadataEntityData : IUtf8JsonSerializable, IModelJsonSerializable<ResourceHealthMetadataEntityData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceHealthMetadataEntityData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceHealthMetadataEntityData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthMetadataEntityData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicableScenarios))
            {
                writer.WritePropertyName("applicableScenarios"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicableScenarios)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedValues))
            {
                writer.WritePropertyName("supportedValues"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedValues)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<MetadataSupportedValueDetail>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static ResourceHealthMetadataEntityData DeserializeResourceHealthMetadataEntityData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> dependsOn = default;
            Optional<IReadOnlyList<MetadataEntityScenario>> applicableScenarios = default;
            Optional<IReadOnlyList<MetadataSupportedValueDetail>> supportedValues = default;
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dependsOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            dependsOn = array;
                            continue;
                        }
                        if (property0.NameEquals("applicableScenarios"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MetadataEntityScenario> array = new List<MetadataEntityScenario>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new MetadataEntityScenario(item.GetString()));
                            }
                            applicableScenarios = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedValues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<MetadataSupportedValueDetail> array = new List<MetadataSupportedValueDetail>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(MetadataSupportedValueDetail.DeserializeMetadataSupportedValueDetail(item));
                            }
                            supportedValues = array;
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
            return new ResourceHealthMetadataEntityData(id, name, type, systemData.Value, displayName.Value, Optional.ToList(dependsOn), Optional.ToList(applicableScenarios), Optional.ToList(supportedValues), serializedAdditionalRawData);
        }

        ResourceHealthMetadataEntityData IModelJsonSerializable<ResourceHealthMetadataEntityData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthMetadataEntityData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceHealthMetadataEntityData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceHealthMetadataEntityData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthMetadataEntityData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceHealthMetadataEntityData IModelSerializable<ResourceHealthMetadataEntityData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceHealthMetadataEntityData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceHealthMetadataEntityData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceHealthMetadataEntityData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceHealthMetadataEntityData"/> to convert. </param>
        public static implicit operator RequestContent(ResourceHealthMetadataEntityData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceHealthMetadataEntityData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceHealthMetadataEntityData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceHealthMetadataEntityData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
