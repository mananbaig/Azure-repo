// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> The change history of the resource move. </summary>
    public partial class ResourceMoveChangeHistory
    {
        /// <summary> Initializes a new instance of ResourceMoveChangeHistory. </summary>
        public ResourceMoveChangeHistory()
        {
        }

        /// <summary> Initializes a new instance of ResourceMoveChangeHistory. </summary>
        /// <param name="azureSubscriptionId"> Azure subscription ID of the resource. </param>
        /// <param name="resourceGroupName"> Azure Resource Group of the resource. </param>
        /// <param name="changedTimeUtc"> UTC timestamp of when the resource was changed. </param>
        internal ResourceMoveChangeHistory(string azureSubscriptionId, string resourceGroupName, DateTimeOffset? changedTimeUtc)
        {
            AzureSubscriptionId = azureSubscriptionId;
            ResourceGroupName = resourceGroupName;
            ChangedTimeUtc = changedTimeUtc;
        }

        /// <summary> Azure subscription ID of the resource. </summary>
        public string AzureSubscriptionId { get; set; }
        /// <summary> Azure Resource Group of the resource. </summary>
        public string ResourceGroupName { get; set; }
        /// <summary> UTC timestamp of when the resource was changed. </summary>
        public DateTimeOffset? ChangedTimeUtc { get; set; }
    }
}
