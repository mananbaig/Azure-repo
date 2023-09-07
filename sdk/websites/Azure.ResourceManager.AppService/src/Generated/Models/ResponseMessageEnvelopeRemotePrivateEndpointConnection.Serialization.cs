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
    public partial class ResponseMessageEnvelopeRemotePrivateEndpointConnection : IUtf8JsonSerializable, IModelJsonSerializable<ResponseMessageEnvelopeRemotePrivateEndpointConnection>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ResponseMessageEnvelopeRemotePrivateEndpointConnection>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ResponseMessageEnvelopeRemotePrivateEndpointConnection>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseMessageEnvelopeRemotePrivateEndpointConnection>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
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
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan"u8);
                if (Plan is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceArmPlan>)Plan).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                if (Properties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RemotePrivateEndpointConnection>)Properties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppServiceSkuDescription>)Sku).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (Optional.IsDefined(Error))
            {
                writer.WritePropertyName("error"u8);
                writer.WriteObjectValue(Error);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        internal static ResponseMessageEnvelopeRemotePrivateEndpointConnection DeserializeResponseMessageEnvelopeRemotePrivateEndpointConnection(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<AppServiceArmPlan> plan = default;
            Optional<RemotePrivateEndpointConnection> properties = default;
            Optional<AppServiceSkuDescription> sku = default;
            Optional<string> status = default;
            Optional<ResponseError> error = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IReadOnlyList<string>> zones = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
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
                if (property.NameEquals("plan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    plan = AppServiceArmPlan.DeserializeAppServiceArmPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = RemotePrivateEndpointConnection.DeserializeRemotePrivateEndpointConnection(property.Value);
                    continue;
                }
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = AppServiceSkuDescription.DeserializeAppServiceSkuDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
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
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ResponseMessageEnvelopeRemotePrivateEndpointConnection(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToDictionary(tags), plan.Value, properties.Value, sku.Value, status.Value, error.Value, identity, Optional.ToList(zones), serializedAdditionalRawData);
        }

        ResponseMessageEnvelopeRemotePrivateEndpointConnection IModelJsonSerializable<ResponseMessageEnvelopeRemotePrivateEndpointConnection>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseMessageEnvelopeRemotePrivateEndpointConnection>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeResponseMessageEnvelopeRemotePrivateEndpointConnection(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ResponseMessageEnvelopeRemotePrivateEndpointConnection>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseMessageEnvelopeRemotePrivateEndpointConnection>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ResponseMessageEnvelopeRemotePrivateEndpointConnection IModelSerializable<ResponseMessageEnvelopeRemotePrivateEndpointConnection>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ResponseMessageEnvelopeRemotePrivateEndpointConnection>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeResponseMessageEnvelopeRemotePrivateEndpointConnection(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ResponseMessageEnvelopeRemotePrivateEndpointConnection"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ResponseMessageEnvelopeRemotePrivateEndpointConnection"/> to convert. </param>
        public static implicit operator RequestContent(ResponseMessageEnvelopeRemotePrivateEndpointConnection model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ResponseMessageEnvelopeRemotePrivateEndpointConnection"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ResponseMessageEnvelopeRemotePrivateEndpointConnection(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeResponseMessageEnvelopeRemotePrivateEndpointConnection(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
