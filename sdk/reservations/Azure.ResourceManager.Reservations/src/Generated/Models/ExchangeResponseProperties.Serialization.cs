// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ExchangeResponseProperties
    {
        internal static ExchangeResponseProperties DeserializeExchangeResponseProperties(JsonElement element)
        {
            Optional<string> sessionId = default;
            Optional<Price> netPayable = default;
            Optional<Price> refundsTotal = default;
            Optional<Price> purchasesTotal = default;
            Optional<IReadOnlyList<ReservationToPurchaseExchange>> reservationsToPurchase = default;
            Optional<IReadOnlyList<ReservationToReturnForExchange>> reservationsToExchange = default;
            Optional<ExchangePolicyErrors> policyResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("netPayable"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    netPayable = Price.DeserializePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("refundsTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    refundsTotal = Price.DeserializePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("purchasesTotal"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    purchasesTotal = Price.DeserializePrice(property.Value);
                    continue;
                }
                if (property.NameEquals("reservationsToPurchase"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReservationToPurchaseExchange> array = new List<ReservationToPurchaseExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToPurchaseExchange.DeserializeReservationToPurchaseExchange(item));
                    }
                    reservationsToPurchase = array;
                    continue;
                }
                if (property.NameEquals("reservationsToExchange"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ReservationToReturnForExchange> array = new List<ReservationToReturnForExchange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReservationToReturnForExchange.DeserializeReservationToReturnForExchange(item));
                    }
                    reservationsToExchange = array;
                    continue;
                }
                if (property.NameEquals("policyResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    policyResult = ExchangePolicyErrors.DeserializeExchangePolicyErrors(property.Value);
                    continue;
                }
            }
            return new ExchangeResponseProperties(sessionId.Value, netPayable.Value, refundsTotal.Value, purchasesTotal.Value, Optional.ToList(reservationsToPurchase), Optional.ToList(reservationsToExchange), policyResult.Value);
        }
    }
}
