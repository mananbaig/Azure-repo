// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ResourceWriteFailureEventDataConverter))]
    public partial class ResourceWriteFailureEventData : IUtf8JsonSerializable, IModelJsonSerializable<ResourceWriteFailureEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResourceWriteFailureEventData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResourceWriteFailureEventData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceWriteFailureEventData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId);
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
            }
            if (Optional.IsDefined(ResourceProvider))
            {
                writer.WritePropertyName("resourceProvider"u8);
                writer.WriteStringValue(ResourceProvider);
            }
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUri);
            }
            if (Optional.IsDefined(OperationName))
            {
                writer.WritePropertyName("operationName"u8);
                writer.WriteStringValue(OperationName);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(AuthorizationJson))
            {
                writer.WritePropertyName("authorization"u8);
                AuthorizationJson.WriteTo(writer);
            }
            if (Optional.IsDefined(ClaimsJson))
            {
                writer.WritePropertyName("claims"u8);
                ClaimsJson.WriteTo(writer);
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(HttpRequestJson))
            {
                writer.WritePropertyName("httpRequest"u8);
                HttpRequestJson.WriteTo(writer);
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

        internal static ResourceWriteFailureEventData DeserializeResourceWriteFailureEventData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> tenantId = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Optional<string> resourceProvider = default;
            Optional<string> resourceUri = default;
            Optional<string> operationName = default;
            Optional<string> status = default;
            Optional<JsonElement> authorization = default;
            Optional<JsonElement> claims = default;
            Optional<string> correlationId = default;
            Optional<JsonElement> httpRequest = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tenantId"u8))
                {
                    tenantId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProvider"u8))
                {
                    resourceProvider = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("operationName"u8))
                {
                    operationName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authorization"u8))
                {
                    authorization = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    claims = property.Value.Clone();
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("httpRequest"u8))
                {
                    httpRequest = property.Value.Clone();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResourceWriteFailureEventData(tenantId.Value, subscriptionId.Value, resourceGroup.Value, resourceProvider.Value, resourceUri.Value, operationName.Value, status.Value, authorization, claims, correlationId.Value, httpRequest, serializedAdditionalRawData);
        }

        ResourceWriteFailureEventData IModelJsonSerializable<ResourceWriteFailureEventData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceWriteFailureEventData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceWriteFailureEventData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResourceWriteFailureEventData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceWriteFailureEventData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResourceWriteFailureEventData IModelSerializable<ResourceWriteFailureEventData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResourceWriteFailureEventData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResourceWriteFailureEventData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResourceWriteFailureEventData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResourceWriteFailureEventData"/> to convert. </param>
        public static implicit operator RequestContent(ResourceWriteFailureEventData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResourceWriteFailureEventData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResourceWriteFailureEventData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResourceWriteFailureEventData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class ResourceWriteFailureEventDataConverter : JsonConverter<ResourceWriteFailureEventData>
        {
            public override void Write(Utf8JsonWriter writer, ResourceWriteFailureEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override ResourceWriteFailureEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeResourceWriteFailureEventData(document.RootElement);
            }
        }
    }
}
