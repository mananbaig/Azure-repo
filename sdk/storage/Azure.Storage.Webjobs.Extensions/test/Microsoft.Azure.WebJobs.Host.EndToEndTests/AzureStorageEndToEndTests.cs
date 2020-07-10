﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Storage.Blob;
using Microsoft.Azure.Storage.Queue;
using Microsoft.Azure.WebJobs.Host.Queues;
using Microsoft.Azure.WebJobs.Host.TestCommon;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using Xunit;
using CloudStorageAccount = Microsoft.Azure.Storage.CloudStorageAccount;

namespace Microsoft.Azure.WebJobs.Host.EndToEndTests
{
    /// <summary>
    /// Various E2E tests that use only the public surface and the real Azure storage
    /// </summary>
    public class AzureStorageEndToEndTests : IClassFixture<AzureStorageEndToEndTests.TestFixture>
    {
        private const string TestArtifactsPrefix = "e2etest";
        private const string ContainerName = TestArtifactsPrefix + "container%rnd%";
        private const string BlobName = "testblob";

        private const string TableName = TestArtifactsPrefix + "table%rnd%";

        private const string HostStartQueueName = TestArtifactsPrefix + "startqueue%rnd%";
        private const string TestQueueName = TestArtifactsPrefix + "queue%rnd%";
        private const string TestQueueNameEtag = TestArtifactsPrefix + "etag2equeue%rnd%";
        private const string DoneQueueName = TestArtifactsPrefix + "donequeue%rnd%";

        private const string BadMessageQueue1 = TestArtifactsPrefix + "-badmessage1-%rnd%";
        private const string BadMessageQueue2 = TestArtifactsPrefix + "-badmessage2-%rnd%";

        private static int _badMessage1Calls;
        private static int _badMessage2Calls;

        private static EventWaitHandle _startWaitHandle;
        private static EventWaitHandle _functionChainWaitHandle;
        private CloudStorageAccount _storageAccount;
        private RandomNameResolver _resolver;

        private static string _lastMessageId;
        private static string _lastMessagePopReceipt;

        public AzureStorageEndToEndTests(TestFixture fixture)
        {
            _storageAccount = fixture.StorageAccount;
        }

#pragma warning disable xUnit1013 // Public method should be marked as test
        /// <summary>
        /// Used to syncronize the application start and blob creation
        /// </summary>
        public static void NotifyStart(
            [QueueTrigger(HostStartQueueName)] string input)
        {
            _startWaitHandle.Set();
        }

        /// <summary>
        /// Covers:
        /// - blob binding to custom object
        /// - blob trigger
        /// - queue writing
        /// - blob name pattern binding
        /// </summary>
        public static void BlobToQueue(
            [BlobTrigger(ContainerName + @"/{name}")] string input,
            string name,
            [Queue(TestQueueNameEtag)] out CustomObject output)
        {
            // TODO: Use CustomObject as param when POCO blob supported:
            //       https://github.com/Azure/azure-webjobs-sdk/issues/995
            var inputObject = JsonConvert.DeserializeObject<CustomObject>(input);

            CustomObject result = new CustomObject()
            {
                Text = inputObject.Text + " " + name,
                Number = inputObject.Number + 1
            };

            output = result;
        }

        /// <summary>
        /// Covers:
        /// - queue binding to custom object
        /// - queue trigger
        /// - table writing
        /// </summary>
        public static void QueueToICollectorAndQueue(
            [QueueTrigger(TestQueueNameEtag)] CustomObject e2equeue,
            [Queue(TestQueueName)] out CustomObject output)
        {
            output = e2equeue;
        }

        /// <summary>
        /// Covers:
        /// - queue binding to custom object
        /// - queue trigger
        /// - table writing
        /// </summary>
        public static void QueueToTable(
            [QueueTrigger(TestQueueName)] CustomObject e2equeue,
            [Queue(DoneQueueName)] out string e2edone)
        {
            // Write a queue message to signal the scenario completion
            e2edone = "done";
        }

        /// <summary>
        /// Notifies the completion of the scenario
        /// </summary>
        public static void NotifyCompletion(
            [QueueTrigger(DoneQueueName)] string e2edone)
        {
            _functionChainWaitHandle.Set();
        }

        /// <summary>
        /// We'll insert a bad message. It should get here okay. It will
        /// then pass it on to the next trigger.
        /// </summary>
        public static void BadMessage_CloudQueueMessage(
            [QueueTrigger(BadMessageQueue1)] CloudQueueMessage badMessageIn,
            [Queue(BadMessageQueue2)] out CloudQueueMessage badMessageOut,
#pragma warning disable CS0618 // Type or member is obsolete
            TraceWriter log)
#pragma warning restore CS0618 // Type or member is obsolete
        {
            _badMessage1Calls++;
            badMessageOut = badMessageIn;
        }

