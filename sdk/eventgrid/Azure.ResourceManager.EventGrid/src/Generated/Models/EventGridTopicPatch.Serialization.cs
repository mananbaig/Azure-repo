// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridTopicPatch : IUtf8JsonSerializable, IJsonModel<EventGridTopicPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventGridTopicPatch>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EventGridTopicPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridTopicPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridTopicPatch)} does not support writing '{format}' format.");
            }

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
                writer.WriteObjectValue(Sku, options);
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
                    writer.WriteObjectValue(item, options);
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
                writer.WriteObjectValue(EventTypeInfo, options);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        EventGridTopicPatch IJsonModel<EventGridTopicPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridTopicPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventGridTopicPatch)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventGridTopicPatch(document.RootElement, options);
        }

        internal static EventGridTopicPatch DeserializeEventGridTopicPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            ManagedServiceIdentity identity = default;
            ResourceSku sku = default;
            EventGridPublicNetworkAccess? publicNetworkAccess = default;
            IList<EventGridInboundIPRule> inboundIPRules = default;
            TlsVersion? minimumTlsVersionAllowed = default;
            bool? disableLocalAuth = default;
            DataResidencyBoundary? dataResidencyBoundary = default;
            PartnerTopicEventTypeInfo eventTypeInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
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
                    sku = ResourceSku.DeserializeResourceSku(property.Value, options);
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
                                array.Add(EventGridInboundIPRule.DeserializeEventGridInboundIPRule(item, options));
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
                            eventTypeInfo = PartnerTopicEventTypeInfo.DeserializePartnerTopicEventTypeInfo(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EventGridTopicPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                identity,
                sku,
                publicNetworkAccess,
                inboundIPRules ?? new ChangeTrackingList<EventGridInboundIPRule>(),
                minimumTlsVersionAllowed,
                disableLocalAuth,
                dataResidencyBoundary,
                eventTypeInfo,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventGridTopicPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridTopicPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventGridTopicPatch)} does not support writing '{options.Format}' format.");
            }
        }

        EventGridTopicPatch IPersistableModel<EventGridTopicPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventGridTopicPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventGridTopicPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventGridTopicPatch)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventGridTopicPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
