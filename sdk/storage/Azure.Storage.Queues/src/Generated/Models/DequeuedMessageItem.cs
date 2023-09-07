// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Queues.Models
{
    /// <summary> The object returned in the QueueMessageList array when calling Get Messages on a Queue. </summary>
    internal partial class DequeuedMessageItem
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DequeuedMessageItem"/>. </summary>
        /// <param name="messageId"> The Id of the Message. </param>
        /// <param name="insertionTime"> The time the Message was inserted into the Queue. </param>
        /// <param name="expirationTime"> The time that the Message will expire and be automatically deleted. </param>
        /// <param name="popReceipt"> This value is required to delete the Message. If deletion fails using this popreceipt then the message has been dequeued by another client. </param>
        /// <param name="timeNextVisible"> The time that the message will again become visible in the Queue. </param>
        /// <param name="dequeueCount"> The number of times the message has been dequeued. </param>
        /// <param name="messageText"> The content of the Message. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="messageId"/>, <paramref name="popReceipt"/> or <paramref name="messageText"/> is null. </exception>
        internal DequeuedMessageItem(string messageId, DateTimeOffset insertionTime, DateTimeOffset expirationTime, string popReceipt, DateTimeOffset timeNextVisible, long dequeueCount, string messageText)
        {
            Argument.AssertNotNull(messageId, nameof(messageId));
            Argument.AssertNotNull(popReceipt, nameof(popReceipt));
            Argument.AssertNotNull(messageText, nameof(messageText));

            MessageId = messageId;
            InsertionTime = insertionTime;
            ExpirationTime = expirationTime;
            PopReceipt = popReceipt;
            TimeNextVisible = timeNextVisible;
            DequeueCount = dequeueCount;
            MessageText = messageText;
        }

        /// <summary> Initializes a new instance of <see cref="DequeuedMessageItem"/>. </summary>
        /// <param name="messageId"> The Id of the Message. </param>
        /// <param name="insertionTime"> The time the Message was inserted into the Queue. </param>
        /// <param name="expirationTime"> The time that the Message will expire and be automatically deleted. </param>
        /// <param name="popReceipt"> This value is required to delete the Message. If deletion fails using this popreceipt then the message has been dequeued by another client. </param>
        /// <param name="timeNextVisible"> The time that the message will again become visible in the Queue. </param>
        /// <param name="dequeueCount"> The number of times the message has been dequeued. </param>
        /// <param name="messageText"> The content of the Message. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DequeuedMessageItem(string messageId, DateTimeOffset insertionTime, DateTimeOffset expirationTime, string popReceipt, DateTimeOffset timeNextVisible, long dequeueCount, string messageText, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MessageId = messageId;
            InsertionTime = insertionTime;
            ExpirationTime = expirationTime;
            PopReceipt = popReceipt;
            TimeNextVisible = timeNextVisible;
            DequeueCount = dequeueCount;
            MessageText = messageText;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="DequeuedMessageItem"/> for deserialization. </summary>
        internal DequeuedMessageItem()
        {
        }

        /// <summary> The Id of the Message. </summary>
        public string MessageId { get; }
        /// <summary> The time the Message was inserted into the Queue. </summary>
        public DateTimeOffset InsertionTime { get; }
        /// <summary> The time that the Message will expire and be automatically deleted. </summary>
        public DateTimeOffset ExpirationTime { get; }
        /// <summary> This value is required to delete the Message. If deletion fails using this popreceipt then the message has been dequeued by another client. </summary>
        public string PopReceipt { get; }
        /// <summary> The time that the message will again become visible in the Queue. </summary>
        public DateTimeOffset TimeNextVisible { get; }
        /// <summary> The number of times the message has been dequeued. </summary>
        public long DequeueCount { get; }
        /// <summary> The content of the Message. </summary>
        public string MessageText { get; }
    }
}
