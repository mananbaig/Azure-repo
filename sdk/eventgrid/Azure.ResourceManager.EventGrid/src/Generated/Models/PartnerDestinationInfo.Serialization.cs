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
    public partial class PartnerDestinationInfo : IUtf8JsonSerializable, IModelJsonSerializable<PartnerDestinationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PartnerDestinationInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PartnerDestinationInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationInfo>(this, options.Format);

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

        internal static PartnerDestinationInfo DeserializePartnerDestinationInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "WebHook": return WebhookPartnerDestinationInfo.DeserializeWebhookPartnerDestinationInfo(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<string> azureSubscriptionId = default;
            Optional<string> resourceGroupName = default;
            Optional<string> name = default;
            PartnerEndpointType endpointType = default;
            Optional<string> endpointServiceContext = default;
            Optional<IList<ResourceMoveChangeHistory>> resourceMoveChangeHistory = default;
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownPartnerDestinationInfo(azureSubscriptionId.Value, resourceGroupName.Value, name.Value, endpointType, endpointServiceContext.Value, Optional.ToList(resourceMoveChangeHistory), serializedAdditionalRawData);
        }

        PartnerDestinationInfo IModelJsonSerializable<PartnerDestinationInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationInfo>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerDestinationInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PartnerDestinationInfo>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationInfo>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PartnerDestinationInfo IModelSerializable<PartnerDestinationInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<PartnerDestinationInfo>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePartnerDestinationInfo(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="PartnerDestinationInfo"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="PartnerDestinationInfo"/> to convert. </param>
        public static implicit operator RequestContent(PartnerDestinationInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="PartnerDestinationInfo"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator PartnerDestinationInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePartnerDestinationInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
