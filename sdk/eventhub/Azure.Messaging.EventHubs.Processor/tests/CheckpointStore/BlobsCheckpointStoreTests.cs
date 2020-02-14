﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Core;
using Azure.Messaging.EventHubs.Processor.Diagnostics;
using Azure.Storage;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Moq;
using NUnit.Framework;

namespace Azure.Messaging.EventHubs.Processor.Tests
{
    /// <summary>
    ///   The suite of tests for the <see cref="BlobsCheckpointStore" />
    ///   class.
    /// </summary>
    ///
    public class BlobsCheckpointStoreTests
    {
        private const string FullyQualifiedNamespace = "fqns";
        private const string EventHubName = "name";
        private const string ConsumerGroup = "group";
        private const string MatchingEtag = "etag";
        private const string WrongEtag = "wrongEtag";
        private const string PartitionId = "1";
        private readonly string OwnershipIdentifier = Guid.NewGuid().ToString();

        /// <summary>
        ///   Provides the test cases for non-fatal exceptions that are not retriable
        ///   when encountered in a subscription.
        /// </summary>
        ///
        public static IEnumerable<object[]> NonFatalNotRetriableExceptionTestCases()
        {
            yield return new object[] { new InvalidOperationException() };
            yield return new object[] { new NotSupportedException() };
            yield return new object[] { new NullReferenceException() };
            yield return new object[] { new ObjectDisposedException("dummy") };
        }

