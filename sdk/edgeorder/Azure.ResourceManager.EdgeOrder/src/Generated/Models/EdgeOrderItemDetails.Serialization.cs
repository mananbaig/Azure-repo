// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderItemDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("productDetails"u8);
            writer.WriteObjectValue(ProductDetails);
            writer.WritePropertyName("orderItemType"u8);
            writer.WriteStringValue(OrderItemType.ToString());
            if (Optional.IsDefined(OrderItemMode))
            {
                writer.WritePropertyName("orderItemMode"u8);
                writer.WriteStringValue(OrderItemMode.Value.ToString());
            }
            if (Optional.IsDefined(SiteDetails))
            {
                writer.WritePropertyName("siteDetails"u8);
                writer.WriteObjectValue(SiteDetails);
            }
            if (Optional.IsDefined(Preferences))
            {
                writer.WritePropertyName("preferences"u8);
                writer.WriteObjectValue(Preferences);
            }
            if (Optional.IsCollectionDefined(NotificationEmailList))
            {
                writer.WritePropertyName("notificationEmailList"u8);
                writer.WriteStartArray();
                foreach (var item in NotificationEmailList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static EdgeOrderItemDetails DeserializeEdgeOrderItemDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProductDetails productDetails = default;
            OrderItemType orderItemType = default;
            Optional<OrderMode> orderItemMode = default;
            Optional<SiteDetails> siteDetails = default;
            Optional<EdgeOrderStageDetails> currentStage = default;
            Optional<IReadOnlyList<EdgeOrderStageDetails>> orderItemStageHistory = default;
            Optional<OrderItemPreferences> preferences = default;
            Optional<ForwardShippingDetails> forwardShippingDetails = default;
            Optional<ReverseShippingDetails> reverseShippingDetails = default;
            Optional<IList<string>> notificationEmailList = default;
            Optional<string> cancellationReason = default;
            Optional<OrderItemCancellationStatus> cancellationStatus = default;
            Optional<EdgeOrderActionStatus> deletionStatus = default;
            Optional<string> returnReason = default;
            Optional<OrderItemReturnStatus> returnStatus = default;
            Optional<IReadOnlyList<ResourceProviderDetails>> managementRPDetailsList = default;
            Optional<ResponseError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("productDetails"u8))
                {
                    productDetails = ProductDetails.DeserializeProductDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("orderItemType"u8))
                {
                    orderItemType = new OrderItemType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orderItemMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orderItemMode = new OrderMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("siteDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    siteDetails = SiteDetails.DeserializeSiteDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("currentStage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentStage = EdgeOrderStageDetails.DeserializeEdgeOrderStageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("orderItemStageHistory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EdgeOrderStageDetails> array = new List<EdgeOrderStageDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EdgeOrderStageDetails.DeserializeEdgeOrderStageDetails(item));
                    }
                    orderItemStageHistory = array;
                    continue;
                }
                if (property.NameEquals("preferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preferences = OrderItemPreferences.DeserializeOrderItemPreferences(property.Value);
                    continue;
                }
                if (property.NameEquals("forwardShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forwardShippingDetails = ForwardShippingDetails.DeserializeForwardShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("reverseShippingDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseShippingDetails = ReverseShippingDetails.DeserializeReverseShippingDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("notificationEmailList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    notificationEmailList = array;
                    continue;
                }
                if (property.NameEquals("cancellationReason"u8))
                {
                    cancellationReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cancellationStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancellationStatus = new OrderItemCancellationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deletionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionStatus = new EdgeOrderActionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("returnReason"u8))
                {
                    returnReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("returnStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    returnStatus = new OrderItemReturnStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managementRpDetailsList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderDetails> array = new List<ResourceProviderDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderDetails.DeserializeResourceProviderDetails(item));
                    }
                    managementRPDetailsList = array;
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
            }
            return new EdgeOrderItemDetails(productDetails, orderItemType, Optional.ToNullable(orderItemMode), siteDetails.Value, currentStage.Value, Optional.ToList(orderItemStageHistory), preferences.Value, forwardShippingDetails.Value, reverseShippingDetails.Value, Optional.ToList(notificationEmailList), cancellationReason.Value, Optional.ToNullable(cancellationStatus), Optional.ToNullable(deletionStatus), returnReason.Value, Optional.ToNullable(returnStatus), Optional.ToList(managementRPDetailsList), error.Value);
        }
    }
}
