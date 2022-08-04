// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The details of the test notification results. </summary>
    public partial class NotificationStatus
    {
        /// <summary> Initializes a new instance of NotificationStatus. </summary>
        /// <param name="state"> The overall state. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="state"/> is null. </exception>
        internal NotificationStatus(string state)
        {
            if (state == null)
            {
                throw new ArgumentNullException(nameof(state));
            }

            State = state;
            ActionDetails = new ChangeTrackingList<NotificationActionDetail>();
        }

        /// <summary> Initializes a new instance of NotificationStatus. </summary>
        /// <param name="context"> The context info. </param>
        /// <param name="state"> The overall state. </param>
        /// <param name="completedTime"> The completed time. </param>
        /// <param name="createdTime"> The created time. </param>
        /// <param name="actionDetails"> The list of action detail. </param>
        internal NotificationStatus(NotificationContext context, string state, string completedTime, string createdTime, IReadOnlyList<NotificationActionDetail> actionDetails)
        {
            Context = context;
            State = state;
            CompletedTime = completedTime;
            CreatedTime = createdTime;
            ActionDetails = actionDetails;
        }

        /// <summary> The context info. </summary>
        public NotificationContext Context { get; }
        /// <summary> The overall state. </summary>
        public string State { get; }
        /// <summary> The completed time. </summary>
        public string CompletedTime { get; }
        /// <summary> The created time. </summary>
        public string CreatedTime { get; }
        /// <summary> The list of action detail. </summary>
        public IReadOnlyList<NotificationActionDetail> ActionDetails { get; }
    }
}
