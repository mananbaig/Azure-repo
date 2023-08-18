// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Notification update request payload. </summary>
    public partial class AcknowledgeOfferNotificationContent
    {
        /// <summary> Initializes a new instance of AcknowledgeOfferNotificationContent. </summary>
        public AcknowledgeOfferNotificationContent()
        {
            AddPlans = new Core.ChangeTrackingList<string>();
            RemovePlans = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Gets or sets a value indicating whether acknowledge action flag is enabled. </summary>
        public bool? IsAcknowledgeActionFlagEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether dismiss action flag is enabled. </summary>
        public bool? IsDismissActionFlagEnabled { get; set; }
        /// <summary> Gets or sets a value indicating whether remove offer action flag is enabled. </summary>
        public bool? IsRemoveOfferActionFlagEnabled { get; set; }
        /// <summary> Gets or sets added plans. </summary>
        public IList<string> AddPlans { get; }
        /// <summary> Gets or sets remove plans. </summary>
        public IList<string> RemovePlans { get; }
    }
}
