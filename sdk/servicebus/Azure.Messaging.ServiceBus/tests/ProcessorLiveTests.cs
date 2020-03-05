﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Azure.Messaging.ServiceBus.Tests
{
    public class ProcessorLiveTests : ServiceBusLiveTestBase
    {
        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public async Task Receive_Event(int numThreads)
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(
                enablePartitioning: false,
                enableSession: false))
            {
                await using var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
                ServiceBusSender sender = client.GetSender(scope.QueueName);

                // use double the number of threads so we can make sure we test that we don't
                // retrieve more messages than expected when there are more messages available
                IEnumerable<ServiceBusMessage> messages = GetMessages(numThreads * 2);
                using ServiceBusMessageBatch batch = await sender.CreateBatchAsync();

                foreach (ServiceBusMessage message in messages)
                {
                    Assert.That(() => batch.TryAdd(message), Is.True, "A message was rejected by the batch; all messages should be accepted.");
                }
                await sender.SendBatchAsync(batch);

                await using var processor = client.GetProcessor(scope.QueueName);
                int messageCt = 0;

                TaskCompletionSource<bool>[] completionSources = Enumerable
                .Range(0, numThreads)
                .Select(index => new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously))
                .ToArray();
                var completionSourceIndex = -1;

                processor.ProcessMessageAsync += ProcessMessage;
                processor.ProcessErrorAsync += ExceptionHandler;
                processor.MaxConcurrentCalls = numThreads;
                await processor.StartProcessingAsync();

                async Task ProcessMessage(ProcessMessageEventArgs args)
                {
                    try
                    {
                        var receiver = args.Receiver;
                        var message = args.Message;
                        await receiver.CompleteAsync(message);
                        Interlocked.Increment(ref messageCt);
                    }
                    finally
                    {
                        var setIndex = Interlocked.Increment(ref completionSourceIndex);
                        completionSources[setIndex].SetResult(true);
                    }
                }
                await Task.WhenAll(completionSources.Select(source => source.Task));
                await processor.StopProcessingAsync();

                // we complete each thread after one message being processed, so the total number of messages
                // processed should equal the number of threads
                Assert.AreEqual(numThreads, messageCt);
            }
        }

        [Test]
        [TestCase(1)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public async Task Receive_StopProcessing(int numThreads)
        {
            await using (var scope = await ServiceBusScope.CreateWithQueue(
                enablePartitioning: false,
                enableSession: false))
            {
                await using var client = new ServiceBusClient(TestEnvironment.ServiceBusConnectionString);
                ServiceBusSender sender = client.GetSender(scope.QueueName);
                int numMessages = 50;
                IEnumerable<ServiceBusMessage> messages = GetMessages(numMessages);
                using ServiceBusMessageBatch batch = await sender.CreateBatchAsync();

                foreach (ServiceBusMessage message in messages)
                {
                    Assert.That(() => batch.TryAdd(message), Is.True, "A message was rejected by the batch; all messages should be accepted.");
                }
                await sender.SendBatchAsync(batch);

                await using var processor = client.GetProcessor(scope.QueueName);
                int messageProcessedCt = 0;

                // stop processing halfway through
                int stopAfterMessagesCt = numMessages / 2;

                TaskCompletionSource<bool> tcs = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
                processor.ProcessMessageAsync += ProcessMessage;
                processor.ProcessErrorAsync += ExceptionHandler;
                processor.MaxConcurrentCalls = numThreads;
                await processor.StartProcessingAsync();

                async Task ProcessMessage(ProcessMessageEventArgs args)
                {
                    Interlocked.Increment(ref messageProcessedCt);
                    if (messageProcessedCt == stopAfterMessagesCt)
                    {
                        await processor.StopProcessingAsync();
                        tcs.SetResult(true);
                    }
                }
                await tcs.Task;
                var remainingCt = 0;
                var receiver = client.GetReceiver(scope.QueueName);

                foreach (ServiceBusMessage message in await receiver.ReceiveBatchAsync(numMessages))
                {
                    remainingCt++;
                }

                // can't assert on the exact amount processed due to threads that
                // are already in flight when calling StopProcessingAsync, but we can at least verify that there are remaining messages
                Assert.IsTrue(remainingCt > 0);
                Assert.IsTrue(messageProcessedCt < numMessages);

            }
        }
    }
}