        /// <summary>
        ///   Provides the test cases for non-fatal exceptions that are retriable
        ///   when encountered in a subscription.
        /// </summary>
        ///
        public static IEnumerable<object[]> NonFatalRetriableExceptionTestCases()
        {
            yield return new object[] { new TimeoutException() };
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorRequiresBlobContainerClient()
        {
            Assert.That(() => new BlobsCheckpointStore(null, Mock.Of<EventHubsRetryPolicy>()), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore" />
        ///   constructor.
        /// </summary>
        ///
        [Test]
        public void ConstructorRequiresRetryPolicy()
        {
            Assert.That(() => new BlobsCheckpointStore(Mock.Of<BlobContainerClient>(), null), Throws.ArgumentNullException);
        }

        /// <summary>
        ///   Verifies basic functionality of ListOwnershipAsync and ensures the appropriate events are emitted on success.
        /// </summary>
        ///
        [Test]
        public async Task ListOwnershipLogsStartAndComplete()
        {
            var blobList = new List<BlobItem>{
                BlobsModelFactory.BlobItem($"{FullyQualifiedNamespace}/{EventHubName}/{ConsumerGroup}/ownership/{Guid.NewGuid().ToString()}",
                                           false,
                                           BlobsModelFactory.BlobItemProperties(true, lastModified: DateTime.UtcNow, eTag: new ETag(MatchingEtag)),
                                           "snapshot",
                                           new Dictionary<string, string> {{BlobMetadataKey.OwnerIdentifier, Guid.NewGuid().ToString()}})
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient() { Blobs = blobList },
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            await target.ListOwnershipAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup, new CancellationToken());

            mockLog.Verify(m => m.ListOwnershipAsyncStart(FullyQualifiedNamespace, EventHubName, ConsumerGroup));
            mockLog.Verify(m => m.ListOwnershipAsyncComplete(FullyQualifiedNamespace, EventHubName, ConsumerGroup, blobList.Count));
        }

        /// <summary>
        ///   Verifies basic functionality of ListOwnershipAsync and ensures the appropriate events are emitted on failure.
        /// </summary>
        ///
        [Test]
        public void ListOwnershipLogsErrorOnException()
        {
            var ex = new RequestFailedException(0, "foo", BlobErrorCode.ContainerNotFound.ToString(), null);

            var target = new BlobsCheckpointStore(new MockBlobContainerClient(getBlobsAsyncException: ex),
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            Assert.ThrowsAsync<RequestFailedException>(async () => await target.ListOwnershipAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup, new CancellationToken()));

            mockLog.Verify(m => m.ListOwnershipAsyncError(FullyQualifiedNamespace, EventHubName, ConsumerGroup, It.Is<string>(e => e.Contains("RequestFailedException"))));
        }

        /// <summary>
        ///   Verifies basic functionality of ClaimOwnershipAsync and ensures the appropriate events are emitted on success.
        /// </summary>
        ///
        [Test]
        public async Task ClaimOwnershipForNewPartitionLogsOwnershipClaimed()
        {
            var partitionOwnerships = new List<PartitionOwnership>{
                new PartitionOwnership(FullyQualifiedNamespace, EventHubName, ConsumerGroup, OwnershipIdentifier, PartitionId, DateTime.UtcNow, null )
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient(),
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            var result = (await target.ClaimOwnershipAsync(partitionOwnerships, new CancellationToken())).ToList();

            CollectionAssert.AreEquivalent(partitionOwnerships, result);
            mockLog.Verify(m => m.OwnershipClaimed(PartitionId, OwnershipIdentifier));
        }

        /// <summary>
        ///   Verifies basic functionality of ClaimOwnershipAsync and ensures the appropriate events are emitted on success.
        /// </summary>
        ///
        [Test]
        public async Task ClaimOwnershipForExistingPartitionLogsOwnershipClaimed()
        {
            var blobInfo = BlobsModelFactory.BlobInfo(new ETag($@"""{MatchingEtag}"""), DateTime.UtcNow);
            var partitionOwnerships = new List<PartitionOwnership>{
                new PartitionOwnership(FullyQualifiedNamespace, EventHubName, ConsumerGroup, OwnershipIdentifier, PartitionId, DateTime.UtcNow, MatchingEtag )
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient { BlobInfo = blobInfo },
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            var result = (await target.ClaimOwnershipAsync(partitionOwnerships, new CancellationToken())).ToList();

            CollectionAssert.AreEquivalent(partitionOwnerships, result);
            mockLog.Verify(m => m.OwnershipClaimed(PartitionId, OwnershipIdentifier));
        }

        /// <summary>
        ///   Verifies basic functionality of ClaimOwnershipAsync and ensures the appropriate events are emitted on success.
        /// </summary>
        ///
        [Test]
        public async Task ClaimOwnershipForExistingPartitionWithWrongEtagLogsOwnershipNotClaimable()
        {
            var blobInfo = BlobsModelFactory.BlobInfo(new ETag($@"""{WrongEtag}"""), DateTime.UtcNow);
            var partitionOwnerships = new List<PartitionOwnership>{
                new PartitionOwnership(FullyQualifiedNamespace, EventHubName, ConsumerGroup, OwnershipIdentifier, PartitionId, DateTime.UtcNow, MatchingEtag )
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient { BlobInfo = blobInfo },
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            var result = (await target.ClaimOwnershipAsync(partitionOwnerships, new CancellationToken())).ToList();

            CollectionAssert.IsEmpty(result);
            mockLog.Verify(m => m.OwnershipNotClaimable(PartitionId, OwnershipIdentifier, It.Is<string>(e => e.Contains(BlobErrorCode.ConditionNotMet.ToString()))));
        }

        /// <summary>
        ///   Verifies basic functionality of ClaimOwnershipAsync and ensures the appropriate events are emitted on failure.
        /// </summary>
        ///
        [Test]
        public void ClaimOwnershipForMissingPartitionThrowsAndLogsOwnershipNotClaimable()
        {
            var partitionOwnerships = new List<PartitionOwnership>{
                new PartitionOwnership(FullyQualifiedNamespace, EventHubName, ConsumerGroup, OwnershipIdentifier, PartitionId, DateTime.UtcNow, MatchingEtag )
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient(),
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            Assert.ThrowsAsync<RequestFailedException>(async () => await target.ClaimOwnershipAsync(partitionOwnerships, new CancellationToken()));
        }

        /// <summary>
        ///   Verifies basic functionality of ListCheckpointsAsync and ensures the appropriate events are emitted on success.
        /// </summary>
        ///
        [Test]
        public async Task ListCheckpointsLogsStartAndComplete()
        {
            var blobList = new List<BlobItem>{
                BlobsModelFactory.BlobItem($"{FullyQualifiedNamespace}/{EventHubName}/{ConsumerGroup}/ownership/{Guid.NewGuid().ToString()}",
                                           false,
                                           BlobsModelFactory.BlobItemProperties(true, lastModified: DateTime.UtcNow, eTag: new ETag(MatchingEtag)),
                                           "snapshot",
                                           new Dictionary<string, string> {{BlobMetadataKey.OwnerIdentifier, Guid.NewGuid().ToString()}})
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient() { Blobs = blobList },
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            await target.ListCheckpointsAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup, new CancellationToken());

            mockLog.Verify(m => m.ListCheckpointsAsyncStart(FullyQualifiedNamespace, EventHubName, ConsumerGroup));
            mockLog.Verify(m => m.ListCheckpointsAsyncComplete(FullyQualifiedNamespace, EventHubName, ConsumerGroup, blobList.Count));
        }

        /// <summary>
        ///   Verifies basic functionality of ListCheckpointsAsync and ensures the appropriate events are emitted on failure.
        /// </summary>
        ///
        [Test]
        public void ListCheckpointsForMissingPartitionThrowsAndLogsOwnershipNotClaimable()
        {
            var ex = new RequestFailedException(0, "foo", BlobErrorCode.ContainerNotFound.ToString(), null);

            var target = new BlobsCheckpointStore(new MockBlobContainerClient(getBlobsAsyncException: ex),
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            Assert.ThrowsAsync<RequestFailedException>(async () => await target.ListCheckpointsAsync(FullyQualifiedNamespace, EventHubName, ConsumerGroup, new CancellationToken()));
        }

        /// <summary>
        ///   Verifies basic functionality of UpdateCheckpointAsync and ensures the appropriate events are emitted on success.
        /// </summary>
        ///
        [Test]
        public async Task UpdateCheckpointLogsCheckpointUpdated()
        {
            var checkpoint = new Checkpoint(FullyQualifiedNamespace, EventHubName, ConsumerGroup, PartitionId, 0L, 0L);
            var blobList = new List<BlobItem>{
                BlobsModelFactory.BlobItem($"{FullyQualifiedNamespace}/{EventHubName}/{ConsumerGroup}/ownership/{Guid.NewGuid().ToString()}",
                                           false,
                                           BlobsModelFactory.BlobItemProperties(true, lastModified: DateTime.UtcNow, eTag: new ETag(MatchingEtag)),
                                           "snapshot",
                                           new Dictionary<string, string> {{BlobMetadataKey.OwnerIdentifier, Guid.NewGuid().ToString()}})
            };
            var target = new BlobsCheckpointStore(new MockBlobContainerClient() { Blobs = blobList },
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            await target.UpdateCheckpointAsync(checkpoint, new CancellationToken());

            mockLog.Verify(m => m.CheckpointUpdated(PartitionId));
        }

        /// <summary>
        ///   Verifies basic functionality of UpdateCheckpointAsync and ensures the appropriate events are emitted on failure.
        /// </summary>
        ///
        [Test]
        public void UpdateCheckpointForMissingCheckpointThrowsAndLogsCheckpointUpdateError()
        {
            var checkpoint = new Checkpoint(FullyQualifiedNamespace, EventHubName, ConsumerGroup, PartitionId, 0L, 0L);
            var ex = new RequestFailedException(404, BlobErrorCode.ContainerNotFound.ToString(), BlobErrorCode.ContainerNotFound.ToString(), null);
            var target = new BlobsCheckpointStore(new MockBlobContainerClient(blobClientUploadBlobException: ex),
                                                  new BasicRetryPolicy(new EventHubsRetryOptions()));
            var mockLog = new Mock<BlobEventStoreEventSource>();
            target.Logger = mockLog.Object;

            Assert.ThrowsAsync<RequestFailedException>(async () => await target.UpdateCheckpointAsync(checkpoint, new CancellationToken()));

            mockLog.Verify(m => m.CheckpointUpdateError(PartitionId, It.Is<string>(s => s.Contains(BlobErrorCode.ContainerNotFound.ToString()))));
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalRetriableExceptionTestCases))]
        public void ListOwnershipAsyncRetriesAndSurfacesRetriableExceptions(Exception exception)
        {
            const int maximumRetries = 2;

            var expectedServiceCalls = (maximumRetries + 1);
            var serviceCalls = 0;

            var mockRetryPolicy = new Mock<EventHubsRetryPolicy>();
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, mockRetryPolicy.Object);

            mockRetryPolicy
                .Setup(policy => policy.CalculateRetryDelay(It.Is<Exception>(value => value == exception), It.Is<int>(value => value <= maximumRetries)))
                .Returns(TimeSpan.FromMilliseconds(5));

            mockContainerClient.GetBlobsAsyncCallback = (traits, states, prefix, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ListOwnershipAsync("ns", "eh", "cg", cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalNotRetriableExceptionTestCases))]
        public void ListOwnershipAsyncSurfacesNonRetriableExceptions(Exception exception)
        {
            var expectedServiceCalls = 1;
            var serviceCalls = 0;

            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));

            mockContainerClient.GetBlobsAsyncCallback = (traits, states, prefix, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ListOwnershipAsync("ns", "eh", "cg", cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should not have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public async Task ListOwnershipAsyncDelegatesTheCancellationToken()
        {
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));

            using var cancellationSource = new CancellationTokenSource();
            var stateBeforeCancellation = default(bool?);
            var stateAfterCancellation = default(bool?);

            mockContainerClient.GetBlobsAsyncCallback = (traits, states, prefix, token) =>
            {
                if (!stateBeforeCancellation.HasValue)
                {
                    stateBeforeCancellation = token.IsCancellationRequested;
                    cancellationSource.Cancel();
                    stateAfterCancellation = token.IsCancellationRequested;
                }
            };

            await checkpointStore.ListOwnershipAsync("ns", "eh", "cg", cancellationSource.Token);

            Assert.That(stateBeforeCancellation.HasValue, Is.True, "State before cancellation should have been captured.");
            Assert.That(stateBeforeCancellation.Value, Is.False, "The token should not have been canceled before cancellation request.");
            Assert.That(stateAfterCancellation.HasValue, Is.True, "State after cancellation should have been captured.");
            Assert.That(stateAfterCancellation.Value, Is.True, "The token should have been canceled after cancellation request.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AlreadyCanceledTokenMakesListOwnershipAsyncThrow()
        {
            var checkpointStore = new BlobsCheckpointStore(Mock.Of<BlobContainerClient>(), Mock.Of<EventHubsRetryPolicy>());

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.That(async () => await checkpointStore.ListOwnershipAsync("ns", "eh", "cg", cancellationSource.Token), Throws.InstanceOf<TaskCanceledException>());
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ClaimOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalRetriableExceptionTestCases))]
        public void ClaimOwnershipAsyncRetriesAndSurfacesRetriableExceptionsWhenETagIsNull(Exception exception)
        {
            const int maximumRetries = 2;

            var expectedServiceCalls = (maximumRetries + 1);
            var serviceCalls = 0;

            var mockRetryPolicy = new Mock<EventHubsRetryPolicy>();
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, mockRetryPolicy.Object);
            var ownership = new PartitionOwnership("ns", "eh", "cg", "id", "pid", default, null);

            mockRetryPolicy
                .Setup(policy => policy.CalculateRetryDelay(It.Is<Exception>(value => value == exception), It.Is<int>(value => value <= maximumRetries)))
                .Returns(TimeSpan.FromMilliseconds(5));

            mockContainerClient.BlobClientUploadAsyncCallback = (content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ClaimOwnershipAsync(new List<PartitionOwnership>() { ownership }, cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ClaimOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalNotRetriableExceptionTestCases))]
        public void ClaimOwnershipAsyncSurfacesNonRetriableExceptionsWhenETagIsNull(Exception exception)
        {
            var expectedServiceCalls = 1;
            var serviceCalls = 0;

            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));
            var ownership = new PartitionOwnership("ns", "eh", "cg", "id", "pid", default, null);

            mockContainerClient.BlobClientUploadAsyncCallback = (content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ClaimOwnershipAsync(new List<PartitionOwnership>() { ownership }, cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should not have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ClaimOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalRetriableExceptionTestCases))]
        [Ignore("Failing test.")]
        public void ClaimOwnershipAsyncRetriesAndSurfacesRetriableExceptionsWhenETagIsNotNull(Exception exception)
        {
            const int maximumRetries = 2;

            var expectedServiceCalls = (maximumRetries + 1);
            var serviceCalls = 0;

            var mockRetryPolicy = new Mock<EventHubsRetryPolicy>();
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, mockRetryPolicy.Object);
            var ownership = new PartitionOwnership("ns", "eh", "cg", "id", "pid", default, "eTag");

            mockRetryPolicy
                .Setup(policy => policy.CalculateRetryDelay(It.Is<Exception>(value => value == exception), It.Is<int>(value => value <= maximumRetries)))
                .Returns(TimeSpan.FromMilliseconds(5));

            mockContainerClient.BlobClientSetMetadataAsyncCallback = (metadata, conditions, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ClaimOwnershipAsync(new List<PartitionOwnership>() { ownership }, cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ClaimOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalNotRetriableExceptionTestCases))]
        [Ignore("Failing test.")]
        public void ClaimOwnershipAsyncSurfacesNonRetriableExceptionsWhenETagIsNotNull(Exception exception)
        {
            var expectedServiceCalls = 1;
            var serviceCalls = 0;

            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));
            var ownership = new PartitionOwnership("ns", "eh", "cg", "id", "pid", default, "eTag");

