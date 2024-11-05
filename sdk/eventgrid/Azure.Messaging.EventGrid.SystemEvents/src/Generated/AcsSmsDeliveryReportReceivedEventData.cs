// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.SMSDeliveryReportReceived event. </summary>
    public partial class AcsSmsDeliveryReportReceivedEventData : AcsSmsEventBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsSmsDeliveryReportReceivedEventData"/>. </summary>
        /// <param name="deliveryAttempts"> List of details of delivery attempts made. </param>
        /// <param name="receivedTimestamp"> The time at which the SMS delivery report was received. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deliveryAttempts"/> is null. </exception>
        internal AcsSmsDeliveryReportReceivedEventData(IEnumerable<AcsSmsDeliveryAttemptProperties> deliveryAttempts, DateTimeOffset receivedTimestamp)
        {
            Argument.AssertNotNull(deliveryAttempts, nameof(deliveryAttempts));

            DeliveryAttempts = deliveryAttempts.ToList();
            ReceivedTimestamp = receivedTimestamp;
        }

        /// <summary> Initializes a new instance of <see cref="AcsSmsDeliveryReportReceivedEventData"/>. </summary>
        /// <param name="messageId"> The identity of the SMS message. </param>
        /// <param name="from"> The identity of SMS message sender. </param>
        /// <param name="to"> The identity of SMS message receiver. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="deliveryStatus"> Status of Delivery. </param>
        /// <param name="deliveryStatusDetails"> Details about Delivery Status. </param>
        /// <param name="deliveryAttempts"> List of details of delivery attempts made. </param>
        /// <param name="receivedTimestamp"> The time at which the SMS delivery report was received. </param>
        /// <param name="tag"> Customer Content. </param>
        internal AcsSmsDeliveryReportReceivedEventData(string messageId, string @from, string to, IDictionary<string, BinaryData> serializedAdditionalRawData, string deliveryStatus, string deliveryStatusDetails, IReadOnlyList<AcsSmsDeliveryAttemptProperties> deliveryAttempts, DateTimeOffset receivedTimestamp, string tag) : base(messageId, @from, to, serializedAdditionalRawData)
        {
            DeliveryStatus = deliveryStatus;
            DeliveryStatusDetails = deliveryStatusDetails;
            DeliveryAttempts = deliveryAttempts;
            ReceivedTimestamp = receivedTimestamp;
            Tag = tag;
        }

        /// <summary> Initializes a new instance of <see cref="AcsSmsDeliveryReportReceivedEventData"/> for deserialization. </summary>
        internal AcsSmsDeliveryReportReceivedEventData()
        {
        }

        /// <summary> Status of Delivery. </summary>
        public string DeliveryStatus { get; }
        /// <summary> Details about Delivery Status. </summary>
        public string DeliveryStatusDetails { get; }
        /// <summary> List of details of delivery attempts made. </summary>
        public IReadOnlyList<AcsSmsDeliveryAttemptProperties> DeliveryAttempts { get; }
        /// <summary> The time at which the SMS delivery report was received. </summary>
        public DateTimeOffset ReceivedTimestamp { get; }
        /// <summary> Customer Content. </summary>
        public string Tag { get; }
    }
}
