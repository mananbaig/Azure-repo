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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DeletedAppRestoreContent : IUtf8JsonSerializable, IModelJsonSerializable<DeletedAppRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DeletedAppRestoreContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DeletedAppRestoreContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedAppRestoreContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeletedSiteId))
            {
                writer.WritePropertyName("deletedSiteId"u8);
                writer.WriteStringValue(DeletedSiteId);
            }
            if (Optional.IsDefined(RecoverConfiguration))
            {
                writer.WritePropertyName("recoverConfiguration"u8);
                writer.WriteBooleanValue(RecoverConfiguration.Value);
            }
            if (Optional.IsDefined(SnapshotTime))
            {
                writer.WritePropertyName("snapshotTime"u8);
                writer.WriteStringValue(SnapshotTime);
            }
            if (Optional.IsDefined(UseDRSecondary))
            {
                writer.WritePropertyName("useDRSecondary"u8);
                writer.WriteBooleanValue(UseDRSecondary.Value);
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

        internal static DeletedAppRestoreContent DeserializeDeletedAppRestoreContent(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<ResourceIdentifier> deletedSiteId = default;
            Optional<bool> recoverConfiguration = default;
            Optional<string> snapshotTime = default;
            Optional<bool> useDRSecondary = default;
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
                        if (property0.NameEquals("deletedSiteId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deletedSiteId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("recoverConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            recoverConfiguration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("snapshotTime"u8))
                        {
                            snapshotTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("useDRSecondary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            useDRSecondary = property0.Value.GetBoolean();
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
            return new DeletedAppRestoreContent(id, name, type, systemData.Value, deletedSiteId.Value, Optional.ToNullable(recoverConfiguration), snapshotTime.Value, Optional.ToNullable(useDRSecondary), kind.Value, serializedAdditionalRawData);
        }

        DeletedAppRestoreContent IModelJsonSerializable<DeletedAppRestoreContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedAppRestoreContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDeletedAppRestoreContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DeletedAppRestoreContent>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedAppRestoreContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DeletedAppRestoreContent IModelSerializable<DeletedAppRestoreContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DeletedAppRestoreContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDeletedAppRestoreContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DeletedAppRestoreContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DeletedAppRestoreContent"/> to convert. </param>
        public static implicit operator RequestContent(DeletedAppRestoreContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DeletedAppRestoreContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DeletedAppRestoreContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDeletedAppRestoreContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