            mockContainerClient.BlobClientSetMetadataAsyncCallback = (metadata, conditions, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ClaimOwnershipAsync(new List<PartitionOwnership>() { ownership }, cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should not have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ClaimOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCase(null)]
        [TestCase("eTag")]
        public async Task ClaimOwnershipAsyncDelegatesTheCancellationToken(string eTag)
        {
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));
            var ownership = new PartitionOwnership("ns", "eh", "cg", "id", "pid", default, eTag);

            using var cancellationSource = new CancellationTokenSource();
            var stateBeforeCancellation = default(bool?);
            var stateAfterCancellation = default(bool?);

            // UploadAsync will be called if eTag is null; SetMetadataAsync is used otherwise.

            if (eTag == null)
            {
                mockContainerClient.BlobClientUploadAsyncCallback = (content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, token) =>
                {
                    if (!stateBeforeCancellation.HasValue)
                    {
                        stateBeforeCancellation = token.IsCancellationRequested;
                        cancellationSource.Cancel();
                        stateAfterCancellation = token.IsCancellationRequested;
                    }
                };
            }
            else
            {
                mockContainerClient.BlobInfo = Mock.Of<BlobInfo>();

                mockContainerClient.BlobClientSetMetadataAsyncCallback = (metadata, conditions, token) =>
                {
                    if (!stateBeforeCancellation.HasValue)
                    {
                        stateBeforeCancellation = token.IsCancellationRequested;
                        cancellationSource.Cancel();
                        stateAfterCancellation = token.IsCancellationRequested;
                    }
                };
            }

