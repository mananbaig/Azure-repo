// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> An event to be notified for. </summary>
    public partial class DevTestLabNotificationChannelEvent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabNotificationChannelEvent"/>. </summary>
        public DevTestLabNotificationChannelEvent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabNotificationChannelEvent"/>. </summary>
        /// <param name="eventName"> The event type for which this notification is enabled (i.e. AutoShutdown, Cost). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabNotificationChannelEvent(DevTestLabNotificationChannelEventType? eventName, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            EventName = eventName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The event type for which this notification is enabled (i.e. AutoShutdown, Cost). </summary>
        public DevTestLabNotificationChannelEventType? EventName { get; set; }
    }
}
