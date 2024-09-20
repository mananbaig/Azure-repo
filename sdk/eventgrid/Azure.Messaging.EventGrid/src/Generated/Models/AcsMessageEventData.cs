// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of common properties of all chat thread events. </summary>
    public partial class AcsMessageEventData
    {
        /// <summary> Initializes a new instance of <see cref="AcsMessageEventData"/>. </summary>
        internal AcsMessageEventData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AcsMessageEventData"/>. </summary>
        /// <param name="from"> The message sender. </param>
        /// <param name="to"> The message recipient. </param>
        /// <param name="receivedTimestamp"> The time message was received. </param>
        /// <param name="errorInternal"> The channel event error. </param>
        internal AcsMessageEventData(string @from, string to, DateTimeOffset? receivedTimestamp, AcsMessageChannelEventError errorInternal)
        {
            From = @from;
            To = to;
            ReceivedTimestamp = receivedTimestamp;
            ErrorInternal = errorInternal;
        }

        /// <summary> The message sender. </summary>
        public string From { get; }
        /// <summary> The message recipient. </summary>
        public string To { get; }
        /// <summary> The time message was received. </summary>
        public DateTimeOffset? ReceivedTimestamp { get; }
    }
}
