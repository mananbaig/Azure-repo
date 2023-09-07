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

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNetworkSecurityPerimeterConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfiguration>(this, options.Format);

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
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(ProvisioningIssues))
            {
                writer.WritePropertyName("provisioningIssues"u8);
                writer.WriteStartArray();
                foreach (var item in ProvisioningIssues)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EventHubsProvisioningIssue>)item).Serialize(writer, options);
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

        internal static EventHubsNetworkSecurityPerimeterConfiguration DeserializeEventHubsNetworkSecurityPerimeterConfiguration(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<EventHubsNetworkSecurityPerimeterConfigurationProvisioningState> provisioningState = default;
            Optional<IList<EventHubsProvisioningIssue>> provisioningIssues = default;
            Optional<EventHubsNetworkSecurityPerimeter> networkSecurityPerimeter = default;
            Optional<EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation> resourceAssociation = default;
            Optional<EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile> profile = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new EventHubsNetworkSecurityPerimeterConfigurationProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningIssues"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventHubsProvisioningIssue> array = new List<EventHubsProvisioningIssue>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventHubsProvisioningIssue.DeserializeEventHubsProvisioningIssue(item));
                            }
                            provisioningIssues = array;
                            continue;
                        }
                        if (property0.NameEquals("networkSecurityPerimeter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            networkSecurityPerimeter = EventHubsNetworkSecurityPerimeter.DeserializeEventHubsNetworkSecurityPerimeter(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("resourceAssociation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceAssociation = EventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation.DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesResourceAssociation(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("profile"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            profile = EventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile.DeserializeEventHubsNetworkSecurityPerimeterConfigurationPropertiesProfile(property0.Value);
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
            return new EventHubsNetworkSecurityPerimeterConfiguration(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), Optional.ToList(provisioningIssues), networkSecurityPerimeter.Value, resourceAssociation.Value, profile.Value, serializedAdditionalRawData);
        }

        EventHubsNetworkSecurityPerimeterConfiguration IModelJsonSerializable<EventHubsNetworkSecurityPerimeterConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfiguration>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNetworkSecurityPerimeterConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubsNetworkSecurityPerimeterConfiguration>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfiguration>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubsNetworkSecurityPerimeterConfiguration IModelSerializable<EventHubsNetworkSecurityPerimeterConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkSecurityPerimeterConfiguration>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubsNetworkSecurityPerimeterConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubsNetworkSecurityPerimeterConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubsNetworkSecurityPerimeterConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(EventHubsNetworkSecurityPerimeterConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubsNetworkSecurityPerimeterConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubsNetworkSecurityPerimeterConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubsNetworkSecurityPerimeterConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
