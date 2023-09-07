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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ServiceFabricApplicationPatch : IUtf8JsonSerializable, IModelJsonSerializable<ServiceFabricApplicationPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceFabricApplicationPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceFabricApplicationPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricApplicationPatch>(this, options.Format);

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
            if (Optional.IsDefined(TypeVersion))
            {
                writer.WritePropertyName("typeVersion"u8);
                writer.WriteStringValue(TypeVersion);
            }
            if (Optional.IsCollectionDefined(Parameters))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                if (UpgradePolicy is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ApplicationUpgradePolicy>)UpgradePolicy).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MinimumNodes))
            {
                writer.WritePropertyName("minimumNodes"u8);
                writer.WriteNumberValue(MinimumNodes.Value);
            }
            if (Optional.IsDefined(MaximumNodes))
            {
                writer.WritePropertyName("maximumNodes"u8);
                writer.WriteNumberValue(MaximumNodes.Value);
            }
            if (Optional.IsDefined(RemoveApplicationCapacity))
            {
                writer.WritePropertyName("removeApplicationCapacity"u8);
                writer.WriteBooleanValue(RemoveApplicationCapacity.Value);
            }
            if (Optional.IsCollectionDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteStartArray();
                foreach (var item in Metrics)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ApplicationMetricDescription>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManagedIdentities))
            {
                writer.WritePropertyName("managedIdentities"u8);
                writer.WriteStartArray();
                foreach (var item in ManagedIdentities)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ApplicationUserAssignedIdentity>)item).Serialize(writer, options);
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

        internal static ServiceFabricApplicationPatch DeserializeServiceFabricApplicationPatch(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> typeVersion = default;
            Optional<IDictionary<string, string>> parameters = default;
            Optional<ApplicationUpgradePolicy> upgradePolicy = default;
            Optional<long> minimumNodes = default;
            Optional<long> maximumNodes = default;
            Optional<bool> removeApplicationCapacity = default;
            Optional<IList<ApplicationMetricDescription>> metrics = default;
            Optional<IList<ApplicationUserAssignedIdentity>> managedIdentities = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("typeVersion"u8))
                        {
                            typeVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            parameters = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("upgradePolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            upgradePolicy = ApplicationUpgradePolicy.DeserializeApplicationUpgradePolicy(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("minimumNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumNodes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("maximumNodes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maximumNodes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("removeApplicationCapacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            removeApplicationCapacity = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationMetricDescription> array = new List<ApplicationMetricDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationMetricDescription.DeserializeApplicationMetricDescription(item));
                            }
                            metrics = array;
                            continue;
                        }
                        if (property0.NameEquals("managedIdentities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ApplicationUserAssignedIdentity> array = new List<ApplicationUserAssignedIdentity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationUserAssignedIdentity.DeserializeApplicationUserAssignedIdentity(item));
                            }
                            managedIdentities = array;
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
            return new ServiceFabricApplicationPatch(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, typeVersion.Value, Optional.ToDictionary(parameters), upgradePolicy.Value, Optional.ToNullable(minimumNodes), Optional.ToNullable(maximumNodes), Optional.ToNullable(removeApplicationCapacity), Optional.ToList(metrics), Optional.ToList(managedIdentities), Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        ServiceFabricApplicationPatch IModelJsonSerializable<ServiceFabricApplicationPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricApplicationPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricApplicationPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceFabricApplicationPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricApplicationPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceFabricApplicationPatch IModelSerializable<ServiceFabricApplicationPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceFabricApplicationPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceFabricApplicationPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceFabricApplicationPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceFabricApplicationPatch"/> to convert. </param>
        public static implicit operator RequestContent(ServiceFabricApplicationPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceFabricApplicationPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceFabricApplicationPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceFabricApplicationPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
