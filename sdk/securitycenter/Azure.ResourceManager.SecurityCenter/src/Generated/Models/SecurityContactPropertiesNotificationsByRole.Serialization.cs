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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityContactPropertiesNotificationsByRole : IUtf8JsonSerializable, IModelJsonSerializable<SecurityContactPropertiesNotificationsByRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityContactPropertiesNotificationsByRole>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityContactPropertiesNotificationsByRole>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityContactPropertiesNotificationsByRole>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Roles))
            {
                writer.WritePropertyName("roles"u8);
                writer.WriteStartArray();
                foreach (var item in Roles)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
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

        internal static SecurityContactPropertiesNotificationsByRole DeserializeSecurityContactPropertiesNotificationsByRole(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityAlertNotificationByRoleState> state = default;
            Optional<IList<SecurityAlertReceivingRole>> roles = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SecurityAlertNotificationByRoleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityAlertReceivingRole> array = new List<SecurityAlertReceivingRole>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityAlertReceivingRole(item.GetString()));
                    }
                    roles = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SecurityContactPropertiesNotificationsByRole(Optional.ToNullable(state), Optional.ToList(roles), serializedAdditionalRawData);
        }

        SecurityContactPropertiesNotificationsByRole IModelJsonSerializable<SecurityContactPropertiesNotificationsByRole>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityContactPropertiesNotificationsByRole>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityContactPropertiesNotificationsByRole(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityContactPropertiesNotificationsByRole>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityContactPropertiesNotificationsByRole>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityContactPropertiesNotificationsByRole IModelSerializable<SecurityContactPropertiesNotificationsByRole>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SecurityContactPropertiesNotificationsByRole>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityContactPropertiesNotificationsByRole(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityContactPropertiesNotificationsByRole"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityContactPropertiesNotificationsByRole"/> to convert. </param>
        public static implicit operator RequestContent(SecurityContactPropertiesNotificationsByRole model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityContactPropertiesNotificationsByRole"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityContactPropertiesNotificationsByRole(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityContactPropertiesNotificationsByRole(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
