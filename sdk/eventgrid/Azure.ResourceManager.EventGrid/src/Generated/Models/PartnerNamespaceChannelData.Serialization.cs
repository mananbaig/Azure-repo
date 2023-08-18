// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class PartnerNamespaceChannelData : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ChannelType))
            {
                writer.WritePropertyName("channelType"u8);
                writer.WriteStringValue(ChannelType.Value.ToString());
            }
            if (Core.Optional.IsDefined(PartnerTopicInfo))
            {
                writer.WritePropertyName("partnerTopicInfo"u8);
                writer.WriteObjectValue(PartnerTopicInfo);
            }
            if (Core.Optional.IsDefined(PartnerDestinationInfo))
            {
                writer.WritePropertyName("partnerDestinationInfo"u8);
                writer.WriteObjectValue(PartnerDestinationInfo);
            }
            if (Core.Optional.IsDefined(MessageForActivation))
            {
                writer.WritePropertyName("messageForActivation"u8);
                writer.WriteStringValue(MessageForActivation);
            }
            if (Core.Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Core.Optional.IsDefined(ReadinessState))
            {
                writer.WritePropertyName("readinessState"u8);
                writer.WriteStringValue(ReadinessState.Value.ToString());
            }
            if (Core.Optional.IsDefined(ExpireOnIfNotActivated))
            {
                writer.WritePropertyName("expirationTimeIfNotActivatedUtc"u8);
                writer.WriteStringValue(ExpireOnIfNotActivated.Value, "O");
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static PartnerNamespaceChannelData DeserializePartnerNamespaceChannelData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Core.Optional<SystemData> systemData = default;
            Core.Optional<PartnerNamespaceChannelType> channelType = default;
            Core.Optional<PartnerTopicInfo> partnerTopicInfo = default;
            Core.Optional<PartnerDestinationInfo> partnerDestinationInfo = default;
            Core.Optional<string> messageForActivation = default;
            Core.Optional<PartnerNamespaceChannelProvisioningState> provisioningState = default;
            Core.Optional<PartnerTopicReadinessState> readinessState = default;
            Core.Optional<DateTimeOffset> expirationTimeIfNotActivatedUtc = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("channelType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            channelType = new PartnerNamespaceChannelType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerTopicInfo = PartnerTopicInfo.DeserializePartnerTopicInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("partnerDestinationInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerDestinationInfo = PartnerDestinationInfo.DeserializePartnerDestinationInfo(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("messageForActivation"u8))
                        {
                            messageForActivation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PartnerNamespaceChannelProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("readinessState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            readinessState = new PartnerTopicReadinessState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("expirationTimeIfNotActivatedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expirationTimeIfNotActivatedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new PartnerNamespaceChannelData(id, name, type, systemData.Value, Core.Optional.ToNullable(channelType), partnerTopicInfo.Value, partnerDestinationInfo.Value, messageForActivation.Value, Core.Optional.ToNullable(provisioningState), Core.Optional.ToNullable(readinessState), Core.Optional.ToNullable(expirationTimeIfNotActivatedUtc));
        }
    }
}
