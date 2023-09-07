// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Subscription.Models
{
    /// <summary> The ID of the subscriptions that is being enabled. </summary>
    public partial class EnabledSubscriptionId
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EnabledSubscriptionId"/>. </summary>
        internal EnabledSubscriptionId()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EnabledSubscriptionId"/>. </summary>
        /// <param name="subscriptionId"> The ID of the subscriptions that is being enabled. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EnabledSubscriptionId(string subscriptionId, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            SubscriptionId = subscriptionId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The ID of the subscriptions that is being enabled. </summary>
        public string SubscriptionId { get; }
    }
}
