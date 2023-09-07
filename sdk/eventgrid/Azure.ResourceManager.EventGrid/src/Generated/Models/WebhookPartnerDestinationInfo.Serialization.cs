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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class WebhookPartnerDestinationInfo : IUtf8JsonSerializable, IModelJsonSerializable<WebhookPartnerDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WebhookPartnerDestinationInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WebhookPartnerDestinationInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebhookPartnerDestinationInfo>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(AzureSubscriptionId))
            {
                writer.WritePropertyName("azureSubscriptionId"u8);
                writer.WriteStringValue(AzureSubscriptionId);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(EndpointServiceContext))
            {
                writer.WritePropertyName("endpointServiceContext"u8);
                writer.WriteStringValue(EndpointServiceContext);
            }
            if (Optional.IsCollectionDefined(ResourceMoveChangeHistory))
            {
                writer.WritePropertyName("resourceMoveChangeHistory"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceMoveChangeHistory)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ResourceMoveChangeHistory>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(EndpointUri))
            {
                writer.WritePropertyName("endpointUrl"u8);
                writer.WriteStringValue(EndpointUri.AbsoluteUri);
            }
            if (Optional.IsDefined(EndpointBaseUri))
            {
                writer.WritePropertyName("endpointBaseUrl"u8);
                writer.WriteStringValue(EndpointBaseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ClientAuthentication))
            {
                writer.WritePropertyName("clientAuthentication"u8);
                if (ClientAuthentication is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PartnerClientAuthentication>)ClientAuthentication).Serialize(writer, options);
                }
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

        internal static WebhookPartnerDestinationInfo DeserializeWebhookPartnerDestinationInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> azureSubscriptionId = default;
            Optional<string> resourceGroupName = default;
            Optional<string> name = default;
            PartnerEndpointType endpointType = default;
            Optional<string> endpointServiceContext = default;
            Optional<IList<ResourceMoveChangeHistory>> resourceMoveChangeHistory = default;
            Optional<Uri> endpointUri = default;
            Optional<Uri> endpointBaseUri = default;
            Optional<PartnerClientAuthentication> clientAuthentication = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("azureSubscriptionId"u8))
                {
                    azureSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new PartnerEndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("endpointServiceContext"u8))
                {
                    endpointServiceContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceMoveChangeHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceMoveChangeHistory> array = new List<ResourceMoveChangeHistory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.ResourceMoveChangeHistory.DeserializeResourceMoveChangeHistory(item));
                    }
                    resourceMoveChangeHistory = array;
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
                        if (property0.NameEquals("endpointUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpointBaseUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpointBaseUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("clientAuthentication"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAuthentication = PartnerClientAuthentication.DeserializePartnerClientAuthentication(property0.Value);
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
            return new WebhookPartnerDestinationInfo(azureSubscriptionId.Value, resourceGroupName.Value, name.Value, endpointType, endpointServiceContext.Value, Optional.ToList(resourceMoveChangeHistory), endpointUri.Value, endpointBaseUri.Value, clientAuthentication.Value, serializedAdditionalRawData);
        }

        WebhookPartnerDestinationInfo IModelJsonSerializable<WebhookPartnerDestinationInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebhookPartnerDestinationInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWebhookPartnerDestinationInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WebhookPartnerDestinationInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebhookPartnerDestinationInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WebhookPartnerDestinationInfo IModelSerializable<WebhookPartnerDestinationInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<WebhookPartnerDestinationInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWebhookPartnerDestinationInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WebhookPartnerDestinationInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WebhookPartnerDestinationInfo"/> to convert. </param>
        public static implicit operator RequestContent(WebhookPartnerDestinationInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WebhookPartnerDestinationInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WebhookPartnerDestinationInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWebhookPartnerDestinationInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
