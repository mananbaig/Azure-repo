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
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeUserData : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeUserData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeUserData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeUserData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EncryptedPassword))
            {
                writer.WritePropertyName("encryptedPassword"u8);
                if (EncryptedPassword is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AsymmetricEncryptedSecret>)EncryptedPassword).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("userType"u8);
            writer.WriteStringValue(UserType.ToString());
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

        internal static DataBoxEdgeUserData DeserializeDataBoxEdgeUserData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<AsymmetricEncryptedSecret> encryptedPassword = default;
            Optional<IReadOnlyList<ShareAccessRight>> shareAccessRights = default;
            DataBoxEdgeUserType userType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("encryptedPassword"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedPassword = AsymmetricEncryptedSecret.DeserializeAsymmetricEncryptedSecret(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("shareAccessRights"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ShareAccessRight> array = new List<ShareAccessRight>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ShareAccessRight.DeserializeShareAccessRight(item));
                            }
                            shareAccessRights = array;
                            continue;
                        }
                        if (property0.NameEquals("userType"u8))
                        {
                            userType = new DataBoxEdgeUserType(property0.Value.GetString());
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
            return new DataBoxEdgeUserData(id, name, type, systemData.Value, encryptedPassword.Value, Optional.ToList(shareAccessRights), userType, rawData);
        }

        DataBoxEdgeUserData IModelJsonSerializable<DataBoxEdgeUserData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeUserData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeUserData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeUserData IModelSerializable<DataBoxEdgeUserData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeUserData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DataBoxEdgeUserData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DataBoxEdgeUserData"/> to convert. </param>
        public static implicit operator RequestContent(DataBoxEdgeUserData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DataBoxEdgeUserData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DataBoxEdgeUserData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeUserData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