            await checkpointStore.ClaimOwnershipAsync(new List<PartitionOwnership>() { ownership }, cancellationSource.Token);

            Assert.That(stateBeforeCancellation.HasValue, Is.True, "State before cancellation should have been captured.");
            Assert.That(stateBeforeCancellation.Value, Is.False, "The token should not have been canceled before cancellation request.");
            Assert.That(stateAfterCancellation.HasValue, Is.True, "State after cancellation should have been captured.");
            Assert.That(stateAfterCancellation.Value, Is.True, "The token should have been canceled after cancellation request.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ClaimOwnershipAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AlreadyCanceledTokenMakesClaimOwnershipAsyncThrow()
        {
            var checkpointStore = new BlobsCheckpointStore(Mock.Of<BlobContainerClient>(), Mock.Of<EventHubsRetryPolicy>());

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.That(async () => await checkpointStore.ClaimOwnershipAsync(Mock.Of<IEnumerable<PartitionOwnership>>(), cancellationSource.Token), Throws.InstanceOf<TaskCanceledException>());
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListCheckpointsAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalRetriableExceptionTestCases))]
        public void ListCheckpointsAsyncRetriesAndSurfacesRetriableExceptions(Exception exception)
        {
            const int maximumRetries = 2;

            var expectedServiceCalls = (maximumRetries + 1);
            var serviceCalls = 0;

            var mockRetryPolicy = new Mock<EventHubsRetryPolicy>();
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, mockRetryPolicy.Object);

