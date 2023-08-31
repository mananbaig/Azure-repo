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

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingServiceBusTopicEndpointProperties : IUtf8JsonSerializable, IModelJsonSerializable<RoutingServiceBusTopicEndpointProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoutingServiceBusTopicEndpointProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoutingServiceBusTopicEndpointProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id.Value);
            }
            if (Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            if (Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpointUri"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (Optional.IsDefined(EntityPath))
            {
                writer.WritePropertyName("entityPath"u8);
                writer.WriteStringValue(EntityPath);
            }
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                writer.WriteObjectValue(Identity);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        internal static RoutingServiceBusTopicEndpointProperties DeserializeRoutingServiceBusTopicEndpointProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> id = default;
            Optional<string> connectionString = default;
            Optional<string> endpointUri = default;
            Optional<string> entityPath = default;
            Optional<IotHubAuthenticationType> authenticationType = default;
            Optional<ManagedIdentity> identity = default;
            string name = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointUri"u8))
                {
                    endpointUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entityPath"u8))
                {
                    entityPath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new IotHubAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = ManagedIdentity.DeserializeManagedIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoutingServiceBusTopicEndpointProperties(Optional.ToNullable(id), connectionString.Value, endpointUri.Value, entityPath.Value, Optional.ToNullable(authenticationType), identity.Value, name, subscriptionId.Value, resourceGroup.Value, rawData);
        }

        RoutingServiceBusTopicEndpointProperties IModelJsonSerializable<RoutingServiceBusTopicEndpointProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingServiceBusTopicEndpointProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoutingServiceBusTopicEndpointProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoutingServiceBusTopicEndpointProperties IModelSerializable<RoutingServiceBusTopicEndpointProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoutingServiceBusTopicEndpointProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RoutingServiceBusTopicEndpointProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RoutingServiceBusTopicEndpointProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoutingServiceBusTopicEndpointProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
