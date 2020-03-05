﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Amqp;

namespace Azure.Messaging.ServiceBus.Core
{
    /// <summary>
    ///   Provides an abstraction for generalizing an Service Bus entity Producer so that a dedicated instance may provide operations
    ///   for a specific transport, such as AMQP or JMS.  It is intended that the public <see cref="ServiceBusSender" /> employ
    ///   a transport producer via containment and delegate operations to it rather than understanding protocol-specific details
    ///   for different transports.
    /// </summary>
    ///
    internal abstract class TransportSender
    {
        /// <summary>
        ///   Indicates whether or not this producer has been closed.
        /// </summary>
        ///
        /// <value>
        ///   <c>true</c> if the producer is closed; otherwise, <c>false</c>.
        /// </value>
        ///
        public virtual bool IsClosed { get; }

        /// <summary>
        ///   Creates a size-constraint batch to which <see cref="ServiceBusMessage" /> may be added using a try-based pattern.  If a message would
        ///   exceed the maximum allowable size of the batch, the batch will not allow adding the message and signal that scenario using its
        ///   return value.
        ///
        ///   Because messages that would violate the size constraint cannot be added, publishing a batch will not trigger an exception when
        ///   attempting to send the message to the Queue/Topic.
        /// </summary>
        ///
        /// <param name="options">The set of options to consider when creating this batch.</param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>An <see cref="ServiceBusMessageBatch" /> with the requested <paramref name="options"/>.</returns>
        ///
        /// <seealso cref="CreateBatchAsync(CreateBatchOptions, CancellationToken)" />
        ///
        public abstract ValueTask<TransportMessageBatch> CreateBatchAsync(
            CreateBatchOptions options,
            CancellationToken cancellationToken);
        /// <summary>
        ///   Sends a message to the associated Service Bus entity.
        /// </summary>
        ///
        /// <param name="message">A message to send.</param>
        /// <param name="retryPolicy"></param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        public abstract Task SendAsync(
            ServiceBusMessage message,
            ServiceBusRetryPolicy retryPolicy,
            CancellationToken cancellationToken);

        /// <summary>
        ///   Sends a set of messages to the associated Queue/Topic using a batched approach.
        /// </summary>
        ///
        /// <param name="messageBatch">The set of messages to send.</param>
        /// <param name="retryPolicy"></param>
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        /// <returns>A task to be resolved on when the operation has completed.</returns>
        ///
        public abstract Task SendBatchAsync(
            ServiceBusMessageBatch messageBatch,
            ServiceBusRetryPolicy retryPolicy,
            CancellationToken cancellationToken);

        /// <summary>
        ///
        /// </summary>
        /// <param name="message"></param>
        /// <param name="retryPolicy"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public abstract Task<long> ScheduleMessageAsync(
            ServiceBusMessage message,
            ServiceBusRetryPolicy retryPolicy,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///
        /// </summary>
        /// <param name="sequenceNumber"></param>
        /// <param name="retryPolicy"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public abstract Task CancelScheduledMessageAsync(
            long sequenceNumber,
            ServiceBusRetryPolicy retryPolicy,
            CancellationToken cancellationToken = default);

        /// <summary>
        ///   Closes the connection to the transport producer instance.
        /// </summary>
        ///
        /// <param name="cancellationToken">An optional <see cref="CancellationToken"/> instance to signal the request to cancel the operation.</param>
        ///
        public abstract Task CloseAsync(CancellationToken cancellationToken);
    }
}