            mockRetryPolicy
                .Setup(policy => policy.CalculateRetryDelay(It.Is<Exception>(value => value == exception), It.Is<int>(value => value <= maximumRetries)))
                .Returns(TimeSpan.FromMilliseconds(5));

            mockContainerClient.GetBlobsAsyncCallback = (traits, states, prefix, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ListCheckpointsAsync("ns", "eh", "cg", cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListCheckpointsAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalNotRetriableExceptionTestCases))]
        public void ListCheckpointsAsyncSurfacesNonRetriableExceptions(Exception exception)
        {
            var expectedServiceCalls = 1;
            var serviceCalls = 0;

            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));

            mockContainerClient.GetBlobsAsyncCallback = (traits, states, prefix, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.ListCheckpointsAsync("ns", "eh", "cg", cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should not have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListCheckpointsAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public async Task ListCheckpointsAsyncDelegatesTheCancellationToken()
        {
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));

            using var cancellationSource = new CancellationTokenSource();
            var stateBeforeCancellation = default(bool?);
            var stateAfterCancellation = default(bool?);

            mockContainerClient.GetBlobsAsyncCallback = (traits, states, prefix, token) =>
            {
                if (!stateBeforeCancellation.HasValue)
                {
                    stateBeforeCancellation = token.IsCancellationRequested;
                    cancellationSource.Cancel();
                    stateAfterCancellation = token.IsCancellationRequested;
                }
            };

            await checkpointStore.ListCheckpointsAsync("ns", "eh", "cg", cancellationSource.Token);

            Assert.That(stateBeforeCancellation.HasValue, Is.True, "State before cancellation should have been captured.");
            Assert.That(stateBeforeCancellation.Value, Is.False, "The token should not have been canceled before cancellation request.");
            Assert.That(stateAfterCancellation.HasValue, Is.True, "State after cancellation should have been captured.");
            Assert.That(stateAfterCancellation.Value, Is.True, "The token should have been canceled after cancellation request.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.ListCheckpointsAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AlreadyCanceledTokenMakesListCheckpointsAsyncThrow()
        {
            var checkpointStore = new BlobsCheckpointStore(Mock.Of<BlobContainerClient>(), Mock.Of<EventHubsRetryPolicy>());

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.That(async () => await checkpointStore.ListCheckpointsAsync("ns", "eh", "cg", cancellationSource.Token), Throws.InstanceOf<TaskCanceledException>());
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.UpdateCheckpointAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalRetriableExceptionTestCases))]
        public void UpdateCheckpointAsyncRetriesAndSurfacesRetriableExceptions(Exception exception)
        {
            const int maximumRetries = 2;

            var expectedServiceCalls = (maximumRetries + 1);
            var serviceCalls = 0;

            var mockRetryPolicy = new Mock<EventHubsRetryPolicy>();
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, mockRetryPolicy.Object);
            var checkpoint = new Checkpoint("ns", "eh", "cg", "pid", 0, 0);

            mockRetryPolicy
                .Setup(policy => policy.CalculateRetryDelay(It.Is<Exception>(value => value == exception), It.Is<int>(value => value <= maximumRetries)))
                .Returns(TimeSpan.FromMilliseconds(5));

            mockContainerClient.BlobClientUploadAsyncCallback = (content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.UpdateCheckpointAsync(checkpoint, cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.UpdateCheckpointAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        [TestCaseSource(nameof(NonFatalNotRetriableExceptionTestCases))]
        public void UpdateCheckpointAsyncSurfacesNonRetriableExceptions(Exception exception)
        {
            var expectedServiceCalls = 1;
            var serviceCalls = 0;

            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));
            var checkpoint = new Checkpoint("ns", "eh", "cg", "pid", 0, 0);

            mockContainerClient.BlobClientUploadAsyncCallback = (content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, token) =>
            {
                serviceCalls++;
                throw exception;
            };

            // To ensure that the test does not hang for the duration, set a timeout to force completion
            // after a shorter period of time.

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.CancelAfter(TimeSpan.FromSeconds(15));

            Assert.That(async () => await checkpointStore.UpdateCheckpointAsync(checkpoint, cancellationSource.Token), Throws.TypeOf(exception.GetType()), "The method call should surface the exception.");
            Assert.That(cancellationSource.IsCancellationRequested, Is.False, "The operation should have stopped without cancellation.");
            Assert.That(serviceCalls, Is.EqualTo(expectedServiceCalls), "The retry policy should have been applied.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.UpdateCheckpointAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public async Task UpdateCheckpointAsyncDelegatesTheCancellationToken()
        {
            var mockContainerClient = new MockBlobContainerClient();
            var checkpointStore = new BlobsCheckpointStore(mockContainerClient, new BasicRetryPolicy(new EventHubsRetryOptions()));
            var checkpoint = new Checkpoint("ns", "eh", "cg", "pid", 0, 0);

            using var cancellationSource = new CancellationTokenSource();
            var stateBeforeCancellation = default(bool?);
            var stateAfterCancellation = default(bool?);

            mockContainerClient.BlobClientUploadAsyncCallback = (content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, token) =>
            {
                if (!stateBeforeCancellation.HasValue)
                {
                    stateBeforeCancellation = token.IsCancellationRequested;
                    cancellationSource.Cancel();
                    stateAfterCancellation = token.IsCancellationRequested;
                }
            };

            await checkpointStore.UpdateCheckpointAsync(checkpoint, cancellationSource.Token);

            Assert.That(stateBeforeCancellation.HasValue, Is.True, "State before cancellation should have been captured.");
            Assert.That(stateBeforeCancellation.Value, Is.False, "The token should not have been canceled before cancellation request.");
            Assert.That(stateAfterCancellation.HasValue, Is.True, "State after cancellation should have been captured.");
            Assert.That(stateAfterCancellation.Value, Is.True, "The token should have been canceled after cancellation request.");
        }

        /// <summary>
        ///   Verifies functionality of the <see cref="BlobsCheckpointStore.UpdateCheckpointAsync" />
        ///   method.
        /// </summary>
        ///
        [Test]
        public void AlreadyCanceledTokenMakesUpdateCheckpointAsyncThrow()
        {
            var checkpointStore = new BlobsCheckpointStore(Mock.Of<BlobContainerClient>(), Mock.Of<EventHubsRetryPolicy>());
            var checkpoint = new Checkpoint("ns", "eh", "cg", "pid", 0, 0);

            using var cancellationSource = new CancellationTokenSource();
            cancellationSource.Cancel();

            Assert.That(async () => await checkpointStore.UpdateCheckpointAsync(checkpoint, cancellationSource.Token), Throws.InstanceOf<TaskCanceledException>());
        }

        private class MockBlobContainerClient : BlobContainerClient
        {
            public override Uri Uri { get; }
            public override string AccountName { get; }
            public override string Name { get; }
            internal IEnumerable<BlobItem> Blobs;
            internal BlobInfo BlobInfo;
            internal Exception BlobClientUploadBlobException;
            internal Exception GetBlobsAsyncException;
            internal Action<BlobTraits, BlobStates, string, CancellationToken> GetBlobsAsyncCallback;
            internal Action<Stream, BlobHttpHeaders, IDictionary<string, string>, BlobRequestConditions, IProgress<long>, AccessTier?, StorageTransferOptions, CancellationToken> BlobClientUploadAsyncCallback;
            internal Action<IDictionary<string, string>, BlobRequestConditions, CancellationToken> BlobClientSetMetadataAsyncCallback;

            public MockBlobContainerClient(string accountName = "blobAccount",
                                           string containerName = "container",
                                           Exception getBlobsAsyncException = null,
                                           Exception blobClientUploadBlobException = null)
            {
                GetBlobsAsyncException = getBlobsAsyncException;
                BlobClientUploadBlobException = blobClientUploadBlobException;
                Blobs = Enumerable.Empty<BlobItem>();
                AccountName = accountName;
                Name = containerName;
                Uri = new Uri("https://foo");
            }
            public override AsyncPageable<BlobItem> GetBlobsAsync(BlobTraits traits = BlobTraits.None, BlobStates states = BlobStates.None, string prefix = null, CancellationToken cancellationToken = default)
            {
                if (GetBlobsAsyncException != null)
                {
                    throw GetBlobsAsyncException;
                }

                GetBlobsAsyncCallback?.Invoke(traits, states, prefix, cancellationToken);

                return new MockAsyncPageable<BlobItem>(Blobs);
            }

            public override BlobClient GetBlobClient(string blobName)
            {
                return new MockBlobClient(blobName, BlobInfo, BlobClientUploadBlobException, BlobClientUploadAsyncCallback, BlobClientSetMetadataAsyncCallback);
            }
        }

        private class MockBlobClient : BlobClient
        {
            public override string Name { get; }
            internal BlobInfo BlobInfo;
            internal Exception BlobClientUploadBlobException;
            private Action<Stream, BlobHttpHeaders, IDictionary<string, string>, BlobRequestConditions, IProgress<long>, AccessTier?, StorageTransferOptions, CancellationToken> UploadAsyncCallback;
            private Action<IDictionary<string, string>, BlobRequestConditions, CancellationToken> SetMetadataAsyncCallback;

            public MockBlobClient(string blobName,
                                  BlobInfo blobInfo = null,
                                  Exception blobClientUploadBlobException = null,
                                  Action<Stream, BlobHttpHeaders, IDictionary<string, string>, BlobRequestConditions, IProgress<long>, AccessTier?, StorageTransferOptions, CancellationToken> uploadAsyncCallback = null,
                                  Action<IDictionary<string, string>, BlobRequestConditions, CancellationToken> setMetadataAsyncCallback = null)
            {
                BlobClientUploadBlobException = blobClientUploadBlobException;
                UploadAsyncCallback = uploadAsyncCallback;
                SetMetadataAsyncCallback = setMetadataAsyncCallback;
                Name = blobName;
                BlobInfo = blobInfo;
            }

            public override Task<Response<BlobInfo>> SetMetadataAsync(IDictionary<string, string> metadata, BlobRequestConditions conditions = null, CancellationToken cancellationToken = default(CancellationToken))
            {
                if (BlobInfo == null)
                {
                    throw new RequestFailedException(404, BlobErrorCode.ContainerNotFound.ToString(), BlobErrorCode.ContainerNotFound.ToString(), default);
                }
                if (BlobInfo.ETag.Equals($@"""{conditions.IfMatch}"""))
                {
                    return Task.FromResult(Response.FromValue(BlobInfo, Mock.Of<Response>()));
                }

                SetMetadataAsyncCallback?.Invoke(metadata, conditions, cancellationToken);

                throw new RequestFailedException(412, BlobErrorCode.ConditionNotMet.ToString(), BlobErrorCode.ConditionNotMet.ToString(), default);
            }

            public override Task<Response<BlobContentInfo>> UploadAsync(Stream content, BlobHttpHeaders httpHeaders = null, IDictionary<string, string> metadata = null, BlobRequestConditions conditions = null, IProgress<long> progressHandler = null, AccessTier? accessTier = null, StorageTransferOptions transferOptions = default, CancellationToken cancellationToken = default)
            {
                if (BlobClientUploadBlobException != null)
                {
                    throw BlobClientUploadBlobException;
                }
                if (BlobInfo != null)
                {
                    throw new RequestFailedException(409, BlobErrorCode.BlobAlreadyExists.ToString(), BlobErrorCode.BlobAlreadyExists.ToString(), default);
                }

                UploadAsyncCallback?.Invoke(content, httpHeaders, metadata, conditions, progressHandler, accessTier, transferOptions, cancellationToken);

                return Task.FromResult(
                    Response.FromValue(
                        BlobsModelFactory.BlobContentInfo(new ETag("etag"), DateTime.UtcNow, new byte[] { }, string.Empty, 0L),
                        Mock.Of<Response>()));
            }
        }

        private class MockAsyncPageable<T> : AsyncPageable<T>
        {
            private readonly IEnumerable<T> Items;

            internal MockAsyncPageable(IEnumerable<T> items)
            {
                Items = items;
            }
            public override IAsyncEnumerable<Page<T>> AsPages(string continuationToken = null, int? pageSizeHint = null)
            {
                return CratePageResponse(Items);
            }

            internal async IAsyncEnumerable<Page<P>> CratePageResponse<P>(IEnumerable<P> value)
            {
                await Task.Delay(0);
                yield return new MockPage<P>(value);
            }
        }

        private class MockPage<T> : Page<T>
        {
            private readonly IReadOnlyList<T> InnerValues;
            public override IReadOnlyList<T> Values => InnerValues;

            public override string ContinuationToken => throw new NotImplementedException();

            public override Response GetRawResponse()
            {
                throw new NotImplementedException();
            }

            public MockPage(IEnumerable<T> items)
            {
                InnerValues = items.ToList().AsReadOnly();
            }
        }
    }
}
