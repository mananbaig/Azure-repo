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

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridTopicPatch : IUtf8JsonSerializable, IModelJsonSerializable<EventGridTopicPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventGridTopicPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventGridTopicPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridTopicPatch>(this, options.Format);

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
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                if (Sku is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<ResourceSku>)Sku).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InboundIPRules))
            {
                writer.WritePropertyName("inboundIpRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundIPRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EventGridInboundIPRule>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinimumTlsVersionAllowed))
            {
                writer.WritePropertyName("minimumTlsVersionAllowed"u8);
                writer.WriteStringValue(MinimumTlsVersionAllowed.Value.ToString());
            }
            if (Optional.IsDefined(IsLocalAuthDisabled))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
            }
            if (Optional.IsDefined(DataResidencyBoundary))
            {
                writer.WritePropertyName("dataResidencyBoundary"u8);
                writer.WriteStringValue(DataResidencyBoundary.Value.ToString());
            }
            if (Optional.IsDefined(EventTypeInfo))
            {
                writer.WritePropertyName("eventTypeInfo"u8);
                if (EventTypeInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PartnerTopicEventTypeInfo>)EventTypeInfo).Serialize(writer, options);
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

        internal static EventGridTopicPatch DeserializeEventGridTopicPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<ResourceSku> sku = default;
            Optional<EventGridPublicNetworkAccess> publicNetworkAccess = default;
            Optional<IList<EventGridInboundIPRule>> inboundIPRules = default;
            Optional<TlsVersion> minimumTlsVersionAllowed = default;
            Optional<bool> disableLocalAuth = default;
            Optional<DataResidencyBoundary> dataResidencyBoundary = default;
            Optional<PartnerTopicEventTypeInfo> eventTypeInfo = default;
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
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = ResourceSku.DeserializeResourceSku(property.Value);
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
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new EventGridPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inboundIpRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventGridInboundIPRule> array = new List<EventGridInboundIPRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventGridInboundIPRule.DeserializeEventGridInboundIPRule(item));
                            }
                            inboundIPRules = array;
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersionAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersionAllowed = new TlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("dataResidencyBoundary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            dataResidencyBoundary = new DataResidencyBoundary(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("eventTypeInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventTypeInfo = PartnerTopicEventTypeInfo.DeserializePartnerTopicEventTypeInfo(property0.Value);
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
            return new EventGridTopicPatch(Optional.ToDictionary(tags), identity, sku.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToList(inboundIPRules), Optional.ToNullable(minimumTlsVersionAllowed), Optional.ToNullable(disableLocalAuth), Optional.ToNullable(dataResidencyBoundary), eventTypeInfo.Value, serializedAdditionalRawData);
        }

        EventGridTopicPatch IModelJsonSerializable<EventGridTopicPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridTopicPatch>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridTopicPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventGridTopicPatch>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridTopicPatch>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventGridTopicPatch IModelSerializable<EventGridTopicPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventGridTopicPatch>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventGridTopicPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventGridTopicPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventGridTopicPatch"/> to convert. </param>
        public static implicit operator RequestContent(EventGridTopicPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventGridTopicPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventGridTopicPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventGridTopicPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
