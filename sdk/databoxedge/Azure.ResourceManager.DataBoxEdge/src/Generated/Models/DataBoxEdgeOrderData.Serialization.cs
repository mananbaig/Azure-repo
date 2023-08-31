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
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    public partial class DataBoxEdgeOrderData : IUtf8JsonSerializable, IModelJsonSerializable<DataBoxEdgeOrderData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DataBoxEdgeOrderData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DataBoxEdgeOrderData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ContactInformation))
            {
                writer.WritePropertyName("contactInformation"u8);
                writer.WriteObjectValue(ContactInformation);
            }
            if (Optional.IsDefined(ShippingAddress))
            {
                writer.WritePropertyName("shippingAddress"u8);
                writer.WriteObjectValue(ShippingAddress);
            }
            if (Optional.IsDefined(ShipmentType))
            {
                writer.WritePropertyName("shipmentType"u8);
                writer.WriteStringValue(ShipmentType.Value.ToString());
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
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

        internal static DataBoxEdgeOrderData DeserializeDataBoxEdgeOrderData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> orderId = default;
            Optional<DataBoxEdgeContactDetails> contactInformation = default;
            Optional<DataBoxEdgeShippingAddress> shippingAddress = default;
            Optional<DataBoxEdgeOrderStatus> currentStatus = default;
            Optional<IReadOnlyList<DataBoxEdgeOrderStatus>> orderHistory = default;
            Optional<string> serialNumber = default;
            Optional<IReadOnlyList<DataBoxEdgeTrackingInfo>> deliveryTrackingInfo = default;
            Optional<IReadOnlyList<DataBoxEdgeTrackingInfo>> returnTrackingInfo = default;
            Optional<DataBoxEdgeShipmentType> shipmentType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("orderId"u8))
                        {
                            orderId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("contactInformation"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            contactInformation = DataBoxEdgeContactDetails.DeserializeDataBoxEdgeContactDetails(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("shippingAddress"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shippingAddress = DataBoxEdgeShippingAddress.DeserializeDataBoxEdgeShippingAddress(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("currentStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            currentStatus = DataBoxEdgeOrderStatus.DeserializeDataBoxEdgeOrderStatus(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("orderHistory"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeOrderStatus> array = new List<DataBoxEdgeOrderStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeOrderStatus.DeserializeDataBoxEdgeOrderStatus(item));
                            }
                            orderHistory = array;
                            continue;
                        }
                        if (property0.NameEquals("serialNumber"u8))
                        {
                            serialNumber = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("deliveryTrackingInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeTrackingInfo> array = new List<DataBoxEdgeTrackingInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(item));
                            }
                            deliveryTrackingInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("returnTrackingInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxEdgeTrackingInfo> array = new List<DataBoxEdgeTrackingInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxEdgeTrackingInfo.DeserializeDataBoxEdgeTrackingInfo(item));
                            }
                            returnTrackingInfo = array;
                            continue;
                        }
                        if (property0.NameEquals("shipmentType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            shipmentType = new DataBoxEdgeShipmentType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DataBoxEdgeOrderData(id, name, type, systemData.Value, kind.Value, orderId.Value, contactInformation.Value, shippingAddress.Value, currentStatus.Value, Optional.ToList(orderHistory), serialNumber.Value, Optional.ToList(deliveryTrackingInfo), Optional.ToList(returnTrackingInfo), Optional.ToNullable(shipmentType), rawData);
        }

        DataBoxEdgeOrderData IModelJsonSerializable<DataBoxEdgeOrderData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxEdgeOrderData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DataBoxEdgeOrderData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DataBoxEdgeOrderData IModelSerializable<DataBoxEdgeOrderData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDataBoxEdgeOrderData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DataBoxEdgeOrderData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DataBoxEdgeOrderData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDataBoxEdgeOrderData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
