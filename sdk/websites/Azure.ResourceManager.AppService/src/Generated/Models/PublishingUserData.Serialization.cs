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

namespace Azure.ResourceManager.AppService
{
    public partial class PublishingUserData : IUtf8JsonSerializable, IModelJsonSerializable<PublishingUserData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PublishingUserData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PublishingUserData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishingUserData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublishingUserName))
            {
                writer.WritePropertyName("publishingUserName"u8);
                writer.WriteStringValue(PublishingUserName);
            }
            if (Optional.IsDefined(PublishingPassword))
            {
                writer.WritePropertyName("publishingPassword"u8);
                writer.WriteStringValue(PublishingPassword);
            }
            if (Optional.IsDefined(PublishingPasswordHash))
            {
                writer.WritePropertyName("publishingPasswordHash"u8);
                writer.WriteStringValue(PublishingPasswordHash);
            }
            if (Optional.IsDefined(PublishingPasswordHashSalt))
            {
                writer.WritePropertyName("publishingPasswordHashSalt"u8);
                writer.WriteStringValue(PublishingPasswordHashSalt);
            }
            if (Optional.IsDefined(ScmUri))
            {
                writer.WritePropertyName("scmUri"u8);
                writer.WriteStringValue(ScmUri.AbsoluteUri);
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

        internal static PublishingUserData DeserializePublishingUserData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> publishingUserName = default;
            Optional<string> publishingPassword = default;
            Optional<string> publishingPasswordHash = default;
            Optional<string> publishingPasswordHashSalt = default;
            Optional<Uri> scmUri = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("publishingUserName"u8))
                        {
                            publishingUserName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPassword"u8))
                        {
                            publishingPassword = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPasswordHash"u8))
                        {
                            publishingPasswordHash = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("publishingPasswordHashSalt"u8))
                        {
                            publishingPasswordHashSalt = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("scmUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scmUri = new Uri(property0.Value.GetString());
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
            return new PublishingUserData(id, name, type, systemData.Value, publishingUserName.Value, publishingPassword.Value, publishingPasswordHash.Value, publishingPasswordHashSalt.Value, scmUri.Value, kind.Value, serializedAdditionalRawData);
        }

        PublishingUserData IModelJsonSerializable<PublishingUserData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishingUserData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePublishingUserData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PublishingUserData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishingUserData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PublishingUserData IModelSerializable<PublishingUserData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PublishingUserData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePublishingUserData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PublishingUserData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PublishingUserData"/> to convert. </param>
        public static implicit operator RequestContent(PublishingUserData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PublishingUserData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PublishingUserData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePublishingUserData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
