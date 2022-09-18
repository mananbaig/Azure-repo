﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Microsoft.Azure.Amqp.Framing;

namespace Azure.Messaging.ServiceBus.Amqp
{
    /// <summary>
    /// The body abstractions allow to optimize several use cases of <see cref="ServiceBusMessage"/> and
    /// <see cref="ServiceBusReceivedMessage"/> to make sure body memory is only converted when needed and as little as possible.
    /// </summary>
    internal abstract class MessageBody : IEnumerable<ReadOnlyMemory<byte>>
    {
        public static MessageBody FromReadOnlyMemorySegments(IEnumerable<ReadOnlyMemory<byte>> segments)
        {
            return segments switch
            {
                MessageBody bodyMemory => bodyMemory,
                _ => new CopyingOnConversionMessageBody(segments)
            };
        }

        public static MessageBody FromReadOnlyMemorySegment(ReadOnlyMemory<byte> segment)
        {
            return new NonCopyingSingleSegmentMessageBody(segment);
        }

        public static MessageBody FromDataSegments(IEnumerable<Data> segments)
        {
            return new EagerCopyingMessageBody(segments ?? Enumerable.Empty<Data>());
        }

        protected abstract ReadOnlyMemory<byte> WrittenMemory { get; }

        public abstract IEnumerator<ReadOnlyMemory<byte>> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public static implicit operator ReadOnlyMemory<byte>(MessageBody memory)
        {
            return memory.WrittenMemory;
        }

        /// <summary>
        /// Wraps a single data segment into an enumerable like type without copying to optimize for the most commonly used
        /// path by always bridging into enumerable like behavior without the additional overhead of underlying lists and copying.
        /// This is the common path for ServiceBusMessage when the Body is set via constructor or the Body property.
        /// </summary>
        private sealed class NonCopyingSingleSegmentMessageBody : MessageBody
        {
            public NonCopyingSingleSegmentMessageBody(ReadOnlyMemory<byte> dataSegment)
            {
                WrittenMemory = dataSegment;
            }

            protected override ReadOnlyMemory<byte> WrittenMemory { get; }

            public override IEnumerator<ReadOnlyMemory<byte>> GetEnumerator()
            {
                yield return WrittenMemory;
            }
        }

        /// <summary>
        /// Copies the provided segments into a single continuous buffer on demand while still keeping around a list of the individual copied segments.
        /// This path is hit when users modify the body via the underlying AmqpAnnotatedMessage.
        /// </summary>
        private sealed class CopyingOnConversionMessageBody : MessageBody
        {
            private ArrayBufferWriter<byte> _writer;
            private IList<ReadOnlyMemory<byte>> _segments;
            private IEnumerable<ReadOnlyMemory<byte>> _lazySegments;

            internal CopyingOnConversionMessageBody(IEnumerable<ReadOnlyMemory<byte>> dataSegments)
            {
                _lazySegments = dataSegments;
            }

            protected override ReadOnlyMemory<byte> WrittenMemory
            {
                get
                {
                    if (_lazySegments != null)
                    {
                        Append(_lazySegments);
                        _lazySegments = null;
                    }

                    return _writer?.WrittenMemory ?? ReadOnlyMemory<byte>.Empty;
                }
            }

            public override IEnumerator<ReadOnlyMemory<byte>> GetEnumerator()
            {
                return _segments?.GetEnumerator() ?? _lazySegments.GetEnumerator();
            }

            private void Append(IEnumerable<ReadOnlyMemory<byte>> dataSegments)
            {
                int length = 0;
                int numberOfSegments = 0;
                List<ReadOnlyMemory<byte>> segments = null;
                foreach (var segment in dataSegments)
                {
                    segments ??= dataSegments is IReadOnlyCollection<ReadOnlyMemory<byte>> readOnlyList
                        ? new List<ReadOnlyMemory<byte>>(readOnlyList.Count)
                        : new List<ReadOnlyMemory<byte>>();
                    length += segment.Length;
                    numberOfSegments++;
                    segments.Add(segment);
                }

                if (segments == null)
                {
                    return;
                }

                // fields are lazy initialized to not occupy unnecessary memory when there are no data segments
                _writer = length > 0 ? new ArrayBufferWriter<byte>(length) : new ArrayBufferWriter<byte>();
                _segments = segments;

                for (var i = 0; i < numberOfSegments; i++)
                {
                    var dataToAppend = segments[i];
                    var memory = _writer.GetMemory(dataToAppend.Length);
                    dataToAppend.CopyTo(memory);
                    _writer.Advance(dataToAppend.Length);
                    segments[i] = memory.Slice(0, dataToAppend.Length);
                }
            }
        }

        /// <summary>
        /// Eagerly copies the provided data segments into a single continuous buffer while still keeping around a list of the individual copied segments.
        /// Important for the receive path in order to make sure the buffers managed by the underlying AMQP library can be released on dispose.
        /// </summary>
        private sealed class EagerCopyingMessageBody : MessageBody
        {
            private ArrayBufferWriter<byte> _writer;
            private IList<ReadOnlyMemory<byte>> _segments;

            internal EagerCopyingMessageBody(IEnumerable<Data> dataSegments)
            {
                Append(dataSegments);
            }

            protected override ReadOnlyMemory<byte> WrittenMemory => _writer?.WrittenMemory ?? ReadOnlyMemory<byte>.Empty;

            public override IEnumerator<ReadOnlyMemory<byte>> GetEnumerator()
            {
                return _segments.GetEnumerator();
            }

            private void Append(IEnumerable<Data> dataSegments)
            {
                int length = 0;
                int numberOfSegments = 0;
                List<ReadOnlyMemory<byte>> segments = null;
                foreach (var segment in dataSegments)
                {
                    segments ??= dataSegments is IReadOnlyCollection<Data> readOnlyList
                        ? new List<ReadOnlyMemory<byte>>(readOnlyList.Count)
                        : new List<ReadOnlyMemory<byte>>();
                    ReadOnlyMemory<byte> dataToAppend = segment.Value switch
                    {
                        byte[] byteArray => byteArray,
                        ArraySegment<byte> arraySegment => arraySegment,
                        _ => ReadOnlyMemory<byte>.Empty
                    };
                    length += dataToAppend.Length;
                    numberOfSegments++;
                    segments.Add(dataToAppend);
                }

                if (segments == null)
                {
                    return;
                }

                // fields are lazy initialized to not occupy unnecessary memory when there are no data segments
                _writer = length > 0 ? new ArrayBufferWriter<byte>(length) : new ArrayBufferWriter<byte>();
                _segments = segments;

                for (var i = 0; i < numberOfSegments; i++)
                {
                    var dataToAppend = segments[i];
                    var memory = _writer.GetMemory(dataToAppend.Length);
                    dataToAppend.CopyTo(memory);
                    _writer.Advance(dataToAppend.Length);
                    segments[i] = memory.Slice(0, dataToAppend.Length);
                }
            }
        }
    }
}
