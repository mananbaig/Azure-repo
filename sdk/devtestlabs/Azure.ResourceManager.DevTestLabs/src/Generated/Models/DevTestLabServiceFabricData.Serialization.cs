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
    public partial class DevTestLabServiceFabricData : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabServiceFabricData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabServiceFabricData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabServiceFabricData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabServiceFabricData>(this, options.Format);

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
            if (Optional.IsDefined(ExternalServiceFabricId))
            {
                writer.WritePropertyName("externalServiceFabricId"u8);
                writer.WriteStringValue(ExternalServiceFabricId);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId"u8);
                writer.WriteStringValue(EnvironmentId);
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

        internal static DevTestLabServiceFabricData DeserializeDevTestLabServiceFabricData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> externalServiceFabricId = default;
            Optional<string> environmentId = default;
            Optional<DevTestLabApplicableSchedule> applicableSchedule = default;
            Optional<string> provisioningState = default;
            Optional<Guid> uniqueIdentifier = default;
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
                        if (property0.NameEquals("externalServiceFabricId"u8))
                        {
                            externalServiceFabricId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("environmentId"u8))
                        {
                            environmentId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicableSchedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicableSchedule = DevTestLabApplicableSchedule.DeserializeDevTestLabApplicableSchedule(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("uniqueIdentifier"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uniqueIdentifier = property0.Value.GetGuid();
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
            return new DevTestLabServiceFabricData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, externalServiceFabricId.Value, environmentId.Value, applicableSchedule.Value, provisioningState.Value, Optional.ToNullable(uniqueIdentifier), serializedAdditionalRawData);
        }

        DevTestLabServiceFabricData IModelJsonSerializable<DevTestLabServiceFabricData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabServiceFabricData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabServiceFabricData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabServiceFabricData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabServiceFabricData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabServiceFabricData IModelSerializable<DevTestLabServiceFabricData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevTestLabServiceFabricData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabServiceFabricData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevTestLabServiceFabricData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevTestLabServiceFabricData"/> to convert. </param>
        public static implicit operator RequestContent(DevTestLabServiceFabricData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevTestLabServiceFabricData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevTestLabServiceFabricData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabServiceFabricData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
