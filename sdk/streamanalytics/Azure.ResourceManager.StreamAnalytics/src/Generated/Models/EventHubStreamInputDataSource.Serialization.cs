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

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class EventHubStreamInputDataSource : IUtf8JsonSerializable, IModelJsonSerializable<EventHubStreamInputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubStreamInputDataSource>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubStreamInputDataSource>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubStreamInputDataSource>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(StreamInputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceBusNamespace))
            {
                writer.WritePropertyName("serviceBusNamespace"u8);
                writer.WriteStringValue(ServiceBusNamespace);
            }
            if (Optional.IsDefined(SharedAccessPolicyName))
            {
                writer.WritePropertyName("sharedAccessPolicyName"u8);
                writer.WriteStringValue(SharedAccessPolicyName);
            }
            if (Optional.IsDefined(SharedAccessPolicyKey))
            {
                writer.WritePropertyName("sharedAccessPolicyKey"u8);
                writer.WriteStringValue(SharedAccessPolicyKey);
            }
            if (Optional.IsDefined(AuthenticationMode))
            {
                writer.WritePropertyName("authenticationMode"u8);
                writer.WriteStringValue(AuthenticationMode.Value.ToString());
            }
            if (Optional.IsDefined(EventHubName))
            {
                writer.WritePropertyName("eventHubName"u8);
                writer.WriteStringValue(EventHubName);
            }
            if (Optional.IsDefined(PartitionCount))
            {
                writer.WritePropertyName("partitionCount"u8);
                writer.WriteNumberValue(PartitionCount.Value);
            }
            if (Optional.IsDefined(ConsumerGroupName))
            {
                writer.WritePropertyName("consumerGroupName"u8);
                writer.WriteStringValue(ConsumerGroupName);
            }
            if (Optional.IsDefined(PrefetchCount))
            {
                writer.WritePropertyName("prefetchCount"u8);
                writer.WriteNumberValue(PrefetchCount.Value);
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

        internal static EventHubStreamInputDataSource DeserializeEventHubStreamInputDataSource(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> serviceBusNamespace = default;
            Optional<string> sharedAccessPolicyName = default;
            Optional<string> sharedAccessPolicyKey = default;
            Optional<StreamAnalyticsAuthenticationMode> authenticationMode = default;
            Optional<string> eventHubName = default;
            Optional<int> partitionCount = default;
            Optional<string> consumerGroupName = default;
            Optional<int> prefetchCount = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("serviceBusNamespace"u8))
                        {
                            serviceBusNamespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyName"u8))
                        {
                            sharedAccessPolicyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sharedAccessPolicyKey"u8))
                        {
                            sharedAccessPolicyKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authenticationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            authenticationMode = new StreamAnalyticsAuthenticationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventHubName"u8))
                        {
                            eventHubName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partitionCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("consumerGroupName"u8))
                        {
                            consumerGroupName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("prefetchCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            prefetchCount = property0.Value.GetInt32();
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
            return new EventHubStreamInputDataSource(type, serviceBusNamespace.Value, sharedAccessPolicyName.Value, sharedAccessPolicyKey.Value, Optional.ToNullable(authenticationMode), eventHubName.Value, Optional.ToNullable(partitionCount), consumerGroupName.Value, Optional.ToNullable(prefetchCount), serializedAdditionalRawData);
        }

        EventHubStreamInputDataSource IModelJsonSerializable<EventHubStreamInputDataSource>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubStreamInputDataSource>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubStreamInputDataSource(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubStreamInputDataSource>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubStreamInputDataSource>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubStreamInputDataSource IModelSerializable<EventHubStreamInputDataSource>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubStreamInputDataSource>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubStreamInputDataSource(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubStreamInputDataSource"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubStreamInputDataSource"/> to convert. </param>
        public static implicit operator RequestContent(EventHubStreamInputDataSource model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubStreamInputDataSource"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubStreamInputDataSource(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubStreamInputDataSource(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