        public static void BadMessage_String(
            [QueueTrigger(BadMessageQueue2)] string message,
#pragma warning disable CS0618 // Type or member is obsolete
            TraceWriter log)
#pragma warning restore CS0618 // Type or member is obsolete
        {
            _badMessage2Calls++;
        }

        // Uncomment the Fact attribute to run
        // [Fact(Timeout = 20 * 60 * 1000)]
        public async Task AzureStorageEndToEndSlow()
        {
            await EndToEndTest(uploadBlobBeforeHostStart: false);
        }

#pragma warning restore xUnit1013 // Public method should be marked as test

        [Fact]
        public async Task AzureStorageEndToEndFast()
        {
            await EndToEndTest(uploadBlobBeforeHostStart: true);
        }

        private async Task EndToEndTest(bool uploadBlobBeforeHostStart)
        {
            // Reinitialize the name resolver to avoid conflicts
            _resolver = new RandomNameResolver();

            IHost host = new HostBuilder()
                .ConfigureDefaultTestHost<AzureStorageEndToEndTests>(b =>
                {
                    b.AddAzureStorage();
                })
                .ConfigureServices(services =>
                {
                    services.AddSingleton<INameResolver>(_resolver);
                })
                .Build();

            if (uploadBlobBeforeHostStart)
            {
                // The function will be triggered fast because the blob is already there
                await UploadTestObject();
            }

            // The jobs host is started
            JobHost jobHost = host.GetJobHost();

            _functionChainWaitHandle = new ManualResetEvent(initialState: false);

            await host.StartAsync();

            if (!uploadBlobBeforeHostStart)
            {
                await WaitForTestFunctionsToStart();
                await UploadTestObject();
            }

            var waitTime = TimeSpan.FromSeconds(15);
            bool signaled = _functionChainWaitHandle.WaitOne(waitTime);

            // Stop the host and wait for it to finish
            await host.StopAsync();

            Assert.True(signaled, $"[{DateTime.UtcNow.ToString("HH:mm:ss.fff")}] Function chain did not complete in {waitTime}. Logs:{Environment.NewLine}{host.GetTestLoggerProvider().GetLogString()}");
        }

        [Fact]
        public async Task BadQueueMessageE2ETests()
        {
            // This test ensures that the host does not crash on a bad message (it previously did)
            // Insert a bad message into a queue that should:
            // - trigger BadMessage_CloudQueueMessage, which will put it into a second queue that will
            // - trigger BadMessage_String, which should fail
            // - BadMessage_String should fail repeatedly until it is moved to the poison queue
            // The test will watch that poison queue to know when to complete

            // Reinitialize the name resolver to avoid conflicts
            _resolver = new RandomNameResolver();
            IHost host = new HostBuilder()
                .ConfigureDefaultTestHost<AzureStorageEndToEndTests>(b =>
                {
                    b.AddAzureStorage();
                })
                .ConfigureServices(services =>
                {
                    // use a custom processor so we can grab the Id and PopReceipt
                    services.AddSingleton<IQueueProcessorFactory>(new TestQueueProcessorFactory());
                    services.AddSingleton<INameResolver>(_resolver);
                })
                .Build();

            TestLoggerProvider loggerProvider = host.GetTestLoggerProvider();

            // The jobs host is started
            host.Start();

            // Construct a bad message:
            // - use a GUID as the content, which is not a valid base64 string
            // - pass 'true', to indicate that it is a base64 string
            string messageContent = Guid.NewGuid().ToString();
            var message = new CloudQueueMessage(messageContent, true);

            var queueClient = _storageAccount.CreateCloudQueueClient();
            var queue = queueClient.GetQueueReference(_resolver.ResolveInString(BadMessageQueue1));
            await queue.CreateIfNotExistsAsync();
            await queue.ClearAsync();

            // the poison queue will end up off of the second queue
            var poisonQueue = queueClient.GetQueueReference(_resolver.ResolveInString(BadMessageQueue2) + "-poison");
            await poisonQueue.DeleteIfExistsAsync();

            await queue.AddMessageAsync(message);

            CloudQueueMessage poisonMessage = null;
            await TestHelpers.Await(async () =>
            {
                bool done = false;
                if (await poisonQueue.ExistsAsync())
                {
                    poisonMessage = await poisonQueue.GetMessageAsync();
                    done = poisonMessage != null;

                    if (done)
                    {
                        // Sleep briefly, then make sure the other message has been deleted.
                        // If so, trying to delete it again will throw an error.
                        Thread.Sleep(1000);

                        // The message is in the second queue
                        var queue2 = queueClient.GetQueueReference(_resolver.ResolveInString(BadMessageQueue2));

                        Azure.Storage.StorageException ex = await Assert.ThrowsAsync<Azure.Storage.StorageException>(
                            () => queue2.DeleteMessageAsync(_lastMessageId, _lastMessagePopReceipt));
                        Assert.Equal("MessageNotFound", ex.RequestInformation.ExtendedErrorInformation.ErrorCode);
                    }
                }
                var logs = loggerProvider.GetAllLogMessages();
                return done;
            });

            await host.StopAsync();

            // find the raw string to compare it to the original
            Assert.NotNull(poisonMessage);
            var propInfo = typeof(CloudQueueMessage).GetProperty("RawString", BindingFlags.Instance | BindingFlags.NonPublic);
            string rawString = propInfo.GetValue(poisonMessage) as string;
            Assert.Equal(messageContent, rawString);

            // Make sure the functions were called correctly
            Assert.Equal(1, _badMessage1Calls);
            Assert.Equal(0, _badMessage2Calls);

            // Validate Logger
            var loggerErrors = loggerProvider.GetAllLogMessages().Where(l => l.Level == Microsoft.Extensions.Logging.LogLevel.Error);
            Assert.True(loggerErrors.All(t => t.Exception.InnerException.InnerException is FormatException));
        }

