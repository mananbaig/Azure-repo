﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.Translation.Document.Tests
{
    public partial class DocumentTranslationClientLiveTests
    {
        private async Task<List<string>> CreateTranslationJobsAsync(DocumentTranslationClient client, int jobsCount = 1, int docsPerJob = 1, DocumentTranslationStatus jobTerminalStatus)
        {
            // create source container
            if (jobTerminalStatus == DocumentTranslationStatus.Cancelled)
            {
                docsPerJob = 20; // in order to avoid job completing before cancelling
            }
            var testDocs = CreateDummyTestDocuments(count: docsPerJob);
            var sourceContainer = await CreateSourceContainerAsync(testDocs);

            // create a translation job
            var resultIds = new List<string>();
            for (int i = 1; i <= jobsCount; i++)
            {
                var targetContainer = await CreateTargetContainerAsync();
                var input = new DocumentTranslationInput(sourceContainer, targetContainer, "fr");
                var translationOp = await client.StartTranslationAsync(input);
                resultIds.Add(translationOp.Id);
                if (jobTerminalStatus == DocumentTranslationStatus.Succeeded)
                {
                    await translationOp.WaitForCompletionAsync();
                }
                else if (jobTerminalStatus == DocumentTranslationStatus.Cancelled)
                {
                    await translationOp.CancelAsync(default);
                    Thread.Sleep(3000); // wait for cancel status to propagate!
                }
            }

            return resultIds;
        }

        [RecordedTest]
        public async Task GetAllTranslationStatusesFilterByStatusTest()
        {
            // create client
            var client = GetClient();

            // create test jobs
            await CreateTranslationJobsAsync(client, jobsCount: 5, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);
            var cancelledIds = await CreateTranslationJobsAsync(client, jobsCount: 2, jobTerminalStatus: DocumentTranslationStatus.Cancelled);

            // list translations with filter
            var cancelledStatusList = new List<DocumentTranslationStatus> {
                    DocumentTranslationStatus.Cancelled,
                    DocumentTranslationStatus.Cancelling
            };
            var filter = new TranslationFilter(
                statuses: cancelledStatusList
            );
            var filteredTranslations = await client.GetAllTranslationStatusesAsync(filter: filter).ToEnumerableAsync();
            var filteredIds = new HashSet<string>(filteredTranslations.Select(t => t.Id).ToList());

            // assert
            Assert.That(filteredTranslations.All(t => cancelledStatusList.Contains(t.Status)));
            Assert.True(cancelledIds.All(cancelledId => filteredIds.Contains(cancelledId)));
        }

        [RecordedTest]
        public async Task GetAllTranslationStatusesFilterByIdsTest()
        {
            // create client
            var client = GetClient();

            // create test jobs
            var allIds = await CreateTranslationJobsAsync(client, jobsCount: 10, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);
            var targetIds = allIds.GetRange(0, 5);

            // list translations with filter
            var filter = new TranslationFilter(
                ids: targetIds
            );
            var filteredTranslations = await client.GetAllTranslationStatusesAsync(filter: filter).ToEnumerableAsync();

            // assert
            Assert.That(filteredTranslations.Any(t => targetIds.Contains(t.Id)));
        }

        [RecordedTest]
        public async Task GetAllTranslationStatusesFilterByCreatedAfter()
        {
            // create client
            var client = GetClient();

            // create test jobs
            await CreateTranslationJobsAsync(client, jobsCount: 5, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);
            var timestamp = DateTimeOffset.UtcNow;
            var targetIds = await CreateTranslationJobsAsync(client, jobsCount: 5, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);

            // list translations with filter
            var filter = new TranslationFilter(
                createdAfter: timestamp
            );
            var filteredTranslations = await client.GetAllTranslationStatusesAsync(filter: filter).ToEnumerableAsync();

            // assert
            Assert.That(filteredTranslations.Any(t => targetIds.Contains(t.Id)));
            Assert.That(filteredTranslations.All(t => t.CreatedOn >= timestamp));
        }

        [RecordedTest]
        public async Task GetAllTranslationStatusesFilterByCreatedBefore()
        {
            // create client
            var client = GetClient();

            // create test jobs
            var targetIds = await CreateTranslationJobsAsync(client, jobsCount: 5, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);
            var timestamp = DateTimeOffset.UtcNow;
            await CreateTranslationJobsAsync(client, jobsCount: 5, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);

            // list translations with filter
            var filter = new TranslationFilter(
                createdAfter: timestamp
            );
            var filteredTranslations = await client.GetAllTranslationStatusesAsync(filter: filter).ToEnumerableAsync();

            // assert
            Assert.That(filteredTranslations.Any(t => targetIds.Contains(t.Id)));
            Assert.That(filteredTranslations.All(t => t.CreatedOn <= timestamp));
        }

        [RecordedTest]
        public async Task GetAllTranslationStatusesOrderByCreatedOn()
        {
            // create client
            var client = GetClient();

            // create test jobs
            await CreateTranslationJobsAsync(client, jobsCount: 5, docsPerJob: 1, jobTerminalStatus: DocumentTranslationStatus.Succeeded);

            // list translations with filter
            var filter = new TranslationFilter(
                orderBy: new List<TranslationFilterOrder> {
                  new TranslationFilterOrder(property: TranslationFilterProperty.CreatedOn, orderBy: DocumentTranslationFilterMode.Desc)
                }
            );
            var filteredTranslations = await client.GetAllTranslationStatusesAsync(filter: filter).ToEnumerableAsync();

            // assert
            var timestamp = DateTimeOffset.UtcNow;
            foreach (var result in filteredTranslations)
            {
                Assert.IsTrue(result.CreatedOn <= timestamp);
                timestamp = result.CreatedOn;
            }
        }
    }
}
