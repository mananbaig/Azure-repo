// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    public partial class StopSellOffersPlansNotificationsList
    {
        internal static StopSellOffersPlansNotificationsList DeserializeStopSellOffersPlansNotificationsList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<IReadOnlyList<StopSellOffersPlansNotificationsResult>> stopSellNotifications = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stopSellNotifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StopSellOffersPlansNotificationsResult> array = new List<StopSellOffersPlansNotificationsResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StopSellOffersPlansNotificationsResult.DeserializeStopSellOffersPlansNotificationsResult(item));
                    }
                    stopSellNotifications = array;
                    continue;
                }
            }
            return new StopSellOffersPlansNotificationsList(Core.Optional.ToList(stopSellNotifications));
        }
    }
}
