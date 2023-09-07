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
using Azure.ResourceManager.EventHubs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventHubs
{
    public partial class EventHubsNetworkRuleSetData : IUtf8JsonSerializable, IModelJsonSerializable<EventHubsNetworkRuleSetData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EventHubsNetworkRuleSetData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EventHubsNetworkRuleSetData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetData>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TrustedServiceAccessEnabled))
            {
                writer.WritePropertyName("trustedServiceAccessEnabled"u8);
                writer.WriteBooleanValue(TrustedServiceAccessEnabled.Value);
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EventHubsNetworkRuleSetVirtualNetworkRules>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<EventHubsNetworkRuleSetIPRules>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
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

        internal static EventHubsNetworkRuleSetData DeserializeEventHubsNetworkRuleSetData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<bool> trustedServiceAccessEnabled = default;
            Optional<EventHubsNetworkRuleSetDefaultAction> defaultAction = default;
            Optional<IList<EventHubsNetworkRuleSetVirtualNetworkRules>> virtualNetworkRules = default;
            Optional<IList<EventHubsNetworkRuleSetIPRules>> ipRules = default;
            Optional<EventHubsPublicNetworkAccessFlag> publicNetworkAccess = default;
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
                        if (property0.NameEquals("trustedServiceAccessEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedServiceAccessEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultAction = new EventHubsNetworkRuleSetDefaultAction(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventHubsNetworkRuleSetVirtualNetworkRules> array = new List<EventHubsNetworkRuleSetVirtualNetworkRules>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventHubsNetworkRuleSetVirtualNetworkRules.DeserializeEventHubsNetworkRuleSetVirtualNetworkRules(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("ipRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventHubsNetworkRuleSetIPRules> array = new List<EventHubsNetworkRuleSetIPRules>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventHubsNetworkRuleSetIPRules.DeserializeEventHubsNetworkRuleSetIPRules(item));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new EventHubsPublicNetworkAccessFlag(property0.Value.GetString());
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
            return new EventHubsNetworkRuleSetData(id, name, type, systemData.Value, Optional.ToNullable(trustedServiceAccessEnabled), Optional.ToNullable(defaultAction), Optional.ToList(virtualNetworkRules), Optional.ToList(ipRules), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(location), serializedAdditionalRawData);
        }

        EventHubsNetworkRuleSetData IModelJsonSerializable<EventHubsNetworkRuleSetData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNetworkRuleSetData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EventHubsNetworkRuleSetData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EventHubsNetworkRuleSetData IModelSerializable<EventHubsNetworkRuleSetData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<EventHubsNetworkRuleSetData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEventHubsNetworkRuleSetData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EventHubsNetworkRuleSetData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EventHubsNetworkRuleSetData"/> to convert. </param>
        public static implicit operator RequestContent(EventHubsNetworkRuleSetData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EventHubsNetworkRuleSetData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EventHubsNetworkRuleSetData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEventHubsNetworkRuleSetData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
