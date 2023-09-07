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
using Azure.ResourceManager.DesktopVirtualization.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DesktopVirtualization
{
    public partial class UserSessionData : IUtf8JsonSerializable, IModelJsonSerializable<UserSessionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UserSessionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UserSessionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserSessionData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(UserPrincipalName))
            {
                writer.WritePropertyName("userPrincipalName"u8);
                writer.WriteStringValue(UserPrincipalName);
            }
            if (Optional.IsDefined(ApplicationType))
            {
                writer.WritePropertyName("applicationType"u8);
                writer.WriteStringValue(ApplicationType.Value.ToString());
            }
            if (Optional.IsDefined(SessionState))
            {
                writer.WritePropertyName("sessionState"u8);
                writer.WriteStringValue(SessionState.Value.ToString());
            }
            if (Optional.IsDefined(ActiveDirectoryUserName))
            {
                writer.WritePropertyName("activeDirectoryUserName"u8);
                writer.WriteStringValue(ActiveDirectoryUserName);
            }
            if (Optional.IsDefined(CreateOn))
            {
                writer.WritePropertyName("createTime"u8);
                writer.WriteStringValue(CreateOn.Value, "O");
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

        internal static UserSessionData DeserializeUserSessionData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<string> objectId = default;
            Optional<string> userPrincipalName = default;
            Optional<VirtualApplicationType> applicationType = default;
            Optional<UserSessionState> sessionState = default;
            Optional<string> activeDirectoryUserName = default;
            Optional<DateTimeOffset> createTime = default;
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
                        if (property0.NameEquals("objectId"u8))
                        {
                            objectId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("userPrincipalName"u8))
                        {
                            userPrincipalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            applicationType = new VirtualApplicationType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sessionState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sessionState = new UserSessionState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("activeDirectoryUserName"u8))
                        {
                            activeDirectoryUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createTime = property0.Value.GetDateTimeOffset("O");
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
            return new UserSessionData(id, name, type, systemData.Value, objectId.Value, userPrincipalName.Value, Optional.ToNullable(applicationType), Optional.ToNullable(sessionState), activeDirectoryUserName.Value, Optional.ToNullable(createTime), serializedAdditionalRawData);
        }

        UserSessionData IModelJsonSerializable<UserSessionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserSessionData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUserSessionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UserSessionData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserSessionData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UserSessionData IModelSerializable<UserSessionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserSessionData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUserSessionData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UserSessionData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UserSessionData"/> to convert. </param>
        public static implicit operator RequestContent(UserSessionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UserSessionData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UserSessionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUserSessionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
