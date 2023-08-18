// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class EventGridSubscriptionPatch : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteObjectValue(Destination);
            }
            if (Core.Optional.IsDefined(DeliveryWithResourceIdentity))
            {
                writer.WritePropertyName("deliveryWithResourceIdentity"u8);
                writer.WriteObjectValue(DeliveryWithResourceIdentity);
            }
            if (Core.Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteObjectValue(Filter);
            }
            if (Core.Optional.IsCollectionDefined(Labels))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expirationTimeUtc"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (Core.Optional.IsDefined(EventDeliverySchema))
            {
                writer.WritePropertyName("eventDeliverySchema"u8);
                writer.WriteStringValue(EventDeliverySchema.Value.ToString());
            }
            if (Core.Optional.IsDefined(RetryPolicy))
            {
                writer.WritePropertyName("retryPolicy"u8);
                writer.WriteObjectValue(RetryPolicy);
            }
            if (Core.Optional.IsDefined(DeadLetterDestination))
            {
                writer.WritePropertyName("deadLetterDestination"u8);
                writer.WriteObjectValue(DeadLetterDestination);
            }
            if (Core.Optional.IsDefined(DeadLetterWithResourceIdentity))
            {
                writer.WritePropertyName("deadLetterWithResourceIdentity"u8);
                writer.WriteObjectValue(DeadLetterWithResourceIdentity);
            }
            writer.WriteEndObject();
        }
    }
}
