// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemAddressProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            writer.WritePropertyName("contactDetails"u8);
            writer.WriteObjectValue(ContactDetails);
            writer.WriteEndObject();
        }

        internal static EdgeOrderItemAddressProperties DeserializeEdgeOrderItemAddressProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EdgeOrderShippingAddress> shippingAddress = default;
            EdgeOrderAddressContactDetails contactDetails = default;
            Optional<EdgeOrderAddressValidationStatus> addressValidationStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shippingAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shippingAddress = EdgeOrderShippingAddress.DeserializeEdgeOrderShippingAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("contactDetails"u8))
                {
                    contactDetails = EdgeOrderAddressContactDetails.DeserializeEdgeOrderAddressContactDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("addressValidationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressValidationStatus = new EdgeOrderAddressValidationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
            }
            return new EdgeOrderItemAddressProperties(shippingAddress.Value, contactDetails, Optional.ToNullable(addressValidationStatus), Optional.ToNullable(provisioningState));
        }
    }
}
