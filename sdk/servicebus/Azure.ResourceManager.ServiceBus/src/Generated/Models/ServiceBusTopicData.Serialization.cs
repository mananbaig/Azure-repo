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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusTopicData : IUtf8JsonSerializable, IModelJsonSerializable<ServiceBusTopicData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceBusTopicData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceBusTopicData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultMessageTimeToLive))
            {
                writer.WritePropertyName("defaultMessageTimeToLive"u8);
                writer.WriteStringValue(DefaultMessageTimeToLive.Value, "P");
            }
            if (Optional.IsDefined(MaxSizeInMegabytes))
            {
                writer.WritePropertyName("maxSizeInMegabytes"u8);
                writer.WriteNumberValue(MaxSizeInMegabytes.Value);
            }
            if (Optional.IsDefined(MaxMessageSizeInKilobytes))
            {
                writer.WritePropertyName("maxMessageSizeInKilobytes"u8);
                writer.WriteNumberValue(MaxMessageSizeInKilobytes.Value);
            }
            if (Optional.IsDefined(RequiresDuplicateDetection))
            {
                writer.WritePropertyName("requiresDuplicateDetection"u8);
                writer.WriteBooleanValue(RequiresDuplicateDetection.Value);
            }
            if (Optional.IsDefined(DuplicateDetectionHistoryTimeWindow))
            {
                writer.WritePropertyName("duplicateDetectionHistoryTimeWindow"u8);
                writer.WriteStringValue(DuplicateDetectionHistoryTimeWindow.Value, "P");
            }
            if (Optional.IsDefined(EnableBatchedOperations))
            {
                writer.WritePropertyName("enableBatchedOperations"u8);
                writer.WriteBooleanValue(EnableBatchedOperations.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(SupportOrdering))
            {
                writer.WritePropertyName("supportOrdering"u8);
                writer.WriteBooleanValue(SupportOrdering.Value);
            }
            if (Optional.IsDefined(AutoDeleteOnIdle))
            {
                writer.WritePropertyName("autoDeleteOnIdle"u8);
                writer.WriteStringValue(AutoDeleteOnIdle.Value, "P");
            }
            if (Optional.IsDefined(EnablePartitioning))
            {
                writer.WritePropertyName("enablePartitioning"u8);
                writer.WriteBooleanValue(EnablePartitioning.Value);
            }
            if (Optional.IsDefined(EnableExpress))
            {
                writer.WritePropertyName("enableExpress"u8);
                writer.WriteBooleanValue(EnableExpress.Value);
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

        internal static ServiceBusTopicData DeserializeServiceBusTopicData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<long> sizeInBytes = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<DateTimeOffset> updatedAt = default;
            Optional<DateTimeOffset> accessedAt = default;
            Optional<int> subscriptionCount = default;
            Optional<MessageCountDetails> countDetails = default;
            Optional<TimeSpan> defaultMessageTimeToLive = default;
            Optional<int> maxSizeInMegabytes = default;
            Optional<long> maxMessageSizeInKilobytes = default;
            Optional<bool> requiresDuplicateDetection = default;
            Optional<TimeSpan> duplicateDetectionHistoryTimeWindow = default;
            Optional<bool> enableBatchedOperations = default;
            Optional<ServiceBusMessagingEntityStatus> status = default;
            Optional<bool> supportOrdering = default;
            Optional<TimeSpan> autoDeleteOnIdle = default;
            Optional<bool> enablePartitioning = default;
            Optional<bool> enableExpress = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                        if (property0.NameEquals("sizeInBytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sizeInBytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("subscriptionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subscriptionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("countDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            countDetails = MessageCountDetails.DeserializeMessageCountDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defaultMessageTimeToLive"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultMessageTimeToLive = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("maxSizeInMegabytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxSizeInMegabytes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxMessageSizeInKilobytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxMessageSizeInKilobytes = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("requiresDuplicateDetection"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requiresDuplicateDetection = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("duplicateDetectionHistoryTimeWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            duplicateDetectionHistoryTimeWindow = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("enableBatchedOperations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBatchedOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToServiceBusMessagingEntityStatus();
                            continue;
                        }
                        if (property0.NameEquals("supportOrdering"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            supportOrdering = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoDeleteOnIdle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoDeleteOnIdle = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("enablePartitioning"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enablePartitioning = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("enableExpress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableExpress = property0.Value.GetBoolean();
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
            return new ServiceBusTopicData(id, name, type, systemData.Value, Optional.ToNullable(sizeInBytes), Optional.ToNullable(createdAt), Optional.ToNullable(updatedAt), Optional.ToNullable(accessedAt), Optional.ToNullable(subscriptionCount), countDetails.Value, Optional.ToNullable(defaultMessageTimeToLive), Optional.ToNullable(maxSizeInMegabytes), Optional.ToNullable(maxMessageSizeInKilobytes), Optional.ToNullable(requiresDuplicateDetection), Optional.ToNullable(duplicateDetectionHistoryTimeWindow), Optional.ToNullable(enableBatchedOperations), Optional.ToNullable(status), Optional.ToNullable(supportOrdering), Optional.ToNullable(autoDeleteOnIdle), Optional.ToNullable(enablePartitioning), Optional.ToNullable(enableExpress), Optional.ToNullable(location), serializedAdditionalRawData);
        }

        ServiceBusTopicData IModelJsonSerializable<ServiceBusTopicData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusTopicData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceBusTopicData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceBusTopicData IModelSerializable<ServiceBusTopicData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ServiceBusTopicData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceBusTopicData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ServiceBusTopicData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ServiceBusTopicData"/> to convert. </param>
        public static implicit operator RequestContent(ServiceBusTopicData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ServiceBusTopicData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ServiceBusTopicData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceBusTopicData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
