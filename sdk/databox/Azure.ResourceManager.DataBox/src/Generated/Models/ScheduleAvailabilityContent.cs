// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary>
    /// Request body to get the availability for scheduling orders.
    /// Please note <see cref="ScheduleAvailabilityContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataBoxScheduleAvailabilityContent"/>, <see cref="DiskScheduleAvailabilityContent"/> and <see cref="HeavyScheduleAvailabilityContent"/>.
    /// </summary>
    public abstract partial class ScheduleAvailabilityContent
    {
        /// <summary> Initializes a new instance of <see cref="ScheduleAvailabilityContent"/>. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        protected ScheduleAvailabilityContent(AzureLocation storageLocation)
        {
            StorageLocation = storageLocation;
        }

        /// <summary> Initializes a new instance of <see cref="ScheduleAvailabilityContent"/>. </summary>
        /// <param name="storageLocation"> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </param>
        /// <param name="skuName"> Sku Name for which the order is to be scheduled. </param>
        /// <param name="country"> Country in which storage location should be supported. </param>
        internal ScheduleAvailabilityContent(AzureLocation storageLocation, DataBoxSkuName skuName, string country)
        {
            StorageLocation = storageLocation;
            SkuName = skuName;
            Country = country;
        }

        /// <summary> Location for data transfer. For locations check: https://management.azure.com/subscriptions/SUBSCRIPTIONID/locations?api-version=2018-01-01. </summary>
        public AzureLocation StorageLocation { get; }
        /// <summary> Sku Name for which the order is to be scheduled. </summary>
        internal DataBoxSkuName SkuName { get; set; }
        /// <summary> Country in which storage location should be supported. </summary>
        public string Country { get; set; }
    }
}
