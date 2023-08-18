// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class AzureFunctionEventSubscriptionDestination : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Core.Optional.IsDefined(MaxEventsPerBatch))
            {
                writer.WritePropertyName("maxEventsPerBatch"u8);
                writer.WriteNumberValue(MaxEventsPerBatch.Value);
            }
            if (Core.Optional.IsDefined(PreferredBatchSizeInKilobytes))
            {
                writer.WritePropertyName("preferredBatchSizeInKilobytes"u8);
                writer.WriteNumberValue(PreferredBatchSizeInKilobytes.Value);
            }
            if (Core.Optional.IsCollectionDefined(DeliveryAttributeMappings))
            {
                writer.WritePropertyName("deliveryAttributeMappings"u8);
                writer.WriteStartArray();
                foreach (var item in DeliveryAttributeMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static AzureFunctionEventSubscriptionDestination DeserializeAzureFunctionEventSubscriptionDestination(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EndpointType endpointType = default;
            Core.Optional<ResourceIdentifier> resourceId = default;
            Core.Optional<int> maxEventsPerBatch = default;
            Core.Optional<int> preferredBatchSizeInKilobytes = default;
            Core.Optional<IList<DeliveryAttributeMapping>> deliveryAttributeMappings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
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
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("maxEventsPerBatch"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxEventsPerBatch = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("preferredBatchSizeInKilobytes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            preferredBatchSizeInKilobytes = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("deliveryAttributeMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeliveryAttributeMapping> array = new List<DeliveryAttributeMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeliveryAttributeMapping.DeserializeDeliveryAttributeMapping(item));
                            }
                            deliveryAttributeMappings = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new AzureFunctionEventSubscriptionDestination(endpointType, resourceId.Value, Core.Optional.ToNullable(maxEventsPerBatch), Core.Optional.ToNullable(preferredBatchSizeInKilobytes), Core.Optional.ToList(deliveryAttributeMappings));
        }
    }
}