        private async Task UploadTestObject()
        {
            string testContainerName = _resolver.ResolveInString(ContainerName);

            CloudBlobContainer container = _storageAccount.CreateCloudBlobClient().GetContainerReference(testContainerName);
            await container.CreateIfNotExistsAsync();

            // The test blob
            CloudBlockBlob testBlob = container.GetBlockBlobReference(BlobName);
            CustomObject testObject = new CustomObject()
            {
                Text = "Test",
                Number = 42
            };

            await testBlob.UploadTextAsync(JsonConvert.SerializeObject(testObject));
        }

        private async Task WaitForTestFunctionsToStart()
        {
            _startWaitHandle = new ManualResetEvent(initialState: false);

            string startQueueName = _resolver.ResolveInString(HostStartQueueName);

            CloudQueueClient queueClient = _storageAccount.CreateCloudQueueClient();
            CloudQueue queue = queueClient.GetQueueReference(startQueueName);
            await queue.CreateIfNotExistsAsync();
            await queue.AddMessageAsync(new CloudQueueMessage(String.Empty));

            _startWaitHandle.WaitOne(30000);
        }

        private class TestQueueProcessorFactory : IQueueProcessorFactory
        {
            public QueueProcessor Create(QueueProcessorFactoryContext context)
            {
                return new TestQueueProcessor(context);
            }
        }

        private class TestQueueProcessor : QueueProcessor
        {
            public TestQueueProcessor(QueueProcessorFactoryContext context)
                : base(context)
            {
            }

            public override Task<bool> BeginProcessingMessageAsync(CloudQueueMessage message, CancellationToken cancellationToken)
            {
                _lastMessageId = message.Id;
                _lastMessagePopReceipt = message.PopReceipt;

                return base.BeginProcessingMessageAsync(message, cancellationToken);
            }
        }

        public class TestFixture : IDisposable
        {
            public TestFixture()
            {
                IHost host = new HostBuilder()
                    .ConfigureDefaultTestHost<TestFixture>(b =>
                    {
                        b.AddAzureStorage();
                    })
                    .Build();

                var provider = host.Services.GetService<StorageAccountProvider>();
                StorageAccount = provider.GetHost().SdkObject;
            }

            public CloudStorageAccount StorageAccount
            {
                get;
                private set;
            }

            public void Dispose()
            {
                CloudBlobClient blobClient = StorageAccount.CreateCloudBlobClient();
                foreach (var testContainer in blobClient.ListContainersSegmentedAsync(TestArtifactsPrefix, null).Result.Results)
                {
                    testContainer.DeleteAsync().Wait();
                }

                CloudQueueClient queueClient = StorageAccount.CreateCloudQueueClient();
                foreach (var testQueue in queueClient.ListQueuesSegmentedAsync(TestArtifactsPrefix, null).Result.Results)
                {
                    testQueue.DeleteAsync().Wait();
                }
            }
        }
    }
}
