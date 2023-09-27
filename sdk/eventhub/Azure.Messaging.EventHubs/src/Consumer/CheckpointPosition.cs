﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Azure.Core;

namespace Azure.Messaging.EventHubs.Consumer
{
    /// <summary>
    ///   The position in a partition's event stream to use when updating a checkpoint, indicating that an event processor should begin reading from the next event.
    /// </summary>
    ///
    public struct CheckpointPosition
    {
        /// <summary>
        ///   The offset to associate with the checkpoint. This value will be used for informational metadata in almost all cases. If there is no sequence number associated
        ///   with the checkpoint, this value will be used for positioning when events are read.
        /// </summary>
        ///
        public long? Offset { get; internal set; } = null;

        /// <summary>
        ///   The replication segment to associate with the checkpoint. Used in conjunction with the sequence number if using a geo replication enabled Event Hubs namespace.
        /// </summary>
        ///
        public string ReplicationSegment { get; internal set; }

        /// <summary>
        ///   The sequence number to associate with the checkpoint. It indicates that a processor should begin reading from the next event in the stream.
        /// </summary>
        ///
        public long SequenceNumber { get; internal set; } = long.MinValue;

        /// <summary>
        ///   Initializes a new instance of the <see cref="CheckpointPosition"/> struct.
        /// </summary>
        ///
        /// <param name="sequenceNumber">The sequence number to associate with the checkpoint, indicating that a processor should begin reading from the next event in the stream.</param>
        /// <param name="offset">An optional offset to associate with the checkpoint, intended as informational metadata.</param>
        ///
        public CheckpointPosition(long sequenceNumber, long? offset = null)
        {
            Offset = offset;
            SequenceNumber = sequenceNumber;
            ReplicationSegment = null;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="CheckpointPosition"/> struct.
        /// </summary>
        ///
        /// <param name="sequenceNumber">The sequence number to associate with the checkpoint, indicating that a processor should begin reading from the next event in the stream.</param>
        /// <param name="replicationSegment">The replication segment to associate with this checkpoint.</param>
        /// <param name="offset">An optional offset to associate with the checkpoint, intended as informational metadata.</param>
        ///
        public CheckpointPosition(long sequenceNumber, string replicationSegment, long? offset = null)
        {
            Offset = offset;
            SequenceNumber = sequenceNumber;
            ReplicationSegment = replicationSegment;
        }

        /// <summary>
        ///   Initializes a new instance of the <see cref="CheckpointPosition"/> from an <see cref="EventData"/> instance.
        /// </summary>
        ///
        /// <param name="eventData">The <see cref="EventData"/> to use to determine the starting point of a checkpoint, indicating that an event processor should begin reading from the next event in the stream.</param>
        ///
        public static CheckpointPosition FromEvent(EventData eventData)
        {
            return new CheckpointPosition(eventData.SequenceNumber, eventData.ReplicationSegment, eventData.Offset);
        }

        /// <summary>
        ///   Determines whether the specified <see cref="CheckpointPosition" /> is equal to this instance.
        /// </summary>
        ///
        /// <param name="other">The <see cref="CheckpointPosition" /> to compare with this instance.</param>
        ///
        /// <returns><c>true</c> if the specified <see cref="CheckpointPosition" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        ///
        public bool Equals(CheckpointPosition other)
        {
            return (Offset == other.Offset)
                && (SequenceNumber == other.SequenceNumber)
                && (ReplicationSegment == other.ReplicationSegment);
        }

        /// <summary>
        ///   Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        ///
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        ///
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) =>
            obj switch
            {
                CheckpointPosition other => Equals(other),
                _ => false
            };

        /// <summary>
        ///   Returns a hash code for this instance.
        /// </summary>
        ///
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        ///
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode()
        {
            var hashCode = new HashCodeBuilder();
            hashCode.Add(Offset);
            hashCode.Add(SequenceNumber);
            hashCode.Add(ReplicationSegment);

            return hashCode.ToHashCode();
        }

        /// <summary>
        ///   Converts the instance to string representation.
        /// </summary>
        ///
        /// <returns>A <see cref="System.String" /> that represents the position in the event stream.</returns>
        ///
        public override string ToString()
        {
            var stringRepresentation = $"Sequence Number: [{SequenceNumber}] | Replication Segment: [{ReplicationSegment}] | Offset: [{Offset}]";
            return stringRepresentation;
        }

        /// <summary>
        ///   Determines whether the specified <see cref="CheckpointPosition" /> instances are equal to each other.
        /// </summary>
        ///
        /// <param name="left">The first <see cref="CheckpointPosition" /> to consider.</param>
        /// <param name="right">The second <see cref="CheckpointPosition" /> to consider.</param>
        ///
        /// <returns><c>true</c> if the two specified <see cref="CheckpointPosition" /> instances are equal; otherwise, <c>false</c>.</returns>
        ///
        public static bool operator ==(CheckpointPosition left,
                                       CheckpointPosition right) => left.Equals(right);

        /// <summary>
        ///   Determines whether the specified <see cref="CheckpointPosition" /> instances are not equal to each other.
        /// </summary>
        ///
        /// <param name="left">The first <see cref="CheckpointPosition" /> to consider.</param>
        /// <param name="right">The second <see cref="CheckpointPosition" /> to consider.</param>
        ///
        /// <returns><c>true</c> if the two specified <see cref="CheckpointPosition" /> instances are not equal; otherwise, <c>false</c>.</returns>
        ///
        public static bool operator !=(CheckpointPosition left,
                                       CheckpointPosition right) => (!left.Equals(right));
    }
}
