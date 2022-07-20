// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Parameters supplied to the Check Name Availability for Namespace and NotificationHubs. </summary>
    public partial class CheckAvailabilityParameters : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CheckAvailabilityParameters. </summary>
        /// <param name="location"> The location. </param>
        public CheckAvailabilityParameters(AzureLocation location) : base(location)
        {
        }

        /// <summary> The sku of the created namespace. </summary>
        public NotificationHubsSku Sku { get; set; }
        /// <summary> True if the name is available and can be used to create new Namespace/NotificationHub. Otherwise false. </summary>
        public bool? IsAvailiable { get; set; }
    }
}
