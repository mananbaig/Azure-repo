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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class UserAssignedServiceIdentity : IUtf8JsonSerializable, IModelJsonSerializable<UserAssignedServiceIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UserAssignedServiceIdentity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UserAssignedServiceIdentity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserAssignedServiceIdentity>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ManagedServiceIdentityType.ToString());
            if (Optional.IsCollectionDefined(UserAssignedIdentities))
            {
                writer.WritePropertyName("userAssignedIdentities"u8);
                writer.WriteStartObject();
                foreach (var item in UserAssignedIdentities)
                {
                    writer.WritePropertyName(item.Key);
                    JsonSerializer.Serialize(writer, item.Value);
                }
                writer.WriteEndObject();
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

        internal static UserAssignedServiceIdentity DeserializeUserAssignedServiceIdentity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ManagedServiceIdentityType type = default;
            Optional<IDictionary<string, UserAssignedIdentity>> userAssignedIdentities = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new ManagedServiceIdentityType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("userAssignedIdentities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, UserAssignedIdentity> dictionary = new Dictionary<string, UserAssignedIdentity>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JsonSerializer.Deserialize<UserAssignedIdentity>(property0.Value.GetRawText()));
                    }
                    userAssignedIdentities = dictionary;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UserAssignedServiceIdentity(type, Optional.ToDictionary(userAssignedIdentities), serializedAdditionalRawData);
        }

        UserAssignedServiceIdentity IModelJsonSerializable<UserAssignedServiceIdentity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserAssignedServiceIdentity>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUserAssignedServiceIdentity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UserAssignedServiceIdentity>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserAssignedServiceIdentity>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UserAssignedServiceIdentity IModelSerializable<UserAssignedServiceIdentity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<UserAssignedServiceIdentity>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUserAssignedServiceIdentity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="UserAssignedServiceIdentity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="UserAssignedServiceIdentity"/> to convert. </param>
        public static implicit operator RequestContent(UserAssignedServiceIdentity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="UserAssignedServiceIdentity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator UserAssignedServiceIdentity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUserAssignedServiceIdentity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
