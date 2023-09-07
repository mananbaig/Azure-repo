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
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class EventGridNamespacePermissionBindingData : IUtf8JsonSerializable, IModelJsonSerializable<EventGridNamespacePermissionBindingData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventGridNamespacePermissionBindingData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventGridNamespacePermissionBindingData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridNamespacePermissionBindingData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(TopicSpaceName))
            {
                writer.WritePropertyName("topicSpaceName"u8);
                writer.WriteStringValue(TopicSpaceName);
            }
            if (Optional.IsDefined(Permission))
            {
                writer.WritePropertyName("permission"u8);
                writer.WriteStringValue(Permission.Value.ToString());
            }
            if (Optional.IsDefined(ClientGroupName))
            {
                writer.WritePropertyName("clientGroupName"u8);
                writer.WriteStringValue(ClientGroupName);
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

        internal static EventGridNamespacePermissionBindingData DeserializeEventGridNamespacePermissionBindingData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> description = default;
            Optional<string> topicSpaceName = default;
            Optional<PermissionType> permission = default;
            Optional<string> clientGroupName = default;
            Optional<PermissionBindingProvisioningState> provisioningState = default;
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("topicSpaceName"u8))
                        {
                            topicSpaceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("permission"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            permission = new PermissionType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientGroupName"u8))
                        {
                            clientGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PermissionBindingProvisioningState(property0.Value.GetString());
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
            return new EventGridNamespacePermissionBindingData(id, name, type, systemData.Value, description.Value, topicSpaceName.Value, Optional.ToNullable(permission), clientGroupName.Value, Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        EventGridNamespacePermissionBindingData IModelJsonSerializable<EventGridNamespacePermissionBindingData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridNamespacePermissionBindingData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridNamespacePermissionBindingData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventGridNamespacePermissionBindingData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridNamespacePermissionBindingData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventGridNamespacePermissionBindingData IModelSerializable<EventGridNamespacePermissionBindingData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridNamespacePermissionBindingData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventGridNamespacePermissionBindingData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventGridNamespacePermissionBindingData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventGridNamespacePermissionBindingData"/> to convert. </param>
        public static implicit operator RequestContent(EventGridNamespacePermissionBindingData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventGridNamespacePermissionBindingData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventGridNamespacePermissionBindingData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventGridNamespacePermissionBindingData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
