﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Microsoft.Azure.Amqp;
using Microsoft.Azure.Amqp.Framing;

namespace Azure.Messaging.ServiceBus.Amqp
{
    internal static class AmqpMessageExtensions
    {
        public static AmqpMessage ToAmqpMessage(this ServiceBusMessage message)
        {
            var body = new Data
            {
                Value = new ArraySegment<byte>(message.Body.Bytes.IsEmpty ? Array.Empty<byte>() : message.Body.Bytes.ToArray())
            };
            return AmqpMessage.Create(body);
        }

        private static byte[] GetByteArray(this Data data)
        {
            switch (data.Value)
            {
                case byte[] byteArray:
                    return byteArray;
                case ArraySegment<byte> arraySegment when arraySegment.Count == arraySegment.Array?.Length:
                    return arraySegment.Array;
                case ArraySegment<byte> arraySegment:
                    {
                        var byteArray = new byte[arraySegment.Count];
                        Array.ConstrainedCopy(
                            sourceArray: arraySegment.Array,
                            sourceIndex: arraySegment.Offset,
                            destinationArray: byteArray,
                            destinationIndex: 0,
                            length: arraySegment.Count);
                        return byteArray;
                    }
                default:
                    return null;
            }
        }

        private static IEnumerable<byte[]> GetDataViaDataBody(AmqpMessage message) =>
            (message.DataBody ?? Enumerable.Empty<Data>()).Select(db => db.GetByteArray()).Where(ba => ba != null);

        // TODO: [WIP] This gets the data bytes via the BodyStream, and this method is current unused.
        // This ignores the already parsed DataBody information, which is potentially faster and uses less memory.
        // However, I'm not confident that doing it this way won't cause unknown issues.
        // This is a drop-in replacement for GetDataViaDataBody.
        private static IEnumerable<byte[]> GetDataViaBodyStream(AmqpMessage message)
        {
            using var streamData = message.BodyStream;
            var data = new byte[streamData.Length];
            streamData.Read(data, 0, (int)streamData.Length);
            return new[] { data };
        }

        // Returns via the out parameter the flattened collection of bytes.
        // A majority of the time, data will only contain 1 element.
        // The method is optimized for this situation to return the pre-existing array.
        private static byte[] ConvertAndFlattenData(IEnumerable<byte[]> data)
        {
            byte[] flattened = null;
            List<byte> flattenedList = null;
            var dataCount = 0;
            foreach (byte[] byteArray in data)
            {
                // Only the first array is needed if it is the only valid array.
                // This should be the case 99% of the time.
                if (dataCount == 0)
                {
                    flattened = byteArray;
                }
                else
                {
                    // We defer creating this list since this case will rarely happen.
                    flattenedList ??= new List<byte>(flattened!);
                    flattenedList.AddRange(byteArray);
                }

                dataCount++;
            }

            if (dataCount > 1)
            {
                flattened = flattenedList!.ToArray();
            }

            return flattened;
        }

        private static ServiceBusMessage CreateAmqpDataMessage(IEnumerable<byte[]> data)
        {
            byte[] flattened = ConvertAndFlattenData(data);
            return new ServiceBusMessage(BinaryData.FromMemory(flattened ?? ReadOnlyMemory<byte>.Empty));
        }

        public static ServiceBusReceivedMessage ToServiceBusReceivedMessage(this AmqpMessage message)
        {
            IEnumerable<byte[]> data = GetDataViaDataBody(message);
            return new ServiceBusReceivedMessage { SentMessage = CreateAmqpDataMessage(data) };
        }
    }
}
