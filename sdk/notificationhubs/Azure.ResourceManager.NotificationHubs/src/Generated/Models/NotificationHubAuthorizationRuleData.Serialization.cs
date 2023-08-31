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
using Azure.ResourceManager.NotificationHubs.Models;

namespace Azure.ResourceManager.NotificationHubs
{
    public partial class NotificationHubAuthorizationRuleData : IUtf8JsonSerializable, IModelJsonSerializable<NotificationHubAuthorizationRuleData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<NotificationHubAuthorizationRuleData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<NotificationHubAuthorizationRuleData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<NotificationHubSku>)Sku).Serialize(writer, options);
                }
            }
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
            if (Optional.IsCollectionDefined(Rights))
            {
                writer.WritePropertyName("rights"u8);
                writer.WriteStartArray();
                foreach (var item in Rights)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
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

        internal static NotificationHubAuthorizationRuleData DeserializeNotificationHubAuthorizationRuleData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NotificationHubSku> sku = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IList<AuthorizationRuleAccessRight>> rights = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<string> keyName = default;
            Optional<string> claimType = default;
            Optional<string> claimValue = default;
            Optional<DateTimeOffset> modifiedTime = default;
            Optional<DateTimeOffset> createdTime = default;
            Optional<int> revision = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = NotificationHubSku.DeserializeNotificationHubSku(property.Value);
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
                        if (property0.NameEquals("rights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AuthorizationRuleAccessRight> array = new List<AuthorizationRuleAccessRight>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString().ToAuthorizationRuleAccessRight());
                            }
                            rights = array;
                            continue;
                        }
                        if (property0.NameEquals("primaryKey"u8))
                        {
                            primaryKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryKey"u8))
                        {
                            secondaryKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("keyName"u8))
                        {
                            keyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("claimType"u8))
                        {
                            claimType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("claimValue"u8))
                        {
                            claimValue = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("modifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("createdTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("revision"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revision = property0.Value.GetInt32();
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
            return new NotificationHubAuthorizationRuleData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToList(rights), primaryKey.Value, secondaryKey.Value, keyName.Value, claimType.Value, claimValue.Value, Optional.ToNullable(modifiedTime), Optional.ToNullable(createdTime), Optional.ToNullable(revision), sku.Value, rawData);
        }

        NotificationHubAuthorizationRuleData IModelJsonSerializable<NotificationHubAuthorizationRuleData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeNotificationHubAuthorizationRuleData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<NotificationHubAuthorizationRuleData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        NotificationHubAuthorizationRuleData IModelSerializable<NotificationHubAuthorizationRuleData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeNotificationHubAuthorizationRuleData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="NotificationHubAuthorizationRuleData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="NotificationHubAuthorizationRuleData"/> to convert. </param>
        public static implicit operator RequestContent(NotificationHubAuthorizationRuleData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="NotificationHubAuthorizationRuleData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator NotificationHubAuthorizationRuleData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeNotificationHubAuthorizationRuleData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
