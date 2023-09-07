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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstancePrivateEndpointConnectionProperties : IUtf8JsonSerializable, IModelJsonSerializable<ManagedInstancePrivateEndpointConnectionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedInstancePrivateEndpointConnectionProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedInstancePrivateEndpointConnectionProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateEndpointConnectionProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PrivateEndpoint))
            {
                writer.WritePropertyName("privateEndpoint"u8);
                JsonSerializer.Serialize(writer, PrivateEndpoint);
            }
            if (Optional.IsDefined(PrivateLinkServiceConnectionState))
            {
                writer.WritePropertyName("privateLinkServiceConnectionState"u8);
                if (PrivateLinkServiceConnectionState is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ManagedInstancePrivateLinkServiceConnectionStateProperty>)PrivateLinkServiceConnectionState).Serialize(writer, options);
                }
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

        internal static ManagedInstancePrivateEndpointConnectionProperties DeserializeManagedInstancePrivateEndpointConnectionProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<WritableSubResource> privateEndpoint = default;
            Optional<ManagedInstancePrivateLinkServiceConnectionStateProperty> privateLinkServiceConnectionState = default;
            Optional<string> provisioningState = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateEndpoint = JsonSerializer.Deserialize<WritableSubResource>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateLinkServiceConnectionState = ManagedInstancePrivateLinkServiceConnectionStateProperty.DeserializeManagedInstancePrivateLinkServiceConnectionStateProperty(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedInstancePrivateEndpointConnectionProperties(privateEndpoint, privateLinkServiceConnectionState.Value, provisioningState.Value, serializedAdditionalRawData);
        }

        ManagedInstancePrivateEndpointConnectionProperties IModelJsonSerializable<ManagedInstancePrivateEndpointConnectionProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateEndpointConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstancePrivateEndpointConnectionProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedInstancePrivateEndpointConnectionProperties>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateEndpointConnectionProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedInstancePrivateEndpointConnectionProperties IModelSerializable<ManagedInstancePrivateEndpointConnectionProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<ManagedInstancePrivateEndpointConnectionProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedInstancePrivateEndpointConnectionProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedInstancePrivateEndpointConnectionProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedInstancePrivateEndpointConnectionProperties"/> to convert. </param>
        public static implicit operator RequestContent(ManagedInstancePrivateEndpointConnectionProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedInstancePrivateEndpointConnectionProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedInstancePrivateEndpointConnectionProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedInstancePrivateEndpointConnectionProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
