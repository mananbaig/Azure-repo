// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    internal partial class UnknownDataCenterAddressResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("datacenterAddressType");
            writer.WriteStringValue(DataCenterAddressType.ToSerialString());
            writer.WriteEndObject();
        }

        internal static UnknownDataCenterAddressResult DeserializeUnknownDataCenterAddressResult(JsonElement element)
        {
            DataCenterAddressType dataCenterAddressType = default;
            Optional<IReadOnlyList<string>> supportedCarriersForReturnShipment = default;
            Optional<AzureLocation> dataCenterAzureLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datacenterAddressType"))
                {
                    dataCenterAddressType = property.Value.GetString().ToDataCenterAddressType();
                    continue;
                }
                if (property.NameEquals("supportedCarriersForReturnShipment"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedCarriersForReturnShipment = array;
                    continue;
                }
                if (property.NameEquals("dataCenterAzureLocation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    dataCenterAzureLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownDataCenterAddressResult(dataCenterAddressType, Optional.ToList(supportedCarriersForReturnShipment), Optional.ToNullable(dataCenterAzureLocation));
        }
    }
}
