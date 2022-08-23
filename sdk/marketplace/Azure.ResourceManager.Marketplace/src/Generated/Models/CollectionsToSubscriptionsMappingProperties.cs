// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> The subscriptions list to get the related collections. </summary>
    internal partial class CollectionsToSubscriptionsMappingProperties
    {
        /// <summary> Initializes a new instance of CollectionsToSubscriptionsMappingProperties. </summary>
        public CollectionsToSubscriptionsMappingProperties()
        {
            SubscriptionIds = new ChangeTrackingList<string>();
        }

        /// <summary> Subscriptions ids list. </summary>
        public IList<string> SubscriptionIds { get; }
    }
}
