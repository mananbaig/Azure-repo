// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Request approvals details. </summary>
    public partial class RequestApprovalsDetails
    {
        /// <summary> Initializes a new instance of RequestApprovalsDetails. </summary>
        internal RequestApprovalsDetails()
        {
            Plans = new Core.ChangeTrackingList<PlanNotificationDetails>();
        }

        /// <summary> Initializes a new instance of RequestApprovalsDetails. </summary>
        /// <param name="offerId"> Gets offer id. </param>
        /// <param name="displayName"> Gets offer display name. </param>
        /// <param name="publisherId"> Gets or sets publisher id. </param>
        /// <param name="messageCode"> Gets or sets the notification message id. </param>
        /// <param name="iconUri"> Gets or sets the icon url. </param>
        /// <param name="plans"> Gets or sets removed plans notifications. </param>
        internal RequestApprovalsDetails(string offerId, string displayName, string publisherId, long? messageCode, Uri iconUri, IReadOnlyList<PlanNotificationDetails> plans)
        {
            OfferId = offerId;
            DisplayName = displayName;
            PublisherId = publisherId;
            MessageCode = messageCode;
            IconUri = iconUri;
            Plans = plans;
        }

        /// <summary> Gets offer id. </summary>
        public string OfferId { get; }
        /// <summary> Gets offer display name. </summary>
        public string DisplayName { get; }
        /// <summary> Gets or sets publisher id. </summary>
        public string PublisherId { get; }
        /// <summary> Gets or sets the notification message id. </summary>
        public long? MessageCode { get; }
        /// <summary> Gets or sets the icon url. </summary>
        public Uri IconUri { get; }
        /// <summary> Gets or sets removed plans notifications. </summary>
        public IReadOnlyList<PlanNotificationDetails> Plans { get; }
    }
}
