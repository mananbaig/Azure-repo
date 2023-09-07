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

namespace Azure.ResourceManager.DevCenter.Models
{
    public partial class DevCenterProjectEnvironmentPatch : IUtf8JsonSerializable, IModelJsonSerializable<DevCenterProjectEnvironmentPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevCenterProjectEnvironmentPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevCenterProjectEnvironmentPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterProjectEnvironmentPatch>(this, options.Format);

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
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeploymentTargetId))
            {
                writer.WritePropertyName("deploymentTargetId"u8);
                writer.WriteStringValue(DeploymentTargetId);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(CreatorRoleAssignment))
            {
                writer.WritePropertyName("creatorRoleAssignment"u8);
                if (CreatorRoleAssignment is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment>)CreatorRoleAssignment).Serialize(writer, options);
                }
            }
            if (Optional.IsCollectionDefined(UserRoleAssignments))
            {
                writer.WritePropertyName("userRoleAssignments"u8);
                writer.WriteStartObject();
                foreach (var item in UserRoleAssignments)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<DevCenterUserRoleAssignments>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
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

        internal static DevCenterProjectEnvironmentPatch DeserializeDevCenterProjectEnvironmentPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ResourceIdentifier> deploymentTargetId = default;
            Optional<EnvironmentTypeEnableStatus> status = default;
            Optional<ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment> creatorRoleAssignment = default;
            Optional<IDictionary<string, DevCenterUserRoleAssignments>> userRoleAssignments = default;
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
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("deploymentTargetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deploymentTargetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new EnvironmentTypeEnableStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creatorRoleAssignment"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creatorRoleAssignment = ProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment.DeserializeProjectEnvironmentTypeUpdatePropertiesCreatorRoleAssignment(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("userRoleAssignments"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, DevCenterUserRoleAssignments> dictionary = new Dictionary<string, DevCenterUserRoleAssignments>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, DevCenterUserRoleAssignments.DeserializeDevCenterUserRoleAssignments(property1.Value));
                            }
                            userRoleAssignments = dictionary;
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
            return new DevCenterProjectEnvironmentPatch(Optional.ToDictionary(tags), identity, deploymentTargetId.Value, Optional.ToNullable(status), creatorRoleAssignment.Value, Optional.ToDictionary(userRoleAssignments), serializedAdditionalRawData);
        }

        DevCenterProjectEnvironmentPatch IModelJsonSerializable<DevCenterProjectEnvironmentPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterProjectEnvironmentPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevCenterProjectEnvironmentPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevCenterProjectEnvironmentPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterProjectEnvironmentPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevCenterProjectEnvironmentPatch IModelSerializable<DevCenterProjectEnvironmentPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<DevCenterProjectEnvironmentPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevCenterProjectEnvironmentPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DevCenterProjectEnvironmentPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DevCenterProjectEnvironmentPatch"/> to convert. </param>
        public static implicit operator RequestContent(DevCenterProjectEnvironmentPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DevCenterProjectEnvironmentPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DevCenterProjectEnvironmentPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevCenterProjectEnvironmentPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
