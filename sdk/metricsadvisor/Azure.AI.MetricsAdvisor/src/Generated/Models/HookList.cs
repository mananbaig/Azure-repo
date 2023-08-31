// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.MetricsAdvisor.Administration;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The HookList. </summary>
    internal partial class HookList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HookList"/>. </summary>
        internal HookList()
        {
            Value = new ChangeTrackingList<NotificationHook>();
        }

        /// <summary> Initializes a new instance of <see cref="HookList"/>. </summary>
        /// <param name="nextLink"></param>
        /// <param name="value">
        /// Please note <see cref="NotificationHook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EmailNotificationHook"/> and <see cref="WebNotificationHook"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HookList(string nextLink, IReadOnlyList<NotificationHook> value, Dictionary<string, BinaryData> rawData)
        {
            NextLink = nextLink;
            Value = value;
            _rawData = rawData;
        }

        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
        /// <summary>
        /// Gets the value
        /// Please note <see cref="NotificationHook"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="EmailNotificationHook"/> and <see cref="WebNotificationHook"/>.
        /// </summary>
        public IReadOnlyList<NotificationHook> Value { get; }
    }
}
