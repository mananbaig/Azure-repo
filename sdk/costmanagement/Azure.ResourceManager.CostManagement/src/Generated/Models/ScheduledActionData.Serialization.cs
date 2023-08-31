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
using Azure.ResourceManager.CostManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CostManagement
{
    public partial class ScheduledActionData : IUtf8JsonSerializable, IModelJsonSerializable<ScheduledActionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ScheduledActionData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ScheduledActionData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(FileDestination))
            {
                writer.WritePropertyName("fileDestination"u8);
                writer.WriteObjectValue(FileDestination);
            }
            if (Optional.IsDefined(Notification))
            {
                writer.WritePropertyName("notification"u8);
                writer.WriteObjectValue(Notification);
            }
            if (Optional.IsDefined(NotificationEmail))
            {
                writer.WritePropertyName("notificationEmail"u8);
                writer.WriteStringValue(NotificationEmail);
            }
            if (Optional.IsDefined(Schedule))
            {
                writer.WritePropertyName("schedule"u8);
                writer.WriteObjectValue(Schedule);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(ViewId))
            {
                writer.WritePropertyName("viewId"u8);
                writer.WriteStringValue(ViewId);
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

        internal static ScheduledActionData DeserializeScheduledActionData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> eTag = default;
            Optional<ScheduledActionKind> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> displayName = default;
            Optional<FileDestination> fileDestination = default;
            Optional<NotificationProperties> notification = default;
            Optional<string> notificationEmail = default;
            Optional<ScheduleProperties> schedule = default;
            Optional<ResourceIdentifier> scope = default;
            Optional<ScheduledActionStatus> status = default;
            Optional<ResourceIdentifier> viewId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eTag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eTag = new ETag(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new ScheduledActionKind(property.Value.GetString());
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
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileDestination"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            fileDestination = FileDestination.DeserializeFileDestination(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("notification"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            notification = NotificationProperties.DeserializeNotificationProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("notificationEmail"u8))
                        {
                            notificationEmail = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("schedule"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            schedule = ScheduleProperties.DeserializeScheduleProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            scope = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = new ScheduledActionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("viewId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            viewId = new ResourceIdentifier(property0.Value.GetString());
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
            return new ScheduledActionData(id, name, type, systemData.Value, displayName.Value, fileDestination.Value, notification.Value, notificationEmail.Value, schedule.Value, scope.Value, Optional.ToNullable(status), viewId.Value, Optional.ToNullable(eTag), Optional.ToNullable(kind), rawData);
        }

        ScheduledActionData IModelJsonSerializable<ScheduledActionData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeScheduledActionData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ScheduledActionData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ScheduledActionData IModelSerializable<ScheduledActionData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeScheduledActionData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ScheduledActionData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ScheduledActionData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeScheduledActionData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
