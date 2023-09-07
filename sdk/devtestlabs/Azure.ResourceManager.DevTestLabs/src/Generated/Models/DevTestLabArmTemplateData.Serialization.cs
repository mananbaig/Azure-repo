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
using Azure.ResourceManager.DevTestLabs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabArmTemplateData : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabArmTemplateData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabArmTemplateData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabArmTemplateData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArmTemplateData>(this, options.Format);

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

        internal static DevTestLabArmTemplateData DeserializeDevTestLabArmTemplateData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<string> publisher = default;
            Optional<string> icon = default;
            Optional<BinaryData> contents = default;
            Optional<DateTimeOffset> createdDate = default;
            Optional<IReadOnlyList<DevTestLabParametersValueFileInfo>> parametersValueFilesInfo = default;
            Optional<bool> enabled = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publisher"u8))
                        {
                            publisher = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("icon"u8))
                        {
                            icon = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contents"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contents = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("createdDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("parametersValueFilesInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DevTestLabParametersValueFileInfo> array = new List<DevTestLabParametersValueFileInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DevTestLabParametersValueFileInfo.DeserializeDevTestLabParametersValueFileInfo(item));
                            }
                            parametersValueFilesInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
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
            return new DevTestLabArmTemplateData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, displayName.Value, description.Value, publisher.Value, icon.Value, contents.Value, Optional.ToNullable(createdDate), Optional.ToList(parametersValueFilesInfo), Optional.ToNullable(enabled), serializedAdditionalRawData);
        }

        DevTestLabArmTemplateData IModelJsonSerializable<DevTestLabArmTemplateData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArmTemplateData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabArmTemplateData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabArmTemplateData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArmTemplateData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabArmTemplateData IModelSerializable<DevTestLabArmTemplateData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabArmTemplateData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabArmTemplateData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabArmTemplateData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabArmTemplateData"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabArmTemplateData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabArmTemplateData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabArmTemplateData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabArmTemplateData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
