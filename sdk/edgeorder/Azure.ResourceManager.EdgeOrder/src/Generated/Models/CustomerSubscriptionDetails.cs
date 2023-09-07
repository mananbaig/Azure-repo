// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Holds Customer subscription details. Clients can display available products to unregistered customers by explicitly passing subscription details. </summary>
    public partial class CustomerSubscriptionDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CustomerSubscriptionDetails"/>. </summary>
        /// <param name="quotaId"> Quota ID of a subscription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="quotaId"/> is null. </exception>
        public CustomerSubscriptionDetails(string quotaId)
        {
            Argument.AssertNotNull(quotaId, nameof(quotaId));

            RegisteredFeatures = new ChangeTrackingList<CustomerSubscriptionRegisteredFeatures>();
            QuotaId = quotaId;
        }

        /// <summary> Initializes a new instance of <see cref="CustomerSubscriptionDetails"/>. </summary>
        /// <param name="registeredFeatures"> List of registered feature flags for subscription. </param>
        /// <param name="locationPlacementId"> Location placement Id of a subscription. </param>
        /// <param name="quotaId"> Quota ID of a subscription. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomerSubscriptionDetails(IList<CustomerSubscriptionRegisteredFeatures> registeredFeatures, string locationPlacementId, string quotaId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RegisteredFeatures = registeredFeatures;
            LocationPlacementId = locationPlacementId;
            QuotaId = quotaId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomerSubscriptionDetails"/> for deserialization. </summary>
        internal CustomerSubscriptionDetails()
        {
        }

        /// <summary> List of registered feature flags for subscription. </summary>
        public IList<CustomerSubscriptionRegisteredFeatures> RegisteredFeatures { get; }
        /// <summary> Location placement Id of a subscription. </summary>
        public string LocationPlacementId { get; set; }
        /// <summary> Quota ID of a subscription. </summary>
        public string QuotaId { get; }
    }
}
